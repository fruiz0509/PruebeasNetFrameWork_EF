using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebeasNetFrameWork_EF
{
    public partial class Pruebas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (ERPWeb_ServerEntities entities = new ERPWeb_ServerEntities())
            {
                var lArticulos = (from x in entities.tbArticulo
                                        join y in entities.tbProveedor
                                        on x.intProvPredeterminado equals y.intProveedorId
                                        select new
                                        {
                                            x.intArticuloId,
                                            x.strPartNum,
                                            x.strPartNumLegacy,
                                            x.strDescripcion,
                                            y.strNombreCorto,
                                            y.strNombre,
                                            x.decPrecioBaseLista,
                                            x.decCostoPromedio
                                        }).ToList();
                GridView1.DataSource = lArticulos;
                GridView1.DataBind();
            }
        }

        decimal decPrecio_ = 0;
        decimal decCosto_ = 0;
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                decPrecio_ += Convert.ToDecimal(e.Row.Cells[6].Text);
                decCosto_ += Convert.ToDecimal(e.Row.Cells[7].Text);
            }

            decPrecio.InnerHtml = String.Format("$ {0:N2}", decPrecio_);
            decCosto.InnerHtml = String.Format("$ {0:N2}", decCosto_);
        }
    }
}