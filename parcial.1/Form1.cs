using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1Convertir_Click(object sender, EventArgs e)
        {
            int de, a;
            double cantidad, respuesta;

            de = cboDeConversores.SelectedIndex;
            a = cboAConversores.SelectedIndex;

            cantidad = double.Parse(txt1CantidadAconvertir.Text);
            double[] areas = { 1, 0.1317, 0.1111, 0.092903, 0.00014775, 0.00001317, 0.0000092903 };
            /*
            Pie Cuadrado
           Vara Cuadrada
           Yarda Cuadrada
           Metro Cuadrado
           Tareas
           Manzana
           Hectárea*/
            respuesta = areas[a] / areas [de] * cantidad;
            lbl4RespuestaDeConversor.Text = "Respuesta: " + Math.Round(respuesta, 3);
        }

        private void btnCerrarProgramaDeConversor_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
