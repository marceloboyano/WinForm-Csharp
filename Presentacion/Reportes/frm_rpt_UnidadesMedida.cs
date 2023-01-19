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
    public partial class frm_rpt_UnidadesMedida : Form
    {
        public frm_rpt_UnidadesMedida()
        {
            InitializeComponent();
        }

        private void frm_rpt_UnidadesMedida_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS_Reportes.USP_Listado_um' table. You can move, or remove it, as needed.
            this.USP_Listado_umTableAdapter.Fill(this.DS_Reportes.USP_Listado_um,cTexto:txt_p1.Text);

            this.reportViewer1.RefreshReport();
        }

       
    }
}
