'''Задача №25. Напишите программу, которая принимает на вход
строку, и отслеживает, сколько раз каждый символ
уже встречался. Количество повторов добавляется к
символам с помощью постфикса формата _n.
Input: a a a b c a a d c d d
Output: a a_1 a_2 b c a_3 a_4 d c_1 d_1 d_2
Для решения данной задачи используйте функцию
.split()
'''

s = "a a a b c a a d c d d"
l = s.split(" ") # получили список со всеми буквами
d = {}
for i in l:
    if i in d:
        print(f'{i}_{d[i]}', end=' ')
    else:
        print(i, end=' ')
    d[i] = d.get(i, 0) + 1