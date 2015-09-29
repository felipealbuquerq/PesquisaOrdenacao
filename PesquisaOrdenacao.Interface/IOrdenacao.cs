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
	}
}

