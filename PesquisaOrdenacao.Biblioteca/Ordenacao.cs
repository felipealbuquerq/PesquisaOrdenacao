﻿using System;
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

		public void QuickSort (ref int[] numeros){
			Ordenar(numeros, 0, numeros.Length - 1);
		}

		private void Ordenar(int[] vetor, int inicio, int fim)
		{
			if (inicio < fim)
			{
				int posicaoPivo = Separar(vetor, inicio, fim);
				Ordenar(vetor, inicio, posicaoPivo - 1);
				Ordenar(vetor, posicaoPivo + 1, fim);
			}
		}

		private int Separar(int[] vetor, int inicio, int fim)
		{
			int pivo = vetor[inicio];
			int i = inicio + 1, f = fim;
			while (i <= f)
			{
				if (vetor[i] <= pivo)
					i++;
				else if (pivo < vetor[f])
					f--;
				else
				{
					int troca = vetor[i];
					vetor[i] = vetor[f];
					vetor[f] = troca;
					i++;
					f--;
				}
			}
			vetor[inicio] = vetor[f];
			vetor[f] = pivo;
			return f;
		}

		public int[] SelectionSort (int[] numeros){
			int min, aux;

			for (int i = 0; i < numeros.Length - 1; i++)
			{
				min = i;

				for (int j = i + 1; j < numeros.Length; j++)
					if (numeros[j] < numeros[min])
						min = j;

				if (min != i)
				{
					aux = numeros[min];
					numeros[min] = numeros[i];
					numeros[i] = aux;
				}
			}

			return numeros;
		}

		public int[] ShellSort(int[] numeros, int qtdeNumeros)
		{
			int i, j, incremento, temp;
			incremento = 3;
			while (incremento > 0)
			{
				for (i = 0; i < qtdeNumeros; i++)
				{
					j = i;
					temp = numeros[i];
					while ((j >= incremento) && (numeros[j - incremento] > temp))
					{
						numeros[j] = numeros[j - incremento];
						j = j - incremento;
					}
					numeros[j] = temp;
				}
				if (incremento / 2 != 0)
					incremento = incremento / 2;
				else if (incremento == 1)
					incremento = 0;
				else
					incremento = 1;
			}

			return numeros;
		}
	}
}

