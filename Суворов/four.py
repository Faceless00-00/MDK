'''
14.11.2022 Суворов Д.С 21ИС-21
Задание 4. Даны три числа. Найти сумму двух наибольших из них.
'''
a = float(input())
b = float(input())
c = float(input())
if a > b and b < c:
    print (a + c)
elif a > b and b > c:
    print (a + b)
else: 
    print (b + c)