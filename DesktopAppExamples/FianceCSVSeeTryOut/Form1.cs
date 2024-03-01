using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;

namespace FianceCSVSeeTryOut
{

    public partial class Form1 : Form
    {
        private List<string[]> csvData;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1(object sender, EventArgs e)
        {
            
        }

        private List<string[]> ReadCsvData(string filePath)
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
        }
    }
}