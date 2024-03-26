import React, {ChangeEvent, FC, SyntheticEvent, useState} from "react";

// Props that need from the App.tsx(Data flow)
interface Props {
    onSearchSubmit: (e : SyntheticEvent) => void;
    search: string | undefined;
    handleSearchChange: (e: ChangeEvent<HTMLInputElement>) => void;
}
const SearchComponent: FC<Props> = ({onSearchSubmit,search,handleSearchChange}: Props):JSX.Element => {
    
    return (
        <>
        <form onSubmit={onSearchSubmit}>
            <input value={search} onChange={handleSearchChange}/>
        </form>
        </>
    );
};

export default SearchComponent;