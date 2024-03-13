
import React, { FC } from 'react';
import "./Card.css"
const Card: FC = () => {
  return (
      <>
    <div className="card">
      <img
          src="https://picsum.photos/500/500"
          alt="Image"
      />
    </div>
  <div className="details">
      <h2>APPL</h2>
      <p>$110</p>
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
