## Programa em c# usando a logica de programação dinamica. 

## Anunciado do exercicio:

<p> Suponha que tenhamos disponíveis moedas com valores de 15, 10, 5, 3 e 1. O problema é criar um algoritmo que para conseguir obter um determinado valor com o menor número de moedas possível (problema do troco). Execute o algoritmo de Programação Dinâmica para resolver este problema e mostre o resultado para os seguintes valores de troco: 9, 13, 17 e 20. </p>

~~~c#
	
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
~~~~
