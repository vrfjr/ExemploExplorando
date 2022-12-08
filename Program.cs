using ExemploExplorando.Models;
using System;
using System.Globalization;



new ExemploExcecao().Metodo1();











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