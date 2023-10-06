''' Дано натуральное число A > 1. Определите, каким по
счету числом Фибоначчи оно является, то есть
выведите такое число n, что φ(n)=A. Если А не
является числом Фибоначчи, выведите число -1.
Input: 5
Output: 6
'''
a = int(input('Введите предполагаемое число Фибоначчи: '))

if a == 2:
    print(4)
else:
    index = 5
    a1 = 1
    a2 = 2
    while True:
        a3 = a1 + a2
        if a == a3:
            print(index)
            break
        if a > a2 and a < a3:
            print(-1)
            break
        index += 1
        a1 = a2
        a2 = a3