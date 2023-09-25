using Bank_Business_Layer;
using Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Presentation_Layer_Windows_App.ClientScreen
{
    public partial class frm_ClientHome : Form
    {

        clsClient client = null;
        public frm_ClientHome(clsClient client)
        {
            this.client = client;
            InitializeComponent();

            ucClientBalanceSummary balanceSummary = new ucClientBalanceSummary(client);
            pnl_Balance.Controls.Add(balanceSummary);
            balanceSummary.Dock = DockStyle.Fill;


            //

            
            //pers_Disposit = 261.0 / 930;//261,335
            //pers_Withdraw = 261.0 / 930;
            //pers_Transfer = 268.0 / 930;
            //pers_Height = 335.0 / 930;
            //pers_X_Withdraw = 292.0/ 850;
            //pers_X_Transfer = 589.0/ 850;

            //pers_Disposit_Width_Heigth =pnl_Deposit .Height  /  pnl_Deposit.Width ;
            //pers_Withdraw_Width_Heigth =pnl_Withdraw.Height  / pnl_Withdraw.Width ;
            //pers_Transfer_Width_Heigth = pnl_Transfer.Height / pnl_Transfer.Width ;
        }


        double pers_Disposit_Width_Heigth    ;
        double pers_Withdraw_Width_Heigth    ;
        double pers_Transfer_Width_Heigth;
        double pers_Disposit, pers_Withdraw,pers_Transfer,pers_Height, pers_X_Withdraw, pers_X_Transfer;

        private void pnl_Deposit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_ClientHomePage_Load(object sender, EventArgs e)
        {
            
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_ClientHome_Resize(object sender, EventArgs e)
        {


            //resize
            //pnl_Deposit.Width = (int)(pers_Disposit * (double)pnl_MidleSep.Width);
            //pnl_Withdraw.Width = (int)(pers_Withdraw * (double)pnl_MidleSep.Width);
            //pnl_Transfer.Width = (int)(pers_Transfer * (double)pnl_MidleSep.Width);

            //pnl_Deposit.Height = (int)(pers_Disposit_Width_Heigth * pnl_Deposit.Width);
            //pnl_Withdraw.Height = (int)(pers_Withdraw_Width_Heigth * pnl_Withdraw.Width);
            //pnl_Transfer.Height = (int)(pers_Transfer_Width_Heigth * pnl_Transfer.Width);



            //pnl_Deposit.Location = new Point(0, 10);
            //pnl_Withdraw.Location = new Point((int)(pers_X_Withdraw * pnl_MidleSep.Width), 10);
            //pnl_Transfer.Location = new Point((int)(pers_X_Transfer * pnl_MidleSep.Width), 10);
        }
    }
}
