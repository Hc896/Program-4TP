import { useState } from 'react';
import './App.css'

export const App2 = () =>{

    const coursesArray = ["angulker dla początkujacych", "Programowanie w C#", "Kurs Django"];

    const[courses, setCourses] = useState(coursesArray);
    const[nameAndSurname, setNameAndSurname] =useState("");
    const[courseNumber, setCourseNumber] = useState(0);

    return(

        <div>
            Hello World from App2!!!!
            <h2>Liczba kursów: {courses.length}</h2>
            <ol>
                {courses.map((courses)=>(
                    <li>{courses}</li>
                )
            )}
            </ol>
            <form>
                <div className='form-group'>
                    <label for="imie_i_nazwisko"></label>
                    <input id="imie_i_nazwisko"></input>
                </div>
                <div className='form-group'>
                    <label></label>
                    <input></input>
                </div>
                <button type="button" className='btn btn-primary'>Zapisz do kursu</button>
            </form>
        </div>
    )
}