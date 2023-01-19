using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Presentacion
{
    public partial class frm_Unidades_Medidas : Form
    {
        public frm_Unidades_Medidas()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int Estadoguarda = 0; //sin ninguna acción
        int Ncodigo = 0;//Se va a utilizar para guardar el código del registro seleccionado
        #endregion

        #region "Mis Metodos"

        private void Formato_um()
        {
            Dgv_principal.Columns[0].Width = 80;
            Dgv_principal.Columns[0].HeaderText = "CÓDIGO";
            Dgv_principal.Columns[1].Width = 250;
            Dgv_principal.Columns[1].HeaderText = "UNIDADES DE MEDIDA";
        }
        private void Listado_um(string cTexto)
        {
            Dgv_principal.DataSource = N_Unidades_Medida.Listar_um(cTexto);
            this.Formato_um();
        }

        private void Estado(bool lEstado)
        {
            txt_descripcion_um.Enabled = lEstado;
            btn_cancelar.Enabled = lEstado;
            btn_guardar.Enabled = lEstado;

            btn_nuevo.Enabled = !lEstado;
            btn_actualizar.Enabled = !lEstado;
            btn_eliminar.Enabled = !lEstado;
            btn_reporte.Enabled = !lEstado;
            btn_salir.Enabled = !lEstado;

            txt_buscar.Enabled = !lEstado;
            btn_buscar.Enabled = !lEstado;
            Dgv_principal.Enabled = !lEstado;
        }
        #endregion

        private void frm_Unidades_Medidas_Load(object sender, EventArgs e)
        {
            this.Listado_um("%");
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if( string.IsNullOrEmpty(txt_descripcion_um.Text))
            {
                MessageBox.Show("No se tiene información para ser guardada", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string Rpta = "";
                E_Unidad_Medida oUm = new E_Unidad_Medida();
                oUm.Codigo_um = Ncodigo;
                oUm.Descripcion_um = txt_descripcion_um.Text.Trim();                    
                Rpta = N_Unidades_Medida.Guardar_um(Estadoguarda, oUm);
                if (Rpta.Equals("OK"))
                {
                    this.Listado_um("%");
                    this.Estado(false);
                    Estadoguarda = 0;
                    Ncodigo = 0;
                    MessageBox.Show("Datos guardados correctamente", "Aviso del sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Listado_um(txt_buscar.Text.Trim());
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Estadoguarda = 1;//nuevo registro
            this.Estado(true);
            txt_descripcion_um.Text = "";
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Estado(false);
            txt_descripcion_um.Text = "";
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2;//actualiza registro
            this.Estado(true);
        }

        private void Dgv_principal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ncodigo = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_um"].Value);
            txt_descripcion_um.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_um"].Value);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult cOpcion;
            cOpcion = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(cOpcion == DialogResult.Yes)
            {
                string Rpta= "";
                Rpta = N_Unidades_Medida.Eliminar_um(Ncodigo);
                if(Rpta.Equals("OK"))
                {
                    this.Listado_um("%");
                    Ncodigo = 0;
                    txt_descripcion_um.Text = "";
                    MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            Reportes.frm_rpt_UnidadesMedida oRpt2 = new Reportes.frm_rpt_UnidadesMedida();
            oRpt2.txt_p1.Text = txt_buscar.Text;
            oRpt2.ShowDialog();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
