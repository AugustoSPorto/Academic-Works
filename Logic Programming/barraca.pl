resolve(S) :-
    S = barraca(_,_,_,_,_),
    exatamente_a_direita(S,A,B),
    nome(A,julio),
    profissao(B,bancario),
    em_algum_lugar_entre(S,C,D,E),
    condimento(C,pimenta),
    condimento(D,maionese),
    condimento(E,mostarda),
    algum_cliente(S,F),
    nome(F,fabiano),
    pastel(F,frango),
    esta_ao_lado(S,G,H),
    camiseta(G,vermelha),
    suco(H,maracuja),
    em_algum_lugar_entre(S,I,A15,J),
    nome(A15,fabiano),
    condimento(I,vinagrete),
    nome(J,carlos),
    algum_cliente(S,K),
    profissao(K,entregador),
    pastel(K,carne),
    exatamente_a_esquerda(S,L,M),
    profissao(L,relojoeiro),
    suco(M,maca),
    em_algum_lugar_a_esquerda(S,G,N),
    condimento(N,ketchup),
    quarta_posicao(S,O),
    condimento(O,mostarda),
    esta_ao_lado(S,P,Q),
    profissao(P,feirante),
    condimento(Q,pimenta),
    em_algum_lugar_entre(S,R,T,U),
    pastel(R,frango),
    pastel(T,carne),
    pastel(U,calabreza),
    algum_cliente(S,X),
    camiseta(X,azul),
    condimento(X,maionese),
    exatamente_a_direita(S,Y,Z),
    nome(Y,rubens),
    pastel(Z,queijo),
    algum_cliente(S,A1),
    profissao(A1,feirante),
    suco(A1,maracuja),
    em_algum_lugar_a_esquerda(S,A2,A3),
    camiseta(A2,amarela),
    camiseta(A3,branca),
    em_algum_lugar_entre(S,A4,A5,A6),
    suco(A5,laranja),
    nome(A4,julio),
    suco(A6,limao),
    primeira_posicao(S,A7),
    pastel(A7,pizza),
    algum_cliente(S,A8),
    profissao(A8,bancario),
    camiseta(A8,verde),
    em_algum_lugar_entre(S,A9,A10,A11),
    condimento(A10,pimenta),
    profissao(A9,relojoeiro),
    camiseta(A11,azul),
    algum_cliente(S,A12),
    nome(A12,marcelo),
    algum_cliente(S,A13),
    suco(A13,uva),
    algum_cliente(S,A14),
    profissao(A14,vendedor).


camiseta(cliente(X,_,_,_,_,_),X).
nome(cliente(_,X,_,_,_,_),X).
pastel(cliente(_,_,X,_,_,_),X).
condimento(cliente(_,_,_,X,_,_),X).
suco(cliente(_,_,_,_,X,_),X).
profissao(cliente(_,_,_,_,_,X),X).


exatamente_a_direita(barraca(B,A,_,_,_),A,B).
exatamente_a_direita(barraca(_,B,A,_,_),A,B).
exatamente_a_direita(barraca(_,_,B,A,_),A,B).
exatamente_a_direita(barraca(_,_,_,B,A),A,B).

em_algum_lugar_entre(barraca(C,D,E,_,_),C,D,E).
em_algum_lugar_entre(barraca(C,D,_,E,_),C,D,E).
em_algum_lugar_entre(barraca(C,D,_,_,E),C,D,E).
em_algum_lugar_entre(barraca(C,_,D,E,_),C,D,E).
em_algum_lugar_entre(barraca(C,_,D,_,E),C,D,E).
em_algum_lugar_entre(barraca(C,_,_,D,E),C,D,E).
em_algum_lugar_entre(barraca(_,C,D,E,_),C,D,E).
em_algum_lugar_entre(barraca(_,C,D,_,E),C,D,E).
em_algum_lugar_entre(barraca(_,C,_,D,E),C,D,E).
em_algum_lugar_entre(barraca(_,_,C,D,E),C,D,E).


algum_cliente(barraca(X,_,_,_,_),X).
algum_cliente(barraca(_,X,_,_,_),X).
algum_cliente(barraca(_,_,X,_,_),X).
algum_cliente(barraca(_,_,_,X,_),X).
algum_cliente(barraca(_,_,_,_,X),X).

esta_ao_lado(barraca(A,B,_,_,_),A,B).
esta_ao_lado(barraca(B,A,_,_,_),A,B).
esta_ao_lado(barraca(_,A,B,_,_),A,B).
esta_ao_lado(barraca(_,B,A,_,_),A,B).
esta_ao_lado(barraca(_,_,A,B,_),A,B).
esta_ao_lado(barraca(_,_,B,A,_),A,B).
esta_ao_lado(barraca(_,_,_,A,B),A,B).
esta_ao_lado(barraca(_,_,_,B,A),A,B).



exatamente_a_esquerda(S,A,B) :-
    exatamente_a_direita(S,B,A).

em_algum_lugar_a_esquerda(barraca(X,Y,_,_,_),X,Y).
em_algum_lugar_a_esquerda(barraca(X,_,Y,_,_),X,Y).
em_algum_lugar_a_esquerda(barraca(X,_,_,Y,_),X,Y).
em_algum_lugar_a_esquerda(barraca(X,_,_,_,Y),X,Y).
em_algum_lugar_a_esquerda(barraca(_,X,Y,_,_),X,Y).
em_algum_lugar_a_esquerda(barraca(_,X,_,Y,_),X,Y).
em_algum_lugar_a_esquerda(barraca(_,X,_,_,Y),X,Y).
em_algum_lugar_a_esquerda(barraca(_,_,X,Y,_),X,Y).
em_algum_lugar_a_esquerda(barraca(_,_,X,_,Y),X,Y).
em_algum_lugar_a_esquerda(barraca(_,_,_,X,Y),X,Y).


quarta_posicao(barraca(_,_,_,X,_),X).

primeira_posicao(barraca(X,_,_,_,_),X).
