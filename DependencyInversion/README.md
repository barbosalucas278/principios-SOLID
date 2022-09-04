# D - Dependency Inversion

“**Depende de abstracciones**, no de clases concretas”.

“los modulos de alto nivel no deberian depender el los modulos de bajo nivel, ambos deberian de depender de interfaces.”

Esto nos permite es reducir el desacople entre sistemas, por ejemplo que nuestro sistema no dependa del motor de base de datos que usemos, al depender de abtracciones (interfaces) nuestro codigo va a reaccionar de la misma manera.