value = None
a = 123
b = 1.23

print(type(a))
print(b)

value = 1234
print(value)

s = 'hello,' # однострочный комментарий
w = "world"
print(s, w)
''' text ''' # многострочный комментарий ctrl + /

s = 'hello \"world' # экранирование строк
s = 'hello "world"'
s = "hello 'world'"
s = 'hello \"world'

a = 3
b = 11
s = 2022
print(a, b, s)
print(a, 'b', 's')
print('{} - {} - {}'.format(a,b,s))
print(f'first - {a} second - {b} third - {s}') # интерполяция

print('-----------------')
'''
print('Введите 1-ое число: ')
a = input()
print('Введите 2-ое число: ')
b = input()
print(a, ' + ', b, ' = ', a+b)

print('-----------------')
'''
n = 1.345
print(int(n)) # Отбрасывается дробная часть вне зависимости больше 0.5 или меньше
m = '345'
print(m * 2) # При умножении строки на число, она повторяется столько раз на какое была умножена
print(int(m) * 2)

print('-----------------')

n = 1.345
print(str(n) * 2)

print('-----------------')
n = '1.345'
print(float(n) * 2)
m = 2
print(float(m))

print('-----------------')
#n = '123Hello'
#print(int(n))
#print(float(n))

# // Целочисленное деление
# ** Возведение в степень

a = 1.43425
b = 2.2983
c = round(a * b, 5) # 3,29633 количество знаков после запятой

iter = 2
iter += 3 # iter = iter + 3
iter -= 4 # iter = iter - 4
iter *= 5 # iter = iter * 5
iter /= 5 # iter = iter / 5
iter //= 5 # iter = iter // 5
iter %= 5 # iter = iter % 5
iter **= 5 # iter = iter ** 5

# not Не (отрицание)
# and И (конъюнкция)
# or Или (дизъюнкция)

a = 1 > 4
print(a) # False

a = 1 < 4 and 5 > 2
print(a) # True

a = 1 == 2
print(a) # False

a = 1 != 2
print(a) # True

a = 'qwe'
b = 'qwe'
print(a == b) # True

a = 1 < 3 < 5 < 10
print (a) # True

#if condition:
    # operator 1
    # operator 2
    # ...
    # operator n
#else: 
    # operator n + 1
    # operator n + 2
    # ...
    # operator n + m
'''
a = int(input("a = "))
b = int(input("b = "))
if a > b:
    print(a)
else:
    print(b)
'''

n = 423
summa = 0
while n > 0:
    x = n % 10
    summa = summa + x
    n = n // 10
print(summa) # 9
'''
n = int(input())
flag = True
i = 2
while flag:
    if n % i == 0: # если остаток при делении числа n на i равен 0
        flag = False
        print(i)
    elif i > n // 2: # делить числа не может превышать введенное число, деленное на 2
        print(n)
        flag = False
    i += 1
'''
for i in 1, -2, 3, 14, 5:
    print(i)
# 1 -2 3 15 5

r = range(5) # 0 1 2 3 4
r = range(2, 5) # 2 3 4
r = range(-5, 0) # ----
r = range(1, 10, 2) # 1 3 5 7
r = range(100, 0, -20) # 100 80 60 40 20
r = range(100, 0, -20) # range(100, 0, -20)
for i in r:
    print(i)
# 100 80 60 40 20

for i in range(5):
    print(i)
# 0 1 2 3 4

line = ""
for i in range(5):
    line = ""
    for j in range(5):
        line += "*"
    print(line)

text = 'СъЕШЬ ещё этих МяГкИх французских булок'
print(len(text)) # 39
print('ещё' in text) # True
print(text.lower()) # съешь ещё этих мягких французских булок
print(text.upper()) # СЪЕШЬ ЕЩЁ ЭТИХ МЯГКИХ ФРАНЦУЗСКИХ БУЛОК
print(text.replace('ещё','ЕЩЁ')) # СъЕШЬ ЕЩЁ этих МяГкИх французских булок

text = 'съешь ещё этих мягких французских булок'
print(text[0]) # c
print(text[1]) # ъ
print(text[len(text)-1]) # к
print(text[-5]) # б
print(text[:]) # съешь ещё этих мягких французских булок
print(text[:2]) # съ
print(text[len(text)-2:]) # ок
print(text[2:9]) # ешь ещё
print(text[6:-18]) # ещё этих мягких
print(text[0:len(text):6]) # сеикакл
print(text[::6]) # сеикакл
text = text[2:9] + text[-5] + text[:2] # ...