#include <stdio.h>

int main()
{
    int array[10];

    printf("Введите 10 чисел:\n");
    for (int i = 0; i < 10; i++)
    {
        printf("Введите число %d: ", i + 1);
        scanf("%d", &array[i]);
    }

    printf("Заполненный массив: ");
    for (int i = 0; i < 10; i++)
    {
        printf("%d ", array[i]);
    }
    printf("\n");

    return 0;
}