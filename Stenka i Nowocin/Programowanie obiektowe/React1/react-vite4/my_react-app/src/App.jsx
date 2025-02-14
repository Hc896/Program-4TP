import { useState } from 'react'
import './App.css'
import { Input } from './Input';
import { Section } from './Section';

function App() {
  
  const [colorName, setColorName] =useState("");

  const handleSubmit = (event) => {
      event.preventDefault();
      /*wewnatrz tej funkcji bedziemy wrzucac console loga na egzaminie pokazujacego dzialanie aplikacji np: Emilian zapisal sie na egzamin xy/ taki egzamin nie istnieje */ 
  }

  const handleInputChange = (e) => {
    setColorName(e.target.value)
  }

  return (
    <>
        <Section
          colorNameProps={colorName}>

        </Section>
        
         <Input
          colorNameProps={colorName}
          handleSubmit = {handleSubmit}
          handleInputChange ={handleInputChange}
          >
        </Input>
        
    </>
  )
}

export default App