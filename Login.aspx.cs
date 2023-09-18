using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CLDVClassGroupActivity
{
    public partial class Login : System.Web.UI.Page
    {

       static List<Register> reg = new List<Register> ();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }



        protected void btnReg_Click(object sender, EventArgs e)
        {
           
                
                    Register register = new Register();
                    register.username = txtUsername.Text;
                    register.password = txtPassword.Text;
                    reg.Add(register);
                
                    //lblWarning.Text = "Username and password already excists!";
                
            
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            foreach (Register re in reg)
            {
                if (re.username == txtUsername.Text && re.password == txtPassword.Text)
                {
                    Response.Redirect("Default");
                }
                else
                {
                    lblWarning.Text = "Login details was incorrect";
                }
            }
        }
    }
   
}

    public class Register
    {
    public string username { get; set; }
    public string password { get; set; }
    }