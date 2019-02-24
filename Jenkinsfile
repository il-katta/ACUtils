@Library('jenkins-libs') _
pipeline {
    agent { node { label 'msbuild && linux' } }
    options {
        disableConcurrentBuilds()
    }
    triggers {
        githubPush()
    }
    environment {
        NUGET_APIKEY = credentials('nuget-api-key')
    }
    stages {
        stage('restore') {
            steps {
                script {
                       sh 'nuget restore'
                }
            }
        }
        stage('build') {
            steps {
                script {
                    env.NEW_VERSION = sh (
                        script: 'python projedit.py ACUtils/ACUtils.csproj',
                        returnStdout: true
                    ).trim()

                    sh '''
                        rm -rf ACUtils/bin
                        dotnet build -c Release ACUtils/ACUtils.csproj
                        dotnet pack -c Release --include-symbols -p:SymbolPackageFormat=snupkg ACUtils/ACUtils.csproj
                    '''
                    env.J_CREDS_IDS = 'repo-git'
                    env.J_GIT_CONFIG = 'false'
                    env.J_USERNAME = 'jenkins agent'
                    env.J_EMAIL = 'jenkins@s.loopback.it'
                    env.J_GIT_CONFIG = "true"
                    env.BRANCH_NAME = "jenkins"
                    git_push_ssh.pushSSH(commitMsg: "Jenkins build #${env.BUILD_NUMBER}", tagName: "${env.NEW_VERSION}", files: ".");
                }
            }
        }
        stage('deploy') {
            steps {
                script {
                    sh '''
                        dotnet nuget push ACUtils/bin/Release/ACUtils.*.nupkg -k "${NUGET_APIKEY}" -s https://api.nuget.org/v3/index.json
                        mv ACUtils/bin/Release/ACUtils.*.nupkg .
                    '''
                }
            }
        }
    }
}