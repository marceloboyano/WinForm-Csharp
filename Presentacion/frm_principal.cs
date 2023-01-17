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
    }
}
