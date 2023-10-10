'''Задача №16. Требуется вычислить, сколько раз встречается некоторое
число X в массиве A[1..N]. Пользователь в первой строке вводит
натуральное число N – количество элементов в массиве. В последующих
строках записаны N целых чисел Ai. Последняя строка содержит число X
5
1 2 3 4 5
3
-> 1
'''
n = int(input('Введите количество элементов массива (списка): '))
numbers = []
for i in range(n):
    numbers.append(int(input('Введите целое число: '))) 
print(numbers)
x = int(input('Введите искомое число: '))
count = 0
for i in range(len(numbers)):
    if numbers[i] == x:
        count += 1
print(count)

# 2 вариант
# n = int(input('Введите количество элементов массива (списка): '))
# numbers = []
# for i in range(n):
#     numbers.append(int(input('Введите целое число: '))) 
# x = int(input('Введите искомое число: '))
# print(numbers.count(x))

# print(list_1.count(k))