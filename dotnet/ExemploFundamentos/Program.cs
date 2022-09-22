using ExemploFundamentos.Common.Models;

//ANALISAR ERRO
//Pessoa pessoa1 = new Pessoa();
//pessoa1.Nome = "Buta";
//pessoa1.Idade = 20;
//pessoa1.Apresentar();


// List<string> listString = new List<string>();
// listString.Add("SP");
// listString.Add("BA");
// listString.Add("MG");
// Console.WriteLine($"Itens na minha lista: {listString.Count} - Capacidade: {listString.Capacity}");
// listString.Add("SC");
// Console.WriteLine($"Itens na minha lista: {listString.Count} - Capacidade: {listString.Capacity}");
// listString.Remove("SC");
// Console.WriteLine($"Itens na minha lista: {listString.Count} - Capacidade: {listString.Capacity}");

// Console.WriteLine ("Percorrendo o array com o for");
// for (int contador = 0; contador < listString.Count; contador++){
//     Console.WriteLine($"Posição Nº {contador} - {listString[contador]}");
// }

// Console.WriteLine ("Percorrendo o array com o FOREACH");
// int contadorForeach = 0;
// foreach(string item in listString){
//     Console.WriteLine($"Posição Nº {contadorForeach} = {item}");
//     contadorForeach++;
// }

//Aumentando tamanho do array
// int[] arrayInteiros = new int[3];
// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// int[] arrayInteirosDobrado = new int[arrayInteiros.Length*2];
//Cria um novo resize e copia os antigos
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);
//Aumenta o número de array
// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
// Console.WriteLine ("Percorrendo o array com o for");
// for (int contador = 0; contador < arrayInteiros.Length; contador++){
//         Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }

// Console.WriteLine ("Percorrendo o array com o FOREACH");
// int contadorForeach = 0;
// foreach(int valor in arrayInteiros){
//     Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
//     contadorForeach++;
// }

// string opcao;
// bool exibirMenu = true;
// while(exibirMenu){
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1- Cadastrar cliente:");
//     Console.WriteLine("2- Buscar cliente");
//     Console.WriteLine("3- Apagar cliente");
//     Console.WriteLine("4- Encerrar");
//     opcao = Console.ReadLine();
//     switch(opcao){       
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar programa");
//             Environment.Exit(0);
//             break;
//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }
// }


// int soma = 0, numero = 0;
// do{
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());
//     soma += numero;
// } while(numero != 0);
// Console.WriteLine($"Total da soma dos números digitados é: {soma}");


// int numero = 5;
// int contador = 0;
// while(contador <= 10){
//     Console.WriteLine($"{numero} x {contador} = {numero * 1}");
//     contador ++;
//     if (contador == 6){
//         break;
//     }
// }
//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨
// for(int contador = 0; contador <= 10; contador++) {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }



//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨ INCREMENTANDO E DECREMENTANDO ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨//
// int numero = 10;
// Console.WriteLine(numero);
// Console.WriteLine("Incrementando o 10");
// numero = numero + 1;
// OU
// numero++;
// numero = numero - 1; 
// OU
// numero--;
// Console.WriteLine(numero);
//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨

//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨ CLASSE CALCULADORA ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨//
//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨
//Calculadora calc = new Calculadora();
// calc.Somar(5, 5);
// calc.Subtrair(20, 30);
// calc.Multiplicar(4, 7);
// calc.Divisao(40, 3);
//calc.Potencia(3,3);
//calc.Coseno(30);
//calc.Seno(30);
//calc.Tangente(30);
//calc.RaizQuadrada(9);

//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨



//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨CLASSE PESSOA¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨//                     
//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨
//ANALISAR ERRO
//Pessoa pessoa1 = new Pessoa();
//pessoa1.Nome = "Buta";
//pessoa1.Idade = 20;
//pessoa1.Apresentar();
// bool choveu = true;
// bool estaTarde = true;

// if (choveu && estaTarde){
//     Console.WriteLine("Vou pedalar");
// } else {
//     Console.WriteLine("Vou pedalar um outro dia");
// }
//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨



//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨
// bool possuiPresencaMinima = true;
// double media = 6.5;

// if (possuiPresencaMinima && media >= 7){
//     Console.WriteLine("Aprovado");
// }else {
//     Console.WriteLine("Reprovado");
// }

//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨


//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨
// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResposavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResposavel){
//     Console.WriteLine("Entrada liberada!");
// }else{
//     Console.WriteLine("Entrada não liberada!");
// }
//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨


//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨
// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();
// switch(letra){
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;    
// }
//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨


//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨
// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();
// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
//     {
//         Console.WriteLine("Vogal");
//     }else{
//         Console.WriteLine("Não é uma vogal");
//     }
//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨


//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨
// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 5;
// bool possivelVenda =  quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;
// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");
// if (quantidadeCompra == 0){
//     Console.WriteLine("Venda inválida");
// }else if (possivelVenda){
//     Console.WriteLine("Venda realizada.");
// }else{
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }
//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨

//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨
//Conversão para String (ToString está presente em todos os tipos)
// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);
//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨


//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨
// Cast - Casting (Processo de conversão)
// Convert = classe
// ToInt = método
// int a = Convert.ToInt32("5");
// int a = Convert.ToInt32(null);
// int a = int.Parse("5c")
// Console.WriteLine(a);
//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨

//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨
// int a = 10;
// int b = 20;
// int c = a + b;
// c = c + 5;
// c += 5;
// c-= 5;
// Console.WriteLine(c);
//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨


//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨
// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);
// DateTime dataCompleta = DateTime.Now.AddDays(5);
// Console.WriteLine(dataCompleta.ToString("dd/MM/yyyy HH:mm"));
//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨


//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨
// int quantidade = 1;
// Console.WriteLine("Quantidade: " + quantidade);
// quantidade =10;
// Console.WriteLine("Quantidade: " + quantidade);
//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨


//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨
// string apresentacao = "Olá, seja bem vindo!";
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;
// Console.WriteLine(apresentacao);
// Console.WriteLine("Quantidade: " + quantidade);
// Console.WriteLine("Altura: " + altura.ToString("0.00"));
// Console.WriteLine("Preço: " + preco);
// Console.WriteLine("Condição: " + condicao);
//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨


//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨
// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Geovanna";
// pessoa1.Idade = 22;
// pessoa1.Apresentar();
//¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨
