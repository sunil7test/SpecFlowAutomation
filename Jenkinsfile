pipeline {
    agent any

    environment{
        DOTNET_CLI_TELEMETRY_OPTOUT='1'
        BROWSER= 'chrome'
    }

    stages {
        stage('Checkout Code'){
            steps{
                git branch: 'https://github.com/sunil7test/SpecFlowAutomation.git'
            }
        } 
        stage('Build') {
            steps {
                echo 'Building..'
                bat 'dotnet build'
                echo 'Build Completed'
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
                bat 'dotnet test SpecFlowAutomation.csproj'
                echo 'Build Completed'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}
