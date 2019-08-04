library 'jenkins-libs'
@Library('jenkins-libs') import it.loopback.jenkins.Projedit

def projedit = new it.loopback.jenkins.Projedit(this)

pipeline {
    agent { node { label 'msbuild' } }
    options {
        disableConcurrentBuilds()
        buildDiscarder(logRotator(numToKeepStr: '5'))
        timestamps()
    }
    triggers { 
		//pollSCM(scmpoll_spec: 'H/2 * * * *', ignorePostCommitHooks: true)
		githubPush()
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
        stage('build ACUtils') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    // increase package version
                    env.NEW_VERSION = projedit.increase_version("netstandard", "ACUtils/ACUtils.csproj")
                    // nuget restore
                    nuget.restore('ACUtils/ACUtils.csproj')
                    build_msbuild projectFile:'ACUtils/ACUtils.csproj', configuration: 'Release', target:'Restore'
                    // build
                    build_msbuild projectFile:'ACUtils/ACUtils.csproj', configuration: 'Release'
                    // archive artifacts
                    archiveArtifacts artifacts: "ACUtils/bin/Release/ACUtils.*.nupkg,ACUtils/bin/Release/ACUtils.*.snupkg", fingerprint: true, onlyIfSuccessful: true
                    // stash
                    stash includes: 'ACUtils/bin/Release/ACUtils.*.nupkg,ACUtils/bin/Release/ACUtils.*.snupkg', name: 'nupkg-ACUtils'
                }
            }
        }
        stage('push ACUtils') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    
                    unstash 'nupkg-ACUtils'
                    
                    nuget.push('nuget-api-key', 'ACUtils/bin/Release/ACUtils.*.nupkg')
                }
            }
        }
		stage('build ACUtils.SqlDb') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    // increase package version
                    env.NEW_VERSION = projedit.increase_version("netstandard", "ACUtils.SqlDb/ACUtils.SqlDb.csproj")
                    // nuget restore
                    nuget.restore('ACUtils.SqlDb/ACUtils.SqlDb.csproj')
                    build_msbuild projectFile:'ACUtils.SqlDb/ACUtils.SqlDb.csproj', configuration: 'Release', target:'Restore'
                    // build
                    build_msbuild projectFile:'ACUtils.SqlDb/ACUtils.SqlDb.csproj', configuration: 'Release'
                    // archive artifacts
                    archiveArtifacts artifacts: "ACUtils.SqlDb/bin/Release/ACUtils.SqlDb.*.nupkg,ACUtils.SqlDb/bin/Release/ACUtils.SqlDb.*.snupkg", fingerprint: true, onlyIfSuccessful: true
                    // stash
                    stash includes: 'ACUtils.SqlDb/bin/Release/ACUtils.SqlDb.*.nupkg,ACUtils.SqlDb/bin/Release/ACUtils.SqlDb.*.snupkg', name: 'nupkg-ACUtils.SqlDb'
                }
            }
        }
        stage('push ACUtils.SqlDb') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    unstash 'nupkg-ACUtils.SqlDb'
                    
                    nuget.push('nuget-api-key', 'ACUtils.SqlDb/bin/Release/ACUtils.SqlDb.*.nupkg')
                }
            }
        }
        stage('git commit') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    env.J_CREDS_IDS = 'repo-git'
                    env.J_GIT_CONFIG = 'false'
                    env.J_USERNAME = 'jenkins'
                    env.J_EMAIL = 'jenkins@s.loopback.it'
                    env.J_GIT_CONFIG = "true"
                    env.BRANCH_NAME = "master"
                    git_push_ssh(commitMsg: "Jenkins build #${env.BUILD_NUMBER}", tagName: "${env.NEW_VERSION}", files: "ACUtils/ACUtils.csproj,ACUtils.SqlDb/ACUtils.SqlDb.csproj");
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