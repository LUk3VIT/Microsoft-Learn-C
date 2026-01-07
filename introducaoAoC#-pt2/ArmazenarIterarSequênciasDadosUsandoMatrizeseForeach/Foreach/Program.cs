//Aqui vamos aprender a usar o foreach com matriz

//Criamos uma matriz simples
int [] inventario = {200, 450, 700, 175, 250};

//Criamos uma variavel para fazer a soma mais pra frente

int sum = 0;

//Usaremos a variavel bim para contarmos quantas vezes samos no loop, o valor tem que bater com a quantidade de valores que tem na matriz
int bin = 0;

//Montamos o loop e observer que criamos uma variavel que recebe os valores da matriz para cada loop que fizer 
foreach (int objs in inventario)
{
    //Com a variavel sum usamos a para somar os valores dentro do lop e guardalos a cada cilco da soma;
    sum += objs;
    bin++;
    Console.WriteLine($"Bin {bin} = {objs} items (Running total: {sum})");
}

//Fora damos um print no sum para ver a sama de todos os valores da matriz inventario
Console.WriteLine($"Nos tem {sum} objetos no inventario");