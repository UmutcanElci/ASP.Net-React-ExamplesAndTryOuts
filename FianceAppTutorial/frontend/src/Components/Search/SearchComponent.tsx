import React, {ChangeEvent, FC, SyntheticEvent, useState} from "react";

// Props that need from the App.tsx(Data flow)
interface Props {
    onClick: (e : SyntheticEvent) => void;
    search: string | undefined;
    handleChange: (e: ChangeEvent<HTMLInputElement>) => void;
}
const SearchComponent: FC<Props> = ({onClick,search,handleChange}: Props):JSX.Element => {
    
    return (
        <>
        <div>
            <input value={search} onChange={(e) => handleChange(e)}></input>
            <button onClick={(e) => onClick(e)}></button>
        </div>
        </>
    );
};

export default SearchComponent;