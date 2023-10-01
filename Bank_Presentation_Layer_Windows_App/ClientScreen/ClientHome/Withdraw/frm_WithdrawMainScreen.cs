﻿using Bank_Business_Layer;
using Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome.Deposit;
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

namespace Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome.Withdraw
{
    public partial class frm_WithdrawMainScreen : frm_MainBaseClass
    {

        clsClient client = null;
        Dictionary<string, Form> forms = new Dictionary<string, Form>();
        public clsTransaction transaction = null;
        public frm_WithdrawMainScreen(clsClient client)
        {
            this.client = client;
            transaction = new clsTransaction(clsTransaction.enTransaction.eDeposit, -1, client.Client_ID, -1, (int)clsTransaction.enTransaction.eDeposit, -1, DateTime.MinValue);
            InitializeComponent();

            forms.Add("First", new frm_DepositFirstScreen(this, client, transaction));
            forms.Add("Second", new frm_DepositSecondScreen(this, client, transaction));

            controler = new clsPagesControler(pnl_Main, forms);
            controler.open_page("First");
        }

        internal clsPagesControler controler = null;

       
    }
}
