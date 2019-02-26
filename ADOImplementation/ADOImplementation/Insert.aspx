<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="ADOImplementation.Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
   <form runat="server">
       <div class="form-group">
    <label for="exampleInputPassword1">Username</label>
      <asp:TextBox ID="TextBox4" class="form-control" runat="server"></asp:TextBox>
    
  </div>
  <div class="form-group">
    <label for="exampleInputEmail1">Email address</label>
      <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox>
    
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Address</label>
      <asp:TextBox ID="TextBox2" class="form-control" runat="server"></asp:TextBox>
    
  </div>
       <div class="form-group">
    <label for="exampleInputPassword1">Contact</label>
      <asp:TextBox ID="TextBox3" class="form-control" runat="server"></asp:TextBox>    
  </div>

       <div class="form-group">
    
         <asp:Label ID="errormsg" runat="server" Text=""></asp:Label>
  </div>
       <asp:Button ID="Button1" CssClass="btn btn-default" runat="server" Text="Button" OnClick="Button1_Click" />
  
</form>
</body>
</html>
