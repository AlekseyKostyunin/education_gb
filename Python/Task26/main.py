'''Задача №26. Напишите программу, которая на вход принимает
два числа A и B, и возводит число А в целую степень B с
помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
'''

# def recApowB(a, b):
#     if b == 0:
#         return 1
#     return a * recApowB(a, b - 1)

# a = int(input('Введите число: '))
# b = int(input('Введите степень: '))
# print(recApowB(a, b))

def f(a, b):
    if b == 0:
        return 1
    return a * f(a, b - 1)

a = 3
b = 5
print(f(a, b))