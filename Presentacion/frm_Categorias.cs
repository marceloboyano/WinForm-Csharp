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
    public partial class frm_Categorias : Form
    {
        public frm_Categorias()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int Estadoguarda = 0; //sin ninguna acción
        int Ncodigo = 0;//Se va a utilizar para guardar el código del registro seleccionado
        #endregion

        #region "Mis Metodos"

        private void Formato_ca()
        {
            Dgv_principal.Columns[0].Width = 80;
            Dgv_principal.Columns[0].HeaderText = "CÓDIGO";
            Dgv_principal.Columns[1].Width = 250;
            Dgv_principal.Columns[1].HeaderText = "CATEGORÍA";
        }
        private void Listado_ca(string cTexto)
        {
            Dgv_principal.DataSource = N_Categorias.Listar_ca(cTexto);
            this.Formato_ca();
        }

        private void Estado(bool lEstado)
        {
            txt_descripcion_ca.Enabled = lEstado;
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

        private void frm_Categorias_Load(object sender, EventArgs e)
        {
            this.Listado_ca("%");
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if( string.IsNullOrEmpty(txt_descripcion_ca.Text))
            {
                MessageBox.Show("No se tiene información para ser guardada", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string Rpta = "";
                E_Categorias oCa = new E_Categorias();
                oCa.Codigo_ca = Ncodigo;
                oCa.Descripcion_ca = txt_descripcion_ca.Text.Trim();                
                Rpta = N_Categorias.Guardar_ca(Estadoguarda,oCa);
                if (Rpta.Equals("OK"))
                {
                    this.Listado_ca("%");
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
            this.Listado_ca(txt_buscar.Text.Trim());
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Estadoguarda = 1;//nuevo registro
            this.Estado(true);
            txt_descripcion_ca.Text = "";
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Estado(false);
            txt_descripcion_ca.Text = "";
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2;//actualiza registro
            this.Estado(true);
        }

        private void Dgv_principal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ncodigo = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_ca"].Value);
            txt_descripcion_ca.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion"].Value);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult cOpcion;
            cOpcion = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(cOpcion == DialogResult.Yes)
            {
                string Rpta= "";
                Rpta = N_Categorias.Eliminar_ca(Ncodigo);
                if(Rpta.Equals("OK"))
                {
                    this.Listado_ca("%");
                    Ncodigo = 0;
                    txt_descripcion_ca.Text = "";
                    MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
