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
	}
}

