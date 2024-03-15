import React from 'react';
import './App.css';
import CardList from "./Components/CardList/CardList";
import SearchComponent from "./Components/Search/SearchComponent";


function App() {
  return (
    <>
    <div className="App">

      <SearchComponent/>
      <CardList />

    </div>
    </>
  );
}

export default App;
