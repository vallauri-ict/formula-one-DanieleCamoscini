<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="formulaOneWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <!--
             Username <asp:TextBox ID="txtUserName" runat="server"/> <br /><br />
             Password <input type="text" id="txtPassword" runat ="server"/> <br /><br />
            -->
             <asp:DropDownList ID="DropDownList1" runat="server" Height="74px" Width="593px" OnSelectedIndexChanged="selectionChanged" AutoPostBack="true">
            </asp:DropDownList>
            <br /><br />  
             <asp:Label ID="lblMessaggio" runat="server" Text=" "> </asp:Label>
        </div>
        <br />
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
    </form>   
</body>
</html>
