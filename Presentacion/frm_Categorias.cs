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
                oCa.Codigo_ca = 0;
                oCa.Descripcion_ca = txt_descripcion_ca.Text.Trim();
                Rpta = N_Categorias.Guardar_ca(1,oCa);
            }
        }
    }
}
