using Microsoft.Extensions.Logging;
using System;
using System.Windows.Forms;


namespace ProjectCollection
{
    public partial class FrmClient : Form
    {
#pragma warning disable IDE0052
        public string fromAddress;
        public string fromPW;
        private readonly ILogger _logger;
        private readonly ICreateMail _createMail;
#pragma warning restore IDE0052
        public FrmClient(ILogger<FrmClient> logger, ICreateMail createMail)
        {
            InitializeComponent();
            txtPW.Text = "";
            txtPW.PasswordChar = '*';
            _logger = logger;
            _createMail = createMail;
        }
        /// <summary>
        /// Creats and sends the message with the entered text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSend_Click(object sender, EventArgs e)
        {
            string mailSender = txtSender.Text;
            string mailReceiver = txtReceiver.Text;
            string mailSubject = txtSubject.Text;
            string mailPw = txtPW.Text;
            string mailContent = rtbContent.Text;
            _createMail.CreateMessage(mailSender, mailReceiver, mailSubject, mailContent, mailPw);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

