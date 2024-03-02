import yfinance as yf
import csv

# Download Microsoft stock data for the past year
msft = yf.Ticker("MSFT")
data = msft.history(period="1y")

# Create the CSV file path in your Downloads folder
file_path = "C:\\Users\\Malat\\Downloads\\msft_historical_data.csv"

# Write data to CSV file
with open(file_path, 'w', newline='') as csvfile:
    writer = csv.writer(csvfile)
    writer.writerow(data.columns)  # Write header row
    writer.writerows(data.to_csv(index=False).splitlines())  # Write data rows
