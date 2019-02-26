<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StdUpdate.aspx.cs" Inherits="ADOImplementation.StdUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Update Form</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
    <form runat="server">
   <div class="form-group">
      <label for="exampleInputPassword1">Student ID</label>
       <asp:DropDownList CssClass="form-control" ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Email" DataValueField="StdId" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
    
       <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Student]"></asp:SqlDataSource>
    
  </div>
        <asp:Button ID="Button1" runat="server" Text="Fetch Rescord" CssClass="btn btn-default" OnClick="Button1_Click" />
  <div class="form-group">
      <label for="exampleInputPassword1">Username</label>
      <asp:TextBox ID="txtUser" class="form-control" runat="server"></asp:TextBox>
    
  </div>
  <div class="form-group">
    <label for="exampleInputEmail1">Email address</label>
      <asp:TextBox ID="txtEmail" class="form-control" runat="server"></asp:TextBox>
    
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Address</label>
      <asp:TextBox ID="txtAdd" class="form-control" runat="server"></asp:TextBox>
    
  </div>
       <div class="form-group">
    <label for="exampleInputPassword1">Contact</label>
      <asp:TextBox ID="txtCnt" class="form-control" runat="server"></asp:TextBox>    
  </div>

       <div class="form-group">
           <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
         <asp:Label ID="errormsg" runat="server" Text=""></asp:Label>
  </div>
       
  
        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Email" DataValueField="StdId">
        </asp:DropDownList>
       
  
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Student]"></asp:SqlDataSource>
       
  
</form>
</body>
</html>
