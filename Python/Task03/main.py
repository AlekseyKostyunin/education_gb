''' Задача №3. В некоторой школе решили набрать три новых
математических класса и оборудовать кабинеты для
них новыми партами. За каждой партой может сидеть
два учащихся. Известно количество учащихся в
каждом из трех классов. Выведите наименьшее
число парт, которое нужно приобрести для них.
Input: 20 21 22(ввод чисел НЕ в одну строку)
Output: 32
'''
from math import ceil

a = int(input('Введите количество учеников 1 класса: '))
b = int(input('Введите количество учеников 2 класса: '))
c = int(input('Введите количество учеников 3 класса: '))
print(ceil((a + b + c)/2)) # округление в большу сторону до целого