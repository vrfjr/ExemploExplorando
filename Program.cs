using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();

p1.Nome = "Vagner";
p1.Sobrenome = "Jr";


Pessoa p2 = new Pessoa();

p2.Nome = "Eduardo";
p2.Sobrenome = "Jr";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();