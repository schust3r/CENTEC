using Entidades.eMatricula;
using LogicaNegocios.modMatricula;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Formulario : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            cmbTipoId.DataSource = new MatriculaNeg().CargarListaTiposParticipante();
            cmbTipoId.DataValueField = "ID";
            cmbTipoId.DataTextField = "Tipo";
            cmbTipoId.Text = "Nacional";
            cmbTipoId.DataBind();
        }
        catch { }
    }

    protected void btnAceptar_Click(object sender, ImageClickEventArgs e)
    {
        EParticipante nuevo = new EParticipante();
        nuevo.Usuario = "admin";
        nuevo.Codigo = Session["Cod"].ToString();
        nuevo.NombreCurso = Session["NombreCurso"].ToString();
        nuevo.IdTipoId = Convert.ToInt16(cmbTipoId.SelectedValue);
        nuevo.Identificacion = txtbIdenti.Text;
        nuevo.Nombre = txtbNombre.Text;
        nuevo.Apellidos = txtbApellidos.Text;
        nuevo.Telefono = txtbTel.Text;
        nuevo.Correo = txtbCorreo.Text;
        nuevo.Observaciones = ta_observ.Value;
        nuevo.TipoApoyo = ta_apoyo.Value;

        if (new MatriculaNeg().MatricularParticipanteEnLinea(nuevo))
        {
            Response.Redirect("Exito.aspx");
        }
        else
        {
            string message = "Ya no existen cupos disponibles para el curso seleccionado.";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("');");
            ClientScript.RegisterOnSubmitStatement(this.GetType(), "alert", sb.ToString());
        }
    }

}