using LogicaNegocios.modMatricula;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Cursos : System.Web.UI.Page
{

    private DataView info;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GridCursos.DataSourceID = null;

            info = new MatriculaNeg().ConsultarCursosEnLinea();
            GridCursos.DataSource = info;

            GridCursos.DataBind();
        }
    }

    protected void GridCursos_RowCreated(object sender, GridViewRowEventArgs e)
    {
        info = new MatriculaNeg().ConsultarCursosEnLinea();

        if (info.Table.Rows.Count != 0)
        {
            e.Row.Cells[0].HorizontalAlign = HorizontalAlign.Center;
            e.Row.Cells[1].HorizontalAlign = HorizontalAlign.Center;
            e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Center;
            e.Row.Cells[3].Visible = false;
            e.Row.Cells[4].Visible = false;
            e.Row.Cells[5].Visible = false;

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onmouseover"] = "this.style.cursor='pointer';this.style.textDecoration='underline';";
                e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';";
                e.Row.ToolTip = "Click para seleccionar";
                e.Row.Attributes["onclick"] = this.Page.ClientScript.
                    GetPostBackClientHyperlink(this.GridCursos, "Select$" + e.Row.RowIndex);
            }
        }
    }

    /// <summary>
    /// Cuando cambie la fila seleccionada
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void GridCursos_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            lblReq.Text = "Requisitos: " + GridCursos.Rows[GridCursos.SelectedIndex].Cells[3].Text.ToString();
            lblObs.Text = "Observaciones: " + GridCursos.Rows[GridCursos.SelectedIndex].Cells[4].Text.ToString();
        }
        catch { }
    }



    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (GridCursos.SelectedRow != null)
            {
                Session["Cod"] = GridCursos.Rows[GridCursos.SelectedIndex].Cells[5].Text.ToString();
                Session["NombreCurso"] = GridCursos.Rows[GridCursos.SelectedIndex].Cells[1].Text.ToString();
                Response.Redirect("Formulario.aspx");
            }
        }
        catch { }
    }


}