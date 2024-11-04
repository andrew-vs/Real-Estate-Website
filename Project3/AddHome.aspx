<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddHome.aspx.cs" Inherits="Project3.AddHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div id ="divAddHome" class="addHome" runat="server">
            <asp:TextBox ID="txtStreet" placeholder="Street" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtCity" placeholder="City" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtState" placeholder="State" runat="server"></asp:TextBox>
             <br />
            <asp:TextBox ID="txtZipcode" placeholder="Zip Code" runat="server"></asp:TextBox>
             <br />
            <asp:TextBox ID="txtPropertytype" placeholder="Property Type" runat="server"></asp:TextBox>
             <br />
            <asp:TextBox ID="txtBedroomCount" placeholder="Bedroom Count" runat="server"></asp:TextBox>
             <br />
            <asp:TextBox ID="txtBathroomCount" placeholder="Bathroom Count" runat="server"></asp:TextBox>
             <br />
            <asp:TextBox ID="txtYearBuilt" placeholder="Year Built" runat="server"></asp:TextBox>
             <br />
            <asp:DropDownList ID="ddlWaterType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlWaterType_SelectedIndexChanged">
                <asp:ListItem Selected="True" Value="Select">Select Water Type</asp:ListItem>
                <asp:ListItem Value="Well">Well</asp:ListItem>
                <asp:ListItem Value="City">Municipal(City)</asp:ListItem>
                <asp:ListItem Value="Surface">Surface</asp:ListItem>
                <asp:ListItem Value="Rainwater">Rainwater</asp:ListItem>
                <asp:ListItem Value="Spring">Spring</asp:ListItem>
                <asp:ListItem Value="Other">Other</asp:ListItem>
            </asp:DropDownList>
             <asp:TextBox ID="txtOtherWaterType" runat="server" Placeholder="Please specify" Visible="False"></asp:TextBox>
             <br />
            <asp:DropDownList ID="ddlSewageType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlSewageType_SelectedIndexChanged">
                <asp:ListItem Selected="True" Value="Select">Select Sewage Type</asp:ListItem>
                <asp:ListItem Value="Municipal">Municipal</asp:ListItem>
                <asp:ListItem Value="Septic">Septic</asp:ListItem>
                <asp:ListItem Value="Cesspool">Cesspool</asp:ListItem>
                <asp:ListItem Value="ATS">Aerobic Treatment System</asp:ListItem>
                <asp:ListItem Value="Composting">Composting Toilets</asp:ListItem>
                <asp:ListItem Value="Holding Tank">Holding Tank</asp:ListItem>
                <asp:ListItem Value="Other">Other</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="txtOtherSewageType" runat="server" Placeholder="Please specify" Visible="False"></asp:TextBox>
             <br />
            <asp:DropDownList ID="ddlHeating" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlHeating_SelectedIndexChanged">
                <asp:ListItem Selected="True" Value="Select">Select Heating Type</asp:ListItem>
                <asp:ListItem Value="Furnace">Furnace</asp:ListItem>
                <asp:ListItem Value="Boiler">Boiler</asp:ListItem>
                <asp:ListItem Value="Heat Pump">Heat Pump</asp:ListItem>
                <asp:ListItem Value="Electric Baseboard">Electric Baseboard Heaters</asp:ListItem>
                <asp:ListItem Value="Radiant Floor Heating">Radiant Floor Heating</asp:ListItem>
                <asp:ListItem Value="Wood/Pellet/Gas Stove">Wood, Pellet, or Gas Stove</asp:ListItem>
                <asp:ListItem Value="Space Heater">Space Heater</asp:ListItem>
                <asp:ListItem Value="Solar Heating">Solar Heating</asp:ListItem>
                <asp:ListItem Value="Ductless Mini-Split">Ductless Mini-Split Heat Pump</asp:ListItem>
                <asp:ListItem Value="Other">Other</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="txtOtherHeatingType" runat="server" Placeholder="Please specify" Visible="False"></asp:TextBox>
             <br />
            <asp:DropDownList ID="ddlCoolingType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCoolingType_SelectedIndexChanged">
                <asp:ListItem Selected="True" Value="Select">Select Cooling Type</asp:ListItem>
                <asp:ListItem Value="Central Air Conditioning">Central Air Conditioning</asp:ListItem>
                <asp:ListItem Value="Window Unit">Window Unit Air Conditioner</asp:ListItem>
                <asp:ListItem Value="Portable AC">Portable Air Conditioner</asp:ListItem>
                <asp:ListItem Value="Ductless Mini-Split">Ductless Mini-Split System</asp:ListItem>
                <asp:ListItem Value="Evaporative Cooler">Evaporative Cooler (Swamp Cooler)</asp:ListItem>
                <asp:ListItem Value="Geothermal Cooling">Geothermal Cooling</asp:ListItem>
                <asp:ListItem Value="Ceiling Fans">Ceiling Fans</asp:ListItem>
                <asp:ListItem Value="Whole House Fan">Whole House Fan</asp:ListItem>
                <asp:ListItem Value="Other">Other</asp:ListItem>
            </asp:DropDownList>
             <asp:TextBox ID="txtOtherCoolingType" runat="server" Placeholder="Please specify" Visible="False"></asp:TextBox>
             <br />
            <asp:DropDownList ID="ddlGarageType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlGarageType_SelectedIndexChanged">
                <asp:ListItem Selected="True" Value="Select">Select Garage Type</asp:ListItem>
                <asp:ListItem Value="Attached">Attached Garage</asp:ListItem>
                <asp:ListItem Value="Detached">Detached Garage</asp:ListItem>
                <asp:ListItem Value="Carport">Carport</asp:ListItem>
                <asp:ListItem Value="Built-In">Built-In Garage</asp:ListItem>
                <asp:ListItem Value="Basement">Basement Garage</asp:ListItem>
                <asp:ListItem Value="Tandem">Tandem Garage</asp:ListItem>
                <asp:ListItem Value="RV Garage">RV Garage</asp:ListItem>
                <asp:ListItem Value="None">None</asp:ListItem>
                <asp:ListItem Value="Other">Other</asp:ListItem>
            </asp:DropDownList>
             <asp:TextBox ID="txtOtherGarageType" runat="server" Placeholder="Please specify" Visible="False"></asp:TextBox>
             <br />
            <asp:TextBox ID="txtAskingPrice" placeholder="Asking Price" runat="server"></asp:TextBox>
             <br />
            <asp:TextBox ID="txtDescription" placeholder="Description" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnAddHome" runat="server" Text="Add Home" OnClick="btnAddHome_Click" />
             
             
        </div>
         <div id="divAddRooms" class="rooms" runat="server">

            <asp:PlaceHolder ID="phAddRooms" runat="server" />
            

             
            

         </div>
        <asp:Button ID="btnAddRooms" runat="server" Text="Add Rooms" Visible="false" OnClick="btnAddRooms_Click" AutoPostBack ="false" />
        <asp:Label ID="lblRooms" runat="server" Text="Label" Visible ="false"></asp:Label>
        <br />
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
