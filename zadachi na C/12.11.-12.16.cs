#include <stdio.h>
#include <string.h>

int main()
{
    char word[] = "hello";
    char second_word[] = "world";
    int k = 4; // Пример для вывода k-го символа

    // 12.11 Вывод третьего символа
    if (strlen(word) >= 3)
    {
        printf("Третий символ: %c\n", word[2]);
    }
    else
    {
        printf("В слове меньше трех символов.\n");
    }

    // 12.12 Вывод последнего символа
    if (strlen(word) > 0)
    {
        printf("Последний символ: %c\n", word[strlen(word) - 1]);
    }
    else
    {
        printf("Слово пустое.\n");
    }

    // 12.13 Вывод k-го символа
    if (strlen(word) >= k)
    {
        printf("k-й символ (%d-й): %c\n", k, word[k - 1]);
    }
    else
    {
        printf("В слове меньше %d символов.\n", k);
    }

    // 12.14 Одинаковы ли второй и четвертый символы
    if (strlen(word) >= 4)
    {
        printf("Второй и четвертый символы одинаковы: %s\n", (word[1] == word[3] ? "да" : "нет"));
    }
    else
    {
        printf("В слове меньше четырех символов.\n");
    }

    // 12.15 Начинается и заканчивается ли слово на одну и ту же букву
    if (strlen(word) > 0)
    {
        printf("Слово начинается и заканчивается на одну и ту же букву: %s\n", (word[0] == word[strlen(word) - 1] ? "да" : "нет"));
    }
    else
    {
        printf("Слово пустое.\n");
    }

    // 12.16 Начинается ли первое слово на ту же букву, на которую заканчивается второе слово
    if (strlen(word) > 0 && strlen(second_word) > 0)
    {
        printf("Первое слово начинается, а второе заканчивается на одну и ту же букву: %s\n", (word[0] == second_word[strlen(second_word) - 1] ? "да" : "нет"));
    }
    else
    {
        printf("Одно из слов пустое.\n");
    }

    return 0;
}