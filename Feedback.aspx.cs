using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text;
using System.IO;
using System.Security;
using System.Security.Principal;

namespace ResTesting
{
    public partial class Feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             IIdentity WinId = HttpContext.Current.User.Identity;
             string strName = WinId.Name.Split('\\')[1];
             txtName.Text = strName;
        }
       
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            IIdentity WinId = HttpContext.Current.User.Identity;
            WindowsIdentity wi = (WindowsIdentity)WinId;
            validate();
            if (lblErr.Text == "")
            {
                if (sendmail() == "SUCCESS")
                {
                    lblErr.ForeColor = System.Drawing.Color.Green;
                    lblErr.Text = "Thank you for submiting you feedback";
                }
            }          
            
        }
        private void validate()
        {
            lblErr.Text = "";
            if (rdbtnlstThisTraining.SelectedItem== null || rdbtnlstThisTraining.SelectedItem.Text == "")
                lblErr.Text += "<br />Please select any option in # 1.";
            if (txtWhatLearning.Text.Trim() == "")
                lblErr.Text += "<br />Please enter you comments in # 2.";
            if (txtApplylearned.Text.Trim() == "")
                lblErr.Text += "<br />Please enter you comments in # 3.";
            if (txtMissing.Text.Trim() == "")
                lblErr.Text += "<br />Please enter you comments in # 4.";
            if (txtDoneBetter.Text.Trim() == "")
                lblErr.Text += "<br />Please enter you comments in # 5.";

        }

        private string sendmail()
        {
            try
            {
                MailMessage mailMessage = new MailMessage();

                mailMessage.To.Add("manoj.chandran@ibsplc.com");
                mailMessage.From = new MailAddress("manoj.chandran@ibsplc.com");
                mailMessage.Subject = "Feedback";
                mailMessage.Body = BuildHTML();
                //SmtpClient smtpClient = new SmtpClient("mail.ibsplc.com");
                //smtpClient.Credentials = new System.Net.NetworkCredential("manoj.chandran@ibsplc.com", "");
                //smtpClient.Send(mailMessage);
               return "SUCCESS";                
            }
            catch (Exception ex)
            {
                lblErr.Text = "Could not send the e-mail - error: " + ex.Message;
                return "FAILURE";
            }
        }

        private string BuildHTML()
        {
            StringBuilder strHTML = new StringBuilder();
            strHTML.Append("<div><label>1. This Training:</div></label><br /><p>");
            strHTML.Append(rdbtnlstThisTraining.SelectedItem.Text);
            strHTML.Append("</p><br /><div><label>2. What you learn from this training?</div></label><br />");
            strHTML.Append(txtWhatLearning.Text.Trim());

            strHTML.Append("</p><br /><div><label>2. What you learn from this training?</div></label><br />");
            strHTML.Append(txtApplylearned.Text.Trim());

            strHTML.Append("</p><br /><div><label>2. What you learn from this training?</div></label><br />");
            strHTML.Append(txtMissing.Text.Trim());

            strHTML.Append("</p><br /><div><label>2. What you learn from this training?</div></label><br />");
            strHTML.Append(txtDoneBetter.Text.Trim());
            FeedbackLog(strHTML.ToString());
            return strHTML.ToString();
        }

        public void FeedbackLog(string sFeedback)
        {
            IIdentity WinId = HttpContext.Current.User.Identity;
            string filename = "Log_" + WinId.Name.Split('\\')[1] + ".txt";
            string LogPath = "D://";
            string filepath = LogPath + filename;
            if (File.Exists(filepath))
            {               
                using (StreamWriter writer = new StreamWriter(filepath, true))
                {
                 writer.WriteLine("-------------------START-------------" + DateTime.Now);
                 writer.WriteLine("1. This Training:");
                 writer.WriteLine(rdbtnlstThisTraining.SelectedItem.Text);
                 writer.WriteLine("2. What you learn from this training?");
                 writer.WriteLine(txtWhatLearning.Text.Trim());
                 writer.WriteLine("3.  How will you apply what you learned to your job?");
                 writer.WriteLine(txtApplylearned.Text.Trim());
                 writer.WriteLine("4. What was missing in this training?");
                 writer.WriteLine(txtMissing.Text.Trim());
                 writer.WriteLine("5.  what would have been done better?");
                 writer.WriteLine(txtDoneBetter.Text.Trim());
                 writer.WriteLine("-------------------END-------------" + DateTime.Now);
                }
            }
            else
            {
                StreamWriter writer = File.CreateText(filepath);
                writer.WriteLine("-------------------START-------------" + DateTime.Now);
                writer.WriteLine("1. This Training:");
                writer.WriteLine(rdbtnlstThisTraining.SelectedItem.Text);
                writer.WriteLine("2. What you learn from this training?");
                writer.WriteLine(txtWhatLearning.Text.Trim());
                writer.WriteLine("3.  How will you apply what you learned to your job?");
                writer.WriteLine(txtApplylearned.Text.Trim());
                writer.WriteLine("4. What was missing in this training?");
                writer.WriteLine(txtMissing.Text.Trim());
                writer.WriteLine("5.  what would have been done better?");
                writer.WriteLine(txtDoneBetter.Text.Trim());
                writer.WriteLine("-------------------END-------------" + DateTime.Now);
                writer.Close();
            }

           
        }
    }          
}