#include <stdio.h>
#include <math.h>
#include <stdlib.h>

double calculate_x(double a, double b, double d)
{
    double term1 = ((2 / b) - b) / (d * d + 25);
    double term2 = (fabs(a) + 2 * sin(b)) / (5.5 * a);
    double x = term1 + term2;
    return x;
}

double calculate_y(double a, double b)
{
    double y = sqrt(b) + (a + b) / 2;
    return y;
}

int main()
{
    double a = 1.0;
    double b = 2.0;
    double d = 3.0;
    double x = calculate_x(a, b, d);
    double y = calculate_y(a, b);
    printf("x = %f\n", x);
    printf("y = %f\n", y);
    return 0;
}