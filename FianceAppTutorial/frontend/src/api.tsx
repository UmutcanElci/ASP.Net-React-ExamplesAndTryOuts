import axios, { AxiosResponse, AxiosError } from "axios";

interface Company {
  
}

interface SearchResponse {
  data: Company[];
}
// Searching the company
export const searchCompanies = async (query: string): Promise<SearchResponse | string> => {
  try {
    const response: AxiosResponse<SearchResponse> = await axios.get(
      `https://financialmodelingprep.com/api/v3/search-ticker?query=${query}&limit=10&exchange=NASDAQ&apikey=${process.env.REACT_APP_API_KEY}`
    );
    console.log("API response:", response.data); // response to console 
    return response.data;
  } catch (error) {
    const axiosError = error as AxiosError;
    if (axiosError.isAxiosError){
      console.log("error message: ",axiosError.message);
      return axiosError.message;
    } else {
      console.log("unexpected error: ",error);
      return "An expected error has occurred";
    }
  }
}