programa {
    
    inclua biblioteca Matematica --> mat
    
	funcao inicio() {
		// 6. Construa um programa em c que, tendo como dados de entrada dois pontos quaisquer no plano, P(x1, y1) e P(x2, y2),
		// escreva a dist�ncia entre eles. A f�rmula que efetua tal c�lculo �: d = RAIZ QUADRADA DE -> (x2 - x1)^2 + (y2 - y1)^2
		
		real x1, x2, y1, y2, d
		
		escreva("Entre com x1: ")
        leia(x1)
        escreva("Entre com x2: ")
        leia(x2)
        escreva("Entre com y1: ")
        leia(y1)
        escreva("Entre com y2: ")
        leia(y2)
        
        d = mat.raiz(mat.potencia( x2 - x1, 2.0) + mat.potencia( y2 - y1, 2.0), 2.0)
        
        escreva("Resultado: ", d)
	}
}
