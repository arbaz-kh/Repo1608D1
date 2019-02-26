using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADOImplementation
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                
                

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 25);
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;

                MailMessage mail = new MailMessage(txtSender.Text, txtReciever.Text);
                mail.Subject = txtSub.Text;
                mail.Body = txtBody.Text;

                foreach (var item in FileUpload1.PostedFiles)
                {
                    string filename = item.FileName;
                    string path = Server.MapPath("~/Attachments/" + filename);
                    FileUpload1.SaveAs(path);
                    Attachment atc = new Attachment(path);
                    mail.Attachments.Add(atc);
                }
                smtp.Credentials = new NetworkCredential(txtSender.Text, txtPsw.Text);
                smtp.Send(mail);
                errormsg.Text = "Email Sent Successfully";
            }
            catch (Exception ex)
            {
                errormsg.Text = ex.Message;
                
            }
            

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                
                foreach (var item in FileUpload1.PostedFiles)
                {
                    if(item.ContentLength<25 || item.ContentType == ".txt")
                    {
                        string filename = item.FileName;
                        string path = Server.MapPath("~/Attachments/" + filename);
                        FileUpload1.SaveAs(path);
                    }
                    
                    
                }
                

                errormsg.Text = "File Saved";
            }
            catch (Exception ex)
            {
                errormsg.Text = ex.Message;                
            }
            
        }
    }
}