# -*- coding: cp1252 -*-
def revertirNumero(x):
    if (x<10):
        return x
    else:
        return x%10,revertirNumero(x/10)

numero = int(raw_input("Numero"))

x = revertirNumero(numero)

print x
print "__________________________________________\n"