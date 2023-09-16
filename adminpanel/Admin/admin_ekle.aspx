<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="admin_ekle.aspx.cs" Inherits="adminpanel.Admin.admin_ekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <form runat="server" >
  <div class="form-group">
    <label for="exampleInputEmail1">Kullanıcı Adı</label>
      <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Şifre</label>
      <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
  </div>

  
        <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Kaydet" OnClick="Button1_Click" />
       <br />
       <br />
       <br />
       <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</form>



</asp:Content>
