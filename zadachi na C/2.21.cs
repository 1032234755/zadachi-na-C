#include <stdio.h>
#include <math.h>

double calculate_a(double e, double f)
{
    return (e + f) / (2 / 3);
}

double calculate_b(double g, double h)
{
    return h * h - g;
}

double calculate_c(double e, double g, double h)
{
    return sqrt((g - h * h) - 3 * sin(e));
}

int main()
{
    double e = 1.0;
    double f = 2.0;
    double g = 3.0;
    double h = 4.0;
    double a = calculate_a(e, f);
    double b = calculate_b(g, h);
    double c = calculate_c(e, g, h);
    printf("a = %f\n", a);
    printf("b = %f\n", b);
    printf("c = %f\n", c);
    return 0;
}