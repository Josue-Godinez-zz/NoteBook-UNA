using DataBaseAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
        public static MySqlService Instance
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

        public void CargarDatos(Dictionary<string, string> directionImages, List<string> persimos)
        {
            mySqlAccess.OpenConnection();
            DataTable dataTable = mySqlAccess.QuerySQL("Select * from categorias");
            if (dataTable.Rows.Count == 0)
            {
                foreach (var element in directionImages)
                {
                    mySqlAccess.EjectSQL("Insert Into categorias(`Nombre`, `Imagen`) values('" + element.Key + "', '" + element.Value + "');");
                    mySqlAccess.CommitTransaction();

                }
            }
            dataTable = mySqlAccess.QuerySQL("Select * from permisos");
            if (dataTable.Rows.Count == 0)
            {
                for(int x = 0; x < persimos.Count ; x++)
                {
                    mySqlAccess.EjectSQL("Insert Into permisos(`Accion`) values('" + persimos[x] + "');");
                    mySqlAccess.CommitTransaction();
                }  
            }
            mySqlAccess.CloseConnection();
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
                    User user = new User();
                    user.NameUser = result.Rows[x]["Nombre_Usuario"].ToString();
                    user.PasswordUser = DesencriptarString(result.Rows[x]["Contraseña"].ToString(),"");
                    user.Name = result.Rows[x]["Nombre"].ToString();
                    user.LastName = result.Rows[x]["Apellido"].ToString();
                    List<int> permisos = new List<int>();
                    DataTable userpermissions = mySqlAccess.QuerySQL("Select * from usuarios_permisos Where Usuarios_Nombre_Usuario = '" + user.NameUser + "';");
                    for (int y = 0; y < userpermissions.Rows.Count; y++)
                    {
                        user.Permissions.Add(Convert.ToInt32(userpermissions.Rows[y]["Permisos_ID_Permiso"]));
                    }
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
            Console.WriteLine(EncriptarString(user.PasswordUser, "").Length);
            mySqlAccess.OpenConnection();
            
            mySqlAccess.EjectSQL("Insert into usuarios values ('"+user.NameUser+"','"+EncriptarString(user.PasswordUser,"")+"','"+user.Name+"','"+user.LastName+"');");
            AsociarUsuarioPermisos(user);
            mySqlAccess.CommitTransaction();
            mySqlAccess.CloseConnection();
        }
        public void CrearLibro(Book book)
        {
            mySqlAccess.OpenConnection();
            mySqlAccess.EjectSQL("Insert Into libros (`Nombre`, `Privacidad`, `Imagen`, `Usuarios_Nombre_Usuario`) VALUES ('" + book.NameBook + "',"+ book.AccessBook +", '"+DireccionImagen(book) +"' ,'" + book.User.NameUser + "');");
            mySqlAccess.CommitTransaction();
            mySqlAccess.CloseConnection();
        }
        public void CrearNota(Note nota)
        {
            string privacidad = "0";
            if (nota.Privacity)
            {
                privacidad = "1";
            }
            mySqlAccess.OpenConnection();
            mySqlAccess.EjectSQL("INSERT INTO `notebook`.`notas` (`Titulo`, `Categoria`, `Contenido`, `Color Fondo`, `Fuente`, `Fecha Creacion`, `Fecha Modificacion`,`Color Letra`,`Privacidad` ) VALUES ('" + nota.Title + "', '" + nota.Category + "', '" + nota.GetContenido() + "', '" + nota.GetColorNota().Name + "', '" + nota.GetFuente().Name + "','" + nota.CreationDate.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + nota.ModificationDate.ToString("yyyy-MM-dd HH:mm:ss") + "','" + nota.GetColorLetra().Name + "','" + privacidad + "');");
            mySqlAccess.CommitTransaction();
            mySqlAccess.CloseConnection();
        }
        public int AsociarLibroNota(Book libro)
        {
            mySqlAccess.OpenConnection();
            DataTable result = mySqlAccess.QuerySQL("SELECT * FROM notas ORDER BY Id_Nota desc LIMIT 1;");
            int id_Nota = Convert.ToInt32(result.Rows[0]["Id_Nota"]);
            
          
            mySqlAccess.EjectSQL("Insert Into `notebook`.`libros_notas` (`Libros_ID_Libro`, `Notas_Id_Nota`) values('" + libro.Id + "', '" + id_Nota + "');");
           
            mySqlAccess.CloseConnection();
            Console.WriteLine(result.Rows[0]["Id_Nota"]);
            return id_Nota;
        }
        public List<Note> CargarNotas(Book libro)
        {
            try
            {
                mySqlAccess.OpenConnection();
                List<Note> notas = new List<Note>();
                DataTable result = mySqlAccess.QuerySQL("SELECT n.*, l.ID_Libro from notebook.libros l join notebook.libros_notas nl on nl.Libros_ID_Libro = l.ID_Libro join notebook.notas n on n.Id_Nota = nl.Notas_Id_Nota where l.ID_Libro = "+ libro.Id + "");
                for (int x = 0; x < result.Rows.Count; x++)
                {
                    Note nota = new Note();
                    nota.Title = result.Rows[x]["Titulo"].ToString();
                    nota.Category = result.Rows[x]["Categoria"].ToString();
                    nota.SetContenido (result.Rows[x]["Contenido"].ToString());
                    nota.SetColorNota (Color.FromName(result.Rows[x]["Color Fondo"].ToString()));
                    nota.SetFuente(new Font(result.Rows[x]["Fuente"].ToString(), 12));
                    nota.CreationDate = DateTime.Parse( result.Rows[x]["Fecha Creacion"].ToString());
                    nota.ModificationDate = DateTime.Parse(result.Rows[x]["Fecha Modificacion"].ToString());
                    nota.SetColorLetra(Color.FromName(result.Rows[x]["Color Letra"].ToString()));
                    nota.Privacity = Convert.ToBoolean(result.Rows[x]["Privacidad"]);
                    nota.User = libro.User.Name;
                    nota.SetId(Convert.ToInt32(result.Rows[x]["Id_Nota"].ToString()));            
                    notas.Add(nota);
                }
                mySqlAccess.CloseConnection();
                return notas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public List<Note> CargarNotas()
        {
            try
            {
                List<Note> notas = new List<Note>();
                List<User> usuarios = CargarUsuarios();
                foreach (User usuario in usuarios)
                {
                    List<Book> libros = CargarLibros(usuario);
                    foreach (Book libro in libros)
                    {
                        List<Note> notasLista = CargarNotas(libro);
                        foreach (Note nota in notasLista)
                        {
                            notas.Add(nota);
                        }
                    }
                         
                }
                return notas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<Note>();
            }
        }
        public void ActualizarNota(Note nota)
        {

            string privacidad = "0";
            if (nota.Privacity)
            {
                privacidad = "1";
            }

            mySqlAccess.OpenConnection();
            mySqlAccess.EjectSQL("UPDATE `notebook`.`notas` SET `Titulo` = '" + nota.Title + "', `Categoria` = '" + nota.Category + "', `Contenido` = '" + nota.GetContenido() + "', `Color Fondo` = '" + nota.GetColorNota().Name + "', `Fuente` = '" + nota.GetFuente().Name + "', `Fecha Creacion` = '" + nota.CreationDate.ToString("yyyy-MM-dd HH:mm:ss") + "', `Fecha Modificacion` = '" + nota.ModificationDate.ToString("yyyy-MM-dd HH:mm:ss") + "', `Color Letra` = '" + nota.GetColorLetra().Name + "', `Privacidad` = '" + privacidad + "' WHERE (`Id_Nota` = " + nota.GetId() + ");");
            mySqlAccess.CommitTransaction();
            mySqlAccess.CloseConnection();
        }
        public void BorrarNota(int id_nota, int id_libro)
        {
            mySqlAccess.OpenConnection();
            mySqlAccess.EjectSQL("DELETE FROM `notebook`.`libros_notas` WHERE (`Libros_ID_Libro` = " + id_libro + ") and (`Notas_Id_Nota` = " + id_nota + "); ");
            mySqlAccess.CommitTransaction();
            mySqlAccess.EjectSQL("DELETE FROM `notebook`.`notas` WHERE (`Id_Nota` = " + id_nota + ");");
            mySqlAccess.CommitTransaction();
            mySqlAccess.CloseConnection();
        }
        public void ModificarContraseña(User user)
        {
            mySqlAccess.OpenConnection();
            mySqlAccess.EjectSQL("Update usuarios set Contraseña = '"+EncriptarString(user.PasswordUser, "")+"' where Nombre_usuario='"+user.NameUser+"'");
            mySqlAccess.CommitTransaction();
            mySqlAccess.CloseConnection();
        }
        public List<Book> CargarLibros(User user)
        {
            try
            {
                mySqlAccess.OpenConnection();
                List<Book> books = new List<Book>();
                DataTable result = mySqlAccess.QuerySQL("SELECT * FROM libros where Usuarios_Nombre_Usuario = '" + user.NameUser + "' or Privacidad = 1;");
                for (int x = 0; x < result.Rows.Count; x++)
                {
                    int id_book = Convert.ToInt32(result.Rows[x]["ID_Libro"]);
                    Book book = new Book();
                    book.Id = id_book;
                    book.NameBook = result.Rows[x]["Nombre"].ToString();
                    book.ImageBook = result.Rows[x]["Imagen"].ToString();
                    book.AccessBook = Convert.ToBoolean(result.Rows[x]["Privacidad"]);
                    DataTable categories = mySqlAccess.QuerySQL("Select Categorias_Nombre from libros_categorias Where Libros_ID_Libro = " + id_book + "");
                    for (int y = 0; y < categories.Rows.Count; y++)
                    {
                        book.CategorieBook.Add(Convert.ToString(categories.Rows[y]["Categorias_Nombre"]));
                    }
                    string usuario = Convert.ToString(result.Rows[x]["Usuarios_Nombre_Usuario"]);
                    if (usuario != user.NameUser)
                    {
                        User usuarioDistinto = new User();
                        usuarioDistinto.NameUser = usuario;
                        book.User = usuarioDistinto;
                    }
                    else
                    {
                        book.User = user;
                    }
                    books.Add(book);
                }
                mySqlAccess.CloseConnection();
                return books;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void CrearCategorias(string categoria, string imagen)
        {
            try
            {
                mySqlAccess.OpenConnection();
                mySqlAccess.EjectSQL("Insert Into categorias(`Nombre`, `Imagen`) values('"+ categoria+"', '"+ DireccionImagen(imagen)+"');");
                mySqlAccess.CommitTransaction();
                mySqlAccess.CloseConnection();
            }
            catch(Exception ex)
            {

            }
        }
        public Dictionary<string, string> ObtenerCategorias()
        {
            mySqlAccess.OpenConnection();
            DataTable result = new DataTable();
            result = mySqlAccess.QuerySQL("Select * From categorias");
            Dictionary<string, string> categorieImage = new Dictionary<string, string>();
            for(int x = 0; x < result.Rows.Count; x++)
            {
                categorieImage.Add(Convert.ToString(result.Rows[x]["Nombre"]),Convert.ToString(result.Rows[x]["Imagen"]));
            }
            return categorieImage;
        }
        public void AsociarLibroCategoria(List<string> categorias)
        {
            mySqlAccess.OpenConnection();
            DataTable result = mySqlAccess.QuerySQL("SELECT * FROM libros ORDER BY ID_Libro desc LIMIT 1;");
            int id_libro = Convert.ToInt32(result.Rows[0]["ID_libro"]);
            for(int x = 0; x<categorias.Count; x++)
            {
                mySqlAccess.EjectSQL("Insert Into libros_categorias(`categorias_Nombre`, `libros_ID_Libro`) values('"+categorias[x]+"', '"+ id_libro+"');");
            }
            mySqlAccess.CloseConnection();
            Console.WriteLine(result.Rows[0]["ID_libro"]);
        }
        private string DireccionImagen(Book book)
        {
            string result = book.ImageBook;
            result = result.Replace('\\', '/');
            Console.WriteLine(result);
            return result;
        }
        private string DireccionImagen(string imagen)
        {
            string result = imagen;
            result = result.Replace('\\', '/');
            Console.WriteLine(result);
            return result;
        }
        public int BuscarLibro(Book book)
        {
            mySqlAccess.OpenConnection();
            DataTable result = mySqlAccess.QuerySQL("Select ID_Libro from libros where Usuarios_Nombre_Usuario = '" + book.User.NameUser + "' and Nombre='" + book.NameBook + "'");
            int id_libro = Convert.ToInt32(result.Rows[0]["ID_libro"]);
            mySqlAccess.CloseConnection();
            return id_libro;
        }
        public void ActualizarLibro(int id_libro, Book book)
        {
            Console.WriteLine(id_libro);
            mySqlAccess.OpenConnection();
            mySqlAccess.EjectSQL("Update libros set Nombre='"+book.NameBook+ "', Privacidad=" + book.AccessBook+ ", Imagen='"+book.ImageBook+"' where ID_Libro =" + id_libro+";");
            mySqlAccess.CommitTransaction();
            mySqlAccess.EjectSQL("Delete from libros_categorias where Libros_ID_Libro = "+id_libro+";");
            mySqlAccess.CommitTransaction();
            for(int x = 0; x< book.CategorieBook.Count; x++)
            {
                mySqlAccess.EjectSQL("Insert Into libros_categorias(`categorias_Nombre`, `libros_ID_Libro`) values('" + book.CategorieBook[x]+"',"+id_libro+")");
                mySqlAccess.CommitTransaction();
            }
            mySqlAccess.CloseConnection();
        }
        public void BorrarLibro(int id_libro)
        {
            mySqlAccess.OpenConnection();
            mySqlAccess.EjectSQL("Delete from libros_categorias where Libros_ID_Libro = " + id_libro + ";");
            mySqlAccess.CommitTransaction();
            mySqlAccess.EjectSQL("Delete From `libros` Where (`ID_Libro` =  "+id_libro+");");
            mySqlAccess.CommitTransaction();
            mySqlAccess.CloseConnection();
        }
        public void AsociarUsuarioPermisos(User user)
        {
            mySqlAccess.OpenConnection();
            DataTable dataTable = mySqlAccess.QuerySQL("Select * from permisos");
            for(int x=0; x<dataTable.Rows.Count;x++)
            {
                mySqlAccess.EjectSQL("Insert into usuarios_permisos (`Permisos_ID_Permiso`,`Usuarios_Nombre_Usuario`) values("+(x+1)+", '"+user.NameUser+"');");
            }
            mySqlAccess.CloseConnection();
        }
        private const string initVector = "EstaFacilExamen2";
        private const int keysize = 256;

        public static string EncriptarString(string plainText, string passPhrase)
        {
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipherTextBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            return Convert.ToBase64String(cipherTextBytes);
        }
        public static string DesencriptarString(string cipherText, string passPhrase)
        {
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        }
    }
}