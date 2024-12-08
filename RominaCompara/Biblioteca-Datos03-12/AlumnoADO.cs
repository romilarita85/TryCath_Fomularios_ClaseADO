//DATOS:
using BibliotecaDeAlumnos_Ado03_12;//Entidades
using MySql.Data.MySqlClient;
using Mysqlx.Connection;//Proveedor
namespace Biblioteca_Datos03_12
{
    public class AlumnoADO
    {
        //-Obtener conection-> crear un connectionString
        static string connectionString;
        //Constructor estatico-> q configura el conecctionString
        static AlumnoADO() 
        {
            connectionString = "Server = localhost; Database=escuela; User ID=root; Password=;SslMode=none;";
            //connectionString = "server=localhost;database=alumnos;uid=root;pwd=";
            //server=localhost;database=alumnos;uid=root;pwd=;
            //Server = localhost -> donde esta alojada mi base de datos(en el servidor php/myAdmin-xammp)
            //Database = escuela ->nombre de la base de datos
            //User ID = root;->identificador de la base de datos(por lo gral el root q es el administrador general)
            //Password =;->la contraseña no tiene q tener espacios
            //SslMode=none; ->propio de la base de datos
            //SELECT User, Host, authentication_string FROM mysql.user;
        }
        //Para cada accion del CRUD voy a hacer distintos metodos:
        //1-Metodo SELECT: voy a traer datos de la base de datos.
        public static List<Alumno> SeleccionarAlumnos() 
        {
            //-Crear la lista de tipo Alumno y la voy a retornar->obtengo datos desde la tabla
            List<Alumno> lista = new List<Alumno>();
            //-Crear la conexion a la base de datos-> Crear objeto del tipo MySqlconecctionString
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();//->Abrir conexion
            //-Establecer la consulta q quiero ejecutar: seleccionar todos los datos de una tabla
            string query = "SELECT * FROM alumnos";
            //string query = "SELECT * FROM alumnos WHERE genero = 'Femenino'";
            //string query = "SELECT * FROM alumnos WHERE genero = 'Femenino' order by edad asc";
            //-Creamos un comando: No puedo ejecutar directamente la consulta.
            //Tengo q entrenar a un objeto para q vaya a la base de datos a travez
            //del proveedor y le diga necesito executar esta consulta-> ese objeto es un comando
            //el comando necesita la consulta q quiero ejecutar y la conexion activa
            MySqlCommand comando = new MySqlCommand(query,conexion);//->le enseño al comando q columna quiero ejecutar
            
            //-Creo un DataReader:Si todo sale bien el comando va a necesitar ejecutar un metodo->ExecuteReader(comando para traer datos)
            MySqlDataReader reader = comando.ExecuteReader();//comando ejecuta el metodo
            //-Puedo agarrar y recorrer el reader:
            while (reader.Read())
            {//*Con lo q voy obteniendo del reader(con cada lectura) voy creando un objeto
                var miAlumno = new Alumno()//->objeto creado a travez de propiedades autoreferenciadas
                {//Con el reader tengo q ir obteniendo los distintos campos de la base de datos
                    Id = reader.GetInt32("id"),
                    Nombre = reader.GetString("nombre"),
                    Edad = reader.GetInt32("edad"),
                    Carrera = reader.GetString("carrera"),
                    MisMaterias = reader.GetString("materias"),
                    Genero = reader.GetString("genero"),
                    PagoMatricula = reader.GetBoolean("pagoMatricula")

                };
                //-Agrego el objeto miAlumno a la lista
                lista.Add(miAlumno);
            }
            conexion.Close();//cierro la conexion
            return lista;
        }
        //2-METODO PARA CREAR
        public static void IncertarAlumno(Alumno alumnito) 
        {
            //-Obtener conexion:
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();//->Abrir conexion
           //-Crear query:
            //string query = $"INSERT INTO alumnos(nombre,edad,carrera,materias,genero,pagoMatricula) value({alumnito.Nombre}, {alumnito.Edad},{alumnito.Carrera},{alumnito.Materias},{alumnito.Genero},{alumnito.PagoMatricula})";//->PROBLEMA DE INYECCION DE DATOS
            string query = $"INSERT INTO alumnos(nombre, edad, carrera, materias, genero, pagoMatricula) value" + "(@nombre, @edad, @carrera, @materias, @genero, @pagoMatricula)";
                                                 //(NOMBRE DE LA COLUMNA EN LA TABLA DE BASE DE DATOS) VALUE + (NOMBRE DEL PARAMETRO LOCAL CONFIGURADO DENTO DEL METODO CREAR)          
            //-Crear comando:
            MySqlCommand comando = new MySqlCommand(query, conexion);//->le enseño al comando q columna quiero ejecutar
           //-Enseñarle al comando cuales son los parametros con los q va a trabajar
            comando.Parameters.AddWithValue("@nombre", alumnito.Nombre);
                 //.parametros.agregar por valor (nombre del parametro,desde donde saco el valor del parametro)
            comando.Parameters.AddWithValue("@edad", alumnito.Edad);
            comando.Parameters.AddWithValue("@carrera", alumnito.Carrera);
            comando.Parameters.AddWithValue("@materias", alumnito.MisMaterias);
            comando.Parameters.AddWithValue("@genero", alumnito.Genero);
            comando.Parameters.AddWithValue("@pagoMatricula", alumnito.PagoMatricula);
            //-Ejecutar consulta:
            //Queremos ejecutar una accion- no tenemos q ejecutar el Reader-no queremos leer nada de la base de datos
            comando.ExecuteNonQuery();
        
        }
        public static void ModificarAlumno(Alumno alumnito) 
        {
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();//->Abrir conexion
            //-Crear query:         
            string query = $"UPDATE alumnos SET nombre=@nombre, edad = @edad, carrera = @carrera, materias = @materias, genero = @genero, pagoMatricula = @pagoMatricula WHERE id = @id";  
            //-Crear comando:
            MySqlCommand comando = new MySqlCommand(query, conexion);//->le enseño al comando q columna quiero ejecutar
            comando.Parameters.AddWithValue("@nombre", alumnito.Nombre);
            comando.Parameters.AddWithValue("@edad", alumnito.Edad);
            comando.Parameters.AddWithValue("@carrera", alumnito.Carrera);
            comando.Parameters.AddWithValue("@materias", alumnito.MisMaterias);
            comando.Parameters.AddWithValue("@genero", alumnito.Genero);
            comando.Parameters.AddWithValue("@pagoMatricula", alumnito.PagoMatricula);
            comando.Parameters.AddWithValue("@id", alumnito.Id);
            //-Ejecutar consulta:
            comando.ExecuteNonQuery();
        }
        public static void EliminarAlumno(int id)
        {
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();//->Abrir conexion
            //-Crear query:         
            string query = "DELETE FROM alumno WHERE id = @id";
            //-Crear comando:
            MySqlCommand comando = new MySqlCommand(query, conexion);//->le enseño al comando q columna quiero ejecutar
           
            comando.Parameters.AddWithValue("@id",id);
            //-Ejecutar consulta:
            comando.ExecuteNonQuery();
        }

    }
}
