using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consumir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            int ci = Convert.ToInt32(ci_e.Text);
            ServiceReference1.WebServiceSoap ws = new ServiceReference1.WebServiceSoapClient();
            string []datos;
            datos = ws.alumno(ci);
            nombre_s.Text = datos[0];
            paterno_s.Text = datos[1];
            materno_s.Text = datos[2];
            telefono_s.Text = datos[3];
        }
    }
}
