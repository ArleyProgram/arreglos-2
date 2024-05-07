class Program
{
	static void Main(string[] args)
	{
		int a = 3;
		string[] estudiantes = new string[] { "Pablo", "Lukas" };
		string[] materias = new string[] { "Catedra", "Algebra", "Seminario" };
		double[,] notas = new double[estudiantes.Length, materias.Length * a]; 
		double[] promedio = new double[estudiantes.Length];

		for (int i = 0; i < estudiantes.Length; i++)
		{
			for (int j = 0; j < materias.Length; j++)
			{
				Console.WriteLine($"{estudiantes[i]} por favor ingresar sus calificaciones en {materias[j]}");
				for (int k = 0; k < a; k++) 
				{
					notas[i, j * a + k] = Convert.ToDouble(Console.ReadLine());
				}
			}
		}

		for (int i = 0; i < estudiantes.Length; i++)
		{
			for (int j = 0; j < materias.Length; j++)
			{
				double suma = 0;
				for (int k = 0; k < a; k++)
				{
					suma += notas[i, j * a + k];
				}
				double notaFinal = suma / a;
				Console.WriteLine($"Estudiante: {estudiantes[i]}, Materia: {materias[j]}, Nota Final: {notaFinal}");
				promedio[i] += notaFinal;
			}
			promedio[i] /= materias.Length;
			Console.WriteLine($"Promedio de {estudiantes[i]}: {promedio[i]}");
		}
	}
}
