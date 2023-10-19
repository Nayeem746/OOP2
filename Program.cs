using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPORTS_ITEAM
{
    public class SportsItem
    {
        private string brand;
        private double price;
        private int quantity;

        public SportsItem()
        {
            brand = "";
            price = 0.0;
            quantity = 0;
        }

        public SportsItem(string brand, double price, int quantity)
        {
            this.brand = brand;
            this.price = price;
            this.quantity = quantity;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public double GetPrice()
        {
            return price;
        }

        public string GetBrand()
        {
            return brand;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public void ShowItemInfo()
        {
            Console.WriteLine("Brand           : " + brand);
            Console.WriteLine("Price           : " + price);
            Console.WriteLine("Quantity        : " + quantity);
        }
    }

    public class Customer
    {
        private string customerName;
        private int noOfItem;
        private double totalPay;

        public Customer()
        {
            customerName = "";
            noOfItem = 0;
            totalPay = 0.0;
        }

        public Customer(string customerName, int noOfItem, double totalPay)
        {
            this.customerName = customerName;
            this.noOfItem = noOfItem;
            this.totalPay = totalPay;
        }

        public string GetCustomerName()
        {
            return customerName;
        }

        public int GetNoOfItem()
        {
            return noOfItem;
        }

        public double GetTotalPay()
        {
            return totalPay;
        }

        public void ShowCustomerInfo()
        {
            Console.WriteLine("Customer Name   : " + customerName);
            Console.WriteLine("Number of Items : " + noOfItem);
            Console.WriteLine("Total Pay       : " + totalPay);
        }
    }

   public  class CricketBat : SportsItem
    {
        private double height;
        private double weight;

        public CricketBat()
        {
            height = 0.0;
            weight = 0.0;
        }

        public CricketBat(string brand, double price, int quantity, double height, double weight) : base(brand, price, quantity)
        {
            this.height = height;
            this.weight = weight;
        }

        public void ShowItemInfo()
        {
            base.ShowItemInfo();
            Console.WriteLine("Item Size       :" + height + " & " + weight);
        }
    }

    class Football : SportsItem
    {
        private double radius;

        public Football()
        {
            radius = 0.0;
        }

        public Football(string brand, double price, int quantity, double radius) : base(brand, price, quantity)
        {
            this.radius = radius;
        }

        public void ShowItemInfo()
        {
            base.ShowItemInfo();
            Console.WriteLine("Radius          : " + radius);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Nayeem", 5, 2500.0);
            Console.WriteLine();
            customer.ShowCustomerInfo();

            CricketBat cricketBat = new CricketBat("Adidas", 500.0, 10, 30.5, 2.5);
            cricketBat.ShowItemInfo();

            Console.WriteLine();

            Customer customer1 = new Customer("Rafi", 5, 1000);
            customer1.ShowCustomerInfo();
            Football football = new Football("Nike", 200.0, 5, 7.0);
            football.ShowItemInfo();

        }
    }
}
