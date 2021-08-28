using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectosemana_5
{
    class Program
    {
        static void Main(string[] args)
        {
            private static void updateData()
            {
                //solicitar el elemnto a modificar
                Console.Write("Escriba el nombre de la persona que realizo para actualizar: ");
                var name = Console.ReadLine();

                //realizar la busqueda
                if (search(name))
                {
                    Console.WriteLine("El registro existe!");
                    Console.Write("Nueva Cita: ");
                    var newAge = Console.ReadLine();

                    //declarar un diccionario
                    Dictionary<object, object> temp = new Dictionary<object, object>();
                    temp = readFile();

                    temp[name] = newAge; //actualizar el valor
                    Console.WriteLine("El registro ha sido actualizado!");
                    File.Delete(getPath()); //eliminamos archivos y posteriormente lo volvemos a crear

                    using (StreamWriter sw = File.AppendText(getPath()))
                    {
                        //leer diccionario temporal y almacenar los elementos en el archivo
                        foreach (KeyValuePair<object, object> values in temp)
                        {
                            sw.WriteLine("{0}; {1}", values.Key, values.Value);
                            // sw.Close();
                        }
                    }

                }
                else
                {
                    Console.WriteLine("El registro no se encontro!");
                }
            }
        }
    }
}
    

