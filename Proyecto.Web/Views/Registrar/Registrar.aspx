<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="Proyecto.Web.Views.Registrar.Registrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>

    <title> Register</title>

    <!-- Bootstrap core CSS-->
    <link href="../../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet"/>

    <!-- Custom fonts for this template-->
    <link href="../../vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css"/>

    <!-- Custom styles for this template-->
    <link href="../../css/sb-admin.css" rel="stylesheet"/>

     <!-- Bootstrap core JavaScript-->
    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>

     <link href="../../css/sweetalert.css" rel="stylesheet" />
    <script src="../../Js/sweetalert.min.js" type="text/javascript"></script>
</head>


  <body class="bg-dark">

    <div class="container">
      <div class="card card-register mx-auto mt-5">
        <div class="card-header">Register an Account</div>
        <div class="card-body">
            <form id="form1" runat="server">
            <div class="form-group">
              <div class="form-row">
                <div class="col-md-6">
                  <div class="form-label-group">
                <asp:Label ID="lblprimernom" runat="server" Text="Primer nombre"></asp:Label>
                 <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                  </div>
                </div>
                <div class="col-md-6">
                  <div class="form-label-group">
                 <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>               
                <asp:TextBox ID="TxtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                  </div>
                </div>
              </div>
            </div>
            <div class="form-group">
              <div class="form-label-group">
                <asp:Label ID="lblIngEmail" runat="server" Text="Email"></asp:Label>               
                <asp:TextBox ID="TxtIngEmail" runat="server" CssClass="form-control"></asp:TextBox>
              </div>
            </div>
            <div class="form-group">
              <div class="form-row">
                <div class="col-md-6">
                  <div class="form-label-group">
                <asp:Label ID="lblIngPassword" runat="server" Text="Contraseña"></asp:Label>               
                <asp:TextBox ID="TxtIngPassword" runat="server" CssClass="form-control" ></asp:TextBox>
                  </div>
                </div>
                <div class="col-md-6">
                  <div class="form-label-group">
                    <asp:Label ID="lblConfPassword" runat="server" Text="COnfirmar Contraseña"></asp:Label>               
                <asp:TextBox ID="txtConfPassword" runat="server" CssClass="form-control" ></asp:TextBox>
                  </div>
                </div>
              </div>
            </div>
             <asp:Button ID="btnAceptar" runat="server" CssClass="btn btn-primary btn-block " Text="Aceptar" OnClick="btnAceptar_Click" />
            </form>
          <div class="text-center">
            <a class="d-block small mt-3" href="login.html">Login Page</a>
            <a class="d-block small" href="forgot-password.html">Forgot Password?</a>
          </div>
        </div>
      </div>
    </div>

   

  </body>

</html>
