class Pila:
     def __init__(self):
         self.items = []

     def estaVacia(self):
         return self.items == []

     def incluir(self, item):
         self.items.append(item)

     def extraer(self):
         return self.items.pop()

     def inspeccionar(self):
         return self.items[len(self.items)-1]

     def tamano(self):
         return len(self.items)

p=Pila()

print(p.estaVacia())
y = int(raw_input("Inserta"))
for i in range(y):
    x = int(raw_input("Inserta"))
    p.incluir += p.incluir(x)

print (p.extraer())    


