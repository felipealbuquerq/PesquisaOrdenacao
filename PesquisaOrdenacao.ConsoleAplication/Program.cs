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
			listNumeros = metodosOrdenacao.InsertionSort(listNumeros.ToArray());

			//Exibição para o usuário
			Console.WriteLine ("Números ordenados por InsertionSort ou em português Ordenação por Inserção:");
			entradaSaidaUsuario.VisualizarNumeros (listNumeros);

			Console.ReadLine ();
		}
	}
}
