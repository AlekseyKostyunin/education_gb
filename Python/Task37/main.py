'''Задача №37. Дано натуральное число N и последовательность из N элементов.
Требуется вывести эту последовательность в обратном порядке.
Примечание. В программе запрещается объявлять массивы и использовать циклы
(даже для ввода и вывода).
Input: 2 -> 3 4
Output: 4 3
'''
import random
n = int(input('Введите натуральное число N: '))
arr = list(random.randint(1, 5) for i in range(n))
print(arr)
print(arr[::-1])