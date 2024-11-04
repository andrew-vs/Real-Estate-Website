using PillowLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace Project3
{
    public partial class AddHome : System.Web.UI.Page
    {
        ArrayList rooms = new ArrayList();
       
        Validate validate = new Validate();
       
        Boolean roomAddClicked = false;

        
       
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["test"] = "yes";
            if (IsPostBack && ViewState["yo"] != null)
            {
                // Recreate the TextBoxes based on the initial count
                
                   double totalRooms = double.Parse(txtBathroomCount.Text) + double.Parse(txtBedroomCount.Text);
                   CreateTextBoxes((int)Math.Round(totalRooms, 1));

                   lblRooms.Text = totalRooms.ToString();
                
            }
            
        }
        private void CreateTextBoxes(int count)
        {

            phAddRooms.Controls.Clear();
           
            for (int i = 0; i < count; i++)
            {
                TextBox txt1 = new TextBox();
                TextBox txt2 = new TextBox();
                TextBox txt3 = new TextBox();
                Label lbl1 = new Label();
                Label lbl2 = new Label();
                Label lbl3 = new Label();
                txt1.ID = "txtRoomName" + i;
                txt2.ID = "txtLength" + i;
                txt3.ID = "txtWidth" + i;
                lbl1.ID = "lblRoomName" + i;
                lbl1.Text = "Room name:";
                lbl2.ID = "lblLength" + i;
                lbl2.Text = "&nbsp Room Length:";
                lbl3.ID = "lblWidth" + i;
                lbl3.Text = "&nbsp Room Width:";
                phAddRooms.Controls.Add(new LiteralControl("<br/>"));
                phAddRooms.Controls.Add(lbl1);
                phAddRooms.Controls.Add(txt1);
                phAddRooms.Controls.Add(lbl2);
                phAddRooms.Controls.Add(txt2);
                phAddRooms.Controls.Add(lbl3);
                phAddRooms.Controls.Add(txt3);
            }
            /*
            Button objButton = new Button();

            objButton.Text = "Add Rooms";

            objButton.ID = "btnAddRooms";

            objButton.Click += new EventHandler(this.SelectButtonHandler);

            phAddRooms.Controls.Add(new LiteralControl("<br/>"));
            phAddRooms.Controls.Add(objButton);
            */
        }
        public void SelectButtonHandler(Object sender, EventArgs e)
        {
            
        }

        protected void ddlSewageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(ddlSewageType.SelectedValue == "Other")
            {
                txtOtherSewageType.Visible = true;
            }
            txtOtherSewageType.Visible = ddlSewageType.SelectedValue == "Other";
        }

        protected void ddlHeating_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (ddlHeating.SelectedValue == "Other")
            {
                txtOtherHeatingType.Visible = true;
            }
            
        }

        protected void ddlCoolingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (ddlCoolingType.SelectedValue == "Other")
            {
                txtOtherCoolingType.Visible = true;
            }
            
        }

        protected void ddlGarageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (ddlGarageType.SelectedValue == "Other")
            {
                txtOtherGarageType.Visible = true;
            }
            
        }
        protected void ddlWaterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (ddlWaterType.SelectedValue == "Other")
            {
                txtOtherWaterType.Visible = true;
            }
           
        }

        protected void btnAddHome_Click(object sender, EventArgs e)
        {
            ViewState["yo"] = "yo";
            btnAddRooms.Visible = true;
            //validate
            Boolean ok = validate.ValidateHomeInputs(getInputs("homeInputs"));
            if(ok == false)
            {
                lblError.Text = "Fill out all textboxes and select all options";
            }
            else
            {
                lblError.Text = validate.ValidateNumbers(getInputs("numbers"));
                if(lblError.Text == "")
                {
                    double totalRooms = double.Parse(txtBathroomCount.Text) + double.Parse(txtBedroomCount.Text);
                    CreateTextBoxes((int)Math.Round(totalRooms, 1));
                    double askingPrice = double.Parse(txtAskingPrice.Text);
                    NewHome newHome = new NewHome(Session["agentID"].ToString(), txtStreet.Text, txtCity.Text, txtState.Text, txtZipcode.Text, txtPropertytype.Text, 1, int.Parse(txtBedroomCount.Text), int.Parse(txtBathroomCount.Text), int.Parse(txtYearBuilt.Text), ddlGarageType.SelectedValue, ddlWaterType.SelectedValue, ddlSewageType.SelectedValue, ddlHeating.SelectedValue, ddlCoolingType.SelectedValue, double.Parse(txtAskingPrice.Text), txtDescription.Text, DateTime.Now); 
                    //NewHome newHome = new NewHome(1, txtStreet.Text, txtCity.Text, txtState.Text, txtZipcode.Text, txtPropertytype.Text, "square feet", txtBedroomCount.Text, txtBathroomCount.Text, txtYearBuilt.Text, ddlGarageType.SelectedValue, ddlWaterType.SelectedValue, ddlHeating.SelectedValue, ddlSewageType.SelectedValue, ddlCoolingType.SelectedValue, txtAskingPrice.Text, txtDescription.Text, DateTime.Now);
                }
             
            }
            
        }
        protected List<string> getInputs(string getWhat)
        {

            List<string> inputs = new List<string>();
            if (getWhat == "homeInputs")
            {
                inputs.AddRange(new string[] { txtStreet.Text, txtCity.Text, txtState.Text, txtZipcode.Text, txtPropertytype.Text, "square feet", txtBedroomCount.Text, txtBathroomCount.Text, txtYearBuilt.Text, ddlGarageType.SelectedValue, ddlWaterType.SelectedValue, ddlHeating.SelectedValue, ddlSewageType.SelectedValue, ddlCoolingType.SelectedValue, txtAskingPrice.Text, txtDescription.Text, DateTime.Now.ToString() });
            }
            else if (getWhat == "numbers")
            {
                inputs.AddRange(new string[] { txtBedroomCount.Text, txtBathroomCount.Text, txtYearBuilt.Text, txtAskingPrice.Text});
            }
            else if (getWhat == "roomNumbers")
            {
                inputs = phAddRooms.Controls
                .OfType<TextBox>() // Only select controls of type TextBox
                .Where(ctrl => ctrl.ID.StartsWith("txtWidth") || ctrl.ID.StartsWith("txtLength"))
                .Select(ctrl => ctrl.Text)
                .ToList();
            }
            
            return inputs;
        }

        protected void btnAddRooms_Click(object sender, EventArgs e)
        {
            
            lblError.Text = validate.ValidateNumbers(getInputs("roomNumbers"));
            if (lblError.Text == "")
            {
                lblRooms.Text = "Rooms added.";
            }
            else
            {
                lblRooms.Text = "idiot.";
            }
            foreach (Control control in phAddRooms.Controls)
            {
                if (control is TextBox textBox)
                {
                    rooms.Add(textBox.Text);
                    lblError.Text += textBox.Text;
                }
            }
            ViewState["RoomInputs"] = rooms;
        }
    }
}
