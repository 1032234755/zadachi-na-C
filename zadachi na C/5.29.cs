#include <stdio.h>

double average_of_range(int start, int end)
{
    double sum = 0;
    for (int i = start; i <= end; i++)
    {
        sum += i;
    }
    return sum / (end - start + 1);
}

int main()
{
    printf("Среднее арифметическое от 1 до 750: %f\n", average_of_range(1, 750));

    int b;
    printf("Введите b (b > 150): ");
    scanf("%d", &b);
    printf("Среднее арифметическое от 150 до %d: %f\n", b, average_of_range(150, b));

    int a;
    printf("Введите a (a <= 200): ");
    scanf("%d", &a);
    printf("Среднее арифметическое от %d до 200: %f\n", a, average_of_range(a, 200));

    printf("Введите a: ");
    scanf("%d", &a);
    printf("Введите b (b >= a): ");
    scanf("%d", &b);
    printf("Среднее арифметическое от %d до %d: %f\n", a, b, average_of_range(a, b));

    return 0;
}