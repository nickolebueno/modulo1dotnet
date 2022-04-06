programa {
	funcao inicio() {
		// 3. Faça um programa que leia o tempo de duração de um evento em uma fábrica expressa 
		// em segundos e mostre-o expresso em horas, minutos e segundos.
		
		inteiro horas, minutos, segundos
		
		escreva("Entre com tempo em segundos: ")
		leia(segundos)
		
		horas = segundos / 3600
		minutos = (segundos % 3600) / 60
		segundos = (segundos % 3600) % 60
		
		escreva(horas, ":", minutos, ":", segundos)
	}
}
