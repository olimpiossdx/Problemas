/*

A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:


Salário	Percentual de Reajuste
0 - 400.00
400.01 - 800.00
800.01 - 1200.00
1200.01 - 2000.00
Acima de 2000.00

15%
12%
10%
7%
4%

Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.

Entrada
A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.

Saída
Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o percentual de reajuste ganho, conforme exemplo abaixo.

Exemplo de Entrada	Exemplo de Saída
400.00

Novo salario: 460.00
Reajuste ganho: 60.00
Em percentual: 15 %

800.01

Novo salario: 880.01
Reajuste ganho: 80.00
Em percentual: 10 %

2000.00

Novo salario: 2140.00
Reajuste ganho: 140.00
Em percentual: 7 %

*/
#include <stdio.h>
int percentual(float salario)
{
    if (salario >= 0 && salario <= 400.00)
    {
        return (15);
    }
    if (salario >= 400.01 && salario <= 800.00)
    {
        return (12);
    }
    if (salario >= 800.01 && salario <= 1200.00)
    {
        return (10);
    }
    if (salario >= 1200.01 && salario <= 2000.00)
    {
        return (7);
    }
    return (4);
}
int main()
{
    float salario;
    scanf("%f", &salario);
    printf("Novo salario: %.2f\n", ((percentual(salario) * salario) / 100) + salario);
    printf("Reajuste ganho: %.2f\n", (percentual(salario) * salario) / 100);
    printf("Em percentual: %d %%\n", percentual(salario));
    return 0;
}
