import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App'; // Adjust this if you’re importing a named export like { App2 }

ReactDOM.createRoot(document.getElementById('root')).render(
  <React.StrictMode>
    <App />
  </React.StrictMode>
);