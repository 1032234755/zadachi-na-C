﻿# include <stdio.h>
# include <math.h>

int is_prime(int n)
{
    if (n <= 1) return 0;
    if (n <= 3) return 1;
    if (n % 2 == 0 || n % 3 == 0) return 0;
    for (int i = 5; i * i <= n; i += 6)
    {
        if (n % i == 0 || n % (i + 2) == 0)
            return 0;
    }
    return 1;
}

int main()
{
    printf("Трехзначные простые числа:\n");
    for (int i = 100; i < 1000; i++)
    {
        if (is_prime(i))
        {
            printf("%d ", i);
        }
    }
    printf("\n");
    return 0;
}