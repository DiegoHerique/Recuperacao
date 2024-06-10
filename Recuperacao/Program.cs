using Recuperacao;

decimal cotacaoDolar = 5.29m;
decimal cotacaoEuro = 5.72m;
decimal cotacaoIene = 0.034m;
decimal cotacaoLibra = 6.72m;

Moeda dolar = new Moeda("Dólar", "Estados Unidos", cotacaoDolar, "Moeda norte-americana");
Moeda euro = new Moeda("Euro", "União Europeia", cotacaoEuro, "Moeda europeia");
Moeda iene = new Moeda("Iene", "Japão", cotacaoIene, "Moeda japonesa");
Moeda libra = new Moeda("Libra Esterlina", "Reino Unido", cotacaoLibra, "Moeda do Reino Unido");

Console.WriteLine("Digite o valor em reais (R$) que deseja converter:");
decimal valorEmReais;
while (!decimal.TryParse(Console.ReadLine(), out valorEmReais))
{
    Console.WriteLine("Valor inválido. Digite um valor numérico:");
}

Console.WriteLine("Selecione a moeda para a qual deseja converter:");
Console.WriteLine("1 - Dólar ($)");
Console.WriteLine("2 - Euro (€)");
Console.WriteLine("3 - Iene (¥)");
Console.WriteLine("4 - Libra Esterlina (£)");

int opcaoMoeda;
while (!int.TryParse(Console.ReadLine(), out opcaoMoeda) || opcaoMoeda < 1 || opcaoMoeda > 4)
{
    Console.WriteLine("Opção inválida. Selecione uma das opções de 1 a 4:");
}

Moeda moedaSelecionada = null;
switch ((MoedaTipo)opcaoMoeda - 1)
{
    case MoedaTipo.Dolar:
        moedaSelecionada = dolar;
        decimal valorDolar = moedaSelecionada.Converter(valorEmReais);
        Console.WriteLine($"Valor convertido: {moedaSelecionada.FormatacaoMoeda(valorDolar)}");
        break;
    case MoedaTipo.Euro:
        moedaSelecionada = euro;
        decimal valorEuro = moedaSelecionada.Converter(valorEmReais);
        Console.WriteLine($"Valor convertido: {moedaSelecionada.FormatacaoMoeda(valorEuro)}");
        break;
    case MoedaTipo.Iene:
        moedaSelecionada = iene;
        decimal valorIene = moedaSelecionada.Converter(valorEmReais);
        Console.WriteLine($"Valor convertido: {moedaSelecionada.FormatacaoMoeda(valorIene)}");
        break;
    case MoedaTipo.LibraEsterlina:
        decimal valorLibra = moedaSelecionada.Converter(valorEmReais);
        Console.WriteLine($"Valor convertido: {moedaSelecionada.FormatacaoMoeda(valorLibra)}");
        moedaSelecionada = libra;
        break;
}
