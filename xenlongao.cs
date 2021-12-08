using System;

namespace PrimeiroDesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int C;
            int N;
            int divisores;
            int divisoresImpares = 0;
            int qtdaMinimaEsferas;
            //Número de casos
            C = int.Parse(Console.ReadLine());
            for(int casos = 0; casos < C; casos++){
                //Número de esferas
                N = int.Parse(Console.ReadLine());
                if(N >= 2 && N <= 109){
                    //Passa por cada esfera para analisar a quantidade de divisores que ela possui.
                    for(int esfera = 0 ; esfera <= N; esfera++){
                        divisores = 0;
                        for(int aux = 1; aux <=esfera; aux++){
                            int resultado = esfera % aux;
                            if(resultado == 0){
                                //Armazena a quantidade de divisores de cada esfera.
                                divisores ++;
                            }
                        }
                        if((divisores % 3) == 0){
                            //Armazena a quantidade de esferas que possuem divisores ímpares em cada caso.
                                divisoresImpares ++;
                        }
                    }  
                }
                qtdaMinimaEsferas = N - divisoresImpares;
                Console.WriteLine(qtdaMinimaEsferas);
                divisoresImpares = 0;
            }
        }
    }
}