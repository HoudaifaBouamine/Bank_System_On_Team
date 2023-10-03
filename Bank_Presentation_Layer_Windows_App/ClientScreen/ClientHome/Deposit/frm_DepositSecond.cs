﻿using Bank_Business_Layer;
using Bank_Presentation_Layer_Windows_App.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome.Deposit
{
    public partial class frm_DepositSecondScreen : Form
    {
        clsClient Client;
        frm_MainBaseForm Main;
        clsTransaction Transaction;
        public frm_DepositSecondScreen(frm_MainBaseForm main, clsClient client,clsTransaction transaction)
        {
            Client = client;
            Main = main;
            Transaction = transaction;
            InitializeComponent();
            this.TopLevel = false;
        }

        private void frm_DepositSecondScreen_Load(object sender, EventArgs e)
        {
            lbl_Amount.Text = "+"+string.Format("{0:0.00}", Transaction.Amount) + "  $";
            lbl_DateTime.Text = Transaction.TransactionDateTime.ToString();
            lbl_ReceiverAccountNumber.Text = Transaction.Receiver.AccountNumber.ToString();

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}