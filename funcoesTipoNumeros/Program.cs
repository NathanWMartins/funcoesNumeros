namespace funcoesTipoNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1 };

            maiorValor(v);
            menorValor(v);
            valorMedio(v);
            tresMaioresValores(v);
            valoresNegativos(v);
            mostrarValores(v);

            Console.Write("Digite o numero que quer remover: ");
            int n = int.Parse(Console.ReadLine());

            remover(v, n);
        }

        static void maiorValor(int[] v)
        {
            int maiorN = -999999;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] > maiorN)
                {
                    maiorN = v[i];
                }
            }
            Console.WriteLine("Maior Numero: " +  maiorN);
        }
        static void menorValor(int[] v)
        {
            int menorN = 999999;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] < menorN)
                {
                    menorN = v[i];
                }
            }
            Console.WriteLine("Maior Numero: " + menorN);
        }
        static void valorMedio(int[] v)
        {
            int valorMedio = 0;
            for (int i = 0; i < v.Length; i++)
            {
                valorMedio = valorMedio + v[i];
            }
            Console.WriteLine("Valor Medio: " + valorMedio/v.Length);
        }
        static void tresMaioresValores(int[] v)
        {            
            Array.Sort(v);
            Array.Reverse(v);
            Console.Write("Maiores 3 Numeros: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(v[i] + "|");
            }
            Console.WriteLine();
        }
        static void valoresNegativos(int[] v)
        {
            Console.Write("Valores negativos: ");
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] < 0)
                {
                    Console.Write(v[i] + "|");
                }
            }
            Console.WriteLine();
        }
        static void mostrarValores(int[] v)
        {
            Console.Write("Valores da função: ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + "|");
            }
            Console.WriteLine();
        }
        static void remover(int[]v, int n)
        {
            v = v.Where(val  => val != n).ToArray();
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i]);
            }
        }
    }
}