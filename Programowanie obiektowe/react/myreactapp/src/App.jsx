import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import {TestComponent} from './TextComponent';

function App() {
  const greeting = "Hello World!";
  const names = ["Emilian", "Wiktor", "Dariusz", "Paweł"];
  const [count, setCount] = useState(0);

  const handleNameChange = () => {

    const length = names.length;
    const x = Math.random();
    const randIndex = Math.floor(Math.random()*length);
    return names[randIndex];
  }
  const handleCounter = () => {
    setCount((count) => count + 1);
  }

  return (
    <>
      <div>
        <h2>{greeting}</h2>
        <h2>{`liczba osób z tablicy: ${names.length}`}</h2>
        <h2>{`Wiktor osczytany z palca z tablicy na sztywno: ${names[1]}`}</h2>
        <h2>{`losowe imie z tablicy:`}{handleNameChange()}</h2>
        <a href="https://vitejs.dev" target="_blank">
          <img src={viteLogo} className="logo" alt="Vite logo" />
        </a>
        <a href="https://react.dev" target="_blank">
          <img src={reactLogo} className="logo react" alt="React logo" />
        </a>
      </div>
      <h1>Vite + React</h1>
      <div className="card">
        <button onClick={handleCounter}>
          count is {count}
        </button>
        <p>
          Edit <code>src/App.jsx</code> and save to test HMR
        </p>
      </div>
      <p className="read-the-docs">
        Click on the Vite and React logos to learn more
      </p>
    </>
  )
}

export default App
