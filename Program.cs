using c_.Models;

Pessoa pessoa1 = new Pessoa("Gustavo", "Siqueira");
Pessoa pessoa2 = new Pessoa("Brena", "Paiva");


// pessoa1.Profissao = "Analista de Sistemas";
// pessoa1.Idade = 24;
// pessoa1.Apresentar();

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.AdicionarAluno(pessoa2);
cursoDeIngles.ListarAlunos();