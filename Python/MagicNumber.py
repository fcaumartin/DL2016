from random import randint

nb = -1
alea = randint(0, 100)
print (alea)

while nb != alea:
	print ("entrez un nombre")
	nb = int(input())
	if nb<alea:
		print ("Trop petit")
	if nb>alea: 
		print ("Trop grand")
	

print ("OK, vous avez trouvé")