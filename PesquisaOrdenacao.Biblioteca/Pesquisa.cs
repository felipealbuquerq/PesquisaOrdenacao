using System;

namespace PesquisaOrdenacao.Biblioteca
{
	using Interface;

	public class Pesquisa: IPesquisa
	{
		public Pesquisa ()
		{		
		}

		public int PesquisaBinaria (int[] numeros, int filtro){
			//Ordena o vetor
			Array.Sort(numeros);

			int meio;
			int Min = 0;
			int Max = numeros.Length - 1;

			do
			{
				meio = (int)(Min + Max) / 2;
				if (numeros[meio] == filtro)
				{
					//Retorna a posição do número na seqüencia.
					return meio;
				}
				else if (filtro > numeros[meio])
					Min = meio + 1;
				else
					Max = meio - 1;
			}
			while (Min <= Max);

			//Caso o retorno for -1, então o número não existe na seqüencia.
			return -1;
		}
	}
}

