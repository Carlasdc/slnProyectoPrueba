using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarCom_Click(object sender, EventArgs e)
        {
            Empleado empleado1 = new Empleado(0, "juan", "Perez"); 
            Empleado empleado2= new Empleado(1, "Marin", "Perez");
            MessageBox.Show(Empleado.Comision.ToString());
            Empleado empleado3 = new Empleado(0, "julia", "Perez");
            Empleado empleado4 = new Empleado(1, "julio", "Perez");
            Empleado.Comision = 50000;
            MessageBox.Show(Empleado.Comision.ToString());

        }
    }
}