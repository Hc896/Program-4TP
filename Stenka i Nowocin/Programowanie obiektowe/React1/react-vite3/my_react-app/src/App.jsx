import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

function App() {
  const [count, setCount] = useState(0)

  const coursesArray = ["Angular dla początkujących","Programowanie w CE","Kurs Django","Kurs C++"]
  const[courses, setCourses] = useState(coursesArray);
  const[nameAndSurname , setNameAndSurname]=useState("");
  const[courseNumber , setCourseNumber] = useState(0);

  const onSubmit = (event)=>{
    event.preventDeflaut();
    console.log(nameAndSurname);
    if(courses[courseNumber-1] != undefined){ 
        console.log(courses[courseNumber-1]);
    } else{
        console.log("Nie ma takiego KURSU!!")
    }

  }
  const handleNameAndSurname = (e) =>{
    setNameAndSurname(e.target.value);
  }
  const handleCourseNumber = (e) =>{
    setCourseNumber(e.target.value);
  }



  return (
    <>
      <div>
        <a href="https://vite.dev" target="_blank">
          <img src={viteLogo} className="logo" alt="Vite logo" />
        </a>
        <a href="https://react.dev" target="_blank">
          <img src={reactLogo} className="logo react" alt="React logo" />
        </a>
      </div>
      <h1>Vite + React</h1>
      <div className="card">
        <button onClick={() => setCount((count) => count + 1)}>
          count is {count}
        </button>
        <p>
          Edit <code>src/App.jsx</code> and save to test HMR
        </p>
      </div>
      <p className="read-the-docs">
        Click on the Vite and React logos to learn more
      </p>


    <h2>Liczba Kursów: {coursesArray.length}</h2>
      <ol>
        {courses.map((course)=>(
        <li>{course}
        </li>
        ))}
        
        
        </ol>
      
      <div>
        <form onSubmit={onSubmit}>
          <div className="form-group">
            <label htmlFor='imie_i_nazwisko'> Imie i Nazwisko
            </label>
            <input className='form-control' 
            id='imie_i_nazwisko' 
            value={nameAndSurname} 
            onChange={handleNameAndSurname}>
            </input>
          </div>
        </form>
      </div>
    </>
  )
}

export default App
