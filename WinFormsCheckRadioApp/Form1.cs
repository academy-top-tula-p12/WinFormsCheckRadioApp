namespace WinFormsCheckRadioApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkCpp_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox check)
            {
                string str = check.Text + " " + check.CheckState.ToString();
                label1.Text = str;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radio)
                lblSecond.Text = radio.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radio)
                lblFirst.Text = radio.Text;
        }
    }
}
