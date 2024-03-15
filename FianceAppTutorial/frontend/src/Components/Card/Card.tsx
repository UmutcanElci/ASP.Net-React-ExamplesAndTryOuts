
import React, { FC } from 'react';
import "./Card.css"
interface Props{
companyName: string;
ticker: string;
price: number;
}
const Card : React.FC<Props> = ({companyName,ticker,price}: Props):JSX.Element => {
  return (
      <>
    <div className="card">
      <img
          src="https://picsum.photos/500/500"
          alt="Image"
      />
    </div>
  <div className="details">
      <h2>{companyName} : {ticker}</h2>
      <p>${price}</p>
  </div>
      <div>
        <p className="info">
            Info of apple stock
        </p>  
      </div>
      </>
  );
}

export default Card;
