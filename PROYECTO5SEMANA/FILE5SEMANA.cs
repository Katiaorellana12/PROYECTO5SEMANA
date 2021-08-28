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

        //metodo para obtener la ruta del archivo
        private static string getPath()
        {
            string PROYECTO = @"C:\DATOS\datos.txt";
            return PROYECTO;
        }

        //metodo para registrar datos en el archivo
        private static void register()
        {
            //solicitar los datos del estudiante
            Console.WriteLine("DATOS PARA CITA");
            Console.Write("Nombre Completo: ");
            string fullname = Console.ReadLine();
            Console.Write("Dia de la cita: ");
            string age = (Console.ReadLine());

            //crear el archivo, uso de StreamWriter para escribir el archivo
            using (StreamWriter sw = File.AppendText(getPath()))
            {
                sw.WriteLine("{0}; {1}", fullname, age);
                sw.Close();
            }
        }

    }
}

