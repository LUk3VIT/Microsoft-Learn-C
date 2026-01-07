Random dice = new Random();

int roll1 = dice.Next(1, 6);
int roll2 = dice.Next(1, 6);
int roll3 = dice.Next(1, 6);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if((roll1 == roll2))

if (total > 14)
{
    Console.WriteLine("Você Venceu!");
}

if (total < 14)
{
    Console.WriteLine("Você Perdeu, Desculpa");    
}
