using System;
using System.Drawing;
using System.Windows.Forms;

namespace _ListProject
{
    public partial class main : Form
    {
        //fields 
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public main()
        {
            InitializeComponent();
            random = new Random();
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColors.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColors.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColors.ColorList[index];
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
                    currentButton.Font = new Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    topic.BackColor = ThemeColors.ChangeColorBrightness(color, -0.3);
                    ThemeColors.PrimaryColor = color;
                    ThemeColors.SecondaryColor = ThemeColors.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            titleLable.Text = childForm.Text;
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.List(), sender);
        }

        private void stackBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Stack(), sender);
        }

        private void generaizedListBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.GeneralizedList(), sender);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
