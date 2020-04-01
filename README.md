# Algoritmo Genético 

### Trabalho III realizado para o Mestrado em Desenvolvimento de Jogos Digitais (PUC-SP)
#### Laboratório 2 (Prof. Dr. Reinaldo Ramos)

![](https://raw.githubusercontent.com/ezefranca/Damas/master/print.png?token=AA32WUH44VEAP5LEVW4EW3C6QKGZS)

## Proposta

Encontrar o melhor array de solução para input em um personagem para que o mesmo complete a corrida por completo.

## Solução

O tabuleiro foi organizado como uma matriz, onde cada tipo de peça foi representado por um numero (1 e 2) e os espaços por 0.

                [ 0 1 0 1 0 1 0 1 ]
                [ 1 0 1 0 1 0 1 0 ]     
    Tabuleiro = [ 0 0 0 0 0 0 0 0 ]    
                [ 0 0 0 0 0 0 0 0 ]
                [ 0 0 0 0 0 0 0 0 ]
                [ 0 0 0 0 0 0 0 0 ]
                [ 0 2 0 2 0 2 0 2 ]
                [ 2 0 2 0 2 0 2 0 ]

### Ordem de decisão

1 Verificamos os vizinhos adjacentes na matriz, para indentificar uma possível morte do oponente. 
Exemplo: A peça marcada com **X** neste caso seria a primeira escolha


    Best = [0,0,0,-1,0,-1,-1,1,-1,1,1,1,-1,-1,0,-1,-1,-1,-1,1,1,-1,0,-1,-1,-1,-1,-1,1,1,0,0,0,-1,-1,0,0,-1,-1,-1,0,1,0,1,0]    
                

2 Escolha randomica, dependendo da possíbilidade de movimento.
 
 ## Resultados
 
 Vídeo no Youtube:
 
 [![Foo](https://raw.githubusercontent.com/ezefranca/Damas/master/thumb.png?token=AA32WUDAPAI3HARMVCZXULS6QKJY)](https://www.youtube.com/watch?v=IHKuQMgCsxs&feature=youtu.be)
