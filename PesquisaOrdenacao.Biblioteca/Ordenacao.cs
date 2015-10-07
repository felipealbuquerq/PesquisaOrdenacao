using System;
using System.Collections.Generic;
using System.Linq;

namespace PesquisaOrdenacao.Biblioteca
{
	using Interface;

	public class Ordenacao: IOrdenacao
	{
		public Ordenacao ()
		{
			
		}

		public List<int> InsertionSort (int[] numeros)
		{
			int posicaoAuxiliar, numeroEleito = 0;		

			for (int posicao = 1; posicao < numeros.Length; posicao++) {
				numeroEleito = numeros[posicao];
				posicaoAuxiliar = posicao;
				while ((posicaoAuxiliar > 0) && (numeros[posicaoAuxiliar -1] > numeroEleito)) {
					numeros[posicaoAuxiliar] = numeros[posicaoAuxiliar - 1];
					posicaoAuxiliar--;
				}
				numeros[posicaoAuxiliar] = numeroEleito;
			}
			return numeros.ToList();
		}		

		public int[] BubbleSort (int[] numeros)
		{
			int temp;

			for (int posicao = 0; posicao < numeros.Length; posicao++) {
				for (int sort = 0; sort < numeros.Length - 1; sort++) {
					if (numeros[sort] > numeros[sort + 1]) {
						temp = numeros[sort + 1];
						numeros[sort + 1] = numeros[sort];
						numeros[sort] = temp;
					}
				}
			}

			return numeros;
		}
	}
}

