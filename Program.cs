using System;

namespace FIGURAS
{
    class Program
    {
        static void Main(string[] args)
        {

            try 
            {
                int n = 1;

                for(int i = 0; i<n; i++)
                {
                    Console.WriteLine("¿Desea utilizar la aplicación? <S/N> \n");
                    string valor = Console.ReadLine();

                    if (valor.ToUpper() == "S")
                    {
                        Console.WriteLine("Escribe la figura de la que desea calcular el Área: \n" +
                    "1. Cuadrado \n" + "2. Rectángulo \n" + "3. Círculo \n");
                        string opcion = "";
                        figuras figuras = new figuras();
                        switch (opcion)
                        {
                            case "1": figuras.areaCuadrado(); break;
                            case "2": figuras.areaRectangulo(); break;
                            case "3": figuras.areaCirculo(); break;
                            default: Console.WriteLine("Opción elegida no válida"); break;
                        }
                        n++;
                    }

                    else if (valor == "N" || valor == "n") //Otra forma sin el "ToUpper"
                    {
                        return; //Termina la función principal y se termina la ejecución en curso
                    }
                }
                Console.ReadKey();
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("La aplicación ha fallado. Contacte con su técnico" + ex.Message);
            }   
        }
    }
}
