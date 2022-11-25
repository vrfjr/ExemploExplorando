using ExemploExplorando.Models;
using System;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt_BR");

decimal valorMonetario = 82.40M;

Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));







// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);





// Pessoa p1 = new Pessoa(nome: "Vagner", sobrenome: "Jr");
// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Aquele La");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();