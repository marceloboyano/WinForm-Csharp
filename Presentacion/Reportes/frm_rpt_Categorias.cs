using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Reportes
{
    public partial class frm_rpt_Categorias : Form
    {
        public frm_rpt_Categorias()
        {
            InitializeComponent();
        }

        private void frm_rpt_Categorias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS_Reportes.USP_Listado_ca' table. You can move, or remove it, as needed.
            this.USP_Listado_caTableAdapter.Fill(this.DS_Reportes.USP_Listado_ca,cTexto: txt_p1.Text);            
            this.reportViewer1.RefreshReport();
        }

       

        private void txt_p1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
