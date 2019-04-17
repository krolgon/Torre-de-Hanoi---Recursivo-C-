<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Hanoi.aspx.cs" Inherits="Estrutura_de_Dados_Hanoi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="col-lg-6">
        <label>Número de Discos</label>
        <asp:TextBox ID="txbDiscos" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Button ID="btnEnviar" runat="server" Text="Enviar" CssClass="btn btn-success" OnClick="btnEnviar_Click" />
        <br />
        <hr />
        <h2>Movimentação</h2>
        <asp:Label ID="lblResultado" runat="server"></asp:Label>
    </div>

</asp:Content>

