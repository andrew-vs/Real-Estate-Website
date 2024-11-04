using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PillowLibrary;

namespace Project3
{
    public partial class Login : System.Web.UI.Page
    {
        Validate validate = new Validate();
        DBCommands dbCommands = new DBCommands();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["test2"] != null)
            {
                lblError.Visible = true;
                lblError.Text = Session["test2"].ToString();
            }
            if (!IsPostBack)
            {
               
                divLogin.Visible = false;
                divCreateAcct.Visible = false;
                divAgent.Visible = false;
            }
            
        }

        protected void btnShowLogin_Click(object sender, EventArgs e)
        {
            divLogin.Visible = true;
            divHome.Visible = false;
        }

        protected void btnViewHomes_Click(object sender, EventArgs e)
        {
            // new page
            Response.Redirect("Homes.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string agentID = dbCommands.CheckAgentLogin(txtUsername.Text, txtPassword.Text);
            if (agentID != "")
            {
                Session["agentID"] = agentID;
                divAgent.Visible = true;
                divLogin.Visible = false;
            }
            else
            {
                lblStatus.Text = "Invalid Username or Password";
            }
            
        }

        protected void btnCreateAccount_Click(object sender, EventArgs e)
        {
            divLogin.Visible = false;
            divHome.Visible = false;
            divCreateAcct.Visible = true;
        }

        protected void btnNewCreateAccount_Click(object sender, EventArgs e)
        {

            if (validate.ValidateAgentInput(getInputs()))
            {
                Account account = new Account(txtName.Text, txtStreetAddress.Text, txtCity.Text, txtState.Text, txtZipcode.Text, txtPhoneNumber.Text, txtEmail.Text, txtNewUsername.Text, txtNewPassword.Text, txtCompany.Text, txtWorkStreetAddress.Text, txtWorkCity.Text, txtWorkState.Text, txtWorkZipcode.Text, txtWorkPhone.Text, txtWorkEmail.Text);
                
                lblError.Text = "";
                
                if (dbCommands.InsertAgentAccount(account))
                {
                    divCreateAcct.Visible = false;
                    divLogin.Visible = true;
                    lblStatus.Text = "Account successfully created.";
                }
                else
                {
                    lblError.Text = "Error while making account";
                }   
            }
            else
            {
                lblError.Text = "Please fill out every piece of information";
            }
           
        }

        protected ArrayList getInputs()
        {
            ArrayList inputs = new ArrayList(){
                txtName.Text, txtStreetAddress.Text, txtCity.Text, txtState.Text,
                txtZipcode.Text, txtPhoneNumber.Text, txtEmail.Text, txtNewUsername.Text,
                txtNewPassword.Text, txtCompany.Text, txtWorkStreetAddress.Text, txtWorkCity.Text,
                txtWorkState.Text, txtWorkZipcode.Text, txtWorkPhone.Text,  txtWorkEmail.Text};

            return inputs;
        }
        

        protected void btnAddHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddHome.aspx");
        }
    }
}