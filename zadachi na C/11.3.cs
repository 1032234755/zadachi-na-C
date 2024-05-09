#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void fill_array_double(double* array, int size, double min, double max)
{
    for (int i = 0; i < size; i++)
    {
        double scale = rand() / (double)RAND_MAX; /* [0, 1.0] */
        array[i] = min + scale * (max - min);      /* [min, max] */
    }
}

void fill_array_int(int* array, int size, int min, int max)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = min + rand() % (max - min);    /* [min, max) */
    }
}

int main()
{
    srand(time(NULL));  // Инициализация генератора случайных чисел
    double array_a[13], array_b[13], array_c