using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Security.Principal;


namespace PillowLibrary
{
    public class DBCommands
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        string strSQL;

        public Boolean InsertAgentAccount(Account account)
        {
            objCommand.CommandType = CommandType.StoredProcedure;

            objCommand.CommandText = "InsertAgentAccount";

            objCommand.Parameters.AddWithValue("@Name", account.Name);
            objCommand.Parameters.AddWithValue("@Street", account.Street);
            objCommand.Parameters.AddWithValue("@City", account.City);
            objCommand.Parameters.AddWithValue("@State", account.State);
            objCommand.Parameters.AddWithValue("@Zipcode", account.ZipCode);
            objCommand.Parameters.AddWithValue("@PhoneNumber", account.PhoneNumber);
            objCommand.Parameters.AddWithValue("@Email", account.Email);
            objCommand.Parameters.AddWithValue("@Username", account.Username);
            objCommand.Parameters.AddWithValue("@Password", account.Password);
            objCommand.Parameters.AddWithValue("@Company", account.Company);
            objCommand.Parameters.AddWithValue("@WorkAddress", account.WorkAddress);
            objCommand.Parameters.AddWithValue("@WorkCity", account.WorkCity);
            objCommand.Parameters.AddWithValue("@WorkState", account.WorkState);
            objCommand.Parameters.AddWithValue("@WorkZip", account.WorkZip);
            objCommand.Parameters.AddWithValue("@WorkPhone", account.WorkPhone);
            objCommand.Parameters.AddWithValue("@WorkEmail", account.WorkEmail);

            int returnvalue = objDB.DoUpdateUsingCmdObj(objCommand);

            if(returnvalue == -1)
            {
                return false;
            }
            return true;
        }
        public Boolean InsertHome(NewHome newHome)
        {
            objCommand.CommandType = CommandType.StoredProcedure;

            objCommand.CommandText = "AddNewHome";

            objCommand.Parameters.AddWithValue("@AgentID", newHome.AgentID);
            objCommand.Parameters.AddWithValue("@Street", newHome.Street);
            objCommand.Parameters.AddWithValue("@City", newHome.City);
            objCommand.Parameters.AddWithValue("@State", newHome.State);
            objCommand.Parameters.AddWithValue("@Zipcode", newHome.Zip);
            objCommand.Parameters.AddWithValue("@PropertyType", newHome.PropertyType);
            objCommand.Parameters.AddWithValue("@LotSize", newHome.SquareFt);
            objCommand.Parameters.AddWithValue("@BedroomCount", newHome.Bedrooms);
            objCommand.Parameters.AddWithValue("@BathroomCount", newHome.Bathrooms);
            objCommand.Parameters.AddWithValue("@YearBuilt", newHome.YearBuilt);
            objCommand.Parameters.AddWithValue("@GarageType", newHome.GarageType);
            objCommand.Parameters.AddWithValue("@WaterType", newHome.WaterType);
            objCommand.Parameters.AddWithValue("@SewageType", newHome.SewageType);
            objCommand.Parameters.AddWithValue("@HeatingType", newHome.HeatingType);
            objCommand.Parameters.AddWithValue("@CoolingType", newHome.CoolingType);
            objCommand.Parameters.AddWithValue("@AskingPrice", newHome.AskingPrice);
            objCommand.Parameters.AddWithValue("@Description", newHome.Description);
            objCommand.Parameters.AddWithValue("@DateListed", newHome.ListingDate);

            int returnvalue = objDB.DoUpdateUsingCmdObj(objCommand);

            if (returnvalue == -1)
            {
                return false;
            }
            return true;
        }

        public string CheckAgentLogin(string username, string password)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CheckAgentLogin";

            objCommand.Parameters.AddWithValue("@Username", username);
            objCommand.Parameters.AddWithValue("@Password", password);

            DataSet returnDS = objDB.GetDataSet(objCommand);
            if (returnDS.Tables.Count == 0 || returnDS.Tables[0].Rows.Count == 0)
            {
                return "";  // No matching user found
            }
            string agentId = returnDS.Tables[0].Rows[0]["AgentID"].ToString();
            return agentId;

        }
    }
}
