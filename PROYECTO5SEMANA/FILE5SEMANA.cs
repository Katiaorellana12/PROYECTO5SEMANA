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
        
        private void mensaje()
        {
            Console.WriteLine("KATIA ORELLANA");
        }