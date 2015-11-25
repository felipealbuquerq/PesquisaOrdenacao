using System;

namespace PesquisaOrdenacao.Interface
{
	public interface IPesquisa
	{
		/// <summary>
		/// A pesquisa ou busca binária (em inglês binary search algorithm ou binary chop) é um algoritmo de busca em vetores
		/// que segue o paradigma de divisão e conquista. Ela parte do pressuposto de que o vetor está ordenado e realiza sucessivas divisões 
		/// do espaço de busca comparando o elemento buscado (chave) com o elemento no meio do vetor. Se o elemento do meio do vetor for a chave,
		/// a busca termina com sucesso. Caso contrário, se o elemento do meio vier antes do elemento buscado, então a busca continua na metade
		/// posterior do vetor. E finalmente, se o elemento do meio vier depois da chave, a busca continua na metade anterior do vetor. 
		/// </summary>
		/// <returns>Se retornar -1 o número não foi encontrado, caso contrário é retornada a posição onde o npumero estava.</returns>
		/// <param name="numeros">Numeros ordenados que possuem os números a serem pesquisados</param>
		/// <param name="filtro">Filtro é o número a ser pesquisado</param>
		int PesquisaBinaria (int[] numeros, int filtro);		
	}
}

