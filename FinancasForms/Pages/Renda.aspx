<%@ Page Title="" EnableEventValidation="false"  Language="C#" MasterPageFile="~/Pages/PagePrincipal.Master" AutoEventWireup="true" CodeBehind="Renda.aspx.cs" Inherits="FinancasForms.Pages.Renda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="pnlRenda" runat="server" Height="400px">
        <asp:Button ID="btnNovaRenda" runat="server" Text="Nova Renda" Class="button-salvar" OnClick="btnNovaRenda_Click" />
        <section>
            <asp:Panel ID="pnlFormularioAddRenda" runat="server" class="addRenda">
                <asp:Label ID="Label1" runat="server" Text="Valor da Renda"></asp:Label>
                <br />
                <asp:TextBox ID="txbValorRenda" runat="server" placeholder="Valor da Renda"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Tipo de Renda"></asp:Label>
                <br />
                <asp:DropDownList ID="ddlTipoRenda" runat="server" Height="35px" Width="292px">
                    <asp:ListItem Text="Selecione o tipo da renda" Value="" />
                    <asp:ListItem>Salario</asp:ListItem>
                    <asp:ListItem>Extra</asp:ListItem>
                    <asp:ListItem>Emprestimo</asp:ListItem>
                    <asp:ListItem>Pis</asp:ListItem>
                    <asp:ListItem>Outros</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" Text="Data de Entrada"></asp:Label>
                <br />
                <asp:TextBox type="date" ID="txtDataEntrada" runat="server" class="input-data" Width="283px" Height="35px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Class="button-cancelar" OnClick="btnCancelar_Click" />
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Class="button-salvar" OnClick="btnSalvar_Click" />
                <br />
                <br />
            </asp:Panel>
            <asp:Panel ID="pnlFormularioEditarRenda" runat="server" class="addRenda">
                <asp:Label ID="Label3" runat="server" Text="Valor da Renda"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox1" runat="server" placeholder="Valor da Renda"></asp:TextBox>
                <br />
                <asp:Label ID="Label4" runat="server" Text="Tipo de Renda"></asp:Label>
                <br />
                <asp:DropDownList ID="DropDownList1" runat="server" Height="35px" Width="292px">
                    <asp:ListItem Text="Selecione o tipo da renda" Value="" />
                    <asp:ListItem>Salario</asp:ListItem>
                    <asp:ListItem>Extra</asp:ListItem>
                    <asp:ListItem>Emprestimo</asp:ListItem>
                    <asp:ListItem>Pis</asp:ListItem>
                    <asp:ListItem>Outros</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" Text="Data de Entrada"></asp:Label>
                <br />
                <asp:TextBox type="date" ID="TextBox2" runat="server" class="input-data" Width="283px" Height="35px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnCancelarEdit" runat="server" Text="Cancelar" Class="button-cancelar" OnClick="btnCancelar_Click" />
                <asp:Button ID="btnSalvarEdit" runat="server" Text="Salvar" Class="button-salvar" OnClick="btnSalvarEdit_Click" />
                <br />
                <br />
            </asp:Panel>
            <asp:Panel ID="pnlListaRenda" runat="server">
                <asp:GridView ID="gvRenda" runat="server" Class="custom-gridview selectable-gridview" 
                    AutoGenerateColumns="False" AllowPaging="True"  PageSize="5" Width="1133px"  >
                    <Columns>
                        <asp:TemplateField HeaderText="Valor da Renda">
                            <ItemTemplate>
                               <asp:Label ID="IdRenda" runat="server" Text="" Visible="false"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Valor da Renda">
                            <ItemTemplate>
                               <asp:Label ID="lblValorRenda" runat="server" Text='<%# Eval("dblValorRenda", "{0:C}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tipo de Renda">
                            <ItemTemplate>
                               <asp:Label ID="lblTipoRenda" runat="server" Text='<%# Eval("txtTipoRenda") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Data de Entrada">
                            <ItemTemplate>
                              <asp:Label ID="lblDataEntrada" runat="server" Text='<%# Eval("dteDataEntrada", "{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="Editar" runat="server" Text="Editar" Class="button-salvar" OnClick="Editar_Click" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="Excluir" runat="server" Text="Remover" Class="button-salvar" OnClick="Excluir_Click" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </asp:Panel>
        </section>
    </asp:Panel>
</asp:Content>
