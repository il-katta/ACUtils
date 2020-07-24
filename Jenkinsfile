library 'jenkins-libs'
@Library('jenkins-libs') import it.loopback.jenkins.Projedit

def projedit = new it.loopback.jenkins.Projedit(this)

pipeline {
    agent { node { label 'windows && msbuild' } }
    options {
        disableConcurrentBuilds()
        buildDiscarder(logRotator(numToKeepStr: '5'))
        timestamps()
    }
    triggers { 
		pollSCM(scmpoll_spec: 'H/2 * * * *', ignorePostCommitHooks: true)
		//githubPush()
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
                    currentBuild.description = env.NEW_VERSION_ACUTILS;
                    // nuget restore
                    nuget.restore('ACUtils/ACUtils.csproj')
                    build_msbuild projectFile:'ACUtils/ACUtils.csproj', configuration: 'Release', target:'Restore'
                    // build
                    build_msbuild projectFile:'ACUtils/ACUtils.csproj', configuration: 'Release'
                    // archive artifacts
                    archiveArtifacts artifacts: "dist/ACUtils*.nupkg,dist/ACUtils*.snupkg", fingerprint: true, onlyIfSuccessful: true
                    // stash
                    stash includes: 'dist/ACUtils*.nupkg,dist/ACUtils*.snupkg', name: 'nupkg-ACUtils'
                }
            }
        }

		stage('build SqlDb') {
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
                    archiveArtifacts artifacts: "dist/ACUtils.SqlDb*.nupkg,dist/ACUtils.SqlDb*.snupkg", fingerprint: true, onlyIfSuccessful: true
                    // stash
                    stash includes: 'dist/ACUtils.SqlDb*.nupkg,dist/ACUtils.SqlDb*.snupkg', name: 'nupkg-ACUtils.SqlDb'
                }
            }
        }

        stage('build SqlDbExt') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    // increase package version
                    projedit.increase_version("netstandard", "ACUtils.SqlDbExt/ACUtils.SqlDbExt.csproj")
                    // nuget restore
                    nuget.restore('ACUtils.SqlDbExt/ACUtils.SqlDbExt.csproj')
                    build_msbuild projectFile:'ACUtils.SqlDbExt/ACUtils.SqlDbExt.csproj', configuration: 'Release', target:'Restore'
                    // build
                    build_msbuild projectFile:'ACUtils.SqlDbExt/ACUtils.SqlDbExt.csproj', configuration: 'Release'
                    // archive artifacts
                    archiveArtifacts artifacts: "dist/ACUtils.SqlDbExt*.nupkg,dist/ACUtils.SqlDbExt*.snupkg", fingerprint: true, onlyIfSuccessful: true
                    // stash
                    stash includes: 'dist/ACUtils.SqlDbExt*.nupkg,dist/ACUtils.SqlDbExt*.snupkg', name: 'nupkg-ACUtils.SqlDbExt'
                }
            }
        }

        stage('build SqlDB2') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    // increase package version
                    projedit.increase_version("netstandard", "ACUtils.SqlDB2/ACUtils.SqlDB2.csproj")
                    // nuget restore
                    nuget.restore('ACUtils.SqlDB2/ACUtils.SqlDB2.csproj')
                    build_msbuild projectFile:'ACUtils.SqlDB2/ACUtils.SqlDB2.csproj', configuration: 'Release', target:'Restore'
                    // build
                    build_msbuild projectFile:'ACUtils.SqlDB2/ACUtils.SqlDB2.csproj', configuration: 'Release'
                    // archive artifacts
                    archiveArtifacts artifacts: "dist/ACUtils.SqlDB2*.nupkg,dist/ACUtils.SqlDB2*.snupkg", fingerprint: true, onlyIfSuccessful: true
                    // stash
                    stash includes: 'dist/ACUtils.SqlDB2*.nupkg,dist/ACUtils.SqlDB2*.snupkg', name: 'nupkg-ACUtils.SqlDB2'
                }
            }
        }

		stage('build EnvironmentUtils') {
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
                    archiveArtifacts artifacts: "dist/ACUtils.EnvironmentUtils*.nupkg,dist/ACUtils.EnvironmentUtils*.snupkg", fingerprint: true, onlyIfSuccessful: true
                    // stash
                    stash includes: 'dist/ACUtils.EnvironmentUtils*.nupkg,dist/ACUtils.EnvironmentUtils*.snupkg', name: 'nupkg-ACUtils.EnvironmentUtils'
                }
            }
        }

		stage('build RegEditUtil') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    // increase package version
                    projedit.increase_version("netstandard", "ACUtils.RegEditUtil/ACUtils.RegEditUtil.csproj")
                    // nuget restore
                    nuget.restore('ACUtils.RegEditUtil/ACUtils.RegEditUtil.csproj')
                    build_msbuild projectFile:'ACUtils.RegEditUtil/ACUtils.RegEditUtil.csproj', configuration: 'Release', target:'Restore'
                    // build
                    build_msbuild projectFile:'ACUtils.RegEditUtil/ACUtils.RegEditUtil.csproj', configuration: 'Release'
                    // archive artifacts
                    archiveArtifacts artifacts: "dist/ACUtils.RegEditUtil*.nupkg,dist/ACUtils.RegEditUtil*.snupkg", fingerprint: true, onlyIfSuccessful: true
                    // stash
                    stash includes: 'dist/ACUtils.RegEditUtil*.nupkg,dist/ACUtils.RegEditUtil*.snupkg', name: 'nupkg-ACUtils.RegEditUtil'
                }
            }
        }

        stage('build FileUtils') {
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
                    archiveArtifacts artifacts: "dist/ACUtils.FileUtils*.nupkg,dist/ACUtils.FileUtils*.snupkg", fingerprint: true, onlyIfSuccessful: true
                    // stash
                    stash includes: 'dist/ACUtils.FileUtils*.nupkg,dist/ACUtils.FileUtils*.snupkg', name: 'nupkg-ACUtils.FileUtils'
                }
            }
        }

        stage('build StringUtils') {
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
                    archiveArtifacts artifacts: "dist/ACUtils.StringUtils*.nupkg,dist/ACUtils.StringUtils*.snupkg", fingerprint: true, onlyIfSuccessful: true
                    // stash
                    stash includes: 'dist/ACUtils.StringUtils*.nupkg,dist/ACUtils.StringUtils*.snupkg', name: 'nupkg-ACUtils.StringUtils'
                }
            }
        }

        stage('build Logger') {
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
                    archiveArtifacts artifacts: "dist/ACUtils.Logger*.nupkg,dist/ACUtils.Logger*.snupkg", fingerprint: true, onlyIfSuccessful: true
                    // stash
                    stash includes: 'dist/ACUtils.Logger*.nupkg,dist/ACUtils.Logger*.snupkg', name: 'nupkg-ACUtils.Logger'
                }
            }
        }
        
        stage('build ProgramUtils') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    // increase package version
                    projedit.increase_version("netstandard", "ACUtils.ProgramUtils/ACUtils.ProgramUtils.csproj")
                    // nuget restore
                    nuget.restore('ACUtils.ProgramUtils/ACUtils.ProgramUtils.csproj')
                    build_msbuild projectFile:'ACUtils.ProgramUtils/ACUtils.ProgramUtils.csproj', configuration: 'Release', target:'Restore'
                    // build
                    build_msbuild projectFile:'ACUtils.ProgramUtils/ACUtils.ProgramUtils.csproj', configuration: 'Release'
                    // archive artifacts
                    archiveArtifacts artifacts: "dist/ACUtils.ProgramUtils*.nupkg,dist/ACUtils.ProgramUtils*.snupkg", fingerprint: true, onlyIfSuccessful: true
                    // stash
                    stash includes: 'dist/ACUtils.ProgramUtils*.nupkg,dist/ACUtils.ProgramUtils*.snupkg', name: 'nupkg-ACUtils.ProgramUtils'
                }
            }
        }

        stage('build DotNetUtils') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    // increase package version
                    projedit.increase_version("netstandard", "ACUtils.DotNetUtils/ACUtils.DotNetUtils.csproj")
                    // nuget restore
                    nuget.restore('ACUtils.DotNetUtils/ACUtils.DotNetUtils.csproj')
                    build_msbuild projectFile:'ACUtils.DotNetUtils/ACUtils.DotNetUtils.csproj', configuration: 'Release', target:'Restore'
                    // build
                    build_msbuild projectFile:'ACUtils.DotNetUtils/ACUtils.DotNetUtils.csproj', configuration: 'Release'
                    // archive artifacts
                    archiveArtifacts artifacts: "dist/ACUtils.DotNetUtils*.nupkg,dist/ACUtils.DotNetUtils*.snupkg", fingerprint: true, onlyIfSuccessful: true
                    // stash
                    stash includes: 'dist/ACUtils.DotNetUtils*.nupkg,dist/ACUtils.DotNetUtils*.snupkg', name: 'nupkg-ACUtils.DotNetUtils'
                }
            }
        }

        stage('build NetUse') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    // increase package version
                    projedit.increase_version("netstandard", "ACUtils.NetUse/ACUtils.NetUse.csproj")
                    // nuget restore
                    nuget.restore('ACUtils.NetUse/ACUtils.NetUse.csproj')
                    build_msbuild projectFile:'ACUtils.NetUse/ACUtils.NetUse.csproj', configuration: 'Release', target:'Restore'
                    // build
                    build_msbuild projectFile:'ACUtils.NetUse/ACUtils.NetUse.csproj', configuration: 'Release'
                    // archive artifacts
                    archiveArtifacts artifacts: "dist/ACUtils.NetUse*.nupkg,dist/ACUtils.NetUse*.snupkg", fingerprint: true, onlyIfSuccessful: true
                    // stash
                    stash includes: 'dist/ACUtils.NetUse*.nupkg,dist/ACUtils.NetUse*.snupkg', name: 'nupkg-ACUtils.NetUse'
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

        stage('push ACUtils') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    
                    unstash 'nupkg-ACUtils'
                    
                    nuget.push('nuget-api-key', 'ACUtils/bin/Release/ACUtils.*.nupkg')
                }
            }
        }

        stage('push EnvironmentUtils') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    unstash 'nupkg-ACUtils.EnvironmentUtils'
                    
                    nuget.push('nuget-api-key', 'ACUtils.EnvironmentUtils/bin/Release/ACUtils.EnvironmentUtils.*.nupkg')
                }
            }
        }

		stage('push RegEditUtil') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    unstash 'nupkg-ACUtils.RegEditUtil'
                    
                    nuget.push('nuget-api-key', 'ACUtils.RegEditUtil/bin/Release/ACUtils.RegEditUtil.*.nupkg')
                }
            }
        }
        
        stage('push SqlDb') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    unstash 'nupkg-ACUtils.SqlDb'
                    
                    nuget.push('nuget-api-key', 'ACUtils.SqlDb/bin/Release/ACUtils.SqlDb.*.nupkg')
                }
            }
        }
        
        stage('push SqlDbExt') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    unstash 'nupkg-ACUtils.SqlDbExt'
                    
                    nuget.push('nuget-api-key', 'ACUtils.SqlDbExt/bin/Release/ACUtils.SqlDbExt.*.nupkg')
                }
            }
        }

        stage('push SqlDB2') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    unstash 'nupkg-ACUtils.SqlDB2'
                    
                    nuget.push('nuget-api-key', 'ACUtils.SqlDB2/bin/Release/ACUtils.SqlDB2.*.nupkg')
                }
            }
        }

        stage('push FileUtils') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    unstash 'nupkg-ACUtils.FileUtils'
                    
                    nuget.push('nuget-api-key', 'ACUtils.FileUtils/bin/Release/ACUtils.FileUtils.*.nupkg')
                }
            }
        }

        stage('push StringUtils') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    unstash 'nupkg-ACUtils.StringUtils'
                    
                    nuget.push('nuget-api-key', 'ACUtils.StringUtils/bin/Release/ACUtils.StringUtils.*.nupkg')
                }
            }
        }

        stage('push Logger') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    unstash 'nupkg-ACUtils.Logger'
                    
                    nuget.push('nuget-api-key', 'ACUtils.Logger/bin/Release/ACUtils.Logger.*.nupkg')
                }
            }
        }

        stage('push ProgramUtils') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    unstash 'nupkg-ACUtils.ProgramUtils'
                    
                    nuget.push('nuget-api-key', 'ACUtils.ProgramUtils/bin/Release/ACUtils.ProgramUtils.*.nupkg')
                }
            }
        }

        stage('push DotNetUtils') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    unstash 'nupkg-ACUtils.DotNetUtils'
                    
                    nuget.push('nuget-api-key', 'ACUtils.DotNetUtils/bin/Release/ACUtils.DotNetUtils.*.nupkg')
                }
            }
        }

        stage('push NetUse') {
            when { expression { !test_committer('jenkins')  } }
            steps {
                script {
                    unstash 'nupkg-ACUtils.NetUse'
                    
                    nuget.push('nuget-api-key', 'ACUtils.NetUse/bin/Release/ACUtils.NetUse.*.nupkg')
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