using System;

namespace PesquisaOrdenacao.Modelo
{
	public class ResultadoPesquisa
	{
		public ResultadoPesquisa (int numero, int posicao)
		{
			Numero = numero;
			Posicao = posicao;
		}

		public int Numero { get; set; }
		public int Posicao { get; set; }
	}
}

