<%@ Page Title="Numeros Primos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Primos.aspx.cs" Inherits="GruruWeb.Primos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>En esta pagina podemos obtener cuantos numeros primos hay acorde al numero y la cantidad digitada en el siguiente formulario.</h3>
    </main>

    <asp:Panel ID="pnlPrimos" runat="server">
        <table style="width: 100%">
            <tr>
                <td>
                    <asp:Label Text="Numero" runat="server" />
                </td>
                <td>
                    <asp:TextBox ID="txtNumero" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label Text="Cantidad" runat="server" />
                </td>
                <td>
                    <asp:TextBox ID="txtCantidad" runat="server" />
                </td>
            </tr>
            <tr>
                <asp:Button ID="btnEnviar" Text="Enviar" runat="server" OnClick="btnEnviar_Click" />
            </tr>
        </table>
    </asp:Panel>
    <br />
    <asp:Panel ID="pnlResultado" runat="server">
        <asp:Label ID="lblRespuesta" runat="server" />
    </asp:Panel>
</asp:Content>
