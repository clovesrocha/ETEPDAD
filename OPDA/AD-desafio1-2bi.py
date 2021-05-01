# ETE PORTO DIGITAL
# PROFESSOR: CLOVES ROCHA
# DISCIPLINA: AD

# Desafios I - 2º BIMESTRE
# Uma das Estruturas de Dados mais básica em Python é a list.
# Uma lista é apenas uma coleção ordenada. 
# É parecida com o array das outras linguagens, mas com algumas funcionalidade a mais.
# Com base nos códigos abaixos, verifique elementos e associações 
# ...dentro do seu Obvervatório de Projetos com ênfase em Dados Abertos - (OPDA) 
# Vale 5 pontos na N1 do 2º BIMESTRE.
 
rocha_list = [1, 2, 3]
heterogena_list = ['strig', 0.1, True]
list_oflists = [ rocha_list, heterogena_list, [] ] 

#length é o comprimento
list_length = len(rocha_list) # é igual a 3
list_sum    = sum(rocha_list) # é igual a 6

#Você pode ter ou configurar o elemento n-ésimo de uma lista com colchetes:
x = range(10) # é a lista [0, 1, ...,9]
zero = x[0]   # é igual a 0, as listas são indexadas a partir de 0 
one = x[1]    # é igual a 1
nine = x[-1]  # é igual a 9, 'Pythonic' para o último elemento 
eight = x[-2] # é igual a 8, 'Pythonic' para o anterior ao último elemento
x[0] = -1     # agora x é [-1, 1, 2, 3 ..., 9]

#Você também pode usar colchetes para repartir as listas:
first_three = x[:3]             	# [-1, 1, 2]
three_to_end = x[3:]            	# [3, 4, ..., 9]
one_to_four = x[1:5]				# [1, 2, 3, 4]	
last_three = x[-3:]					# [7, 8, 9]
without_first_and_last = x[1:-1]	# [1, 2, ..., 8]
copy_of_x =[:]						# [-1, 1, 2, ..., 9]

#A Sintaxe do Python possui o operador in para verificar a associação à lista:
	1 in [1, 2, 3] # Verdadeiro
	0 in [1, 2, 3] # Falso 

#É fácil concatenar as listas juntas:
	x = [1, 2, 3]
	x.extend([4, 5, 6])		# x agora é [1, 2, 3, 4, 5, 6]

#Se você não quiser modificar x você pode usar uma adição na lista:
	c = [1, 2, 3]
	r = c + [4, 5, 6]		# r é[1, 2, 3, 4, 5, 6]; x não mudou

#Com mais frequência, anexaremos um item de cada vez nas listas:
	x = [1, 2, 3]
	x.append(0)		# x agora é [1, 2, 3, 0]
	y = x[-1] 		# é igual a 0
	z = len(x) 		# é igual a 4

#Às vezes é convenientes desfazer as listas se você sabe quantos elementos elas possuem:
	x, y = [1, 2] # agora x é 1, y é 2


print('Nunca Desista de Seus Sonhos ou Diminua o Brilho dos Seus Olhos!') 
print('Um grande abraço, Prof. MSc. Cloves Rocha.')  
