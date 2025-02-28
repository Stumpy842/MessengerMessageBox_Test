using DarkModeForms;

namespace MessengerMessageBox_Test
{
    public partial class Form1 : Form
    {
        private MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1;
        private MessageBoxIcon mbIcon = MessageBoxIcon.None;
        private string m;
        private string t;

        private bool _isDarkMode = false;
        private readonly DarkModeCS dm;

        public Form1()
        {
            InitializeComponent();
            dm = new DarkModeCS(this)
            {
                // Choose your preferred mode here:
                ColorMode = DarkModeCS.DisplayMode.SystemDefault
            };
            m = tbMessage.Text;
            t = tbTitle.Text;
            lbResult.Text = "";
        }

        #region RadioButton stuff
        private void rbOne_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOne.Checked) defaultButton = MessageBoxDefaultButton.Button1;
            else if (rbTwo.Checked) defaultButton = MessageBoxDefaultButton.Button2;
            else if (rbThree.Checked) defaultButton = MessageBoxDefaultButton.Button3;
            else if (rbFour.Checked) defaultButton = MessageBoxDefaultButton.Button4;
        }

        private void rbSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSystem.Checked)
            {
                dm!.ColorMode = DarkModeCS.DisplayMode.ClearMode;
                _isDarkMode = dm.isDarkMode();
            }
            else if (rbDark.Checked)
            {
                dm!.ColorMode = DarkModeCS.DisplayMode.DarkMode;
                _isDarkMode = true;
            }
            else
            {
                dm!.ColorMode = DarkModeCS.DisplayMode.ClearMode;
                _isDarkMode = false;
            }
            dm.ApplyTheme(_isDarkMode);
        }

        private void rbNone_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            switch (rb.Name)
            {
                case "rbNone": mbIcon = MessageBoxIcon.None;
                    break;
                case "rbHand": mbIcon = MessageBoxIcon.Hand;
                    break;
                case "rbQuestion": mbIcon = MessageBoxIcon.Question;
                    break;
                case "rbExclamation": mbIcon = MessageBoxIcon.Exclamation;
                    break;
                case "rbAsterisk": mbIcon = MessageBoxIcon.Asterisk;
                    break;
            }
        }
        #endregion RadioButton stuff


        #region TextBox stuff
        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            t = tbTitle.Text;
        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {
            m = tbMessage.Text;
        }
        #endregion TextBox stuff


        private void ShowResult(DialogResult result)
        {
            lbResult.Text = result.ToString();
        }

        #region WinForms MessageBox
        private void btOK_Click(object sender, EventArgs e)
        {
            ShowResult(MessageBox.Show(m, t, MessageBoxButtons.OK, mbIcon));
        }

        private void btOKCancel_Click(object sender, EventArgs e)
        {
            ShowResult(MessageBox.Show(m, t, MessageBoxButtons.OKCancel, mbIcon, defaultButton));
        }

        private void btAbortRetryIgnore_Click(object sender, EventArgs e)
        {
            ShowResult(MessageBox.Show(m, t, MessageBoxButtons.AbortRetryIgnore, mbIcon, defaultButton));
        }

        private void btYesNoCancel_Click(object sender, EventArgs e)
        {
            ShowResult(MessageBox.Show(m, t, MessageBoxButtons.YesNoCancel, mbIcon, defaultButton));
        }

        private void btYesNo_Click(object sender, EventArgs e)
        {
            ShowResult(MessageBox.Show(m, t, MessageBoxButtons.YesNo, mbIcon, defaultButton));
        }

        private void btRetryCancel_Click(object sender, EventArgs e)
        {
            ShowResult(MessageBox.Show(m, t, MessageBoxButtons.RetryCancel, mbIcon, defaultButton));
        }

        private void btCancelTryContinue_Click(object sender, EventArgs e)
        {
            ShowResult(MessageBox.Show(m, t, MessageBoxButtons.CancelTryContinue, mbIcon, defaultButton));
        }
        #endregion WinForms MessageBox


        #region Messenger.MessageBox
        private void btmOK_Click(object sender, EventArgs e)
        {
            ShowResult(Messenger.MessageBox(m, t, MessageBoxButtons.OK, mbIcon, defaultButton, _isDarkMode));
        }

        private void btmOKCancel_Click(object sender, EventArgs e)
        {
            ShowResult(Messenger.MessageBox(m, t, MessageBoxButtons.OKCancel, mbIcon, defaultButton, _isDarkMode));
        }

        private void btmAbortRetryIgnore_Click(object sender, EventArgs e)
        {
            ShowResult(Messenger.MessageBox(m, t, MessageBoxButtons.AbortRetryIgnore, mbIcon, defaultButton, _isDarkMode));
        }

        private void btmYesNoCancel_Click(object sender, EventArgs e)
        {
            ShowResult(Messenger.MessageBox(m, t, MessageBoxButtons.YesNoCancel, mbIcon, defaultButton, _isDarkMode));
        }

        private void btmYesNo_Click(object sender, EventArgs e)
        {
            ShowResult(Messenger.MessageBox(m, t, MessageBoxButtons.YesNo, mbIcon, defaultButton, _isDarkMode));
        }

        private void btmRetryCancel_Click(object sender, EventArgs e)
        {
            ShowResult(Messenger.MessageBox(m, t, MessageBoxButtons.RetryCancel, mbIcon, defaultButton, _isDarkMode));
        }

        private void btmCancelTryContinue_Click(object sender, EventArgs e)
        {
            ShowResult(Messenger.MessageBox(m, t, MessageBoxButtons.CancelTryContinue, mbIcon, defaultButton, _isDarkMode));
        }
        #endregion Messenger.MessageBox
    }
}
