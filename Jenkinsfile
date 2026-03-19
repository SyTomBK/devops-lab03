pipeline {
    agent any

    stages {

        stage('Build') {
            agent {
                docker {
                    image 'mcr.microsoft.com/dotnet/sdk:8.0'
                    args '-u root'
                }
            }
            steps {
                sh 'dotnet restore'
                sh 'dotnet build -c Release'
                sh 'dotnet publish -c Release -o out'
            }
        }

        stage('Docker Build') {
            steps {
                sh 'docker build -t lab03-app .'
            }
        }

        stage('Run') {
            steps {
                sh '''
                docker rm -f lab03 || true
                docker run -d --name lab03 -p 5191:8080 lab03-app
                '''
            }
        }
    }
}