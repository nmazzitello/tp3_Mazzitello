<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Web.pruebaDos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Carrito web Mazzitello</title>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous" />
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
    <link href="estilos.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="barra">
            <asp:Button runat="server"
                ID="btnCarrito"
                CssClass="botonCarrito btn btn-dark"
                Text="Ir carrito" OnClick="btnCarrito_Click" />
            <p class="float-right cantArt" id="lblCantArt"><strong> CANTIDAD DE ARTICULOS: <% = carri.listaCarrito.Count() %></strong></p>
        </div>

        <header class="titulo">
            <asp:Label ID="lblTituloPag" runat="server"
                Text="Carrito web Mazzitello" Font-Bold="True"></asp:Label>
        </header>

        <section class="conBus">
            <div class="container">
                <div class="row justify-content-start">
                    <div class="col-4">
                        <asp:Label runat="server"
                            Text="Ingrese el nombre:" Font-Size="30px" />
                    </div>
                    <div class="col-4">
                        <asp:TextBox runat="server"
                            ID="txtBuscar"
                            Font-Size="30px" />
                    </div>
                    <div>
                        <asp:Button Text="Buscar" runat="server" 
                            id="btnBuscar" OnClick="btnBuscar_Click" CssClass="btn btn-danger"/>
                        <asp:Button Text="Reiniciar" runat="server" 
                            id="btnReiniciar" OnClick="btnReiniciar_Click" CssClass="btn btn-danger"/>
                    </div>
                </div>
            </div>
        </section>

        <section class="card-columns" style="margin-left: 10px; margin-right: 10px;">
            <asp:Repeater runat="server" ID="repetidor">
                <ItemTemplate>
                    <div class="card" <%--style="width:350px; height: 700px;"--%>>
                        <img src="<%#Eval("imagen") %>" class="card-img-top" alt="imagen del articulo">
                        <div class="card-body">
                            <h3 class="card-title"><%#Eval("nombre")%></h3>
                            <p class="card-text"><%#Eval("categoria")%></p>
                            <p class="card-text"><%#Eval("marca")%></p>
                            <p class="card-text"><%#Eval("precio")%></p>
                            <p class="card-text"><%#Eval("descripcion")%></p>
                            <asp:Button ID="btnAgregar" runat="server"
                                Text="Agregar al carrito" CssClass="btn btn-primary btn-block"
                                CommandName="articuloSeleccionado" CommandArgument='<%#Eval("codigo")%>'
                                OnClick="btnAgregar_Click" />
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </section>

    </form>
</body>
</html>
