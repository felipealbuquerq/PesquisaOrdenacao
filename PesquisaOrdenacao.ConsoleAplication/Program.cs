using System;
using System.Collections.Generic;

namespace PesquisaOrdenacao.ConsoleAplication
{
	using Interface;
	using Biblioteca;

	class Programa
	{
		static void Main(string[] args)
		{
			//Instanciando Métodos da Camada de Exibição
			IControleEntradaSaida entradaSaidaUsuario = new ControleEntradaSaida ();

			//Instanciando Métodos da Biblioteca Usada em Outras Camadas
			IOrdenacao metodosOrdenacao = new Ordenacao();

			//Dados de Entrada
			List<int> listNumeros = entradaSaidaUsuario.ColetarNumerosUsuario ();

			//Visualizando Dados de Entrada
			Console.WriteLine ("Números na ordem digitada:");
			entradaSaidaUsuario.VisualizarNumeros(listNumeros);

			//Aplicando Algoritimo de Ordenação
			var listNumerosInsertionSort = metodosOrdenacao.InsertionSort(listNumeros.ToArray());

			//Exibição para o usuário
			Console.WriteLine ("Números ordenados por InsertionSort ou em português ordenação por Inserção:");
			entradaSaidaUsuario.VisualizarNumeros (listNumerosInsertionSort);

			//Aplicando Algoritimo de Ordenação
			var listNumerosBubbleSort = metodosOrdenacao.BubbleSort(listNumeros.ToArray());

			//Exibição para o usuário
			Console.WriteLine ("Números ordenados por BubbleSort ou em português ordenação por flutuação (literalmente \"por bolha\"):");
			entradaSaidaUsuario.VisualizarNumeros (listNumerosBubbleSort);

			Console.ReadLine ();
		}
	}
}
