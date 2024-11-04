<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project3.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="LoginStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div runat="server" class="topnav">
            <a class="active" href="Home.aspx">Home</a>
            <a href="Login.aspx">Login</a>
        </div>
        <div class="home" id="divHome" runat="server">
            <p>Welcome to Pillow, log in as an agent or search for homes
            </p>
            <asp:Button ID="btnShowLogin" runat="server" Text="Agent Login" OnClick="btnShowLogin_Click" />
            <asp:Button ID="btnViewHomes" runat="server" Text="View Homes" OnClick="btnViewHomes_Click" />
        </div>

        <div class="login" id="divLogin" runat="server">
            <p>Enter username and password or create account</p>
            <br />
            <asp:Label ID ="lblStatus" runat="server"></asp:Label>
            <br />
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            <asp:Button ID="btnCreateAccount" runat="server" Text="Create New Account" OnClick="btnCreateAccount_Click"/>
        </div>
         <asp:Label ID="lblError" runat="server"></asp:Label>
        <div class="create" id="divCreateAcct" runat="server">
            <p>Fill out the following information to create an account</p>
           
            
            <p>Personal Info:</p>
            <asp:TextBox ID="txtName" placeholder="Full Name" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtStreetAddress" placeholder="Street Address" runat="server"></asp:TextBox>
            
            <asp:TextBox ID="txtCity" placeholder="City" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtState" placeholder="State" runat="server"></asp:TextBox>
            
            <asp:TextBox ID="txtZipcode" placeholder="Zipcode" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtPhoneNumber" placeholder="Phone Number" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtEmail" placeholder="Email" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtNewUsername" placeholder="Username" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtNewPassword" placeholder="Password" runat="server"></asp:TextBox>
            
            <p>Company info:</p>
            
            <asp:TextBox ID="txtCompany" placeholder="Company Name" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtWorkStreetAddress" placeholder="Work Street Address" runat="server"></asp:TextBox>
            
            <asp:TextBox ID="txtWorkCity" placeholder="Work Address City" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtWorkState" placeholder="Work Address State" runat="server"></asp:TextBox>
            
            <asp:TextBox ID="txtWorkZipcode" placeholder="Work Address Zipcode" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtWorkPhone" placeholder="Work Phone" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtWorkEmail" placeholder="Work Email" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnNewCreateAccount" runat="server" Text="Create Account" OnClick="btnNewCreateAccount_Click" />
        </div>
        <div id="divAgent" class="agent" runat="server">
            <p>Welcome, (agent name)</p>
            <asp:Button ID="btnViewOffers" runat="server" Text="View Offers on your homes" />
            <asp:Button ID="btnAgentHomes" runat="server" Text="View and Edit Your homes on the market" />
            <asp:Button ID="btnViewShowings" runat="server" Text="View showing requests on your homes" />
            <asp:Button ID="btnAddHome" runat="server" Text="Add a new home to sell" OnClick="btnAddHome_Click" />
        </div>
       
    </form>
</body>
</html>
