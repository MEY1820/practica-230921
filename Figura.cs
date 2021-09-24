using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_230921
{
    class Figura
    {
        // Definir Miembros
        // Propiedades 

        private int _figuraId;
        private string _forma;
        private string _angulo;

        // Propiedades autoimplementadas
        public string _nombre { get; set; }
        public string _lados { get; set; }

        // Metodos de propiedades
        // get-- obtiene el valor almacenado en la propiedad
        // set-- asignar

        public void setFiguraId(int figuraId)
        {
            _figuraId = figuraId;
        }
        public int getFiguraId()
        {
            return _figuraId;
        }

        //forma
        public void setForma(string forma)
        {
            _forma = forma;
        }
        public string getForma()
        {
            return _forma;
        }

        //_lados
        public void setlado(string lados)
        {
            _lados = lados;
        }
        public string getlados()
        {
            return _lados;
        }

    }
}

