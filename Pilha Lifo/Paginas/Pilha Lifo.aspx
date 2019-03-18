<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pilha Lifo.aspx.cs" Inherits="Paginas_Pilha_Lifo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pilha Lifo</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/DataTables/css/dataTables.bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/DataTables/css/jquery.dataTables.min.css" rel="stylesheet" />
</head>
<body class="jumbotron">
    <form id="form1" runat="server">
        <div class ="row" style="margin:50px">
            <div class="col-xs-9 col-sm-6 col-md-4 col-lg-3">
                <asp:TextBox ID="txtElemento" runat="server" placeholder="Inserir elemento" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-xs-3 col-sm-4 col-md-4 col-lg-3">
                <asp:Button ID="btnInserir" runat="server" CssClass="btn btn-primary form-control" Text="Inserir" OnClick="btnInserir_Click"></asp:Button>
            </div>
        </div>
       <div class="row" style="margin:50px">
           <div class="col-xs-12 col-sm-12 col-md-6 col-lg-6">
               <asp:Literal ID="ltrMsg" runat="server"></asp:Literal>
           </div>
       </div>
        <div class="row" style="margin:50px">
           <div class ="col-xs-4 col-sm-4 col-md-4 col-lg-3">
                <asp:Button ID="btnMostrar" runat="server" CssClass="btn btn-success form-control" Text="Mostrar" OnClick="btnMostrar_Click"></asp:Button>
            </div>
             <div class="col-xs-4 col-sm-4 col-md-4 col-lg-3">
                <asp:Button ID="btnTopo" runat="server" CssClass="btn btn-outline-secondary form-control" Text="Topo" OnClick="btnTopo_Click"></asp:Button>
            </div>
             <div class="col-xs-4 col-sm-4 col-md-4 col-lg-3">
                <asp:Button ID="btnRetirar" runat="server" CssClass="btn btn-danger form-control" Text="Retirar" OnClick="btnRetirar_Click"></asp:Button>
            </div>
       </div>
        <div class="row" style="margin:50px">
           <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
               <asp:Literal ID="ltrDados" runat="server"></asp:Literal>
           </div>
       </div>
    </form>
    <script src="../Scripts/jquery-3.3.1.min.js"></script>
    <script src="../Scripts/DataTables/jquery.dataTables.min.js"></script>
    <script>  //linkando plugin do dataTable
        $(document).ready(function(){
            $('#tabela').DataTable();
        });
    </script>
</body>
</html>
