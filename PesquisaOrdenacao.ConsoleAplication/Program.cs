﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PesquisaOrdenacao.ConsoleAplication
{
	using Interface;
	using Biblioteca;
	using Modelo;

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

			//Aplicando Algoritimo de Ordenação
			int[] numerosMergeSort = listNumeros.ToArray();
			metodosOrdenacao.MergeSort(ref numerosMergeSort, 0, numerosMergeSort.Length - 1);

			//Exibição para o usuário
			Console.WriteLine ("Números ordenados por MergeSort:");
			entradaSaidaUsuario.VisualizarNumeros (numerosMergeSort);

			//Pesquisa
			Console.WriteLine("Pesquisa");
			ResultadoPesquisa resultadoPesquisa = entradaSaidaUsuario.PesquisarNumero(numerosMergeSort, entradaSaidaUsuario.ColetarNumeroValido());
			entradaSaidaUsuario.ExibirNumero (resultadoPesquisa.Numero, resultadoPesquisa.Posicao);

			//Aplicando Algoritimo de Ordenação
			int[] numerosQuickSort = listNumeros.ToArray();
			metodosOrdenacao.QuickSort(ref numerosQuickSort);

			//Exibição para o usuário
			Console.WriteLine ("Números ordenados por QuickSort:");
			entradaSaidaUsuario.VisualizarNumeros (numerosQuickSort);

			//Pesquisa
			Console.WriteLine("Pesquisa");
			resultadoPesquisa = entradaSaidaUsuario.PesquisarNumero(numerosQuickSort, entradaSaidaUsuario.ColetarNumeroValido());
			entradaSaidaUsuario.ExibirNumero (resultadoPesquisa.Numero, resultadoPesquisa.Posicao);

			//Aplicando Algoritimo de Ordenação
			int[] numerosSelectionSort = listNumeros.ToArray();
			numerosSelectionSort = metodosOrdenacao.SelectionSort(numerosSelectionSort);

			//Exibição para o usuário
			Console.WriteLine ("Números ordenados por SelectionSort:");
			entradaSaidaUsuario.VisualizarNumeros (numerosSelectionSort);

			//Pesquisa
			Console.WriteLine("Pesquisa Binária - QuickSort");
			resultadoPesquisa = entradaSaidaUsuario.PesquisaBinaria(numerosQuickSort, entradaSaidaUsuario.ColetarNumeroValido());
			entradaSaidaUsuario.ExibirNumero (resultadoPesquisa.Numero, resultadoPesquisa.Posicao);

			//Aplicando Algoritimo de Ordenação
			int[] numerosShellSort = listNumeros.ToArray();
			numerosShellSort = metodosOrdenacao.ShellSort(numerosShellSort, numerosShellSort.Length);

			//Exibição para o usuário
			Console.WriteLine ("Números ordenados por ShellSort:");
			entradaSaidaUsuario.VisualizarNumeros (numerosShellSort);

			//Pesquisa
			Console.WriteLine("Pesquisa Binária - ShellSort");
			resultadoPesquisa = entradaSaidaUsuario.PesquisaBinaria(numerosShellSort, entradaSaidaUsuario.ColetarNumeroValido());
			entradaSaidaUsuario.ExibirNumero (resultadoPesquisa.Numero, resultadoPesquisa.Posicao);

			Console.ReadLine ();
		}
	}
}
