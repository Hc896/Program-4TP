import { useState } from 'react'
import './App.css'
import { Input } from './Input';
import { Section } from './Section';

function App() {

  const [colorName, setColorName] = useState("");

  const handleSubmit = (event) => {
    event.preventDefault();
    /*wewnątrz tej funkcji będzimy wrzucać console loga na egzaminie
    pokazującego działanie aplikacji np: Emil zapisał się na egzamin xy/ taki
    egzamin nie istnieje*/
  }

  const handleInputChange = (e) => {
    setColorName(e.target.value);
  }
  
  return (
    <>
     
      <Section 
        colorNameProps={colorName}>

      </Section>

      <Input
        colorNameProps={colorName}
        handleSubmit = {handleSubmit}
        handleInputChange = {handleInputChange}
      >

      </Input>
      
    </>
  )
}

export default App
