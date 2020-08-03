<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina_Principal.aspx.cs" Inherits="Laboratorio7y8.Pagina_Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager runat="server"></asp:ScriptManager>
            <asp:UpdatePanel runat="server" ID="upd1">
                <ContentTemplate>
             <table>
             <tr>
                    <td>Pais</td>
                    <td><asp:DropDownList id= "cmbPais" runat="server" DataSourceID="NomPais" DataTextField="NomPais" DataValueField="NomPais"></asp:DropDownList>
                        <asp:SqlDataSource ID="NomPais" runat="server" ConnectionString="<%$ ConnectionStrings:bdFondoMonetarioInternacional %>" SelectCommand="SELECT [NomPais] FROM [CatPais]"></asp:SqlDataSource>
                    </td>
                </tr>
                 <tr>
                    <td>Habitantes</td>
                    <td><asp:TextBox ID="txtHabitantes" runat="server"></asp:TextBox></td> 
                </tr>
                 <tr>
                    <td>Idioma</td>
                    <td><asp:DropDownList id= "cmbIdioma" runat="server" DataSourceID="NomIdioma" DataTextField="NomIdioma" DataValueField="NomIdioma"></asp:DropDownList>
                        <asp:SqlDataSource ID="NomIdioma" runat="server" ConnectionString="<%$ ConnectionStrings:bdFondoMonetarioInternacional %>" SelectCommand="SELECT [NomIdioma] FROM [CatIdioma]"></asp:SqlDataSource>
                     </td>
                       
                </tr>
                 <tr>
                    <td>PIB</td>
                    <td><asp:TextBox ID="txtPIB" runat="server"></asp:TextBox></td>
                </tr>
                  <tr>
                    <td>Superficie</td>
                    <td><asp:TextBox ID="txtSuperficie" runat="server"></asp:TextBox></td>
                </tr>
                  <tr>
                    <td>Riesgo seguridad</td>
                    <td><asp:RadioButton ID="rdbAlto" runat="server"></asp:RadioButton><asp:label runat="server">Alto</asp:label></td>
                    <td><asp:RadioButton ID="rdbMedio" runat="server"></asp:RadioButton><asp:label runat="server">Medio</asp:label></td>
                    <td><asp:RadioButton ID="rdbBajo" runat="server"></asp:RadioButton><asp:label runat="server">Bajo</asp:label></td>
                </tr>
                  <tr>
                    <td>Sujeto a Prestamo?</td>
                    <td><asp:CheckBox ID="cbPrestamo" runat="server"></asp:CheckBox></td>
                </tr>
                 <tr>
                            <td><asp:Button ID="btnRegistrar" Text="Registrar" runat="server" OnClick="btnRegistrar_Click" /></td>
                            <td><asp:Button ID="btnActualizar" Text="Actualizar" runat="server" OnClick="btnActualizar_Click" /></td>
                            <td><asp:Button ID="btnEliminar" Text="Eliminar" runat="server" OnClick="btnEliminar_Click" /></td>
                        </tr>        
             </table>
            <br>
            <br/>
                <div>
                <asp:GridView ID="gridDatos" runat="server" 
                                AutoGenerateColumns="false"  
                                DataKeyNames="Pais"
                                BackColor="White" 
                                BorderColor="#999999" 
                                BorderStyle="None" 
                                BorderWidth="1px" 
                                CellPadding="3" 
                                GridLines="Vertical"                                                                             
                                >
                                <Columns>
                                    <asp:BoundField DataField="Pais" HeaderText="Pais" />
                                    <asp:BoundField DataField="Habitantes" HeaderText="Habitantes" />
                                    <asp:BoundField DataField="Idioma" HeaderText="Idioma" />
                                    <asp:BoundField DataField="PIB" HeaderText="PIB" />
                                    <asp:BoundField DataField="Superficie" HeaderText="Superficie" />
                                    <asp:BoundField DataField="RiesgoSeguridad" HeaderText="Riesgo Superficie" />
                                    <asp:BoundField DataField="SujetoPrestamo" HeaderText="Sujeto a Prestamo?" />
                                </Columns>
                                <AlternatingRowStyle BackColor="#DCDCDC" />
                                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#000065" />
                            </asp:GridView>
            </div>
            </ContentTemplate>

            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
