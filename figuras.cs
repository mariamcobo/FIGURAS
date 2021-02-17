using System;
using System.Collections.Generic;
using System.Text;

namespace FIGURAS
{
	public class figuras
	{
		//public decimal area { get; set; } Otra forma que no usaremos
		double area = 0, lado = 0, ancho = 0, largo = 0, radio = 0;

		public void areaCuadrado()
		{
			Console.WriteLine("Escribe el lado ");
			lado = Convert.ToDouble(Console.ReadLine());
			area = lado * lado;
			Console.WriteLine("El resultado es: " + area);
		}

		public void areaRectangulo()
		{
			Console.WriteLine("Escribe el ancho del rectángulo ");
			ancho = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Escribe el largo del rectángulo ");
			largo = Convert.ToDouble(Console.ReadLine());
			area = ancho * largo;
			Console.WriteLine("El resultado es: " + area);
		}

		public void areaCirculo()
		{
			Console.WriteLine("Escribe el radio del círculo ");
			radio = Convert.ToDouble(Console.ReadLine());

			area = Math.PI * (radio * radio);
			Console.WriteLine("El resultado es: " + area);
		}
	}
}
