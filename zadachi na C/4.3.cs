#include <stdio.h>
#include <math.h>

double calculate_y(double x)
{
    if (x > 0)
    {
        return pow(sin(x), 2);
    }
    else
    {
        return 1 + 2 * pow(sin(x), 2);
    }
}

int main()
{
    double x = 1.0;  // Пробуем для x > 0
    double y = calculate_y(x);
    printf("y = %f\n", y);

    x = -1.0;  // Пробуем для x <= 0
    y = calculate_y(x);
    printf("y = %f\n", y);
    return 0;
}