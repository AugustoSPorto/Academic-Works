% Racha cuca

resolve(S) :-
     S = rua(casa(_,_,_,_,_),
             casa(_,_,_,_,_),
             casa(_,_,_,_,_),
             casa(_,_,_,_,_),
             casa(_,_,_,_,_)),
     
     % O Inglês vive na casa Vermelha.
     nacionalidade(A,ingles),
     cor(A,vermelha),
     % O Sueco tem Cachorros como animais de estimação.
     nacionalidade(B,sueco),
     animal(B,cachorros),
     % O Dinamarquês bebe Chá.
     nacionalidade(C,dinamarques),
     bebida(C,cha),
     % A casa Verde fica do lado esquerdo da casa Branca.
     a_esquerda(S,D,E),
     cor(D,verde),
     cor(E,branca),
     % O homem que vive na casa Verde bebe Café.
     bebida(D,cafe),
     % O homem que fuma Pall Mall cria Pássaros.
     cigarro(E,pall_mall),
     animal(E,passaros),
     % O homem que vive na casa Amarela fuma Dunhill.
     cor(F,amarela),
     cigarro(F,dunhill),
     % O homem que vive na casa do meio bebe Leite.
     casa_do_meio(S,G),
     bebida(G,leite),
     % O Norueguês vive na primeira casa.
     primeira_casa(S,H),
     nacionalidade(H,noruegues),
     % O homem que fuma Blends vive ao lado do que tem Gatos.
     ao_lado(S,I,J),
     cigarro(I,blends),
     animal(J,gatos),
     % O homem que cria Cavalos vive ao lado do que fuma Dunhill.
     ao_lado(S,K,L),        % L pode ser F
     animal(K,cavalos),
     cigarro(L,dunhill),
     % O homem que fuma Blue Master bebe Cerveja.
     cigarro(M,blue_master),
     bebida(M,cerveja),
     % O Alemão fuma Prince.
     nacionalidade(N,alemao),
     cigarro(N,prince),
     % O Norueguês vive ao lado da casa Azul.
     ao_lado(S,O,P)
     nacionalidade(O,noruegues),
     cor(P,azul),
     % O homem que fuma Blends é vizinho do que bebe Água.
     ao_lado(S,Q,R)  % Q pode ser I
     cigarro(Q,blends),
     bebida(R,agua).
     
     


cor(casa(X,_,_,_,_),X).
nacionalidade(casa(_,X,_,_,_),X).
bebida(casa(_,_,X,_,_),X).
cigarro(casa(_,_,_,X,_),X).
animal(casa(_,_,_,_,X),X).

ao_lado(rua(X,Y,_,_,_),X,Y).
ao_lado(rua(Y,X,_,_,_),X,Y).
ao_lado(rua(_,X,Y,_,_),X,Y).
ao_lado(rua(_,Y,X,_,_),X,Y).
ao_lado(rua(_,_,X,Y,_),X,Y).
ao_lado(rua(_,_,Y,X,_),X,Y).
ao_lado(rua(_,_,_,X,Y),X,Y).
ao_lado(rua(_,_,_,Y,X),X,Y).

a_esquerda(rua(X,_,_,_,Y),X,Y).
a_esquerda(rua(_,X,_,_,Y),X,Y).
a_esquerda(rua(_,_,X,_,Y),X,Y).
a_esquerda(rua(_,_,_,X,Y),X,Y).
a_esquerda(rua(X,_,_,Y,_),X,Y).
a_esquerda(rua(_,X,_,Y,_),X,Y).
a_esquerda(rua(_,_,X,Y,_),X,Y).
a_esquerda(rua(X,_,Y,_,_),X,Y).
a_esquerda(rua(_,X,Y,_,_),X,Y).
a_esquerda(rua(X,Y,_,_,_),X,Y).

casa_do_meio(rua(_,_,X,_,_),X).

primeira_casa(rua(X,_,_,_,_),X).
