<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cursos.aspx.cs" Inherits="Cursos" 
    EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div id="top">

            <asp:Image ID="Image1" runat="server" Height="45px" ImageUrl="~/Res/Logo.png" Width="287px" />

        </div>

        <div id="center">
            <asp:ImageButton ID="ImageButton1" runat="server" Height="58px" ImageUrl="~/Res/sistema_mat.png" Width="597px" />

            <asp:GridView ID="GridCursos" runat="server"
                EmptyDataText="No se encontraron cursos disponibles" 
                OnRowCreated="GridCursos_RowCreated" style="margin-left: 0px; margin-top: 12px;" Width="604px" CellPadding="4" ForeColor="#333333" GridLines="None" Height="232px" OnSelectedIndexChanged="GridCursos_SelectedIndexChanged">
               <AlternatingRowStyle BackColor="White" />
               <EditRowStyle BackColor="#2461BF" />
               <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
               <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
               <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
               <RowStyle BackColor="#EFF3FB" />
              <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
               <SortedAscendingCellStyle BackColor="#F5F7FB" />
               <SortedAscendingHeaderStyle BackColor="#6D95E1" />
               <SortedDescendingCellStyle BackColor="#E9EBEF" />
               <SortedDescendingHeaderStyle BackColor="#4870BE" />
           </asp:GridView>

            <div id="data">
                <p><asp:Label ID="lblReq" runat="server" Text="LOS REQUISITOS: "></asp:Label></p>
                <p><asp:Label ID="lblObs" runat="server" Text="Observaciones: "></asp:Label></p>
            </div>

            &nbsp;<asp:ImageButton ID="ImageButton2" runat="server" Height="46px" Width="139px"
                style="margin-left:425px;" ImageUrl="~/Res/btn_continuar.png" OnClick="ImageButton2_Click" />

            </div>

        <style>
           #center { width:600px; height:500px; margin-left:auto; margin-right:auto; margin-top:40px}
           #top { margin-left:30px; margin-top:30px;}
           #data {margin-top:30px; margin-left:20%; margin-right:20% }
        </style>

        </form>
    </body>
</html>
