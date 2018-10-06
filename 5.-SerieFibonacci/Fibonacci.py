# -*- coding: 850 -*-
repetir = 1
while repetir == 1:  
    f=1 #Numero inicial
    n=0 #Ultimo numero
    x=0 #Numero anterior al ultimo
    print "__________________________________________\n"
    print "#       Serie Fibonacci en Python        #"  
    print "__________________________________________"

    while True:
            try: #Evaluar numeros enteros
                print "__________________________________________\n"
                fn = int(raw_input("      Ingresa un numero: ")) #Veces que se va a repetir el ciclo
                while x < 0:
                    print "__________________________________________\n"
                    print "Numero invalido solo se acpetan valores positivos"
                    fn = int(raw_input("      Ingresa un numero: ")) #Veces que se va a repetir el ciclo
                break
            except ValueError:
                print "__________________________________________\n"
                print "      Vuelve a intentarlo!!!"
                print "__________________________________________\n"

    for i in range(fn): #Ciclo Fibonacci
        print "\n       ",x, " + ", n, " = ", f
        x=n
        n=f
        f=x+n
    print "__________________________________________\n"

    while True: #Evaluar si se quiere repetir la operacion
        try:
            repetir = int(raw_input("      ¿Desea otro proceso? \n             Si = 1 \n             No = 2 \n             "))
            while repetir <= 0 or repetir >= 3:
                print "Opcion invalida, eliga una opcion correcta"
                repetir = int(raw_input("      ¿Desea otro proceso? \n             Si = 1 \n             No = 2 \n             "))
            break
        except ValueError:
            print "Selecciona una opcion correcta..."
print "Fin del proceso"
        
        

