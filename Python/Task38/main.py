'''Задача №38. Дополнить справочник возможностью копирования данных из одного файла в другой. 
Пользователь вводит номер строки, которую необходимо перенести из одного файла в другой.
'''
phonebook = open('phonebook.txt', 'r')
s=[]
for line in phonebook:
    s.append(line.split(','))
phonebook.close

phonebook_copy = open('phonebook_copy.txt', 'a')

n = int(input("Введите номер строки для копирования: "))

if (n>len(s)):
    print("Такой строки не существует")
else:
    str = ",".join(s[n-1])
    phonebook_copy.writelines(f"{str}\n" )