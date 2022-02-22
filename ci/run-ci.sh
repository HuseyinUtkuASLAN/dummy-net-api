# use this script to automatically set everything related to CI

# requirements : docker, fly, minikube, python, python-flask


# 1. minikube start
# 2. compose concourse
# 3. fly login & sync
# 4. run k8s flask service
# 5. set-pipeline
# 6. unpause pipeline
# 7. manually trigger pipeline
# 8. minikube dashboard
# 9. minikube tunnel