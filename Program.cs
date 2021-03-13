using System;
using System.Collections.Generic;
namespace ProgramaDinamica
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] moedas = new int[5];
            int n = 20;
            moedas[0] = 1;
            moedas[1] = 3;
            moedas[2] = 5;
            moedas[3] = 10;
            moedas[4] = 15;

        System.Console.WriteLine(num_moedas(n, moedas.Length, moedas));
        }

        public static int num_moedas(int N, int M, int[] moedas)
        {


            int[] dp = new int[N + 1];//Definimos um N +1 para não ocorrer overflow

            for(int i=1; i<=N; i++) {

                dp[i] = int.MaxValue;//Definimos um valor alto que vai ser substiuido 

                for(int j=0; j<M; j++) {
                    if(i-moedas[j] >= 0) {
                        dp[i] = Math.Min(dp[i], dp[ i-moedas[j] ]+1);//Aqui fazemos e regra de salva na memoria, 
                        //fazendo assim programação dinamica.
                    }
                }
            }
            return dp[N];
        }

       
    }
}
