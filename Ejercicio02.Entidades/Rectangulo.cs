namespace Ejercicio02.Entidades
{
    public class Rectangulo
    {
        #region Constructores
        public Rectangulo()
        {
            
        }
        public Rectangulo(int ladoMayor, int ladoMenor)
        {
            LadoMayor = ladoMayor;
            LadoMenor = ladoMenor;
        }
        #endregion 
        public int LadoMayor { get; set; }

        public int LadoMenor { get; set; }

        public double GetPerimetro() => 2 * LadoMayor + 2 * LadoMenor;

        public double GetSuperficie() => LadoMenor * LadoMayor;



    }
}
