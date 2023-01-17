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
        //int Contador = 0;//inicializando variable para el uso del timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            ////if (Contador<100)
            ////{
            //    Contador++;
            //    txt_contador.Text = Convert.ToString(Contador);
            //    //  progressBar1.Value = Contador;
            //    progressBar1.Increment(1);
            //}
            //else
            //{
            //    timer1.Stop();
            //}

            //la segunda forma de trabajo con el progressbar y el timer
            if (progressBar1.Value < 100)
            {
                progressBar1.Increment(1);
                txt_contador.Text = Convert.ToString(progressBar1.Value);

            }else
            {
                timer1.Stop();
            }
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
