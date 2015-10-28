using System;
using System.Collections.Generic;

namespace PesquisaOrdenacao.Interface
{
	public interface IOrdenacao
	{
		/// <summary>
		/// Insertion sort, ou ordenação por inserção, 
		/// é um simples algoritmo de ordenação, eficiente quando aplicado a um pequeno número de elementos. 
		/// Em termos gerais, ele percorre um vetor de elementos da esquerda para a direita 
		/// e à medida que avança vai deixando os elementos mais à esquerda ordenados. 
		/// O algoritmo de inserção funciona da mesma maneira com que muitas pessoas ordenam cartas em um jogo de baralho como o pôquer.
		/// </summary>
		/// <returns>Os números ordenados.</returns>
		/// <param name="numeros">Numeros a serem ordenados.</param>
		List<int> InsertionSort (int[] numeros);

		/// <summary>
		/// O bubble sort, ou ordenação por flutuação (literalmente "por bolha"), 
		/// é um algoritmo de ordenação dos mais simples. 
		/// A ideia é percorrer o vector diversas vezes, 
		/// a cada passagem fazendo flutuar para o topo o maior elemento da sequência. 
		/// Essa movimentação lembra a forma como as bolhas em um tanque de água procuram seu próprio nível, 
		/// e disso vem o nome do algoritmo.
		///No melhor caso, o algoritmo executa n operações relevantes, 
		/// onde n representa o número de elementos do vector. 
		/// No pior caso, são feitas n^2 operações. A complexidade desse algoritmo é de Ordem quadrática. 
		/// Por isso, ele não é recomendado para programas que precisem de velocidade e operem com quantidade elevada de dados.
		/// </summary>
		/// <returns>Os números ordenados.</returns>
		/// <param name="numeros">Numeros a serem ordenados.</param>
		int[] BubbleSort (int[] numeros);

		/// <summary>
		/// O merge sort, ou ordenação por mistura, ou até mesmo ordenação por entrechechamento, 
		/// é um exemplo de algoritmo de ordenação do tipo dividir-para-conquistar.
		///Sua ideia básica consiste em Dividir(o problema em vários sub-problemas e resolver esses sub-problemas através da recursividade) 
		/// e Conquistar(após todos os sub-problemas terem sido resolvidos ocorre a conquista que é a união das resoluções dos sub-problemas).
		/// Como o algoritmo do Merge Sort usa a recursividade em alguns problemas 
		/// esta técnica não é muito eficiente devido ao alto consumo de memória e tempo de execução.
		/// </summary>
		/// <param name="numeros">Numeros.</param>
		/// <param name="esquerda">Posição a Esquerda (Inicio, ex.: 0)</param>
		/// <param name="direita">Posição a Direita (Fim, ex.: tamanho -1, pois quando começa de zero é necessário subtrair uma posição)</param>
		void MergeSort (ref int[] numeros, int esquerda, int direita);
		/// <summary>
		/// O algoritmo Quicksort é um método de ordenação muito rápido e eficiente, inventado por C.A.R. Hoare em 1960, 
		/// quando visitou a Universidade de Moscovo como estudante. 
		/// Naquela época, Hoare trabalhou em um projeto de tradução de máquina para o National Physical Laboratory. 
		/// Ele criou o Quicksort ao tentar traduzir um dicionário de inglês para russo, ordenando as palavras, 
		/// tendo como objetivo reduzir o problema original em subproblemas que possam ser resolvidos mais fácil e rápido. 
		/// Foi publicado em 1962 após uma série de refinamentos.
		/// </summary>
		/// <param name="numeros">Numeros.</param>
		void QuickSort (ref int[] numeros);
	}
}

