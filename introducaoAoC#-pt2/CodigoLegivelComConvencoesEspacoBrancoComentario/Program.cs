string firstName = "Bob";
int widgetsPurchased = 7;
// Testinga change to the message.
// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
Console.WriteLine($"{firstName} purchased {widgetsPurchased} wigests");

/*

Essa forma de comentar se chama comentario em bloco sendo capaz de comentar varias linhas
de uma vez, muito util

*/

//Desafio de código

/*

Objetivo do codigo é de saber quantos O tem na fraze, 
depois que ela é invertidae e que frase ela cria desse jetito

*/

string message = "The quick brown fox jumps over the lazy dog.";
int x = 0;

char[] charMessage = message.ToCharArray();
Array.Reverse(charMessage);

foreach (char i in charMessage) 
{ 
    if (i == 'o') 
    { 
        x++; 
    } 
}

string newMessage = new String(charMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {x} times.");