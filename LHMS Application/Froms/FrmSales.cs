using LHMS_Application.Theme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHMS_Application.Forms
{
    public partial class FrmSales : Form
    {
        //field
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public FrmSales()
        {
            InitializeComponent();

            random = new Random();
            btncloseChildFrom.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
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
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnlTitleBar.BackColor = color;
                    pnlmain.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btncloseChildFrom.Visible = true;

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMenu.Controls)
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
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            this.panelDesktopPanal.Controls.Add(childFrom);
            this.panelDesktopPanal.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
            lblTitle.Text = childFrom.Text;


        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME DashBoard";
            pnlTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            pnlTitleBar.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btncloseChildFrom.Visible = false;
        }

        private void btndel_cus_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Froms.FrmDealersAndCustomer(), sender);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {

        }

        private void btnSales_Click(object sender, EventArgs e)
        {

        }
    }
}
