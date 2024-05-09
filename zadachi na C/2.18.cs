#include <stdio.h>
#include <math.h>

double calculate_z(double x, double y)
{
    return (x + 2 + y) / (x * x);
}

double calculate_q(double x, double y)
{
    return 7.25 * sin(x - fabs(y));
}

int main()
{
    double x = 1.0;
    double y = 2.0;
    double z = calculate_z(x, y);
    double q = calculate_q(x, y);
    printf("z = %f\n", z);
    printf("q = %f\n", q);
    return 0;
}