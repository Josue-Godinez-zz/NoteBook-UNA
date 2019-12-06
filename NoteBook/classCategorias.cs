using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook
{
    public class classCategorias
    {
        private string nombreCategoria;
        private string colorCategoria;
        
        classCategorias()
        {
            nombreCategoria = "";
            colorCategoria = "";
        }

        classCategorias(string nombreCategoria, string colorCategoria)
        {
            this.nombreCategoria = nombreCategoria;
            this.colorCategoria = colorCategoria; 
        }

        public void setnombreCategoria(string nombreCategoria)
        {
            this.nombreCategoria = nombreCategoria;
        }

        public void setcolorCategoria(string colorCategoria)
        {
            this.colorCategoria = colorCategoria;
        }

        public string getnombreCotegoria()
        {
            return nombreCategoria;
        }

        public string getcolorCategoria()
        {
            return colorCategoria;
        }


    }
}
