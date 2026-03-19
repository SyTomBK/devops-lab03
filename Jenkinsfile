pipeline {
    agent {
        docker {
            image 'mcr.microsoft.com/dotnet/sdk:8.0'
            args '-u root'
        }
    }

    environment {
        DOTNET_VERSION = '8.0'
    }

    stages {

        stage('Restore') {
            steps {
                sh 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                sh 'dotnet build --no-restore -c Release'
            }
        }

        stage('Test') {
            steps {
                sh 'dotnet test --no-build -c Release'
            }
        }

        stage('Publish') {
            steps {
                sh 'dotnet publish -c Release -o out'
            }
        }
    }
}