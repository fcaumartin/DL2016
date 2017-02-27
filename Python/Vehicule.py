class Vehicule:

	def __init__(self, marque, puissance, places):
		self.marque = marque
		self.puissance = puissance
		self.places=places
		self._kilometrage = 0

	def Avance(self):
		print ("Le vehicule avance")


class Voiture(Vehicule):

	def Avance(self):
		print ("La voiture avance")


v1 = Vehicule("BMW", 250, 5)
v2 = Voiture("BMW", 250, 5)

garage = [v1, v2]

for v in garage:
	v.Avance()