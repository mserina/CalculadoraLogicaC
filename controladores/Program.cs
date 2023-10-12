using CalculadoraLogica.servicios;

namespace CalculadoraLogica
{
	/// <summary>
	/// Clase Principal
	/// fecha - msm
	/// </summary>
	class Program
	{
		/// <summary>
		/// Metodo menu, donde contendra el orden en el que se debe ejecutar los metodos
		/// fecha - msm
		/// </summary>
		/// <param name="args"></param>
		static void	Main(string[] args)
		{
			MenuInterfaz mi = new MenuImplementacion();
			OperacionInterfaz operacion = new OperacionImplementacion();
			bool cerrarMenu = false;
			int OpcionSeleccionada;

			while (!cerrarMenu) 
			{
				OpcionSeleccionada = mi.abrirMenuYrespuesta();

				switch (OpcionSeleccionada)
				{
					case 0:
						
						break;
                    case 1:
                        Console.WriteLine("Cerrando Menu");                
						cerrarMenu |= true;
                        break;
                    case 2:
                        Console.WriteLine("Ha seleccionado igualdad");
						operacion.igualdad();
                        break;
                    case 3:
                        Console.WriteLine("Ha seleccionado desigualdad");
                        operacion.desigualdad();
                        break;
                }
			
			}

		}

	}
}
