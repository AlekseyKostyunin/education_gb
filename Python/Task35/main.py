'''Задача №35. Напишите функцию, которая принимает одно число и
проверяет, является ли оно простым
Напоминание: Простое число - это число, которое
имеет 2 делителя: 1 и n(само число)
Input: 5
Output: yes
'''
n = int(input('Введите число: '))
delitel = 1
for i in range(2, n+1):
    if n%i == 0:
        delitel += 1
    if delitel > 3:
        break
if(delitel == 2):
    print('yes')
else:
    print('no')