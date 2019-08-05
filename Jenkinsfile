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
                    env.NEW_VERSION_ACUTILS = projedit.increase_version("netstandard", "ACUtils/ACUtils.csproj")
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

		stage('build ACUtils.SqlDb') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    // increase package version
                    projedit.increase_version("netstandard", "ACUtils.SqlDb/ACUtils.SqlDb.csproj")
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

		stage('build ACUtils.EnvironmentUtils') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    // increase package version
                    projedit.increase_version("netstandard", "ACUtils.EnvironmentUtils/ACUtils.EnvironmentUtils.csproj")
                    // nuget restore
                    nuget.restore('ACUtils.EnvironmentUtils/ACUtils.EnvironmentUtils.csproj')
                    build_msbuild projectFile:'ACUtils.EnvironmentUtils/ACUtils.EnvironmentUtils.csproj', configuration: 'Release', target:'Restore'
                    // build
                    build_msbuild projectFile:'ACUtils.EnvironmentUtils/ACUtils.EnvironmentUtils.csproj', configuration: 'Release'
                    // archive artifacts
                    archiveArtifacts artifacts: "ACUtils.EnvironmentUtils/bin/Release/ACUtils.EnvironmentUtils.*.nupkg,ACUtils.EnvironmentUtils/bin/Release/ACUtils.EnvironmentUtils.*.snupkg", fingerprint: true, onlyIfSuccessful: true
                    // stash
                    stash includes: 'ACUtils.EnvironmentUtils/bin/Release/ACUtils.EnvironmentUtils.*.nupkg,ACUtils.EnvironmentUtils/bin/Release/ACUtils.EnvironmentUtils.*.snupkg', name: 'nupkg-ACUtils.EnvironmentUtils'
                }
            }
        }

        stage('build ACUtils.FileUtils') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    // increase package version
                    projedit.increase_version("netstandard", "ACUtils.FileUtils/ACUtils.FileUtils.csproj")
                    // nuget restore
                    nuget.restore('ACUtils.FileUtils/ACUtils.FileUtils.csproj')
                    build_msbuild projectFile:'ACUtils.FileUtils/ACUtils.FileUtils.csproj', configuration: 'Release', target:'Restore'
                    // build
                    build_msbuild projectFile:'ACUtils.FileUtils/ACUtils.FileUtils.csproj', configuration: 'Release'
                    // archive artifacts
                    archiveArtifacts artifacts: "ACUtils.FileUtils/bin/Release/ACUtils.FileUtils.*.nupkg,ACUtils.FileUtils/bin/Release/ACUtils.FileUtils.*.snupkg", fingerprint: true, onlyIfSuccessful: true
                    // stash
                    stash includes: 'ACUtils.FileUtils/bin/Release/ACUtils.FileUtils.*.nupkg,ACUtils.FileUtils/bin/Release/ACUtils.FileUtils.*.snupkg', name: 'nupkg-ACUtils.FileUtils'
                }
            }
        }

        stage('build ACUtils.StringUtils') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    // increase package version
                    projedit.increase_version("netstandard", "ACUtils.StringUtils/ACUtils.StringUtils.csproj")
                    // nuget restore
                    nuget.restore('ACUtils.StringUtils/ACUtils.StringUtils.csproj')
                    build_msbuild projectFile:'ACUtils.StringUtils/ACUtils.StringUtils.csproj', configuration: 'Release', target:'Restore'
                    // build
                    build_msbuild projectFile:'ACUtils.StringUtils/ACUtils.StringUtils.csproj', configuration: 'Release'
                    // archive artifacts
                    archiveArtifacts artifacts: "ACUtils.StringUtils/bin/Release/ACUtils.StringUtils.*.nupkg,ACUtils.StringUtils/bin/Release/ACUtils.StringUtils.*.snupkg", fingerprint: true, onlyIfSuccessful: true
                    // stash
                    stash includes: 'ACUtils.StringUtils/bin/Release/ACUtils.StringUtils.*.nupkg,ACUtils.StringUtils/bin/Release/ACUtils.StringUtils.*.snupkg', name: 'nupkg-ACUtils.StringUtils'
                }
            }
        }

        stage('build ACUtils.Logger') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    // increase package version
                    projedit.increase_version("netstandard", "ACUtils.Logger/ACUtils.Logger.csproj")
                    // nuget restore
                    nuget.restore('ACUtils.Logger/ACUtils.Logger.csproj')
                    build_msbuild projectFile:'ACUtils.Logger/ACUtils.Logger.csproj', configuration: 'Release', target:'Restore'
                    // build
                    build_msbuild projectFile:'ACUtils.Logger/ACUtils.Logger.csproj', configuration: 'Release'
                    // archive artifacts
                    archiveArtifacts artifacts: "ACUtils.Logger/bin/Release/ACUtils.Logger.*.nupkg,ACUtils.Logger/bin/Release/ACUtils.Logger.*.snupkg", fingerprint: true, onlyIfSuccessful: true
                    // stash
                    stash includes: 'ACUtils.Logger/bin/Release/ACUtils.Logger.*.nupkg,ACUtils.Logger/bin/Release/ACUtils.Logger.*.snupkg', name: 'nupkg-ACUtils.Logger'
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

        stage('push ACUtils.EnvironmentUtils') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    unstash 'nupkg-ACUtils.EnvironmentUtils'
                    
                    nuget.push('nuget-api-key', 'ACUtils.EnvironmentUtils/bin/Release/ACUtils.EnvironmentUtils.*.nupkg')
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

        stage('push ACUtils.FileUtils') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    unstash 'nupkg-ACUtils.FileUtils'
                    
                    nuget.push('nuget-api-key', 'ACUtils.FileUtils/bin/Release/ACUtils.FileUtils.*.nupkg')
                }
            }
        }

        stage('push ACUtils.StringUtils') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    unstash 'nupkg-ACUtils.StringUtils'
                    
                    nuget.push('nuget-api-key', 'ACUtils.StringUtils/bin/Release/ACUtils.StringUtils.*.nupkg')
                }
            }
        }

        stage('push ACUtils.Logger') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    unstash 'nupkg-ACUtils.Logger'
                    
                    nuget.push('nuget-api-key', 'ACUtils.Logger/bin/Release/ACUtils.Logger.*.nupkg')
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
                    git_push_ssh(commitMsg: "Jenkins build #${env.BUILD_NUMBER}", tagName: "${env.NEW_VERSION_ACUTILS}", files: ".");
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