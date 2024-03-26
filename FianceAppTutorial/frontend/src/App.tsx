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
  const handleSearchChange = (e: ChangeEvent<HTMLInputElement>) => { //We make sure data flowing is in the main part(App) that we control in one place
    setSearch(e.target.value);
    console.log(e);
  }

  const onPortfolioCreate = (e: SyntheticEvent) =>{
    e.preventDefault();
    console.log(e);
  }
  const onSearchSubmit = async (e : SyntheticEvent) => {
    e.preventDefault();
    try {
      const result = await searchCompanies(search);
      if (typeof result === "string") {
        setServerError(result);
      } else {
        const companies: CompanySearch[] = Object.values(result); //Old  usage result.data news is Object.values
        setSearchResult(companies);
      }

    } catch (error) {
      setServerError("An error occurred while fetching data.");
    }
      console.log(searchResult);
    }
  return (
    <>
    <div className="App">

      <SearchComponent onSearchSubmit={onSearchSubmit} search={search} handleSearchChange={handleSearchChange}/>
      <CardList searchResults={searchResult} onPortfolioCreate={onPortfolioCreate}/>
      {serverError && <h1>{serverError}</h1>} // gives error at console and in page
      
    </div>

    </>
  );
}

export default App;
