﻿#include <stdio.h>
#include <math.h>

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
    printf("Пары простых чисел-близнецов до 200:\n");
    for (int num = 2; num < 199; num++)
    {
        if (is_prime(num) && is_prime(num + 2))
        {
            printf("(%d, %d)\n", num, num + 2);
        }
    }
    return 0;
}