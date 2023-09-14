<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/PagePrincipal.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FinancasForms.Pages.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .sec-home {
            width: 275px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="pnlHome" runat="server" Height="400px">
        <div class="section-container">
            <section class="sec-home twenty-percent" >
                <div  class="clearfix">
                    <asp:Label ID="Label3" runat="server" Text="Renda"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Total"></asp:Label>
                    <br />
                    <asp:TextBox ID="txbRendaTotal" runat="server" placeholder="renda Total"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Anual"></asp:Label>
                    <br />
                    <asp:TextBox ID="txbRendaAnual" runat="server" placeholder="Renda Anual"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Mensal"></asp:Label>
                    <br />
                    <asp:TextBox ID="txbRendaMesAtual" runat="server" placeholder="Renda Mensal"></asp:TextBox>
                    <br />
                    <br />
                </div>
            </section>
            <section class="eighty-percent">
                <asp:GridView ID="gvRenda" runat="server" Class="custom-gridview" AutoGenerateColumns="False" AllowPaging="True" PageSize="6" Width="868px">
                    <Columns>
                        <asp:BoundField DataField="IdRenda" HeaderText="" Visible="false" />
                        <asp:TemplateField HeaderText="Valor da Renda">
                            <ItemTemplate>
                                <%# Eval("dblValorRenda", "{0:C}") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tipo de Renda">
                            <ItemTemplate>
                                <%# Eval("txtTipoRenda") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Data de Entrada">
                            <ItemTemplate>
                                <%# Eval("dteDataEntrada", "{0:dd/MM/yyyy}") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </section>
        </div>
    </asp:Panel>
</asp:Content>
