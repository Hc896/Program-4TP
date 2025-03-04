import logo from './logo.svg';
import './App.css';
import 'bootstrap/dist/css/bootstrap.css';

function App() {
  return (
   <header>
      <h1>Kategoria Zdjęć</h1>
      <div class="form-check-inline form-switch">
        <input class="form-check-input" type="checkbox" id="ctrId"/>
        <label class="form-check-label" for="ctrId">Książki</label>
      </div>
      <div class="form-check-inline form-switch">
        <input class="form-check-input" type="checkbox" id="ctrId2"/>
        <label class="form-check-label" for=" ctrId2">Samochody</label>
      </div>
      <div class="form-check-inline form-switch">
        <input class="form-check-input" type="checkbox" id="ctrId3"/>
        <label class="form-check-label" for=" ctrId3">Zwierzęta</label>
      </div>
    </header>
  );
}
export default App;