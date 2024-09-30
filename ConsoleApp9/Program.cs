using System.Data;
using System.Drawing;
using System.Xml;
//declarações 
//variaveis
// '//' comentario
int idade = 35; // 35 é uma constante
Console.WriteLine($"A idade do Mario é " + idade);
//variáveis de inteiros 
sbyte pessoas = -128; // -128 ~ 127 - 255(256) 2^8 com sinal
byte joias = 255; // ele suporta de 0 ate 255 abaixo ou alem disso ele nao suporta ele suporta vaores apenas 0 e 255! variaveis do tipo byte nao suportam valores negativos apenas positivo 
short malas = 32767;// ele suporta -32767 e suporta o mesmo valor positivo 
ushort telas = 65535; // essa não permite numero negativo o 0 e contado como valor entao ele nao vai alem de 65535 
int pcs = -2147483648; // e uma variavel iteira de 32 bits ele suporta esse valor de 2147483648 positivo e nagativo porem esse vai ate o - o 47 ja o positivo vai 48 o zero ele e um numero entao ele conta a partir do zero
                       // sempre faça os bites elevado a 2^ mas depois faça ele dividido por 2 para saber quanto e ele em negativo e positivo
uint malhas = 4294967295; // ele suporta 4 bilhoes de inteiros porem ele nao suporta numeros negativos  esse e o inteiro de 32 bits sem sinal
long estrelas = 9223372036854775807;//    
ulong planteas = 18446744073709551615;// ele não suporta numeros negativos  // o u de ulong ele nao aceita numeros negativos
                                      // sistemas nao aceitam casas decimais depois de 4 numero depoois da virugula por ex:4444, pode ser ate 3 333,//variaveis de ponto flutuante, e qu8ando tem cawsa decimal depois da virgula
float numero1 = 0.4564656546546556465465546466464654F;
double numero = 0.0D;//sempre tem que ser maiscula a letra no final
decimal decimalzinho = 0.000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000005M;
// variavel teste logico 
bool teste = true;//George Boole foi um matemático e filósofo britânico, mais conhecido por criar a álgebra booleana, que é fundamental para a lógica matemática e a ciência da computação1. A álgebra booleana utiliza valores binários (verdadeiro e falso) para realizar operações lógicas, sendo essencial para o funcionamento dos circuitos digitais e computadores modernos2 
                  //operadores aritimeticos 
                  //https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/arithmetic-operators
Console.WriteLine(5 + 6);
Console.WriteLine(5 + 6);
Console.WriteLine(5 * 6);
Console.WriteLine(5 / 6);
// Console.WriteLine($" a++ {a++}");
 
Console.WriteLine();
 
Console.WriteLine("tabuada");
int num = 7;
int cont = 0;
while (cont < 10)
{
 
 
    Console.WriteLine($" {num} x  {cont + 0} = {num * (cont++ + 0)} ");
}
//RAIZ QUADRADA
Console.WriteLine($"Raiz quadrada de 144 => {Math.Pow(144, 11)}");
 
Console.WriteLine();
 
Console.WriteLine($" 5 MOD 2 -> {5 % 2}");
double valor = 125.98;
valor += 10;
Console.WriteLine(valor.ToString("#0.00"));// esse comando ele coloca uma mascaras nos zeros que sobram apos a conta e se quiser fazer mascara de uma linha de comando especifico precisa abrir dois parenteses
 
//precedencia de operadores
Console.WriteLine("5.0*2.0-7.0/4.0+3.0");
 
//Matrizesintint
int[] m = { 1, 2, 8, 7 };
 
int i = 0;
int[] mx = new int[5];
mx[0] = 13;
mx[1] = 40;
mx[2] = 31;
mx[3] = 19;
mx[4] = 21;
foreach (int item in mx)
{
    Console.WriteLine(item);
}
 
 
Console.WriteLine(m[i++]);
Console.WriteLine(m[i++]);
Console.WriteLine(m[i++]);
Console.WriteLine(m[1]);
//int[] mx = new int[5];
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
 
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
//matrizes
int[,] mat = new int[5, 5];//
mat[0, 0] = 65;// dentro do conchete sem pre vai ter o indice que mostra a condicao
 
Console.WriteLine($"Resultado => {mat[0, 0]}");//
                                               //essa usamos para preencher a matriz de 5x5
Random rand = new();// uma linha objeto que faz valores aleatorios
for (int l = 0; l < 5; l++)// este e o "para"
{
 
    for (int c = 0; c < 5; c++)
    {
 
        mat[l, c] = rand.Next(0, 10);
    }
}
Console.WriteLine();
int dp = 0, di = 0, sl = 0, sc = 0;
int[] smcoluna = new int[5];
//agora iremos exibir a matriz 5X5
for (int l = 0; l < 5; l++)
{
    for (int c = 0; c < 5; c++)
    {
        Console.Write($"{mat[l, c]} ");
        if (l == c) dp += mat[l, c];// ele soma l mais c que são a diagonal principal dp recebe ele mesmo e soma toda a diagonal
        if (l + c == 4) di += mat[l, c];
        sl += mat[l, c];
        sc += mat[c, l];
 
    }
    smcoluna[l] = sc;
    sc = 0;
    Console.WriteLine($"-> {sl}");
    sl = 0;
    Console.WriteLine();
}
for (int k = 0; k < 5; k++)
{
    Console.Write($" \\/ ");
}
Console.WriteLine();
for (int k = 0; k < 5; k++)
{
    Console.Write($"{smcoluna[k]} ");
}
Console.WriteLine($"diagonal principal ={dp}");
Console.WriteLine($"diagonal principal ={di}");
 
Console.WriteLine();
 
Array array;
 
int[] ti = new int[10];
for (int c = 0; c < 10; c++)
{
 
    ti[c] = rand.Next(100, 1000);
}
Console.WriteLine("----------Matriz----------");
Array.Sort(ti);
for (int j = 0; j < 10; j++)
{
    Console.WriteLine(ti[j]);
}
 
 
Console.ReadKey();