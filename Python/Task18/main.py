
'''Задача №18. Требуется найти в массиве A[1..N] самый близкий по
величине элемент к заданному числу X. Пользователь в первой строке
вводит натуральное число N – количество элементов в массиве. В
последующих строках записаны N целых чисел Ai. Последняя строка
содержит число X
5
1 2 3 4 5
6
-> 5
'''
# from random import randint
# n = int(input('Введите количество элементов массива (списка): '))
# nums = [randint(0, 10) for i in range(n)]
# print(*nums)
# x = int(input('Введите искомое число: '))
# min = abs(x - nums[0])
# index = 0
# for i in range(1, n):
#     count = abs(x - nums[i])
#     if count < min:
#         min = count
#         index = i
# print(nums[index])

# list_1 = [1, 2, 3, 4, 5]
# k = 6
# # 5

# list_1 = [2, 4, 1, 6, 8, 2, 9, 3, 2, 5]
# k = 10
# # 9

# list_1 = [1, 4, 3, 7, 8, 9, 2]
# k = 8
# 8

list_1 = [1, 12, 6, 7, 8, 15]
k = 11
# 12


min = abs(k - list_1[0])
index = 0
for i in range(1, len(list_1)):
    count = abs(k - list_1[i])
    if count < min:
        min = count
        index = i
print(list_1[index])