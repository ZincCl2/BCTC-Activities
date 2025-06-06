﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedAndBreakfast
{
    public partial class BreakfastOptionsForm : Form
    {
        private const double CONT_BREAKFAST_PRICE = 6.00;
        private const double FULL_BREAKFAST_PRICE = 9.95;
        private const double DELUXE_BREAKFAST_PRICE = 16.50;
        public BreakfastOptionsForm()
        {
            InitializeComponent();
        }

        private void BreakfastOptionsForm_Load(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " + CONT_BREAKFAST_PRICE.ToString("C");
        }

        private void contRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " + CONT_BREAKFAST_PRICE.ToString("C");
        }

        private void fullRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " + FULL_BREAKFAST_PRICE.ToString("C");
        }

        private void deluxeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " + DELUXE_BREAKFAST_PRICE.ToString("C");
        }
    }
}
