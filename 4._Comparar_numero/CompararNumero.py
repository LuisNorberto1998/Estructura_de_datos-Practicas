# -*- coding: cp1252 -*-

repetir = 1
while repetir == 1:
    try:
        print("Este programa\nEvalua si el primer numero es menor que el segundo y lo suma\nSi no, lo multiplica\n")
        print "_____________________\n"
        x = int(raw_input("Numero 1: "))
        y = int(raw_input("Numero 2: "))
        if(x<y):
            result = (x + y)
            print x, '+', y, '=', result    
            print "_____________________\n"            
        else:
            result = (x * y)
            print x," * ",y," = ",result
            print "_____________________\n"
    except ValueError:
        print "Error"
    try:    
        repetir = int(raw_input("1) Repetir \n2) Salir \n "))
        if(repetir == 1):
            print "\nRepitiendo proceso..."
            print "_____________________"
    except ValueError:
        print "Error"