import React, { ChangeEvent, SyntheticEvent, useState } from "react";
import './App.css';
import CardList from "./Components/CardList/CardList";
import SearchComponent from "./Components/Search/SearchComponent";
import {CompanySearch} from "./company";
import {searchCompanies} from "./api";


function App() {
  const [ search,setSearch] = useState<string>("");
  //Type Narrowing
  const [searchResult,setSearchResult] = useState<CompanySearch[]>([]);
  const [serverError, setServerError] = useState<string>("");

  // -- SearchComponent --
  const handleChange = (e: ChangeEvent<HTMLInputElement>) => { //We make sure data flowing is in the main part(App) that we control in one place
    setSearch(e.target.value);
    console.log(e);
  }

  const onClick = async (e : SyntheticEvent) => {
      e.preventDefault();
      const result = await searchCompanies(search);
      if (typeof result === "string"){
        setServerError(result);
      } else if (Array.isArray(result.data)) {
          const companies = result.data as CompanySearch[];
          setSearchResult(companies);
      }
      console.log(searchResult);
    }
  return (
    <>
    <div className="App">

      <SearchComponent onClick={onClick} search={search} handleChange={handleChange}/>
      {serverError && <h1>{serverError}</h1>} // gives error at console and in page 
      <CardList />

    </div>
    </>
  );
}

export default App;
