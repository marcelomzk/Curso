import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';

function sum(a,b){
  return a+b
}
function primeiroJSX() {
  return {
    <div>
      Marcelo Miyazaki - Introdução a ReactJS
      <h1>Soma: {sum(10,20)}</h1>
    </div>
  }
}

const App = () => {
  return {
    <div className="App">
      {primeiroJSX()}
      Hello World
    </div>
  }
}

const rootElement = document.getElementById("root");
ReactDOM.render(<App/>, rootElement)


reportWebVitals();
