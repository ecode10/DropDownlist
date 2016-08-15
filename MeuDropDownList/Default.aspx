<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MeuDropDownList._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   

    <div class="row">
        <div class="col-md-12">
            <h2>Meu DropDownList</h2>
            <p>
                <asp:DropDownList runat="server" ID="cmbEstado" OnSelectedIndexChanged="cmbEstado_SelectedIndexChanged" AutoPostBack="true">
                    <asp:ListItem Text="Selecione" Value="" />
                    <asp:ListItem Text="DF" Value="1" />
                    <asp:ListItem Text="GO" Value="2" />
                    <asp:ListItem Text="SP" Value="3" />
                    <asp:ListItem Text="RJ" Value="4" />
                </asp:DropDownList>

                <asp:DropDownList runat="server" ID="cmbCidades" Visible="false">
                    
                </asp:DropDownList>
            </p>
        </div>
    </div>
        
</asp:Content>
