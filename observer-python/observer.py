class Observer:
    def update(self, mensaje):
        print("Notificación recibida:", mensaje)

class Subject:
    def __init__(self):
        self.observers = []

    def add(self, observer):
        self.observers.append(observer)

    def notify(self, mensaje):
        for obs in self.observers:
            obs.update(mensaje)

# Uso del patrón
sujeto = Subject()
usuario = Observer()

sujeto.add(usuario)
sujeto.notify("Nuevo evento disponible")