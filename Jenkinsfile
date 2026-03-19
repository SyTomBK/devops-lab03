pipeline {
    agent any

    environment {
        IMAGE_NAME = "lab03-app"
    }

    stages {

        stage('Build') {
            steps {
                sh 'dotnet restore'
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

        stage('Build Docker Image') {
            steps {
                sh 'docker build -t lab03-app .'
            }
        }

        stage('Run Container') {
            steps {
                sh '''
                docker rm -f lab03 || true
                docker run -d --name lab03 -p 5191:8080 lab03-app
                '''
            }
        }
    }
}