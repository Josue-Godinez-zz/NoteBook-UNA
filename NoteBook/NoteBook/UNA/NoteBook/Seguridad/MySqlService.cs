using DataBaseAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.Notebook;
using UNA.NoteBook;

namespace NoteBook.UNA.NoteBook.Seguridad
{
    public class MySqlService
    {
        private static MySqlService _instance = null;
        private static MySqlAccess mySqlAccess; 
        private MySqlService()
        {

        }
        public static MySqlService Intance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MySqlService();
                    mySqlAccess = new MySqlAccess();
                    mySqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DateBaseNoteBook"].ConnectionString;
                }
                return _instance;
            }
        }

        public List<User> CargarUsuarios()
        {
            try
            {
                mySqlAccess.OpenConnection();
                DataTable result = new DataTable();
                result = mySqlAccess.QuerySQL("SELECT * FROM usuarios");
                List<User> usuarios = new List<User>();
                for (int x = 0; x < result.Rows.Count; x++)
                {
                    Console.WriteLine(result.Rows[x]["Nombre_Usuario"].ToString());
                    User user = new User();
                    user.NameUser = result.Rows[x]["Nombre_Usuario"].ToString();
                    user.PasswordUser = result.Rows[x]["Contraseña"].ToString();
                    user.Name = result.Rows[x]["Nombre"].ToString();
                    user.LastName = result.Rows[x]["Apellido"].ToString();
                    usuarios.Add(user);
                }
                mySqlAccess.CloseConnection();
                return usuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void CrearUsuario(User user)
        {
            mySqlAccess.OpenConnection();
            mySqlAccess.EjectSQL("Insert into usuarios values ('"+user.NameUser+"','"+user.PasswordUser+"','"+user.Name+"','"+user.LastName+"');");
            mySqlAccess.CommitTransaction();
            mySqlAccess.CloseConnection();
        }

        public void CrearLibro(Book book)
        {
            mySqlAccess.OpenConnection();
            mySqlAccess.EjectSQL("Insert Into libros (`Nombre`, `Imagen`, `Usuarios_Nombre_Usuario`) VALUES ('" + book.NameBook + "', '" + DireccionImagen(book) + "', '" + book.User.NameUser + "');");
            mySqlAccess.CommitTransaction();
            mySqlAccess.CloseConnection();
        }

        public void CargarLibros(User user)
        {
            mySqlAccess.OpenConnection();
            DataTable result =  mySqlAccess.QuerySQL("Select * From libros where Usuarios_Nombre_Usuario ="+user.NameUser+";");
            mySqlAccess.CloseConnection();
        }

        private string DireccionImagen(Book book)
        {
            string result = book.ImageBook;
            result = result.Replace('\\', '/');
            Console.WriteLine(result);
            return result;
        }
    }
}