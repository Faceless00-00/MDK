'''
14.11.2022 Суворов Д.С 21ИС-21
Задание 2. Дано целое число. Если оно является положительным, то вычесть из него 8;
в противном случае прибавить к нему 6. Вывести полученное число
'''
x = int(input())
if x > 0: 
    print (x - 8)
elif x == 0:
    print (x)
else: 
    print (x + 6)
