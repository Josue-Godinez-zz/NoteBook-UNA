﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook
{
    class classUsuario
    {
        private string nombreUsuario;
        private string contrasenaUsuario;
        public classUsuario()
        {
            nombreUsuario = "";
            contrasenaUsuario = "";
        }
        
        public classUsuario(string nombreUsuario, string contrasenaUsuario)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasenaUsuario = contrasenaUsuario;
        }

        public void setnombreUsuario(string nombreUsuario)
        {
            this.nombreUsuario = nombreUsuario;
        }

        public void setcontraseñaUsuario(string contrasenaUsuario)
        {
            this.contrasenaUsuario = contrasenaUsuario;
        }

        public string getnombreUsuario()
        {
            return nombreUsuario;
        }

        public string getcontraseñaUsuario()
        {
            return contrasenaUsuario;
        }
    }
}
