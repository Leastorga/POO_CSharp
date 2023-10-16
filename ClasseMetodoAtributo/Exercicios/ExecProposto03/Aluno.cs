namespace ExecProposto03
{
    public class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double CalculaMedia()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (CalculaMedia() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - CalculaMedia();
            }
        }
    }
}