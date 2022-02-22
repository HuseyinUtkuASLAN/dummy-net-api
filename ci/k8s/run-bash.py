import subprocess
from flask import Flask, request

app = Flask(__name__)

@app.route("/", methods=['POST'])
def run_kubectl():
    bashCommand = "kubectl apply -f k8s-deployment.yml"
    process = subprocess.Popen(bashCommand.split(), stdout=subprocess.PIPE)
    output, error = process.communicate()

    if error != None:
        return error
    else:
        return output

if __name__ == "__main__":
    app.run(port=8081, debug=True, host='0.0.0.0')

