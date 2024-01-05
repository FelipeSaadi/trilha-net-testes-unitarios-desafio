using TestesUnitarios.Desafio.Console.Services;

// Listas
ValidacoesLista validacoesLista = new();

List<int> lista = [3, 4, 2, 1];

var maiorValor = validacoesLista.RetornarMaiorNumeroLista(lista);
Console.WriteLine($"Maior valor: {maiorValor}");

var menorValor = validacoesLista.RetornarMenorNumeroLista(lista);
Console.WriteLine($"Menor valor: {menorValor}");

var multiplicacao = validacoesLista.MultiplicarNumerosLista(lista, 2);
Console.WriteLine($"Multiplicação de {String.Join(", ", lista)} é {String.Join(", ", multiplicacao)}");

int valor = 2;
Console.WriteLine($"A lista contem o valor {valor}?");
var contemNumero = validacoesLista.ListaContemDeterminadoNumero(lista, valor);

if(contemNumero) {
  Console.WriteLine("Sim");
}
else {
  Console.WriteLine("Não");
}

Console.WriteLine("");

// Strings
ValidacoesString validacoesString = new();

string texto = "Hello World";
string caractere = "o";

var contemCaractere = validacoesString.ContemCaractere(texto, caractere);
if(contemCaractere) {
  Console.WriteLine($"A palavra {texto} contém o caractere");
}
else {
  Console.WriteLine($"A palavra {texto} não contém o caractere");
}

var quantidadeCaracteres = validacoesString.RetornarQuantidadeCaracteres(texto);
Console.WriteLine($"O texto {texto} possui {quantidadeCaracteres} caracteres");

var terminaCom = validacoesString.TextoTerminaCom(texto, caractere);
if(terminaCom) {
  Console.WriteLine($"O texto {texto} temina com o caractere");
}
else {
  Console.WriteLine($"O texto {texto} não termina com o caractere");
}