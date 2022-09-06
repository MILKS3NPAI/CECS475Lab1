using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CECS475Lab1
{
    public class StockNotification : EventArgs
    {
        public string StockName { get; set; }
        public int CurrentValue { get; set; }
        public int NumChanges { get; set; }

        /// <summary> 
        /// Stock notification attributes that are set and changed 
        /// </summary> 
        /// <param name="stockName">Name of stock</param> 
        /// <param name="currentValue">Current vallue of the stock</param> 
        /// <param name="numChanges">Number of changes the stock goes through</param> 
        public StockNotification(string stockName, int currentValue, int numChanges)
        {
            // !NOTE!: Fill in below of what the notification will do using the comments  above
            this.StockName = stockName;
            this.CurrentValue = currentValue;
            this.NumChanges = numChanges;
        }

    }
    public class driver
    {
        static void Main(string[] args)
        {
            Stock stock1 = new Stock("Technology", 160, 5, 15);
            Stock stock2 = new Stock("Retail", 30, 2, 6);
            Stock stock3 = new Stock("Banking", 90, 4, 10);
            Stock stock4 = new Stock("Commodity", 500, 20, 50);
            StockBroker b1 = new StockBroker("Broker 1");
            b1.AddStock(stock1);
            b1.AddStock(stock2);
            StockBroker b2 = new StockBroker("Broker 2");
            b2.AddStock(stock1);
            b2.AddStock(stock3);
            b2.AddStock(stock4);
            StockBroker b3 = new StockBroker("Broker 3");
            b3.AddStock(stock1);
            b3.AddStock(stock3);
            StockBroker b4 = new StockBroker("Broker 4");
            b4.AddStock(stock1);
            b4.AddStock(stock2);
            b4.AddStock(stock3);
            b4.AddStock(stock4);
            string titles = "Broker".PadRight(16) + "Stock".PadRight(16) +
            "Value".PadRight(16) + "Changes".PadRight(10) + "Date and Time";

            Console.WriteLine(titles);

        }
    }
} 


