programa {
    
    inclua biblioteca Matematica --> mat
	
	funcao inicio() {
		// 4. Escreva  um programa que leia tr�s n�meros inteiros e positivos (A, B, C) e calcule a seguinte express�o:
		// D = (R + S)/2
		// R = (A + B)^2
		// S = (B + C)^2
		
		real A, B, C, D1, D2
		
		escreva("Entre com valor A: ")
		leia(A)
		escreva("Entre com valor B: ")
		leia(B)
		escreva("Entre com valor C: ")
		leia(C)
		
		D1 = ((( A + B ) * ( A + B )) + (( B + C ) * ( B + C ))) / 2
		
		D2 = (mat.potencia( A + B, 2.0) + mat.potencia( B + C, 2.0)) / 2
		
		escreva("Resultado sem biblioteca: ", D1, "\n")
		
		escreva("Resultado com biblioteca: ", D2)
	}
}
