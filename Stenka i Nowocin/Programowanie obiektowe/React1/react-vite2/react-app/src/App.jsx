import { useState } from 'react'
import './App.css'
import { Section } from './assets/Section';
import { Input } from './assets/Input';

function App() {
  const [colorName, setColorName] = useState("");
  const handleSubmit = (event) => {
    event.preventDefault();
    /*wewnąrtrz tej funkcji bedziemy wrzucac console logi na egzaminie 
    pokazującego dzialanie aplikacji npx emil zapoisal sie na egzamin 
    xyz taki egzamin nie istnieje*/
  }
  const handleInputChange = (e) =>{
    setColorName(e.target.value);
  }

  return (
    <>
      <section className='' style={{backgroundColor: colorName}}>
        <p>{colorName? colorName : "please write a color name in input"}</p>
      </section>

      <form onSubmit={handleSubmit}>
        <input
        autoFocus
        type="text"
        placeholder='enter a color name'
        required
        value={colorName}
        onChange={handleInputChange}>
        </input>



      </form>
      <Input></Input>
      <Section></Section>
    </>
  )
}

export default App
