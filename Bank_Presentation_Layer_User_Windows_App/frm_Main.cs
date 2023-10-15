using Bank_Presentation_Layer_User_Windows_App.Properties;
using Bank_Presentation_Layer_User_Windows_App.Start;
using System.Runtime.InteropServices;

namespace Bank_Presentation_Layer_User_Windows_App
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;


        }
        frm_Login LoginScreen = null;



        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnl_HeaderBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btn_Maximize.Image = Resources.img_maximizeFormON;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btn_Maximize.Image = Resources.img_maximizeFormOFF;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Main_Shown(object sender, EventArgs e)
        {

            this.LoginScreen = frm_Login.Screen;
            this.pnl_Background.Controls.Add(LoginScreen);
            this.LoginScreen.Dock = DockStyle.Fill;
            this.LoginScreen.BringToFront();
            this.LoginScreen.Show();
        }
    }
}