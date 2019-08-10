<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterWebForm.aspx.cs" Inherits="WebAppMVC5.RegisterWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Email
        <asp:textbox runat="server" id="Email" /><br />
        First Name
       <asp:textbox runat="server" id="FirstName" /><br />
        Special Meal
        <asp:CheckBox runat="server" id="SpecialMeal" /><br />
        <input type="submit" value="Submit" />
    </div>
    </form>
</body>
</html>
