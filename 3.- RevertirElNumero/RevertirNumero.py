# -*- coding: cp1252 -*-
repetir = 1
while repetir == 1:     
    a = 0 
    b = 0
    c = 0
    d = 0
    e = 0
    f = 0
    while True:
        try:
            x = int(raw_input("Inserte una cantidad en enteros: $ "))
            while x < 0:
                 print "Numero invalido solo se acpetan valores positivos"
                 x = int(raw_input("Inserte una cantidad en enteros: $ "))
            break
        except ValueError:
            print "Vuelve a intentarlo!!!"
    n = x #Conserva el valor de x     
    a = x // 100 #Se obtiene el entero de una division para cada billete
    x = x - (100 * a) 

    d = x // 10
    x = x - (10 * d)

    f = x // 1
    x = x - (1 * f)
    print "La cantidad ingresada fue: ", x
    print "La cantidad revertida: ", f,d,a
    print "_____________________________________________"
    while True:
        try:
            repetir = int(raw_input("�Desea otro proceso? \n Si = 1 \n No = 2 \n "))
            while repetir <= 0 or repetir >= 3:
                print "Opcion invalida, eliga una opcion correcta"
                repetir = int(raw_input("�Desea otro proceso? \n Si = 1 \n No = 2 \n "))
            break
        except ValueError:
            print "Selecciona una opcion correcta..."
print "Fin del proceso"