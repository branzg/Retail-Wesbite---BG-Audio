<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RetailSite.Admin.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField  DataField="Id" ReadOnly="true" HeaderText="Image ID"/>
            <asp:BoundField  DataField="ImageName" HeaderText="File Name"/>
            <asp:BoundField  DataField="ImageType" HeaderText="Image File Type"/>
            <asp:BoundField  DataField="ImageSize" HeaderText="Image Size (bytes)"/>
            <asp:TemplateField HeaderText="Image View" ControlStyle-Width="100px" ControlStyle-Height="100px">
                <ItemTemplate>
                    <asp:Image ID="Image" runat="server" ImageUrl='<%# "Handler.ashx?id=" + Eval("Id")  %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
</asp:GridView>
</asp:Content>
