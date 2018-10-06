# -*- coding: cp1252 -*-
from time import time #Funcion de tiempo
# Crear un algoritmo que solicite y almacene en un vector 10 números y programar(imprimir vector).
def leerVector():
    x=[]
    for i in range(0,10):
        x.append(int(raw_input("Ingrese numero %d : " % i)))
    return x

def imprimirVector(x):
    print "_____________________________________________________"
    print x
    print "_____________________________________________________"

# Usar un método de búsqueda para determinar en que posición esta "X" numero y mostrarlo.

#Busqueda secuencial
def busquedaSecuencial(x):
    busqueda = int(raw_input("Buscar numero por posicion: "))

    encontrado=-1

    tiempoInicial = time()
    for i in range(10):
        if(x[i] == busqueda):
            encontrado=i
            print "_____________________________________________"
            print "||Valor: ", busqueda, "||Posicion: ",encontrado+1
            print "_____________________________________________"
    tiempoFinal = time()
    tiempoEjecucion = tiempoFinal - tiempoInicial
    print 'El tiempo de ejecucion fue:',tiempoEjecucion #En segundos


#Busqueda binaria
def busquedaBinaria(x):
    busqueda = int(raw_input("Buscar numero por posicion: "))
    
    tiempoInicial = time()
    for i in range(1,busqueda):
        aux=x[i]
        izq=0
        der=i-1
        while izq<=der:
                m=(izq+der)/2
                if aux < x[m]:
                        der=m-1
                else:
                        izq=m+1

        j=i-1
        while j>=izq:
                x[j+1]=x[j]
                j=j-1
        x[izq]=aux
        
        tiempoFinal = time()
        tiempoEjecucion = tiempoFinal - tiempoInicial
        print 'El tiempo de ejecucion fue:',tiempoEjecucion #En segundos

        print "_____________________________________________"
        print "||Valor: ", busqueda, "||Posicion: ",x[izq]
        print "_____________________________________________"
   

        


# Usar un método para ordenar los números de forma secuencial.

#Ordenamiento burbuja
def ordenamientoBurbuja(y):
    tiempoInicial = time()
    for i in range(1,10):
        for j in range(0,10-i):
            if(y[j] > y[j+1]):
                k = y[j+1]
                y[j+1] = y[j]
                y[j] = k

    tiempoFinal = time()
    tiempoEjecucion = tiempoFinal - tiempoInicial
    print 'El tiempo de ejecucion fue:',tiempoEjecucion #En segundos


#Metodo de insercion
def insercion(x):
    tiempoInicial = time()
    for indice in range(1,len(x)):
        valorActual = x[indice]
        posicion = indice

    while posicion>0 and x[posicion-1]>valorActual:
         x[posicion]=x[posicion-1]
         posicion = posicion-1

    x[posicion]=valorActual

    tiempoFinal = time()
    tiempoEjecucion = tiempoFinal - tiempoInicial
    print 'El tiempo de ejecucion fue:',tiempoEjecucion #En segundos


#Ejecucion
leer = leerVector()
leerUno = leer
leerDos = leerUno

imprimirVector(leer)
print "\n___________________ Buscar numero secuencial _______________________"
busquedaSecuencial(leer)

print "\n___________________ Busqueda binaria _______________________"
busquedaBinaria(leer)

print "\n___________________ Ordenamiento burbuja _______________________"
ordenamientoBurbuja(leer)
imprimirVector(leer)

print "\n___________________ Metodo de insercion _______________________"
insercion(leerDos)
imprimirVector(leerDos)



