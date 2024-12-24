DOCKER_CREDENTIALS_ID = 'dockerhub-cred-123'

pipeline {
    agent any

    environment {
        DOCKER_CREDENTIALS = credentials(DOCKER_CREDENTIALS_ID)
    }

    stages {
        stage('Docker Login') {
            steps {
                script {
                    // Login to Docker registry using Jenkins credentials
                    docker.withRegistry('https://registry.hub.docker.com', DOCKER_CREDENTIALS) {
                        echo 'Successfully logged in to Docker!'
                    }
                }
            }
        }
        // Add more pipeline stages as needed
    }
}
