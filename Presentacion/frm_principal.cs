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
    public partial class frm_principal : Form
    {
        //instanciar los formularios de trabajo para el menu principal
        MiPrimerFormulario frm_01;
        frm_trackbar frm_02;
        frm_Categorias frm_ca;
        frm_Unidades_Medidas frm_um;
        
        public frm_principal()
        {
            InitializeComponent();
        }

        private void miPrimerFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_01 == null)
            {
              frm_01 = new MiPrimerFormulario();
              frm_01.MdiParent = this;
              frm_01.FormClosed += new FormClosedEventHandler(Alta_frm_01);
              frm_01.Show();
            }
            else
            {
                frm_01.Activate();
            }
        }

        void Alta_frm_01(object sender, EventArgs e)
        {
            frm_01 = null;
        }
        void Alta_frm_02(object sender, EventArgs e)
        {
            frm_02 = null;
        }

        void Alta_frm_ca(object sender, EventArgs e)
        {
            frm_ca = null;
        }

        void Alta_frm_um(object sender, EventArgs e)
        {
            frm_um = null;
        }
        private void trackBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_02 == null)
            {
                frm_02 = new frm_trackbar();
                frm_02.MdiParent = this;
                frm_02.FormClosed += new FormClosedEventHandler(Alta_frm_02);
                frm_02.Show();

            }
            else
            {
                frm_02.Activate();
            }
        }

        private void datosMestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void m_btn_01_Click(object sender, EventArgs e)
        {
            if (frm_01 == null)
            {
                frm_01 = new MiPrimerFormulario();
                frm_01.MdiParent = this;
                frm_01.FormClosed += new FormClosedEventHandler(Alta_frm_01);
                frm_01.Show();
            }
            else
            {
                frm_01.Activate();
            }
        }

        private void m_btn_02_Click(object sender, EventArgs e)
        {
            if (frm_02 == null)
            {
                frm_02 = new frm_trackbar();
                frm_02.MdiParent = this;
                frm_02.FormClosed += new FormClosedEventHandler(Alta_frm_02);
                frm_02.Show();

            }
            else
            {
                frm_02.Activate();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frm_ca == null)
            {
                frm_ca = new frm_Categorias();
                frm_ca.MdiParent = this;
                frm_ca.FormClosed += new FormClosedEventHandler(Alta_frm_ca);
                frm_ca.Show();
            }
            else
            {
                frm_ca.Activate();
            }
        }

        private void unidadesDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_um == null)
            {
                frm_um = new frm_Unidades_Medidas();
                frm_um.MdiParent = this;
                frm_um.FormClosed += new FormClosedEventHandler(Alta_frm_um);
                frm_um.Show();
            }
            else
            {
                frm_um.Activate();
            }
        }
    }
}
