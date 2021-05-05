using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CE;
using CN;
using System.Data;


namespace rosalba
{
    public partial class Formulario1 : System.Web.UI.Page
    {
        CEcita oecita = new CEcita();
        CNCita oncita = new CNCita();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnguardar_Click(object sender, EventArgs e)
        {
            oecita.Cod_cita1 = Convert.ToString(txtcodcita.Text);
            oecita.Fecha = Convert.ToDateTime(txtfecha.Text);
            oecita.Hora = Convert.ToDateTime(txthora.Text);
            oecita.Id_paciente = Convert.ToString(txtidpaciente.Text);
            oecita.Id_medico = Convert.ToString(txtidmedico.Text);
            oecita.Valor = Convert.ToInt32(txtvalor.Text);
            oecita.Diagnostico = Convert.ToString(txtdiagnostico.Text);
            oecita.Nom_acompanante = Convert.ToString(txtnomacompanante.Text);
            //oecita.Activo = Convert.ToByte(txtactivo.Text);

            if(oncita.crear_cita(oecita))
            {
                lblrespuesta.Text = "Cita Guardada";
            }
            else
            {
                lblrespuesta.Text = "No se pudo guardar la cita";
            }

}

        protected void btnconsultar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            oecita.Cod_cita1 = Convert.ToString(txtcodcita.Text);

            ds = oncita.consulta_cita(oecita);

            if (ds.Tables[0].Rows.Count == 0)
            {
                lblrespuesta.Text = "No hay cita";
            }
            else
            {

                lblrespuesta.Text = ds.Tables[0].Rows[0]["Cod_cita1"].ToString();

                //txtcodcita.Text = ds.Tables[0].Rows[0]["fecha"].ToString();
                txtfecha.Text = ds.Tables[0].Rows[0]["fecha"].ToString();
                txthora.Text = ds.Tables[0].Rows[0]["hora"].ToString();
                txtidpaciente.Text = ds.Tables[0].Rows[0]["id_paciente1"].ToString();
                txtidmedico.Text = ds.Tables[0].Rows[0]["id_medico"].ToString();
                txtvalor.Text = ds.Tables[0].Rows[0]["valor"].ToString();
                txtdiagnostico.Text = ds.Tables[0].Rows[0]["diagnostico"].ToString();


            }


        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            oecita.Cod_cita1 = Convert.ToString(txtcodcita.Text);

            if (oncita.eliminar_cita(oecita))
            {
                lblrespuesta.Text = " Cita se ha eliminado correctamente";
            }
            else
            {
                lblrespuesta.Text = "No se pudo eliminado cita";
            }

        }

        protected void btneliminar_Click1(object sender, EventArgs e)
        {
            oecita.Cod_cita1 = Convert.ToString(txtcodcita.Text);
            if(oncita.eliminar_cita( oecita))
            {
                lblrespuesta.Text = "Cita de ha eliminido correctamente";

            }
            else
            {
                lblrespuesta.Text = "No se pudo eliminar la cita";
            }
}
}
}
