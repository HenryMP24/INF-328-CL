namespace calculadora
{
    internal class Pila
    {
        private int n;
        private int tope;
        private string []pila = new string[100];

        public Pila(int n)
        {
            this.n = n;
            tope = 0;
        }
        public bool estaVacia()
        {
            return tope == 0;
        }
        public bool estaLlena()
        {
            return tope == n;
        }
        public bool apilar(string dato)
        {
            if (estaLlena())
            {
                return false;
            }
            pila[tope] = dato;
            tope++;
            return true;
        }
        public string desapilar()
        {
            if (estaVacia())
            {
                return null;
            }
            tope--;
            return pila[tope];
        }
        public string elementotope()
        {
            return pila[tope - 1];
        }
    }
}