<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="ADOImplementation.ContactUs" %>

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
    <label for="exampleInputPassword1">From</label>
      <asp:TextBox ID="txtSender" class="form-control" runat="server"></asp:TextBox>
    
  </div>
  <div class="form-group">
    <label for="exampleInputEmail1">Password</label>
      <asp:TextBox type="password" ID="txtPsw" class="form-control" runat="server"></asp:TextBox>
    
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">To</label>
      <asp:TextBox ID="txtReciever" class="form-control" runat="server"></asp:TextBox>
    
  </div>
       <div class="form-group">
    <label for="exampleInputPassword1">Subject</label>
      <asp:TextBox ID="txtSub" class="form-control" runat="server"></asp:TextBox>    
  </div>
       <div class="form-group">
    <label for="exampleInputPassword1">Body</label>
      <asp:TextBox ID="txtBody" class="form-control" runat="server"></asp:TextBox>    
  </div>
       <div class="form-group">
    <label for="exampleInputPassword1">Attach File</label>
           <asp:FileUpload allow=".jpg" ID="FileUpload1" AllowMultiple="true" runat="server" />
  </div>
       <div class="form-group">
    
         <asp:Label ID="errormsg" runat="server" Text=""></asp:Label>
  </div>
       <asp:Button ID="btnSend" CssClass="btn btn-default" runat="server" Text="Send" OnClick="btnSend_Click" />

       <asp:Button ID="btnUpload" CssClass="btn btn-default" runat="server" Text="Upload" OnClick="btnUpload_Click" />
  
</form>
</body>
</html>
