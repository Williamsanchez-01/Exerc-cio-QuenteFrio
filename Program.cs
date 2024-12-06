Console.Clear();
Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int tentativas = 0;
        bool ganhou = false;
 
        while (tentativas < 7)
        {
            Console.Write("Palpite (1-100): ");
            int palpite = Convert.ToInt32(Console.ReadLine());
            tentativas++;
 
            if (palpite == numeroSecreto)
            {
                ganhou = true;
                break;
            }
            else
            {
                int diferenca = Math.Abs(numeroSecreto - palpite);
 
                if (diferenca <= 10)
                {
                    Console.WriteLine("Está quente!");
                }
                else if (diferenca <= 30)
                {
                    Console.WriteLine("Está pelando!");
                }
                else if (diferenca > 30)
                {
                    if (numeroSecreto > palpite)
                    {
                        Console.WriteLine("Está congelando! O número secreto é maior.");
                    }
                    else
                    {
                        Console.WriteLine("Está congelando! O número secreto é menor.");
                    }
                }
                else
                {
                    if (numeroSecreto > palpite)
                    {
                        Console.WriteLine("Está frio demais! O número secreto é maior.");
                    }
                    else
                    {
                        Console.WriteLine("Está frio demais! O número secreto é menor.");
                    }
                }
            }
        }
 
        if (ganhou)
        {
            Console.WriteLine($"Parabéns! Você ganhou em {tentativas} tentativas.");
        }
        else
        {
            Console.WriteLine($"Game over! O número secreto era {numeroSecreto}.");
        }
