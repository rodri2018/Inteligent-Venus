<%@ Page Title="" Language="C#" MasterPageFile="~/Recursos/Template/Template.Master" AutoEventWireup="true" CodeBehind="PosiblesClientes.aspx.cs" Inherits="Proyecto.Web.Views.PosiblesClientes.PosiblesClientes" %>

<asp:Content ID="ContentHeader" ContentPlaceHolderID="header" runat="server">

</asp:Content>


<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor" runat="server">
    <script src="../../Js/sweetalert.min.js" type="text/javascript"></script>
    <link href="../../css/sweetalert.css" type="text/css" rel="stylesheet"/>
	<div class="mx-auto mt-5">
        <!-- primera fila-->
        <div class="form-group">
			<div class="form-row">
				<div class="col-md-12">
					<h1><b>Posibles Clientes</b></h1>
                    <asp:label runat="server" ID="lblOpcion" visible="false"></asp:label>
				</div>
			</div>
		</div>
		<div class="form-group">
			<div class="form-row">
				<div class="col-md-3">
					<asp:label runat="server" ID="lblIdentificacion" text="Identificacion *"></asp:label>
					<asp:textbox runat="server" ID="txtIdentificacion" cssclass="form-control"></asp:textbox>
				</div>
				<div class="col-md-3">
					<asp:label runat="server" id="lblEmpresa" text="Empresa"></asp:label>
					<asp:textbox runat="server" id="txtEmpresa" cssclass="form-control"></asp:textbox>
				</div>
				<div class="col-md-3">
					<asp:label runat="server" id="lblPrimerNombre" text="Primer Nombre *"></asp:label>
					<asp:textbox runat="server" id="txtPrimerNombre" cssclass="form-control"></asp:textbox>
				</div>
				<div class="col-md-3">
					<asp:label runat="server" id="lblSegundoNombre" text="Segundo Nombre"></asp:label>
					<asp:textbox runat="server" id="txtSegundoNombre" cssclass="form-control"></asp:textbox>
				</div>
			</div>
		</div>

        <!-- segunda fila -->
        <div class="form-group">
			<div class="form-row">
				<div class="col-md-3">
					<asp:label runat="server" ID="lblPrimerApellido" text="Primer Apellido *"></asp:label>
					<asp:textbox runat="server" ID="txtPrimerApellido" cssclass="form-control"></asp:textbox>
				</div>
				<div class="col-md-3">
					<asp:label runat="server" id="lblSegundoApellido" text="Segundo apellido *"></asp:label>
					<asp:textbox runat="server" id="txtSegundoApellido" cssclass="form-control"></asp:textbox>
				</div>
				<div class="col-md-3">
					<asp:label runat="server" id="lblDireccion" text="Direccion *"></asp:label>
					<asp:textbox runat="server" id="txtDireccion" cssclass="form-control"></asp:textbox>
				</div>
				<div class="col-md-3">
					<asp:label runat="server" id="lblTelefono" text="Telefono *"></asp:label>
					<asp:textbox runat="server" id="txtTelefono" cssclass="form-control"></asp:textbox>
				</div>
			</div>
		</div>

        <!-- tercera fila -->
        <div class="form-group">
			<div class="form-row">
				<div class="col-md-12">
					<asp:label runat="server" ID="lblCorreo" text="Correo *"></asp:label>
					<asp:textbox runat="server" ID="txtCorreo" cssclass="form-control"></asp:textbox>
				</div>
			</div>
		</div>

        <!-- cuarta fila -->
        <div class="form-group">
			<div class="form-row">
				<div class="col-md-12">
                    <asp:Label runat="server" ID="msj" Text="Los campos con * son obligatorios"></asp:Label>
                    <br />
					<asp:Button runat="server" ID="btnGuardar" text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click"></asp:Button>
					<asp:Button runat="server" ID="btnCancelar" text="Cancelar" CssClass="btn btn-primary" OnClick="btnLimpiar_Click"></asp:Button>
				</div>
			</div>
		</div>

         <!-- quinta fila -->
        <div class="form-group">
			<div class="form-row">
				<div class="col-md-12">
					<h3><b>Resultados</b></h3>
				</div>
			</div>
		</div>
        <div class="form-group">
			<div class="form-row">
				<div class="col-md-12"style="overflow:auto" >
					<asp:GridView runat="server" ID="gvwDatos" Width="100%" AutoGenerateColumns="false" EmptyDataText="No se encontraron registros" OnRowCommand="gvwDatos_RowCommand">
                        <Columns>
                            <%--  representacion de datos en controles web --%>
                            <asp:TemplateField HeaderText="Identificacion">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblIdentificacion2" Text='<%# Bind("clieIdentificacion") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <%-- representacion de datos en  celdas --%>
                            <asp:BoundField HeaderText="Empresa" DataField="clieEmpresa"/>
                            <asp:BoundField HeaderText="Primer Nombre" DataField="cliePrimerNombre"/>
                            <asp:BoundField HeaderText="Segundo nombre" DataField="clieSegundoNombre"/>
                            <asp:BoundField HeaderText="Primer Apellido" DataField="cliePrimerApellido"/>
                            <asp:BoundField HeaderText="Segundo Apellido" DataField="clieSegundoApellido"/>
                            <asp:BoundField HeaderText="Direccion" DataField="clieDireccion"/>
                            <asp:BoundField HeaderText="Telefono" DataField="clieTelefono"/>
                            <asp:BoundField HeaderText="Correo" DataField="clieCorreo"/>

                            <asp:TemplateField HeaderText="Editar">
                                <ItemTemplate>
                                    <asp:ImageButton ID="sbEditar" runat="server" ImageUrl="~/Recursos/Images/edit.png" CommandName="Editar" CommandArgument="<% ((GridViewRow) Container).RowIndex %>" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Eliminar">
                                <ItemTemplate>
                                    <asp:ImageButton ID="sbEliminar" runat="server" ImageUrl="~/Recursos/Images/delete.png" CommandName="Eliminar" CommandArgument="<% ((GridViewRow) Container).RowIndex %>" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateField>

                        </Columns>

					</asp:GridView>
				</div>
			</div>
		</div>
	</div>
</asp:Content>