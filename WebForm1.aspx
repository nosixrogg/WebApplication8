<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication8.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Calculator</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <style type="'text/css">
        .set {margin-left: 450px; margin-right:450px; padding:30px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-weight: 700; font-size: x-large; text-align: center">
            <center class="set" style="background-color:aquamarine; width: 306px; height: 278px;">
                <asp:TextBox ID="TextBox1" runat="server" Height="45px" Width="282px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnOne" runat="server" Height="45px" OnClick="btnOne_Click" Text="1" Width="45px" />
&nbsp;<asp:Button ID="btnTwo" runat="server" Height="45px" OnClick="btnTwo_Click" Text="2" Width="45px" />
&nbsp;<asp:Button ID="btnThree" runat="server" Height="45px" OnClick="btnThree_Click" Text="3" Width="45px" />
&nbsp;<asp:Button ID="btnPlus" runat="server" Height="45px" OnClick="btnPlus_Click" Text="+" Width="45px" />
                <br />
                <asp:Button ID="btnFour" runat="server" Height="45px" OnClick="btnFour_Click" Text="4" Width="45px" />
&nbsp;<asp:Button ID="btnFive" runat="server" Height="45px" OnClick="btnFive_Click" Text="5" Width="45px" />
&nbsp;<asp:Button ID="btnSix" runat="server" Height="45px" OnClick="btnSix_Click" Text="6" Width="45px" />
&nbsp;<asp:Button ID="btnMinus" runat="server" Height="45px" OnClick="btnMinus_Click" Text="-" Width="45px" />
                <br />
                <asp:Button ID="btnSeven" runat="server" Height="45px" OnClick="btnSeven_Click" Text="7" Width="45px" />
&nbsp;<asp:Button ID="btnEight" runat="server" Height="45px" OnClick="btnEight_Click" Text="8" Width="45px" />
&nbsp;<asp:Button ID="btnNine" runat="server" Height="45px" OnClick="btnNine_Click" Text="9" Width="45px" />
&nbsp;<asp:Button ID="btnMulti" runat="server" Height="45px" OnClick="btnMulti_Click" Text="*" Width="45px" />
                <br />
                <asp:Button ID="btnZero" runat="server" Height="45px" OnClick="btnZero_Click" Text="0" Width="45px" />
&nbsp;<asp:Button ID="btnClear" runat="server" Height="45px" OnClick="btnClear_Click" Text="CLR" Width="45px" />
&nbsp;<asp:Button ID="btnDone" runat="server" Height="45px" OnClick="btnDone_Click" Text="=" Width="45px" />
&nbsp;<asp:Button ID="btnDiv" runat="server" Height="45px" OnClick="btnDiv_Click" Text="/" Width="45px" />

            </center>
        </div>
        <div class="container m-4 p-4"> 
        </div>
    </form>
</body>
</html>
