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
    public partial class MiPrimerFormulario : Form
    {

        public MiPrimerFormulario()
        {
            InitializeComponent();
        }

        //Inicio de mis variables
        int NestatadoGuarda = 0;

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            NestatadoGuarda = 1;//Nuevo registro
            lst_mantenimiento.Enabled= false;

            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            grb_mantenimiento.Enabled = true;
            txt_codigo.Enabled = true;

            grb_botones_principales.Enabled = false;

            //txt_codigo.Select(); hay 2 formas de hacerlo pero lo adecuado sería el focus
            txt_codigo.Focus();

          

        }

        private void MiPrimerFormulario_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            grb_mantenimiento.Enabled = false;

            grb_botones_principales.Enabled = true;

            lst_mantenimiento.Enabled = true;

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string Registro;
            Registro= txt_codigo.Text.Trim() +" | "+ txt_descripcion.Text.Trim();

            if (NestatadoGuarda == 1)//Nuevo registro
            {
                lst_mantenimiento.Items.Add(Registro);

            }
            else //Actualizar  registro
            {
                int ElementoSeleccionado = lst_mantenimiento.SelectedIndex;
                lst_mantenimiento.Items.Remove(lst_mantenimiento.SelectedItem);
                lst_mantenimiento.Items.Insert(ElementoSeleccionado, Registro);
            }


            MessageBox.Show("Datos Guardados");

            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            grb_mantenimiento.Enabled = false;
            grb_botones_principales.Enabled = true;

            lst_mantenimiento.Enabled = true;


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            lst_mantenimiento.Items.Remove(lst_mantenimiento.SelectedItem);

            MessageBox.Show("Elemento eliminado");
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            NestatadoGuarda = 2;//Actualizar registro
            lst_mantenimiento.Enabled = false;

            grb_mantenimiento.Enabled = true;
            txt_codigo.Enabled= false;

            grb_botones_principales.Enabled = false;

            txt_codigo.Focus();
        }

        private void lst_mantenimiento_Click(object sender, EventArgs e)
        {
            string TextoSeleccionado;
            int LongitudTexto;
            
            TextoSeleccionado = lst_mantenimiento.SelectedItem.ToString().Trim();
            LongitudTexto = TextoSeleccionado.Length;
            txt_codigo.Text = TextoSeleccionado.Substring(0, 3);
            txt_descripcion.Text = TextoSeleccionado.Substring(6, LongitudTexto-6);
        }

      
    }
}
