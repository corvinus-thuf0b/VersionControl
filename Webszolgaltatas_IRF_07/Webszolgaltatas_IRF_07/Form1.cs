﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Webszolgaltatas_IRF_07.Entities;



namespace Webszolgaltatas_IRF_07
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();
        string r;        

        public Form1()
        {
            InitializeComponent();
            GetEuroExchangeRates();
            GetXmlRates();

            dgwRates.DataSource = Rates;
            rtb.Text = r;
            rtb.Visible = false;
        }

        private void GetEuroExchangeRates()
        {
            var mnbService = new MnbServiceReference.MNBArfolyamServiceSoapClient();

            var request = new MnbServiceReference.GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

            var response = mnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;

            r = result;
        }


        private void GetXmlRates()
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(r);

            foreach (XmlElement element in xml.DocumentElement)
            {
                var rate = new RateData();
                Rates.Add(rate);

                rate.Date = DateTime.Parse(element.GetAttribute("date"));

                var childElement = (XmlElement)element.ChildNodes[0];
                rate.Currency = childElement.GetAttribute("curr");

                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                {
                    rate.Value = value / unit;
                }
            }
        }
    }
}
