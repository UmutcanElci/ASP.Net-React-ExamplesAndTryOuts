
import React, {ChangeEvent, FC, SyntheticEvent, useState} from "react";

type Props = {
    
}
const SearchComponent: FC<Props> = (props: Props):JSX.Element => {
    const[search,setSearch] = useState<string>("");
    const handleChange = (e: ChangeEvent<HTMLInputElement>) => {
        setSearch(e.target.value);
        console.log(e);
    }
    
    const onClick = (e : SyntheticEvent) =>{
        
        console.log(e);
    }
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