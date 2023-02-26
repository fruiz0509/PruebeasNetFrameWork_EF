<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pruebas.aspx.cs" Inherits="PruebeasNetFrameWork_EF.Pruebas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 500px; width: 800px; overflow: auto;" runat="server" visible="true">
            <div style="width: 1150px">
                <table border="0">
                    <tr>
			            <th scope="col" style="width:50px; background-color: gray;">Id</th>
                        <th scope="col" style="width:150px; background-color: gray;">PartNum</th>
                        <th scope="col" style="width:150px; background-color: gray;">PartNum antiguo</th>
                        <th scope="col" style="width:250px; background-color: gray;">Articulo</th>
                        <th scope="col" style="width:100px; background-color: gray;">Prov Id</th>
                        <th scope="col" style="width:250px; background-color: gray;">Proveedor</th>
                        <th scope="col" style="width:100px; background-color: gray;">Precio Lista</th>
                        <th scope="col" style="width:100px; background-color: gray;">Costo promedio</th>
		            </tr>                    
                </table>
            </div>
            <div id="container_gdv" style="overflow: auto; width: 1167px; height: 400PX;">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" Height="300" ShowHeader="false" 
                    BorderStyle="Solid" BorderColor="White" BorderWidth="0" OnRowDataBound="GridView1_RowDataBound">
                    <Columns>
                        <asp:BoundField DataField="intArticuloId" HeaderText="Id" 
                            HeaderStyle-Width="50" HeaderStyle-Wrap="true" 
                            ItemStyle-Width="50" ItemStyle-Wrap="true" ItemStyle-BorderColor="White" ItemStyle-BorderWidth="0" ItemStyle-HorizontalAlign="Center"
                            />
                        <asp:BoundField DataField="strPartNum" HeaderText="PartNum" 
                            HeaderStyle-Width="150" HeaderStyle-Wrap="true" 
                            ItemStyle-Width="150" ItemStyle-Wrap="true" ItemStyle-BorderColor="White" ItemStyle-BorderWidth="0" ItemStyle-HorizontalAlign="Center"
                            />
                        <asp:BoundField DataField="strPartNumLegacy" HeaderText="PartNum antiguo" 
                            HeaderStyle-Width="150" HeaderStyle-Wrap="true" 
                            ItemStyle-Width="150" ItemStyle-Wrap="true" ItemStyle-BorderColor="White" ItemStyle-BorderWidth="0" ItemStyle-HorizontalAlign="Center"
                            />
                        <asp:BoundField DataField="strDescripcion" HeaderText="Articulo" 
                            HeaderStyle-Width="250" HeaderStyle-Wrap="true" 
                            ItemStyle-Width="250" ItemStyle-Wrap="true" ItemStyle-BorderColor="White" ItemStyle-BorderWidth="0" ItemStyle-HorizontalAlign="Center"
                            />
                        <asp:BoundField DataField="strNombreCorto" HeaderText="Prov Id" 
                            HeaderStyle-Width="100" HeaderStyle-Wrap="true" 
                            ItemStyle-Width="100" ItemStyle-Wrap="true" ItemStyle-BorderColor="White" ItemStyle-BorderWidth="0" ItemStyle-HorizontalAlign="Center"
                            />
                        <asp:BoundField DataField="strNombre" HeaderText="Proveedor" 
                            HeaderStyle-Width="250" HeaderStyle-Wrap="true" 
                            ItemStyle-Width="250" ItemStyle-Wrap="true" ItemStyle-BorderColor="White" ItemStyle-BorderWidth="0" ItemStyle-HorizontalAlign="Center"
                            />
                        <asp:BoundField DataField="decPrecioBaseLista" HeaderText="Precio Lista" 
                            HeaderStyle-Width="100" HeaderStyle-Wrap="true" 
                            ItemStyle-Width="100" ItemStyle-Wrap="true" ItemStyle-BorderColor="White" ItemStyle-BorderWidth="0" ItemStyle-HorizontalAlign="Center"
                            />
                        <asp:BoundField DataField="decCostoPromedio" HeaderText="Costo promedio"  
                            HeaderStyle-Width="100" HeaderStyle-Wrap="true" 
                            ItemStyle-Width="100" ItemStyle-Wrap="true" ItemStyle-BorderColor="White" ItemStyle-BorderWidth="0" ItemStyle-HorizontalAlign="Center"
                            />
                    </Columns>                
                </asp:GridView>
            </div>
            <div style="width: 1150px">
                <table border="0">
                    <tr>
			            <td scope="col" style="width:50px; background-color: gray;"></td>
                        <td scope="col" style="width:150px; background-color: gray;"></td>
                        <td scope="col" style="width:150px; background-color: gray;"></td>
                        <td scope="col" style="width:250px; background-color: gray;" runat="server"></td>
                        <td scope="col" style="width:100px; background-color: gray;" runat="server"></td>
                        <td scope="col" style="width:250px; background-color: gray;" runat="server">Totales $</td>
                        <td scope="col" style="width:100px; background-color: gray;" runat="server" id="decPrecio"></td>
                        <td scope="col" style="width:100px; background-color: gray;" runat="server" id="decCosto"></td>
		            </tr>                    
                </table>
            </div>
        </div>
    </form>
</body>
</html>
