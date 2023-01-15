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
    public partial class frm_tiempo : Form
    {
        public frm_tiempo()
        {
            InitializeComponent();
        }
        int Contador = 0; //inicializando variable para el uso del timer
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            Contador++;
            txt_contador.Text = Convert.ToString(Contador);
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_detener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
