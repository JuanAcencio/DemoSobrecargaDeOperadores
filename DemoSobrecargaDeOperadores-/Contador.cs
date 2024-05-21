namespace DemoSobrecargaDeOperadores_
{
    public class Contador
    {
        private int _conteo;
        public int Conteo => _conteo;

        public Contador(int inicio = 0)
        {
            _conteo = inicio;
        }

        public int GetNextValue()
        {
            _conteo++;
            return _conteo;
        }
        public static Contador operator +(Contador c1, Contador c2)
        {
            return new Contador(c1.Conteo + c2.Conteo);
        }
        public static Contador operator -(Contador c1, Contador c2)
        {
            return new Contador(c1.Conteo - c2.Conteo);
        }
    }
}
