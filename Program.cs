using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Vagner", sobrenome: "Jr");
Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Aquele La");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();