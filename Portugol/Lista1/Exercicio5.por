programa {
	funcao inicio() {
		// 5. Faça um programa que leia as 3 notas de um aluno e calcule a média final deste aluno.
		// Considerar que a média é ponderada e que o peso das notas é: 2,3 e 5, respectivamente.
		
		real nota1, nota2, nota3, media
		
		escreva("Entre Nota 1: ")
		leia(nota1)
		escreva("Entre Nota 2: ")
		leia(nota2)
		escreva("Entre Nota 3: ")
		leia(nota3)
		
		media = (( nota1 * 2 ) + ( nota2 * 3 ) + ( nota3 * 5 )) / (2 + 3 + 5)
		
		escreva("Resultado da média: ", media)
	}
}
