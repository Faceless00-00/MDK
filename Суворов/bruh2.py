'''
Шифр цезаря (усложнен) (писал сам, правда)
'''
en_alphabet = 'abcdefghijklmnopqrstuvwxyz'
ru_alphabet = 'абвгдеёжзийклмнопрстуфхцчшщъьэюя'
zero = ' '
print('ВЫБЕРЕТЕ ВАРИАНТ РАБОТЫ','если нужно зашифровать - нажмите 1','если нужно дешифровать - нажмите 2', sep ='\n')
while True:
    for_rab = int(input())
    if for_rab != 1 and for_rab != 2:
        print('попробуй ещё раз')
    break
if for_rab == 1:
    print('ВЫБЕРЕТЕ ЯЗЫК', 'английский - нажмите 1','русский - нажмите 2', sep = '\n')
    while True:
        language = int(input())
        if language != 1 and language != 2:
            print('попробуй ещё раз')
        break
    if language == 1:
        print('введите текст')
        text = input()
        i = 0
        while i < len(text):
            prom = [en_alphabet.find(text[i])]
            i += 1
        print('output_text - ',prom,'i - ',i)
    elif language == 2:
        print('введите текст')
        text = input()
        i = 0
        print('ещё не готово')
elif for_rab == 2:
    print('ещё не готово')