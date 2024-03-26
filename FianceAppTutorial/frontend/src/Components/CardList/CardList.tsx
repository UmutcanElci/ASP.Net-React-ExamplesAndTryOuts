import React, { FC } from 'react';
import Card from "../Card/Card";
import { v4 as uuidv4 } from "uuid";
import { CompanySearch } from "../../company";

interface Props {
    searchResults: CompanySearch[];
}

const CardList: FC<Props> = ({ searchResults }: Props): JSX.Element => {
    return (
      <>
        {searchResults.length > 0 ? (
          searchResults.map((result) => {
            return <Card id={result.symbol} searchResult={result} key={uuidv4()} />;
          })
        ) : (
          <h1>No Results</h1>
        )}

      </>
    );
};

export default CardList;
