<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateContact.aspx.cs" Inherits="EntityFrameworkTest.UpdateContact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
                  Update the contact details<br />
                  <br />
                  ID:&nbsp;&nbsp;
                  <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                  <br />
                  <br />
                  First Name:&nbsp;&nbsp;
                  <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                  <br />
                  <br />
                  Last Name:&nbsp;&nbsp;
                  <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                  <br />
                  <br />
                  Phone Number:&nbsp;&nbsp;&nbsp;
                  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                  <br />
                  <br />
                  <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Update" />
&nbsp;
                  <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Cancel" />
&nbsp;&nbsp;&nbsp;
                  <asp:Label ID="Label4" runat="server"></asp:Label>
                  <br />
                  <br />
                  <asp:CheckBox ID="CheckBox1" runat="server" Text="Delete" />
&nbsp;
                  <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Delete" />
&nbsp;&nbsp;
                <br />
                
        
</asp:Content>
