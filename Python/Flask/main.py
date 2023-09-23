from flask import Flask 

app = Flask(__name__)

@app.route('/')
def main():
    return '<h1> Hello, World!</h1>'

if __name__ == '__main__':
    app.run()

@app.route('/info') # GET - по умолчанию
def info():
    return '<h1>Меня создала компания GeekBrains</h1>'

@app.route('/summa/<x>/<y>')
def summa(x, y):
    return f'<h1>{x} + {y} = {int(x) + int(y)}</h1>'