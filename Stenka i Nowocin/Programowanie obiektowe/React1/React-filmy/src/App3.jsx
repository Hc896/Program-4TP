//Zadanie arkusz aplikacja webowa inf_04_2023_06_01

//React szablon stworzony w vite
import 'bootstrap/dist/css/bootstrap.css'
import { useState } from 'react'

export const App3 = () => {

    /*w tej apce zmiennymi/ dynamicznymi elementami strony są input i lista rozwijana.
    Elementy zmienne obsługujemy w stanie aplikacji - funkcja tzw hook useState()
    Deklaruje stany dla inputa (tytuł filmu) i listy rozwijanej(rodzaj filmu)
    title i genre to zmienne zawierające aktualny stan a setTitle i setGenre to funkcje
    aktualizujące stan */
    const[title, setTitle] = useState("");
    const[genre, setGenre] = useState("");

    const handleTitle = (event) => {
        /*ogarynam tutaj tytuł z inputa czyli aktualizacje stanu
        kazda funkcja podpieta pod zdarzenie dla el html albo JSX ma dostęp 
        do obiektu zdarzenia event. Value odczytujemy z event.target.value i
        wysylamy jako argument do funkcji aktualizujacej stan.
        Funkcje handleTitle musze podpiąc po element interfejsu w kodzie JSX-
        w tym przpadku jest to input*/
        setTitle(event.target.value);
    }
    const handleGenre = (e) => {
        //ogarynam tutaj rodzaj z listy czyli aktualizacje stanu
        setGenre(e.target.value);
    }
    const handleSubmit = (zdarzenie) => {
        //akcja na zatwierdzenie formularza/ nacisniecie buttona wewnatrz formularza i 
        //zapobieżenie get request do serwera - odświeżenia całej strony
        zdarzenie.preventDefault();
        //w consoli wyświetlam wartości naszych stanów wg założen aplikacji
        console.log("Tytuł: "+ title + "; " + "rodzaj: "+ genre);
    }
        /*poniżej po return mamy elemnty interfejsu. Musimy je połączyć z kodem JS
        value na kontrolkach łączymy z stanem aplikacji a ich zdarzenia z funkcjami np
        dla inputa value={title}, zdarzenie onChange={handleTitle}*/
    return(
        <>
            <div>Hello World from APP3 !!!!!</div>

            <form onSubmit = {handleSubmit}>
                <div className="form-group">
                    <label htmlFor="title">Tytuł Filmu</label>
                    <input 
                        type="text" 
                        id="title" 
                        className="form-control"
                        value={title} 
                        onChange={handleTitle}>
                    </input>
                </div>
                <br></br>

                <div className="form-group">
                    <label>Rodzaj</label>
                    <div>
                        <select 
                            value = {genre}
                            onChange = {handleGenre}
                            >
                            <option value="0"></option>
                            <option value="1">Komedia</option>
                            <option value="2">Horror</option>
                            <option value="3">Dokument</option>
                            <option value="4">Obyczajowy</option>
                        </select>
                    </div>
                </div>
                <button>Dodaj</button>
            </form>
        </>
    )
}