''' Задача № 12. Петя и Катя – брат и сестра. Петя – студент, а Катя – школьница. Петя помогает Кате по математике.
Он задумывает два натуральных числа X и Y (X,Y≤1000), а Катя должна их отгадать. Для этого Петя делает две подсказки. 
Он называет сумму этих чисел S и их произведение P. Помогите Кате отгадать задуманные Петей числа.
Примечание: числа S и P задавать не нужно, они будут передаваться в тестах. В результате вы должны 
вывести все возможные варианты чисел X и Y через пробел.
Пример
На входе:
s = 12
p = 27
На выходе:
3 9
9 3

Примеры:
x = 12
y = 27
3 9
9 3

x = 8
y = 16
4 4

x = 17
y = 72
8 9
9 8

x = 4
y = 4
2 2
'''
x = 4
y = 4

for i in range(1,1000):
    for j in range(1, 1000):
        if i + j == x and i * j == y:
            print(i, j)