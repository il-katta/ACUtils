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
        stage('restore') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    sh 'nuget restore'
                }
            }
        }
        stage('build') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    env.NEW_VERSION = projedit.increase_version("netstandard", "ACUtils/ACUtils.csproj")

                    sh '''
                        rm -rf ACUtils/bin
                        dotnet build -c Release ACUtils/ACUtils.csproj
                        dotnet pack -c Release --include-symbols -p:SymbolPackageFormat=snupkg ACUtils/ACUtils.csproj
                    '''
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
                }
            }
        }
        stage('deploy') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    archiveArtifacts artifacts: "ACUtils/bin/Release/ACUtils.*.nupkg", fingerprint: true, onlyIfSuccessful: true
                    sh '''
                        dotnet nuget push ACUtils/bin/Release/ACUtils.*.nupkg -k "${NUGET_APIKEY}" -s https://api.nuget.org/v3/index.json
                        mv ACUtils/bin/Release/ACUtils.*.nupkg .
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