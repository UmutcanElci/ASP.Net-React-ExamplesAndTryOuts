using System;
using CsvHelper.Configuration.Attributes;

namespace FianceCSVSeeTryOut
{
    public class StockModel
    {
        [Name("Date")]
        public string DateStock { get; set; }
        [Name("Close/Last")]
        public string OpenClose { get; set; }
        [Name("Open")]
        public string Open { get; set; }
        [Name("High")]
        public string High { get; set; }
        [Name("Low")]
        public string Low { get; set; }
        
    }
}