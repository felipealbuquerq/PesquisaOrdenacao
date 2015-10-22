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

		public void MergeSort (ref int[] numeros, int esquerda, int direita)
		{
			int meio;

			if (direita > esquerda)
			{
				meio = (direita + esquerda) / 2;
				MergeSort(ref numeros, esquerda, meio);
				MergeSort(ref numeros, (meio + 1), direita);

				DoMerge(numeros, esquerda, (meio+1), direita);
			}				
		}

		private void DoMerge(int [] numeros, int esquerda, int meio, int direita)
		{
			int [] temp = new int[numeros.Length];
			int i, esquerda_end, num_elements, tmp_pos;

			esquerda_end = (meio - 1);
			tmp_pos = esquerda;
			num_elements = (direita - esquerda + 1);

			while ((esquerda <= esquerda_end) && (meio <= direita))
			{
				if (numeros[esquerda] <= numeros[meio])
					temp[tmp_pos++] = numeros[esquerda++];
				else
					temp[tmp_pos++] = numeros[meio++];
			}

			while (esquerda <= esquerda_end)
				temp[tmp_pos++] = numeros[esquerda++];

			while (meio <= direita)
				temp[tmp_pos++] = numeros[meio++];

			for (i = 0; i < num_elements; i++)
			{
				numeros[direita] = temp[direita];
				direita--;
			}				
		}
	}
}

