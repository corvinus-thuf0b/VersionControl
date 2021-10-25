using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Webszolgaltatas_IRF_07.Entities;



namespace Webszolgaltatas_IRF_07
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();

        public Form1()
        {
            InitializeComponent();
            GetEuroExchangeRates();

            dgwRates.DataSource = Rates;
        }

        private static void GetEuroExchangeRates()
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
        }
    }
}
