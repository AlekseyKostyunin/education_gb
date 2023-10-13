'''Задача №33. Хакер Василий получил доступ к классному журналу и
хочет заменить все свои минимальные оценки на
максимальные. Напишите программу, которая
заменяет оценки Василия, но наоборот: все
максимальные – на минимальные.
Input: 5 -> 1 3 3 3 4
Output: 1 3 3 3 1
'''
import random
n = int(input('Введите количество оценок: '))
grades = list(random.randint(1, 5) for i in range(n))
# print(grades)
for i in grades:
    if(grades[i] == 4 or grades[i] == 5):
        grades[i] = 1
print(*grades)