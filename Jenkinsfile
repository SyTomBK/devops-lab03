pipeline {
	agent any
	environment {
        DOTNET_VERSION = '8.0'
    }
	
	stages {
		 stage('Checkout') {
            steps {
                git 'https://your-repo-url.git'
            }
        }
		 stage('Build') {
            steps {
                sh 'dotnet restore'
                sh 'dotnet build --no-restore'
            }
        }
        stage('Test') {
            steps {
                sh 'dotnet test'
            }
        }
         stage('Run App') {
            steps {
                sh 'dotnet run &'
            }
        }
	}
}