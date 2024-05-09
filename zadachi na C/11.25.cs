#include <stdio.h>

int main()
{
    int array[] = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
    int length = sizeof(array) / sizeof(array[0]);

    printf("Второй, четвертый и т.д. элементы:\n");
    for (int i = 1; i < length; i += 2)
    {
        printf("%d ", array[i]);
    }
    printf("\n");

    printf("Третий, шестой и т.д. элементы:\n");
    for (int i = 2; i < length; i += 3)
    {
        printf("%d ", array[i]);
    }
    printf("\n");

    return 0;
}