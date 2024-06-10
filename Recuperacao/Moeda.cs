using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacao
{
    public class Moeda
    {
            public string Nome { get; set; }
            public string Origem { get; set; }
            public decimal ValorEmReais { get; set; }
            public string Descricao { get; set; }

            public Moeda(string nome, string origem, decimal valorEmReais, string descricao)
            {
                Nome = nome;
                Origem = origem;
                ValorEmReais = valorEmReais;
                Descricao = descricao;
            }

            public decimal Converter(decimal valorEmReais)
            {
                return valorEmReais / ValorEmReais;
            }

            public string FormatacaoMoeda(decimal valor)
            {
                var cultura = new CultureInfo("en-US");
                switch (Nome)
                {
                    case "Dólar":
                        cultura = new CultureInfo("en-US");
                        break;
                    case "Euro":
                        cultura = new CultureInfo("fr-FR");
                        break;
                    case "Iene":
                        cultura = new CultureInfo("ja-JP");
                        break;
                    case "Libra Esterlina":
                        cultura = new CultureInfo("en-GB");
                        break;
                }
                return string.Format(cultura, "{0:C}", valor);
            }
    }
}
