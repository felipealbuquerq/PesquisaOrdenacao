using System;
using System.Collections.Generic;

namespace PesquisaOrdenacao.ConsoleAplication
{
	public class ControleEntradaSaida: IControleEntradaSaida
	{
		private List<int> numeros = new List<int>();
		private int quantidadeNumeros = 0;
		private string infoUsuario = string.Empty;

		public List<int> ColetarNumerosUsuario()
		{
			Console.WriteLine("Algoritimos de Ordenação");
			Console.WriteLine("Informe a quantidade de números:");
			infoUsuario = Console.ReadLine();
			int.TryParse(infoUsuario, out quantidadeNumeros);

			Console.WriteLine(string.Format("Informe {0} números inteiros: ", quantidadeNumeros));

			for (var posicao = 0; posicao < quantidadeNumeros; posicao++)
			{
				var numero = 0;
				infoUsuario = string.Empty;
				infoUsuario = Console.ReadLine();
				int.TryParse(infoUsuario, out numero);
				numeros.Add(numero);
			}

			return numeros;
		}

		public void VisualizarNumeros(List<int> listNumeros){
			foreach (var numero in listNumeros) {
				Console.WriteLine (numero);
			}
		}

		public void VisualizarNumeros (int[] listNumeros)
		{
			foreach (var numero in listNumeros) {
				Console.WriteLine (numero);
			}
		}
	}
}

