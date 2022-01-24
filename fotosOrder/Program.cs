using System;
using System.IO;

namespace fotosOrder
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("\n **************************************************************************");
            Console.WriteLine("\n   Bienvenido a la aplicación para el ordenamiento de archivos por fecha!");
            Console.WriteLine("\n **************************************************************************\n");

            Console.WriteLine("\n Carpeta con archivos a ordenar: ");
            Console.WriteLine("\n Ejemplo: c:\\miCarpetaDeFotosDesordenada");
            Console.Write("\n ");
            string sourceDirectory = Console.ReadLine();

            Console.WriteLine("\n Carpeta donde se van a guardar los archivos: ");
            Console.WriteLine("\n Ejemplo: c:\\CarpetaFotosOrdenada");
            Console.Write("\n ");
            string newDirectory = Console.ReadLine();

            Console.WriteLine("\n ****************************************************************************");
            Console.WriteLine($"\n Carpeta con los archivos desordenados: {sourceDirectory}");
            Console.WriteLine("\n ****************************************************************************");
            Console.WriteLine($"\n Carpeta con los archivos ordenados: {newDirectory}{Path.DirectorySeparatorChar}");
            Console.WriteLine("\n ****************************************************************************");

            Console.Write("\n Presione enter para continuar");
            string temp = Console.ReadLine();

            var foundFiles = Directory.EnumerateFiles(sourceDirectory, "*.*", SearchOption.AllDirectories); // variable que almacena los nombres de los archivos a ordenar

            foreach (var file in foundFiles)
            {
                FileInfo info = new(file);

                var creacionFile = File.GetLastWriteTime(file).ToString();


                File.SetAttributes(file, FileAttributes.Normal);

                //var raiz = "e:";

                Console.WriteLine($"\n\n\tFull Name: {info.FullName}"); // info.Fullname almacena la ruta completa de mi archivo

                var monthFile = creacionFile.Substring(3, 2);
                var yearFile = creacionFile.Substring(6, 4);
                var nameFile = info.Name;

                if (info.Name != "Thumbs.db")
                {
                    switch (monthFile)
                    {
                        case "01":
                            Directory.CreateDirectory($"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}01.Enero");
                            File.Move(info.FullName, $"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}01.Enero{Path.DirectorySeparatorChar}{nameFile}", true);
                            break;
                        case "02":
                            Directory.CreateDirectory($"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}02.Febrero");
                            File.Move(info.FullName, $"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}02.Febrero{Path.DirectorySeparatorChar}{nameFile}", true);
                            break;
                        case "03":
                            Directory.CreateDirectory($"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}03.Marzo");
                            File.Move(info.FullName, $"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}03.Marzo{Path.DirectorySeparatorChar}{nameFile}", true);
                            break;
                        case "04":
                            Directory.CreateDirectory($"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}04.Abril");
                            File.Move(info.FullName, $"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}04.Abril{Path.DirectorySeparatorChar}{nameFile}", true);
                            break;
                        case "05":
                            Directory.CreateDirectory($"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}05.Mayo");
                            File.Move(info.FullName, $"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}05.Mayo{Path.DirectorySeparatorChar}{nameFile}", true);
                            break;
                        case "06":
                            Directory.CreateDirectory($"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}06.Junio");
                            File.Move(info.FullName, $"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}06.Junio{Path.DirectorySeparatorChar}{nameFile}", true);
                            break;
                        case "07":
                            Directory.CreateDirectory($"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}07.Julio");
                            File.Move(info.FullName, $"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}07.Julio{Path.DirectorySeparatorChar}{nameFile}", true);
                            break;
                        case "08":
                            Directory.CreateDirectory($"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}08.Agosto");
                            File.Move(info.FullName, $"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}08.Agosto{Path.DirectorySeparatorChar}{nameFile}", true);
                            break;
                        case "09":
                            Directory.CreateDirectory($"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}09.Septiembre");
                            File.Move(info.FullName, $"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}09.Septiembre{Path.DirectorySeparatorChar}{nameFile}", true);
                            break;
                        case "10":
                            Directory.CreateDirectory($"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}10.Octubre");
                            File.Move(info.FullName, $"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}10.Octubre{Path.DirectorySeparatorChar}{nameFile}", true);
                            break;
                        case "11":
                            Directory.CreateDirectory($"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}11.Noviembre");
                            File.Move(info.FullName, $"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}11.Noviembre{Path.DirectorySeparatorChar}{nameFile}", true);
                            break;
                        case "12":
                            Directory.CreateDirectory($"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}12.Diciembre");
                            File.Move(info.FullName, $"{newDirectory}{Path.DirectorySeparatorChar}{yearFile}{Path.DirectorySeparatorChar}12.Diciembre{Path.DirectorySeparatorChar}{nameFile}", true);
                            break;
                        default:
                            Console.WriteLine("Ha ocurrido un error y no se por que??");
                            break;
                    }
                    if (info.Name == "Thumbs.db")
                        File.Delete(file);
                }
            }

        }
    }
}

