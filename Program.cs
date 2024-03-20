namespace Ejercicio4Fichero
{
    /// <summary>
    /// Clase princicpal de la aplicacion
    /// irodhan -> 20/03/2024
    /// </summary>
    class Program 
    {
        /// <summary>
        /// Metodo principal de la aplicacion
        /// irodhan -> 20/03/2024
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {   
            //Ruta del fichero
            string fichero = "C:\\Users\\csi22-irodhan\\Desktop\\ficheroPrueba.txt";
            
            //Creamos un try{}catch para las excepciones
            try 
            {
                //Pedimos al usuario en que linea desea escribir
                Console.WriteLine("Indica la linea deseas escribir: ");
                int numeroLinea = Convert.ToInt32(Console.ReadLine());
                
                //Guardamos la informacion de la lista en un array
                string[] lineas = File.ReadAllLines(fichero);

                //Comprobamos que la linea  indicada este dentro del tamaño del array
                if (numeroLinea >= 1 && numeroLinea < lineas.Length)
                {
                    //Guardamos la linea indicada en un string
                    string linea = lineas[numeroLinea-1];
                    
                    //Pedimos al usuario la posicion de la linea donde desea escribir
                    Console.WriteLine("Indica la posicion en la que desea añadir texto: ");
                    int numeroPosicion=Convert.ToInt32(Console.ReadLine());

                    //Comprobamos que la posicion entre dentro del rango
                    if (numeroPosicion >= 1 && numeroPosicion <= linea.Length)
                    {
                        //Le pedimos al usuario lo que desea escribir en el fichero
                        Console.WriteLine("Que desea escribir: ");
                        string nuevoTexto = Console.ReadLine();

                        //Añadimos le texto indicado a la posicion
                        string nuevaLinea=linea.Insert(numeroPosicion, nuevoTexto);

                        //Modificamos la linea con el texto nuevo incluido
                        lineas[numeroLinea - 1] = nuevaLinea;

                        //Sobreescribimos el archivo con la nueva informacion
                        File.WriteAllLines(fichero,lineas);

                    }
                    else 
                    { 
                        Console.WriteLine("La posicion indicada esta fuera del rango de la linea");
                    }
                
                }
                else 
                { 
                    Console.WriteLine("La linea indicada no cioncide con el tamaño del fichero");
                }
            }
            catch (IOException e) 
            { 
                Console.WriteLine("La aplicacion no pudo leer o modificar el fichero "+e.Message);
            }
        }
    }
}
