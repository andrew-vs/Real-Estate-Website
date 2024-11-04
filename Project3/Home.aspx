<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Project3.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="HomeStyle.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div runat="server" class="topnav">
            <a class="active" href="Home.aspx">Home</a>
            <a href="Login.aspx">Login</a>
        </div>
        <div runat="server" id="divHomes" class="homes">
            <p>[Images]</p>
            <h1>$175,000</h1>
            <h2>123 Main Street Philadelphia, PA, 12345</h2>
            <p>5 bed 2 bath</p>
            <table>
                <tr>
                    <td>Built in 1978</td>
                    <td>1000 sq ft</td>
                    <td>Row Home</td>
                </tr>
                <tr>
                    <td>No Garage</td>
                    <td>Water type</td>
                    <td>Domestic sewage</td>
                </tr>
                 <tr>
                    <td>Hot water, natural gas</td>
                    <td>Central A/C</td>
                    <td>Listing Date</td>
                </tr>
            </table>
            <p>Seller: Bob jimbo</p>
            <p>Description:</p>
        </div>
       
    </form>
</body>
</html>
