#include <stdio.h>

int main()
{
    int array[] = { 10, -1, 22, -33, 47, -5, 6, -7 };
    int length = sizeof(array) / sizeof(array[0]);

    printf("Неотрицательные элементы:\n");
    for (int i = 0; i < length; i++)
    {
        if (array[i] >= 0)
        {
            printf("%d ", array[i]);
        }
    }
    printf("\n");

    printf("Отрицательные элементы:\n");
    for (int i = 0; i < length; i++)
    {
        if (array[i] < 0)
        {
            printf("%d ", array[i]);
        }
    }
    printf("\n");

    return 0;
}