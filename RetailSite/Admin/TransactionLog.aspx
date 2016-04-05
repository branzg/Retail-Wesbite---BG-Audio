<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TransactionLog.aspx.cs" Inherits="RetailSite.Admin.TransactionLog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  
    <asp:FormView ID="Orders" runat="server" ItemType="RetailSite.Models.Order" SelectMethod ="GetOrders" RenderOuterTable="false">

        <ItemTemplate>
            <div>
                <h1>Transaction History</h1>
                

                  
               

            <asp:GridView ID="Grid" runat="server" ItemType="RetailSite.Models.Order" DataKeyNames="OrderID" 
              SelectMethod="GetOrders" BorderColor="#010101" BorderStyle="Groove" BorderWidth="1px" 
                 AutoGenerateColumns="false" HeaderStyle-BackColor="CornflowerBlue" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White" CssClass="grid">
                 <RowStyle BackColor="White" ForeColor="#330099" HorizontalAlign="Center"/>
                <HeaderStyle HorizontalAlign= "Center" />
<%--                <RowStyle Font-Italic="True" /> --%>

<%--<AlternatingRowStyle BackColor="Red" BorderColor="Green" BorderStyle="Dashed"   BorderWidth="1px" Font-Bold="True" /> --%>
         


            <columns >

            <asp:BoundField DataField="OrderDate" HeaderText="Order Date"  />
            <asp:BoundField DataField="UserName" HeaderText="User Name" />
            <asp:BoundField DataField="FirstName" HeaderText="Name" />
                <asp:DynamicField DataField="LastName" />
                <asp:DynamicField DataField="Address" />
                <asp:DynamicField DataField="City" />
                <asp:DynamicField DataField="State" />
                <asp:DynamicField DataField="PostalCode" />
                <asp:DynamicField DataField="Country" />
                <asp:DynamicField DataField="Email" />
                <asp:DynamicField DataField="Total" />
                <asp:DynamicField DataField="PaymentTransactionId" />
                <%--<asp:BoundField DataField="HasBeenShipped" HeaderText="Shipped" SortExpression="ID"/>--%>
                <%-- <asp:DynamicField DataField="HasBeenShipped"  />--%>
                <asp:TemplateField HeaderText="Shipped" SortExpression="HasBeenShipped">
                        <ItemTemplate>
                            <asp:HiddenField ID="HiddenID" runat="server" Value='<%# Eval("OrderId") %>' />
                            <asp:CheckBox ID="CheckBox1"  runat="server" Checked='<%# Bind("HasBeenShipped") %>'
                                Enabled="true" OnCheckedChanged="CheckBox1_OnCheckedChanged" AutoPostBack="true"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
               
            </columns>

            </asp:GridView> 

            </tr>

        </ItemTemplate>
    </asp:FormView>
</asp:Content>
