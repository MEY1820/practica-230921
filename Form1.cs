using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_230921
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Instancia de la clase figura 

            Figura figura = new Figura();
            // MEDIANTE METODOS DE PROPIEDAD
            // Creamos un objeto figura
            //SET
            figura.setFiguraId(1);
            figura.setForma("Cuadrado");


            // Mostrar datos de figura
            //GET
            MessageBox.Show(figura.getFiguraId() + figura.getForma());

            //MEDIANTE PROPIEDAD AUTOIMPLEMENTADA
            //SET
            figura._lados = "Son 4 lados";

            //GET
            MessageBox.Show(figura._lados);

        }
    }
}
