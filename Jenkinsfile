library 'jenkins-libs'
@Library('jenkins-libs') import it.loopback.jenkins.Projedit

def projedit = new it.loopback.jenkins.Projedit(this)

pipeline {
    agent { node { label 'linux && msbuild' } }
    options {
        disableConcurrentBuilds()
        buildDiscarder(logRotator(numToKeepStr: '5'))
    }
    triggers { 
		//pollSCM(scmpoll_spec: 'H/2 * * * *', ignorePostCommitHooks: true)
		githubPush()
	}
    environment {
        NUGET_APIKEY = credentials('nuget-api-key')
    }
    stages {
		stage('short circuit') {
            when { expression { test_committer('jenkins')  } }
            steps {
                script {
                    print("skip build")
                    currentBuild.result = currentBuild?.previousBuild?.result
                    currentBuild.keepLog = false
                    currentBuild.description = "skipped"
                }
            }
        }
        stage('build') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    // increase package version
                    env.NEW_VERSION = projedit.increase_version("netstandard", "ACUtils/ACUtils.csproj")
                    // nuget restore
                    nuget_download 'ACUtils/ACUtils.csproj'
                    // build
                    build_msbuild projectFile:'ACUtils/ACUtils.csproj', configuration: 'Release'
                    // archive artifacts
                    archiveArtifacts artifacts: "ACUtils/bin/Release/ACUtils.*.nupkg", fingerprint: true, onlyIfSuccessful: true
                    // stash
                    stash includes: 'ACUtils/bin/Release/ACUtils.*.nupkg', name: 'nupkg'
                }
            }
        }
        stage('push') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    env.J_CREDS_IDS = 'repo-git'
                    env.J_GIT_CONFIG = 'false'
                    env.J_USERNAME = 'jenkins'
                    env.J_EMAIL = 'jenkins@s.loopback.it'
                    env.J_GIT_CONFIG = "true"
                    env.BRANCH_NAME = "master"
                    git_push_ssh(commitMsg: "Jenkins build #${env.BUILD_NUMBER}", tagName: "${env.NEW_VERSION}", files: "ACUtils/ACUtils.csproj");
                    
                    
                    unstash 'nupkg'
                    sh '''
                        dotnet nuget push ACUtils/bin/Release/ACUtils.*.nupkg -k "${NUGET_APIKEY}" -s https://api.nuget.org/v3/index.json
                    '''
                }
            }
        }
    }
    post { 
        always { 
            cleanWs()
        }
    }
}