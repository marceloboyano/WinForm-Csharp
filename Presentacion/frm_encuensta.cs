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
    public partial class frm_encuensta : Form
    {
        public frm_encuensta()
        {
            InitializeComponent();
        }

         private void btn_procesar_Click(object sender, EventArgs e)
        {
            string Resultado = "";

            if(chk_vfp.Checked == true)           
                Resultado += chk_vfp.Text+", ";
            

            if(chk_csharp.Checked == true)           
                Resultado += chk_csharp.Text + ", ";
           

            if(chk_vbnet.Checked == true)
                Resultado += chk_vbnet.Text + ", ";
            

            if(chk_java.Checked == true)           
                Resultado += chk_java.Text;


            //Evaluando proceso de selección de radiobutton
            if (rdb_presencial.Checked == true)
            {
                Resultado += " ::::: " + rdb_presencial.Text + " ::::: ";
            }
            else
            {
                Resultado += " ::::: " + rdb_virtual.Text + " ::::: ";
            }

            txt_resultado.Text = Resultado;
            
            
        }

      
    }
}
