programa {
	funcao inicio() {
		// 8. O custo ao consumidor de um carro novo � a soma do custo de f�brica com a percentagem do distribuidor
		// e dos impostos (aplicados ao custo de f�brica). Supondo que a percentagem do distribuidor seja de 28% e
		// os impostos de 45%, escrever um programa que leia o custo de f�brica de um carro e escreva o custo ao consumidor.
		
		
		real custo_consumidor, custo_fabrica
		
		escreva("Entre com o custo de fabrica: ")
		leia(custo_fabrica)
		
		custo_consumidor = custo_fabrica + (custo_fabrica * 0.28) + (custo_fabrica * 0.45)
		
		escreva("Custo consumidor: ", custo_consumidor)
	}
}
