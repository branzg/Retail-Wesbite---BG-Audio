<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="RetailSite.ProductList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     
        <section>          
            
<%--             <header id="myCarousel" class="carousel slide">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
        </ol>

        <!-- Wrapper for slides -->
        <div class="carousel-inner" >
            <div class="item active">
                <div class="fill" style="background-image:url('http://placehold.it/1900x1080&text=Slide One');"></div>
                <div class="carousel-caption">
                    <h2>Caption 1</h2>
                </div>
            </div>
            <div class="item">
                <div class="fill" style="background-image:url('http://placehold.it/1900x1080&text=Slide Two');"></div>
                <div class="carousel-caption">
                    <h2>Caption 2</h2>
                </div>
            </div>
            <div class="item">
                <div class="fill" style="background-image:url('http://placehold.it/1900x1080&text=Slide Three');"></div>
                <div class="carousel-caption">
                    <h2>Caption 3</h2>
                </div>
            </div>
        </div>

        <!-- Controls -->
        <a class="left carousel-control" href="#myCarousel" data-slide="prev">
            <span class="icon-prev"></span>
        </a>
        <a class="right carousel-control" href="#myCarousel" data-slide="next">
            <span class="icon-next"></span>
        </a>
    </header>--%>

        <div style="width:100%;">
            <hgroup>
                <h2><%: Page.Title %></h2>
            </hgroup>
            <div class="products" style="float:right; width:83%; ">
            <asp:ListView ID="productList" runat="server" 
                DataKeyNames="ProductID" GroupItemCount="1"
                ItemType="RetailSite.Models.Product" SelectMethod="GetProducts">
                <EmptyDataTemplate>
                    <table >
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td/>
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>

                <ItemTemplate>
                    <td runat="server">
                        <table class="paginated">
                            <style type="text/css">
                                .tg  {border-collapse:collapse;border-spacing:0;}
                                .tg td{font-family:Arial, sans-serif;font-size:14px;padding:10px 5px;overflow:hidden;word-break:normal;}
                                .tg th{font-family:Arial, sans-serif;font-size:14px;font-weight:normal;padding:10px 5px;overflow:hidden;word-break:normal;}
                                .tg .tg-lqy6{text-align:right;vertical-align:top}
                                .tg .tg-yw4l{vertical-align:top}
                                </style>
                                <table class="tg" style="undefined; table-layout: fixed; width: 100%"; >
                                <colgroup>
                                <col style="width: 210px">
                                <col style="width: 50%">
                                <col style="width: 150px">
                                </colgroup>
                                  <tr>
                                    <th class="tg-yw4l" rowspan="2">
                                        <a href="ProductDetails.aspx?productID=<%#:Item.ProductID%>">
                                        <img src="/Catalog/Images/Thumbs/<%#:Item.ImagePath%>"
                                            width="200"  style="border: solid" /></a>
                                    </th>
                                    <th class="tg-yw4l">
                                        <a href="ProductDetails.aspx?productID=<%#:Item.ProductID%>" style="font-size: 22px; margin-left:5%">
                                        <span>
                                            <%#:Item.ProductName%>
                                        </span>
                                    </th>
                                    <th class="tg-lqy6" style="font-size: 22px">
                                        <span>
                                             <%#:String.Format("{0:c}", Item.UnitPrice)%><b> each</b>
                                        </span>
                                    </th>
                                  </tr>
                                  <tr>
                                    <td class="tg-yw4l">
                                        
                                        <span style="font-size: 16px; ">
                                            <%#:Item.Description%>
                                        </span>
                                    </td>
                                    <td class="tg-lqy6">
                                        <a href="/AddToCart.aspx?productID=<%#:Item.ProductID %>" >               
                                        <span class="ProductListItem">
                                            <b>
                                                <img src="Images/add-to-cart-button-green-3.png">
                                            <b>
                                        </span>       
                                    </td>
                                      <hr>
                                  </tr>
                                </table>
<%--                            <tr>
                                <td>
                                    <a href="ProductDetails.aspx?productID=<%#:Item.ProductID%>">
                                        <img src="/Catalog/Images/Thumbs/<%#:Item.ImagePath%>"
                                            width="100" height="75" style="border: solid" /></a>
                                </td>
                                <td>
                                    <a href="ProductDetails.aspx?productID=<%#:Item.ProductID%>" style="font-size: 22px; margin-left:5%">
                                        <span>
                                            <%#:Item.ProductName%>
                                        </span>
                                </td>
                                <td style="margin-right:0%">
                                     <span>
                                        <b>Price: </b><%#:String.Format("{0:c}", Item.UnitPrice)%>
                                    </span>
                                    <br />
                                    <a href="/AddToCart.aspx?productID=<%#:Item.ProductID %>">               
                                        <span class="ProductListItem">
                                            <b>Add To Cart<b>
                                        </span>           
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="ProductDetails.aspx?productID=<%#:Item.ProductID%>">
                                        <span>
                                            <%#:Item.ProductName%>
                                        </span>
                                    </a>
                                    <br />
                                    <span>
                                        <b>Price: </b><%#:String.Format("{0:c}", Item.UnitPrice)%>
                                    </span>
                                    <br />
                                    <a href="/AddToCart.aspx?productID=<%#:Item.ProductID %>">               
                                        <span class="ProductListItem">
                                            <b>Add To Cart<b>
                                        </span>           
                                    </a>
                                    <hr>
                                </td>
                            </tr>--%>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
                    
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width:100%;">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr></tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
                <asp:DataPager id="dtpager" runat="server" PagedControlID="productList" PageSize="5">
        <Fields>
            <asp:NextPreviousPagerField ButtonType="Link" ShowFirstPageButton="true"
              ShowNextPageButton="false" ShowPreviousPageButton="false" FirstPageText="First" />
            <asp:NumericPagerField ButtonType="Link" ButtonCount="10" />
            <asp:NextPreviousPagerField ButtonType="Link" ShowLastPageButton="true"
               ShowNextPageButton="false" ShowPreviousPageButton="false" LastPageText="Last" />

        </Fields>
    </asp:DataPager>
                </div>
            <div class="categories" style="float:left; width:15%;">
                <h4>Categories</h4>
                            <asp:ListView ID="categories"  
                ItemType="RetailSite.Models.Category" 
                runat="server"
                SelectMethod="GetCategories">
                <ItemTemplate>
                    <b style=" font-size: large; font-style: normal "  >
                        <a class="category" href="/ProductList.aspx?id=<%#: Item.CategoryID %>"  >
                        <%#: Item.CategoryName %>
                        </a>
                    </b>

                </ItemTemplate>
                                
               <%-- <ItemSeparatorTemplate>  |  </ItemSeparatorTemplate>--%>
            </asp:ListView>
                </div >
        </div>
    </section>

</asp:Content>

