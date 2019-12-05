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

        }

        classCategorias(string nombreCategoria, string colorCategoria)
        {
            this.nombreCategoria = nombreCategoria;
            this.colorCategoria = colorCategoria; 
        }
    }
}
