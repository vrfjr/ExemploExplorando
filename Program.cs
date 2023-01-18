using ExemploExplorando.Models;
using System;
using System.Globalization;






(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Vagner", "Figueiredo", 1.80M );

// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Vagner", "Figueiredo", 1.80M );
// var outroExemploTuplaCreate = Tupla.Create(1, "Vagner", "Figueiredo", 1.80M );


Console.WriteLine($"id: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");












// <chave, valor>

// Dictionary<string, string> estados = new Dictionary<string, string>();


// estados.Add("SP", "São Paulo");
// estados.Add("RJ", "Rio de Janeiro");
// estados.Add("MG", "Minas Gerais");

// Console.WriteLine(estados["MG"]);


// foreach (KeyValuePair<string, string> item in estados)

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }


//  Console.WriteLine($"removendo o SP ");
//  estados.Remove("SP");


// Console.WriteLine($"alterando Rio ");
// estados["RJ"] = "Rio - Valor alterado";

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }


// string chave = "MG2";
// Console.WriteLine($"verificando o elemtno {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor ja existe {chave}");

// }
// else{
//     Console.WriteLine($"Pode adicionar a {chave}");
// }




// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);


// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }




// Console.WriteLine($"Removendo da fila o numero {pilha.Pop()}");

// //add numero 20
// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }







// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }
//  Console.WriteLine($"Removendo da fila o numero {fila.Dequeue()}");


// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

//  Console.WriteLine($"Removendo da fila o numero {fila.Dequeue()}");


// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }
//  Console.WriteLine($"Removendo da fila o numero {fila.Dequeue()}");


// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }
//  Console.WriteLine($"Removendo da fila o numero {fila.Dequeue()}");


// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }




// new ExemploExcecao().Metodo1();











// try {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

// foreach(string linha in linhas){
//     Console.WriteLine(linha);
// }
// } catch (FileNotFoundException ex1)
// {
//     Console.WriteLine($"Arquivo nao encontrado. {ex1.Message}");
// }catch (DirectoryNotFoundException ex2)
// {
//     Console.WriteLine($"Caminho da pasta nao encontrado. {ex2.Message}");
// }catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }finally{
//     Console.WriteLine("Chegou ate aqui");
// }




// string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

// foreach(string linha in linhas){
//     Console.WriteLine(linha);
// }








// data

// string dataString = "2022-12-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// ////// DateTime.TryParseExact(string, formatado que esta string, cultura ou padrao, estilo, variavel que ele vai jogar);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data valida");
// }





// DateTime data = DateTime.Parse("17/04/2022 18:00");

// Console.WriteLine(data);


// Console.WriteLine(data.ToShortTimeString());

// Console.WriteLine(data.ToShortDateString());

// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// Console.WriteLine(data.ToString("dd-MM-yyyy HH:mm"));










// Formatação

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt_BR");

// decimal valorMonetario = 82.40M;


// Console.WriteLine(valorMonetario.ToString("C2"));


// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##"));

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));







// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);





// Pessoa p1 = new Pessoa(nome: "Vagner", sobrenome: "Jr");
// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Aquele La");


// p1.Idade = 1;
// p1.Apresentar();

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();