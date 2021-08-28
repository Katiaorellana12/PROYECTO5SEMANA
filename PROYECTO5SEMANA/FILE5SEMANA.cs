using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PROYECTO5SEMANA
{
    class FILE5SEMANA
    {
        static void Main()
        {
            bool showMenu = true;

            while (showMenu)
            {
                showMenu = Menu(); //llamdo al metodo Menu()
            }
            Console.ReadKey();
        }

        private static bool Menu()
        {
            //crear el menu para mostrar al usuario
            //Console.Clear(); //permite limpiar la consola
            Console.WriteLine("Seleccion la operación a realizar: ");
            Console.WriteLine("1. Registrar nueva cita");
            Console.WriteLine("2. Actualizar datos de las citas");
            Console.WriteLine("3. Mostrar listado de las listas");
            Console.WriteLine("4. Salir");
            Console.Write("\nOpcion: ");

            switch (Console.ReadLine())
            {
                case "1":
                    register(); //llamado al metodo registrar
                    return true;
                case "2":
                    updateData(); //llamdo al metodo para actualizar
                    Console.ReadKey();
                    return true;
                case "3":
                    //mostrar el contenido del archivo
                    Console.WriteLine("LISTADO DE CITAS");
                    foreach (KeyValuePair<object, object> data in readFile())
                    {
                        Console.WriteLine("{0}: {1}", data.Key, data.Value);
                    }
                    Console.ReadKey();
                    return true;
                case "4":
                    return false;
                default:
                    return false;
            }
        }
        //metodo para leer el contenido del archivo
        private static Dictionary<object, object> readFile()
        {
            //declarar el diccionario
            Dictionary<object, object> listData = new Dictionary<object, object>();

            //uso del StreamReader para leer el archivo
            using (var reader = new StreamReader(getPath()))
            {
                //variable para almacenar el contenido del archivo
                string lines;

                while ((lines = reader.ReadLine()) != null) //mientras no se encuentre una linea vacia se ejecuta el ciclo
                {
                    string[] keyvalue = lines.Split(';');
                    if (keyvalue.Length == 2)
                    {
                        listData.Add(keyvalue[0], keyvalue[1]);
                    }
                }

            }

            //retornar el diccionario
            return listData;
        }

        //metodo para buscar por clave
        private static bool search(string name)
        {
            if (!readFile().ContainsKey(name))
            {
                return false;
            }
            return true;
        }

        //metodo para actualizar
        private void mensaje()
        {
            Console.WriteLine("erick cano");
        }