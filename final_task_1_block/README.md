# Репозиторий для решения итоговой контрольной работы по основному блоку

## Условия задачи:
Задача: *Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

# Алгоритм решения
1. Запрашиваем у пользователя количество элементов массива строк.
2. Через цикл, равный количеству элементов массива, принимаем от пользователя строки и формируем исходный массив.
3. Через цикл for считаем количество строк, длина которых менее или равна 3 символам.
4. Создаем новый массив, количество элементов которого равно счетчику из шага 3.
5. Через цикл for перебираем исходный массив. И если длина строки элемента массива меньше или равна 3, то копируем значение в новый массив. 