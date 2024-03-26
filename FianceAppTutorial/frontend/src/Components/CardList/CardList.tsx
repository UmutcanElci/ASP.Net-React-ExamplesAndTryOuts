import React, {FC, SyntheticEvent} from 'react';
import Card from "../Card/Card";
import { v4 as uuidv4 } from "uuid";
import { CompanySearch } from "../../company";

interface Props {
    searchResults: CompanySearch[];
    onPortfolioCreate : (e: SyntheticEvent) => void;
}

const CardList: FC<Props> = ({ searchResults,onPortfolioCreate }: Props): JSX.Element => {
    return (
      <>
        {searchResults.length > 0 ? (
          searchResults.map((result) => {
            return <Card id={result.symbol} searchResult={result} key={uuidv4()} onPortfolioCreate={onPortfolioCreate} />;
          })
        ) : (
          <h1>No Results</h1>
        )}

      </>
    );
};

export default CardList;
