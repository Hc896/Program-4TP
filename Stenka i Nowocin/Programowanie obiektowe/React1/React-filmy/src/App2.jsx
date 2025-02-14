/*Zadanko z arkusza egzaminacyjnego 2022.06.02 (lista, stan aplikacji, formularz, inputy)
Na zatwierdzeniu formularza wyświetlamy w konsoli imie i nazwisko z inputa oraz 
kurs jeśli taki istnieje w przeciwnym wypadku komunikat - "nieprawidlowy numer kursu*/
import { useState } from 'react';
import './App.css'
import 'bootstrap/dist/css/bootstrap.css'

export const App2 = () =>{

    const coursesArray = ["Angular dla początkjących", "Programowanie w C#", "Kurs Django","Kurs Javascript"];

    const[courses, setCourses] =useState(coursesArray);
    const[nameAndSurname, setNameAndSurname] =useState("");
    const[courseNumber, setCourseNumber] =useState(0);

    /*Można napisać też tak:
    const[courses, setCourses] =useState(["Angular dla początkjących", "Programowanie w C#", "Kurs Django"];);*/

    const onSubmit = (event)=>{
        event.preventDefault();
        console.log(nameAndSurname);
        //console.log(nameAndSurname + " "+ courseNumber);
    //    if(courseNumber <= courses.length && courseNumber > 0){
    //     console.log(courses[courseNumber-1]);
    //    } else{
    //     console.log("nie ma takiego kursu");
    //    }

        if(courses[courseNumber-1] != undefined){
            console.log(courses[courseNumber-1]);
        } else{
            console.log("nie ma takiego kursu");
        }

    }

    const handleNameAndSurname = (e) => {
        //console.log(e.target.value);
        setNameAndSurname(e.target.value);
    }

    const handleCourseNumber =(e)=>{
        setCourseNumber(e.target.value);
    }

    
    return(

        <div>
            Hello World from App2!!!!
            <h2>Liczba kursów: {coursesArray.length}</h2>
            <ol>
                {courses.map((course)=>(
                    <li>{course}
                    </li>
                ))}
            </ol>

            <form onSubmit={onSubmit}>
                <div className='form-group'>
                    <label htmlFor="imie_i_nazwisko">Imie i Nazwisko</label>
                    <input 
                        className='form-control' 
                        id="imie_i_nazwisko"
                        value={nameAndSurname}
                        onChange={handleNameAndSurname}>
                    </input>
                </div>

                <div className='form-group'>
                    <label htmlFor="liczba_kursów">Numer kursu </label>
                    <input 
                    className='form-control' 
                    id="liczba_kursów"
                    value={courseNumber}
                    onChange={handleCourseNumber}
                    ></input>
                </div>
                <button type="submit" className='btn btn-primary'>Zapisz do kursu</button>
            </form>
        </div>
    )
}