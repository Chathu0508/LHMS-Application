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
    public partial class FrmSalesnMarketing : Form
    {
        //field
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public FrmSalesnMarketing()
        {
            InitializeComponent();

            random = new Random();
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
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);

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
        }
        private void Reset()
        {
            DisableButton();
            currentButton = null;
        }

        private void btndel_cus_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Froms.FrmDealersAndCustomer(), sender);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Froms.FrmPurchase(), sender);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Froms.FrmPurchase(), sender);

        }

        private void btncloseChildFrom_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
    }
}
