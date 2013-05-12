<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="EntityFrameworkTest._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to Entity framework test application</h2>
    <br />
This page will show all the contacts&#39; details from the database
<table border="1">
                 <tr>
                <td>
                <strong>Contact ID</strong>
                </td>
                <td>
                <strong> First Name</strong>
                </td>
                <td>
                <strong>Last Name</strong>
                </td>
                <td>
                <strong>Phone Number</strong>
                </td>
                <td>
                </td>
                </tr>
                 
                <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate> 
                 <tr>
                <td>
                <%#DataBinder.Eval(Container.DataItem, "id") %>
                </td>
                <td>
                <%#DataBinder.Eval(Container.DataItem, "fname") %>
                </td>
                <td>
                <%#DataBinder.Eval(Container.DataItem, "lname") %>
                </td>
                 <td>
               <%#DataBinder.Eval(Container.DataItem, "phone") %>
                </td>    
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#DataBinder.Eval(Container,"DataItem.id", "updatecontact.aspx?id={0}")%>'>update</asp:HyperLink>
                </td>          
                </tr>
                </ItemTemplate>
                </asp:Repeater>
                
                </table>
</asp:Content>
