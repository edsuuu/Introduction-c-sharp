namespace novoprojeto;
class Program
{
    static void Main(string[] args)
    {
        Escola escola = new Escola("Edson", "Tecnologia da Informação", "Manha","João", 1);

        Console.WriteLine("\n" +escola.ToString() + "\n");

        // Console.WriteLine("\n" + escola.Aluno);
        // Console.WriteLine(escola.Curso);
        // Console.WriteLine(escola.Turno);
        // Console.WriteLine(escola.Professor);
        // Console.WriteLine(escola.Sala + "\n");
    }
}
/* string aluno, string curso, string turno, string professor, int sala */

public class Caneta 
{
    public string? Cor;

    public double Carga;
    //double é um tipo de variavel que pode receber numeros decimais '1,50' numeros quebrados
    public bool Tampada;
    //bool é um tipo de variavel que pode receber 2 valores, verdadeiro ou falso
    //sempre inicia com letra minuscula
}

// public class Escola
// {
//     public string Aluno;
//     //nome do aluno
//     public string Curso;
//     //tipo de curso
//     public string Turno;
//     //manha tarde noite 
//     public string Professor;
//     //nome do professor
//     public int Sala;
//     //int é para receber um numero inteiro "double para usar numero quebrado por exeplo 1.5"
// }

public class PessoaClasse
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
}

//apenas os atributos da classe podem ter ; e a classe finaliza apenas com a {}




