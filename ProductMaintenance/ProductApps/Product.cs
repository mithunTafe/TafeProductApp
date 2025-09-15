﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal totalCharge;
        private decimal totalChargeWrap;
        private decimal totalChargeGST;
        private decimal delivery;
        private decimal wrapping;
        private decimal gst;

        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }

        public decimal TotalCharge
        {
            get { return totalCharge; }
            set { totalCharge = value; }
        }

        public decimal TotalChargeWrap
        {
            get { return totalChargeWrap; }
            set { totalChargeWrap = value; }
        }

        public decimal TotalChargeGST
        {
            get { return totalChargeGST; }
            set { totalChargeGST = value; }
        }

        private decimal Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        private decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }

        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
        }

        //Calculate the total charge
        public void calTotalCharge()
        {
            TotalCharge = TotalPayment + 25;
        }

        //Calculate the total charge after wrap
        public void calTotalChargeWrap()
        {
            TotalChargeWrap = TotalPayment + 25 + 5;
        }

        //Calculate the total charge after GST
        public void calTotalChargeGST()
        {
            TotalChargeGST = (TotalPayment + 25 + 5) * 1.1m;
        }
    }
}
