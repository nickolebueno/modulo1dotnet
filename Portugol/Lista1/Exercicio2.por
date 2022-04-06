programa {
	funcao inicio() {
		//2. Faça um programa que leia a idade de uma pessoa expressa em dias e mostre-a expressa em anos, meses e dias
		// (considere que: 1 ano = 365 dias / 1 mês = 30 dias e 1 dia = 1 dia em todos os casos).
		
		inteiro anos, meses, dias
		inteiro resultado, resto
		
		escreva("Idade expressa em dias: ")
		leia(dias)
		
		anos = dias / 365
		meses = (dias % 365) / 30
		dias = (dias % 365) % 30
		
		escreva("Voce tem: ", anos, " anos, ", meses, " meses e ", dias, " dias de vida.")
	}
}
