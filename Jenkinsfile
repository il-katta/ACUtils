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
                    sh '''
                        rm -rf ACUtils/bin
                        dotnet build -c Release ACUtils/ACUtils.csproj
                        dotnet pack -c Release --include-symbols -p:SymbolPackageFormat=snupkg ACUtils/ACUtils.csproj
                    '''
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