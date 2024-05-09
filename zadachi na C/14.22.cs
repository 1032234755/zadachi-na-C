#include <stdio.h>

int is_power_of_five(int n)
{
    if (n < 1) return 0;
    while (n % 5 == 0)
    {
        n /= 5;
    }
    return n == 1;
}

int main()
{
    int numbers[] = { 1, 5, 25, 3, 125, 20, 625, 500 };
    int count = 0;
    int size = sizeof(numbers) / sizeof(numbers[0]);

    for (int i = 0; i < size; i++)
    {
        if (is_power_of_five(numbers[i]))
        {
            count++;
        }
    }

    printf("Количество чисел, являющихся степенями пятерки: %d\n", count);
    return 0;
}