<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScissorsWelcome.aspx.cs" Inherits="ScissorsGame.ScissorsGame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <H1>Play a Game!</H1>
            <br />
            <asp:ImageButton ID="imgBtnStartGame" OnClick="imgBtnStartGame_Click" ImageUrl="~/Images/Start.png" runat="server"/>
            
        </div>
    </form>
</body>
</html>
