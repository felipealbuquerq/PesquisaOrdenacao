using System;
using System.Collections.Generic;

namespace PesquisaOrdenacao.ConsoleAplication
{
	using Modelo;

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

		public void VisualizarNumeros (int[] numeros)
		{
			foreach (var numero in numeros) {
				Console.WriteLine (numero);
			}
		}

		public ResultadoPesquisa PesquisarNumero (int[] numeros, int filtro)
		{
			ResultadoPesquisa resultado = new ResultadoPesquisa(0, 0);

			for (int i = 0; i < numeros.Length; i++) {
				if (filtro == numeros[i]){
					resultado.Numero = filtro;
					resultado.Posicao = i;
				}
			}

			return resultado;
		}

		public void ExibirNumero (int numero, int posicao)
		{
			if (numero > 0) {
					Console.WriteLine (string.Format("O número encontrado é: {0} na posição {1}", numero, posicao));
			} else {
				Console.WriteLine ("Número não encontrado.");
			}
		}

		public int ColetarNumeroValido(){				
			Console.WriteLine("Informe um número válido: ");

			try
			{
				return Convert.ToInt32(Console.ReadLine());
			}
			catch 
			{
				return ColetarNumeroValido();                
			}
		}
	}
}

