using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_datagridview : Form
    {
        public frm_datagridview()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if(txt_nombre.Text != "" && txt_email.Text !="")
            {
                dtv_datos.Rows.Add(txt_nombre.Text, txt_email.Text);
                txt_nombre.Text = "";
                txt_email.Text = "";
                MessageBox.Show("Datos Guardados");
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta;
            Respuesta = MessageBox.Show("Estas seguro de eliminar la fila seleccionada?","Aviso del Sistema",MessageBoxButtons.YesNo);
            if (Respuesta == DialogResult.Yes)
            {
                int nFila;
                nFila = dtv_datos.CurrentRow.Index;
                dtv_datos.Rows.RemoveAt(nFila);
                MessageBox.Show("Fila Eliminada");

            }
        }

        private void dtv_datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nombre.Text = Convert.ToString(dtv_datos.CurrentRow.Cells["Column1"].Value);
            txt_email.Text = Convert.ToString(dtv_datos.CurrentRow.Cells["Column2"].Value);
        }
    }
}
