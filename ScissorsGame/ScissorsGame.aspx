<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScissorsGame.aspx.cs" Inherits="ScissorsGame.ScissorsGame1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Make a Choice!</h1>
            <br />
            <asp:ImageButton ID="imgBtnRock" OnClick="imgBtnRock_Click" ImageUrl="~/Images/Rock.png" runat="server"/>
            <asp:ImageButton ID="imgBtnPaper" OnClick="imgBtnPaper_Click" ImageUrl="~/Images/Paper.png" runat="server"/>
            <asp:ImageButton ID="imgBtnScissors" OnClick="imgBtnScissors_Click" ImageUrl="~/Images/Scissors.png" runat="server"/>
            <br />
            <br />
            <h1><asp:Label ID="lblMessage" Text="" runat="server"></asp:Label></h1>
            <br />
            <asp:ImageButton ID="imgBtnPlayAgain" Visible="false" OnClick="imgBtnPlayAgain_Click" ImageUrl="~/Images/PlayAgain.png" runat="server"/>
        </div>
    </form>
</body>
</html>
