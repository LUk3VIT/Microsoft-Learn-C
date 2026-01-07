/*

//Iniciarndo uma matriz 

//Primeiro falo que tipo de matriz é, no caso uma matriz de caracteres: string[].
//Segundo coloco o nome da matriz: fraudulenteOrdeIDs.
//Terceiro inicio o matiz e dentro dos colchetes falo ques valores pode ser colocados dentro da matriz: new string[Quantidade de valores].

//veja o exemplo:

string[] fraudulenteOrderIDs = new string[3];

//Colocando os caracteres dentro dos valores da matriz

//Primeiro chamo a matriz e falo em qual valor quero usar: fraudulenteOrdeIDs[Valor que queria usar]
//Segundo colocaque o que deseja dentro dessa valor da matriz: = "o que quer adicionar dentro desse valor da matiz";

//veja o exemplo:

fraudulenteOrderIDs[0] = "AD43D";
fraudulenteOrderIDs[1] = "GR453";
fraudulenteOrderIDs[2] = "T3425";

// Chamando os valores da matriz e mostrando o que tem dentro de cada valor

//veja o exemplo:

Console.WriteLine($"First: {fraudulenteOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulenteOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulenteOrderIDs[2]}");

// é possivel reescreverr os valores da matriz mesmo não sendo null

//veja o exemplo:

fraudulenteOrderIDs[0] = "BE54E";

Console.WriteLine($"Reassing first: {fraudulenteOrderIDs[0]}");

*/

// Inciando um matriz com os valores e tamaho ja estabelecido em uma linha

//Veja o exemlo
string[] fraudulenteOrderIDs = [ "A123", "B123", "C456"];

Console.WriteLine($"First: {fraudulenteOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulenteOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulenteOrderIDs[2]}");

fraudulenteOrderIDs[0] = "BE54E";

Console.WriteLine($"Reassing first: {fraudulenteOrderIDs[0]}");

//Aqui estmos mosntrando o tamnaho da matriz (a quantidade de valores que se pode ter dentro dela), para isso usamos a propriedade Length

//veja o exemplo
Console.WriteLine($"There are {fraudulenteOrderIDs.Length} fraudulent orders to process.");

