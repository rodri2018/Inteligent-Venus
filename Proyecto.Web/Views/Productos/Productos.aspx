<%@ Page Title="" Language="C#" MasterPageFile="~/Recursos/Template/Template.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Proyecto.Web.Views.Productos.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor" runat="server">
    <div class="mx-0 my-auto mt-5"> 
       <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <h3>
                        <b>
                        Productos
                        </b>
                    </h3>
                </div>
            </div>
       </div>
    <div class="form-group">
        <div class="form-row">
            <div class="col-md-3">
                <asp:label runat="server" id="lblCodigo" text="Codigo"></asp:label>
                
                <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control"></asp:TextBox>
                
            </div>
             <div class="col-md-3">
                  <asp:label runat="server" id="NombreProd" text="Nombre producto"></asp:label>
                
                <asp:TextBox ID="txtNomproducto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
             <div class="col-md-3">
                  <asp:label runat="server" id="DescripcionProp" text="Descripcion Producto"></asp:label>
                
                <asp:TextBox ID="txtDescProducto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
             <div class="col-md-3">
                  <asp:label runat="server" id="Color" text="Color"></asp:label>
                
                <asp:TextBox ID="txtColor" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            
        </div>
     </div>
<%---- segunda seccion -------%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <asp:Button runat="server" id="btnGuardar" text="Guardar" CssClass="btn btn-primary"/>
                    <asp:Button runat="server" id="btnCancelar" text="Cancelar" CssClass="btn btn-primary"/>
                </div>
            </div>
        </div>
<%---- Tercera seccion -------%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <asp:label runat="server" id="lblSubtitulos" text="Resultados"></asp:label>
                </div>
            </div>
        </div>
         <div class="form-group">
            <div class="form-row">
                <div class="col-md-12" style="overflow:auto">
                    <asp:Gridview runat="server" id="gvwDatos"
                       width="100%"
                       AutoGenerateColumns="False"
                        EmptyDataText="No se encontraron registros" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                       
                        <columns>
                            <%---represntacion en controlesweb--%>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Label runat="server" id="lblCodigo" text='<%# Bind("Codigo") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <%---por celas--%>
                            <asp:BoundField HeaderText="Producto" DataField="Nom_producto" />
                            <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                            <asp:BoundField HeaderText="Color" DataField="Color" />
                 
                        </columns>

                        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" ForeColor="#003399" />
                        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SortedAscendingCellStyle BackColor="#EDF6F6" />
                        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                        <SortedDescendingCellStyle BackColor="#D6DFDF" />
                        <SortedDescendingHeaderStyle BackColor="#002876" />

                    </asp:Gridview>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
