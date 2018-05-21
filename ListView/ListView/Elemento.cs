using System;
using System.Collections.Generic;
using System.Text;

namespace ListView
{
    public class Elemento
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }



    public class ListaElementos
    {
        public List<Elemento> _elementos { get; set; }

        public ListaElementos()
        {
            _elementos = new List<Elemento>();
            LoadElements();
        }

        public void LoadElements()
        {
            _elementos.Add(new Elemento
            {
                Nombre = "Andersson",
                Descripcion = "Equipo 1-Laptop"

            });
            _elementos.Add(new Elemento
            {
                Nombre = "Emersson",
                Descripcion = "Equipo 2-Escritorio"

            });

            _elementos.Add(new Elemento
            {
                Nombre = "Harris",
                Descripcion = "Equipo 3-Laptop"

            });
        }

    }
}
