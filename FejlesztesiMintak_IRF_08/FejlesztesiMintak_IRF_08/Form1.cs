using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FejlesztesiMintak_IRF_08.Abstactions;
using FejlesztesiMintak_IRF_08.Entities;

namespace FejlesztesiMintak_IRF_08
{
    public partial class Form1 : Form
    {
        List<Toy> _toys = new List<Toy>();
        private Toy _nextToy;

        public IToyFactory _factory;
        public IToyFactory Factory
        {
            get { return _factory; }
            set 
            { 
                _factory = value;
                DisplayNext();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var toy = Factory.CreateNew();
            _toys.Add(toy);
            toy.Left = -toy.Width;
            mainPanel.Controls.Add(toy);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var item in _toys)
            {
                item.MoveToy();
                if (item.Left > maxPosition)
                {
                    maxPosition = item.Left;
                }
            }

            if (maxPosition >= 1000)
            {
                var oldestToy = _toys[0];
                mainPanel.Controls.Remove(oldestToy);
                _toys.Remove(oldestToy);
            }
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void btnBall_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory
            {
                BallColor = btnBallColor.BackColor
            };
        }

        private void DisplayNext()
        {
            if (_nextToy != null) Controls.Remove(_nextToy);

            _nextToy = Factory.CreateNew();
            _nextToy.Left = lblNext.Left;
            _nextToy.Top = lblNext.Top + lblNext.Height + 20;
            mainPanel.Controls.Add(_nextToy);
        }

        private void btnBallColor_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var colorPicker = new ColorDialog();

            colorPicker.Color = button.BackColor;
            if (colorPicker.ShowDialog() != DialogResult.OK) return;
            button.BackColor = colorPicker.Color;
        }

        private void btnPresent_Click(object sender, EventArgs e)
        {
            Factory = new PresentFactory
            {
                BoxColor = btnBoxColor.BackColor,
                RibbonColor = btnRibbonColor.BackColor,
            };
        }
    }
}
