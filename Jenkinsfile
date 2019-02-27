library 'jenkins-libs'
@Library('jenkins-libs') import it.loopback.jenkins.Projedit

def skipBuild = false

def projedit = new it.loopback.jenkins.Projedit(this)

pipeline {
    agent { node { label 'linux && msbuild' } }
    options {
        disableConcurrentBuilds()
        buildDiscarder(logRotator(numToKeepStr: '5'))
    }
    triggers {
        githubPush()
    }
    environment {
        NUGET_APIKEY = credentials('nuget-api-key')
    }
    stages {
		stage('short circuit') {
            steps {
                script {
                    if (test_committer('jenkins')) {
                        print("skip build")
                        currentBuild.result = currentBuild?.previousBuild?.result
                        currentBuild.keepLog = false
                        currentBuild.description = "skipped"
                        skipBuild = true
                        return
                    }
                }
            }
        }
        stage('restore') {
            when { expression { !skipBuild  } }
            steps {
                script {
                    sh 'nuget restore'
                }
            }
        }
        stage('build') {
            when { expression { !skipBuild  } }
            steps {
                script {
                    
                    env.NEW_VERSION = projedit.projedit("netstandard", "ACUtils/ACUtils.csproj")

                    sh '''
                        rm -rf ACUtils/bin
                        dotnet build -c Release ACUtils/ACUtils.csproj
                        dotnet pack -c Release --include-symbols -p:SymbolPackageFormat=snupkg ACUtils/ACUtils.csproj
                    '''
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
            when { expression { !skipBuild  } }
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