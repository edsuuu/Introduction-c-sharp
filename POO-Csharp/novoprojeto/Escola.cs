public class Escola
{
    public string Aluno;
    public string Curso;
    public string Turno;
    public string Professor;
    public int Sala;

    public Escola(string aluno, string curso, string turno, string professor, int sala)
    {
        Aluno = aluno;
        Curso = curso;
        Turno = turno;
        Professor = professor;
        Sala = sala;
    }

    public override string ToString()
    {
        return $"Aluno: {Aluno}, Curso: {Curso}, Turno: {Turno}, Professor: {Professor}, Sala: {Sala}";
    }

}

public Computador()
{
    placaMae = "Asus";
    processador = "Intel Core i7";
    memoria = "8GB";
    hd = "1TB";

}