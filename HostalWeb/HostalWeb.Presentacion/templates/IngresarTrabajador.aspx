﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="IngresarTrabajador.aspx.cs" Inherits="HostalWeb.Presentacion.templates.IngresarTrabajador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Ingreso Trabajador</h2>


           <asp:Label ID="lbRut" runat="server" Text="Rut : "></asp:Label>
              <asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
              
        <br /><asp:Label ID="lbNombre" runat="server" Text="Nombre : "></asp:Label>
              <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
              
        <br /><asp:Label ID="lbGiro" runat="server" Text="Giro : "></asp:Label>
              <asp:TextBox ID="txtGiro" runat="server"></asp:TextBox>
              
        <br /><asp:Label ID="lbDireccion" runat="server" Text="Direccion : "></asp:Label>
              <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
              
  

    <br /><br />
    <asp:Button ID="btnCreate" runat="server" Text="Ingresar"  Width="470px"  />
    <br />
    <asp:Button ID="btnRead" runat="server" Text="Buscar"  Width="470px" />
    <br />
    <asp:Button ID="btnUpdate" runat="server" Text="Modificar"  Width="470px"  />
    <br />
    <asp:Button ID="btnlimpiar" runat="server"  Text="Limpiar Campos" Width="470px"  />
    <br />
    <asp:Label ID="lblMessages" runat="server" Text=""></asp:Label>
    <br />


</asp:Content>
