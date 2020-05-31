<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pantallaDos.aspx.cs" Inherits="Web.pantallaDos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous" />
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
    <link href="estilos.css" rel="stylesheet" />
    <title>Detalles carrito</title>
</head>

<body>
    <form id="form2" runat="server">

        <div class="barra">
        </div>

        <header class="titulo" style="text-align: center; margin-bottom: 20px;">
            <asp:Label runat="server"
                Text="Detalle de carrito" Font-Bold="True" />
        </header>

        <%--<asp:GridView ID="dgv1" runat="server" AutoGenerateColumns="false" CssClass="centrar">
                <Columns>
                    <asp:BoundField HeaderText="articulo" DataField="nombre" />
                    <asp:BoundField HeaderText="categoria" DataField="categoria" />
                    <asp:BoundField HeaderText="marca" DataField="marca" />
                    <asp:BoundField HeaderText="precio" DataField="precio" />
                    <asp:BoundField HeaderText="descripcion" DataField="descripcion" />
                    <asp:ButtonField HeaderText="Accion" ButtonType="Link" Text="Eliminar" 
                        CommandName ="elim_click"
                        />
                </Columns>
            </asp:GridView>--%>

                         <%--<asp:Repeater runat="server" ID="repeaterCarri">
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("nombre")%></td>
                                    <td><%#Eval("descripcion")%></td>
                                    <td>$<%#Eval("precio")%></td>
                                  <td>
                                        <asp:Button
                                            ID="btnQuitarDelCarrito"
                                            CssClass="btn btn-primary"
                                            Text="Quitar del carrito"
                                            CommandArgument='<%#Eval("codigo")%>'
                                            CommandName="articuloAEliminar"
                                            runat="server"
                                            OnClick="btnQuitarDelCarrito_Click" />
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>--%>
                 
        <section>
            <table class="table table-hover">
                <thead>
                    <tr>
                        <th scope="col">Articulo</th>
                        <th scope="col">Marca</th>
                        <th scope="col">Categoria</th>
                        <th scope="col">Precio</th>
                        <th scope="col">Descripcion</th>
                        <th scope="col">Accion</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater runat="server" ID="repeaterCarri">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("nombre")%></td>
                                <td><%#Eval("marca")%></td>
                                <td><%#Eval("categoria")%></td>
                                <td><%#Eval("precio")%></td>
                                <td><%#Eval("descripcion")%></td>
                                <td>
                                    <asp:Button runat="server" ID="btnEliminar"
                                        Text="Eliminar" CommandName="articuloEliminado" CommandArgument='<%#Eval("codigo")%>'
                                        OnClick="btnEliminar_Click" />
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </section>

        <section style="text-align: center;">
            <div class="subtotal">
                <asp:Label ID="lblTotal" runat="server"
                    Text="EL TOTAL A PAGAR ES $ "></asp:Label>
            </div>
        </section>

        <section class="trans">
            <div>
                <asp:Button runat="server" ID="btnVolver"
                    OnClick="btnVolver_Click" Text="Agregar productos" CssClass="btn btn-outline-danger btn-responsive btninter centrado" />
                <asp:Button runat="server" ID="btnFinalizar"
                    Text="Finalizar" OnClick="btnFinalizar_Click" CssClass="btn btn-outline-danger btn-responsive btninter right centrado" />
            </div>
        </section>
    </form>
</body>
</html>
