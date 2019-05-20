Refactoring

1) Remove Subclass
- Remoção das subclasses "LampadaQuadrada" e "LampadaRedonda" da classe "Lampada".
- Tornamos a classe "Lampada" concreta ao invés de abstrata.
- Criamos um enumerador para o "TipoDeLampada".
- Com isso, tiramos a responsabilidade das subclasses de determinar a característica da "Lampada" e deixamos que a própria "Lampada" determine a característica pelo seu própio "Tipo".

2) Remove Dead Code
- Remoção do método "Desliga" da classe "Semaforo", pois ele foi implementado desnecessariamente, pois na primeira iteração não se sabia que o console não permitiria, entrar com a opção de desligamento ao mesmo tempo que o semáforo era exibido.

