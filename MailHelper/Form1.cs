using System;

using System.Windows.Forms;

namespace MailHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailHelper mailHelper = new MailHelper();
            //mailHelper.Host = "smtp.exmail.qq.com";
            //mailHelper.MailFrom ="system-message@chiccasa.com.cn";
            //mailHelper.MailPwd ="Chic123456789";

            mailHelper.Host = "smtp.exmail.qq.com";
            mailHelper.MailFrom = "11@chiccasa.com.cn";
            mailHelper.MailPwd = "Chic123456";
            //mailHelper.MailFrom = "software-engineer@chiccasa.com.cn";
            //mailHelper.MailPwd = "Hua19931020";

            //mailHelper.Host = "smtp-mail.outlook.com";
            //mailHelper.MailFrom = "saihua_chen@outlook.com";
            //mailHelper.MailPwd = "c1101269325";
            mailHelper.MailSubject = titleBox.Text;
            mailHelper.MailBody = richTextBox1.Text;
            mailHelper.MailToArray = new string[1] { emailBox.Text };
            try
            {
                mailHelper.Send();
                label4.Text = "发送成功！";
            }
            catch (Exception ex)
            {
                label4.Text = "发送失败！" + ex.Message;
                throw ex;
            }
        }
    }
}