import React, { FC } from 'react';
import Card from "../Card/Card";
import { v4 as uuidv4} from "uuid";
interface Props{
    searchResults: CompanySearch[];
}
const CardList:FC<Props> = ({searchResults}:Props): JSX.Element => {
    return (
        <>
        {searchResults.Length > 0 ?(
            searchResults.map((result) => {
                return <Card id ={result.symbol} key={uuidv4()} searchResult={result}/>
            })
        ) : (
            <h1>
                No Results
            </h1>
        )}
        </>
    );
};

export default CardList;