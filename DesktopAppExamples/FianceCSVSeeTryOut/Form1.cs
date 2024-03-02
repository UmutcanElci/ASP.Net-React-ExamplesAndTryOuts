using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using YahooFinance;
using YahooFinanceClient.Models;


namespace FianceCSVSeeTryOut
{

    public partial class Form1 : Form
    {
        //private List<string[]> csvData;

        public Form1()
        {
            InitializeComponent();
        }



        /*private List<string[]> ReadCsvData(string filePath)
        {
            List<string[]> data = new List<string[]>();
            using (var reader = new StreamReader(filePath))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture);
                var parser = new CsvParser(reader, config);
                var csv = new CsvReader(parser);

                while (csv.Read())
                {
                    data.Add(csv.GetRecord<string[]>());
                }
            }

            return data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = fileDialog.FileName;
                string filePath = fileDialog.FileName;
                csvData = ReadCsvData(filePath);

                // Display data in the panel (e.g., richTextBox1)
                richTextBox1.Clear(); // Clear any existing text
                foreach (string[] row in csvData)
                {
                    string formattedRow =
                        string.Join(", ", row) + Environment.NewLine; // Join elements with commas, add new line
                    richTextBox1.AppendText(formattedRow);
                }
            }
        }*/
        private void file_button_Click(object sender, EventArgs e)
        {
            
            string filePath = "C:\\Users\\Malat\\Downloads\\HistoricalData_1709298232018.csv";

            try
            {
               
                List<StockModel> stockData = new List<StockModel>();

                
                using (var reader = new StreamReader(filePath))
                {
                    var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                    stockData = csv.GetRecords<StockModel>().ToList();
                }

                
                dataGridView1.DataSource = stockData;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Error reading CSV file: {ex.Message}");
            }
        }

        private void nasdaqSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.nasdaq.com/market-activity/quotes/historical");
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /*public async Task<int> getStockData(string symbol,DateTime startDate, DateTime endTime)
        {
            try
            {
               Stock.
            }
            catch
            {

            }
        }*/
        
        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = "main.py",
                WorkingDirectory = @"C:\Users\Malat\Desktop\Code\net\DesktopAppExamples\FianceCSVSeeTryOut" // Adjust as needed
            };
            System.Diagnostics.Process.Start(startInfo);
        }

      
    }
}