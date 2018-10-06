# -*- coding: cp1252 -*-

#Nombre y matrciula de alumnos
#Cuantos registros va a guardar

arreglo1 = []
arreglo2 = []
matriz=()()

while True:
        try:
            guardar = int(raw_input("¿Cuantos registros quieres guardar?"))
            while guardar < 0:
                 print "Numero invalido solo se acpetan valores positivos"
                 guardar = int(raw_input("¿Cuantos registros quieres guardar?"))
            break
        except ValueError:
            print "Vuelve a intentarlo!!!"


for x in range (guardar):
    nombre = raw_input("Ingresa el nombre: ")
    arreglo1+=nombre,
    matrciula = int(raw_input("Ingresa la matricula"))
    arreglo2+=matrciula,


print arreglo1
print arreglo2
arreglo=[arreglo1,arreglo2]

print arreglo 
print "_________________________________________"

print arreglo[0][0]
print arreglo[1][0]
for x in arreglo:
    for y in x:
        print y,
    print