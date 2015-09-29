using System;
using System.Collections.Generic;

namespace PesquisaOrdenacao.ConsoleAplication
{
	/// <summary>
	/// Eu controlo a entrada e saida.
	/// </summary>
	public interface IControleEntradaSaida
	{
		/// <summary>
		/// Coletar os numeros a serem ordenados escolhidos pelo usuario.
		/// </summary>
		/// <returns>Os numeros que o usuario informou.</returns>
		List<int> ColetarNumerosUsuario ();
		/// <summary>
		/// Visualizar os numeros via aplicação console.
		/// </summary>
		/// <param name="listNumeros">Lista de numeros a serem exibidos.</param>
		void VisualizarNumeros(List<int> listNumeros);
	}
}

