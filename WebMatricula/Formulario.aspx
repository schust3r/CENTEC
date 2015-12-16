<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Formulario.aspx.cs" Inherits="Formulario" %>

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

         <div id ="forms">

               <div style="float:left;">    

                   <p style="height: 23px">Tipo de identificación*</p>
                   <p style="height: 23px">Identificación*</p>
                   <p style="height: 23px">Nombre*</p>
                   <p style="height: 23px">Apellidos*</p>
                   <p style="height: 23px">Teléfono</p>
                   <p style="height: 23px">Correo electrónico*</p>
                   <p style="height: 23px">Observaciones</p>
                   <p style="height: 28px">Tipos de apoyos requeridos</p>
                   <p style="margin-top:45px">* Campo obligatorio</p>

               </div>

             <div style="float:right; width:200px;">

                 <p>
                     <asp:DropDownList ID="cmbTipoId" runat="server" Height="24px" Width="200px"></asp:DropDownList></p>
                 <p>
                     <asp:TextBox ID="txtbIdenti" runat="server" Width="200px"></asp:TextBox></p>
                 <p>
                     <asp:TextBox ID="txtbNombre" runat="server" Width="200px"></asp:TextBox></p>
                 <p>
                     <asp:TextBox ID="txtbApellidos" runat="server" Width="200px"></asp:TextBox></p>
                 <p>
                     <asp:TextBox ID="txtbTel" runat="server" Width="200px"></asp:TextBox></p>
                 <p>
                     <asp:TextBox ID="txtbCorreo" runat="server" Width="200px"></asp:TextBox></p>
                 <p>
                     <textarea id="ta_observ" runat="server" cols="25" rows="2"></textarea></p>
                 <p>
                     <textarea id="ta_apoyo" runat="server" cols="25" rows="2"></textarea></p>

             </div>

             <div style="clear:both; margin-left:220px; margin-top:100px;">
                 <asp:ImageButton ID="btnAceptar" runat="server" Height="48px" Width="169px" ImageUrl="~/Res/btn_aceptar.png" OnClick="btnAceptar_Click"
                     />
               </div>
            
        </div>
    

        <style>
            #top { margin-left:30px; margin-top:30px; margin-bottom:50px;}
            #forms { width:400px; height:500px; margin-left:auto; margin-right:auto; margin-top:40px}
        </style>

    </form>
</body>
</html>
