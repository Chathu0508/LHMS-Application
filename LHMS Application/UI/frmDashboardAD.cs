using LHMS_Application.Theme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHMS_Application.UI
{
    public partial class frmDashboardAD : Form
    {
        //bool logic 
        bool salesollapsed;

        //field
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Contrust
        public frmDashboardAD()
        {
            InitializeComponent();
            random = new Random();
            btncloseChildFrom.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //to show he sub buttons
            customizeDesign();
        }
        
        //rest the button the dashboard
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME DashBoard";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btncloseChildFrom.Visible = false;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //method
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        //make the button to preant child to open the Frms 
        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btncloseChildFrom.Visible = true;

                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                }
            }
        }
        private void OpenChildForm(Form childFrom, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock= DockStyle.Fill;
            this.panelDesktopPanal.Controls.Add(childFrom);
            this.panelDesktopPanal.Tag= childFrom;
            childFrom.BringToFront();
            childFrom.Show();
            lblTitle.Text = childFrom.Text;
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmUsers(),  sender);
        }
        private void btncloseChildFrom_Click(object sender, EventArgs e)
        {
            if (activeForm != null) 
                activeForm.Close();
            Reset();

        }

        //Add Subbutton to the dashbaord
        private void customizeDesign()
        {
            pnlsubinvmanue.Visible = false;
            pnlSalesandmar.Visible = false;
            pnlsubtaskmanue.Visible = false;
        }

        private void hidsubmenu()
        {
            if (pnlsubinvmanue.Visible == true)
            pnlsubinvmanue.Visible = false;

            if (pnlsubtaskmanue.Visible == true)
            pnlsubtaskmanue.Visible = false;

            if (pnlSalesandmar.Visible == true)
                pnlSalesandmar.Visible = false;
        }

        private void ShowSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidsubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        //to move the Application from the Title Bar
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        //operator for the Application Close maximize and Minimize
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //Inventroy Deatils button and sub button
        private void btnInve_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnlsubinvmanue);
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmProduct(), sender);
            hidsubmenu();
        }
        private void btncategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmCategory(), sender);
            hidsubmenu();
        }
        private void btninvqty_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Froms.FrmInventoryTrackAD(), sender);
            hidsubmenu();
        }

        //task Deatils button and sub button
        private void button1_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnlsubtaskmanue);
        }

        private void btncreatetask_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmTasks(), sender);
            hidsubmenu();
        }

        private void btntracktask_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Froms.FrmTaskTrackAD(), sender);
            hidsubmenu();
        }

        //Sales and marketing and other

        private void btnsales_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnlSalesandmar);
        }

        private void btmSales_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Froms.FrmPurchaseandsales(), sender);
            hidsubmenu();
        }

        private void btnpurs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Froms.FrmPurchaseandsales(), sender);
            hidsubmenu();
        }

        //logout button 
        private void btnlogout_Click(object sender, EventArgs e)
        {
            FrmLogin log = new FrmLogin();
            log.Show();
            this.Hide();
        }
    }
}
