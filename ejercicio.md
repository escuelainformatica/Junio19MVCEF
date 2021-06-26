## Ejercicio:

Usando el proyecto actual, cree lo siguiente:

* Cree dos tablas de la siguiente manera.

### Animal

* id = llave primaria, entero
* nombre = texto (varchar)
* idespecie = llave foranea, entero



| id   | nombre | idespecie |
| ---- | ------ | --------- |
| 1    | perro  | 1         |
| 2    | gato   | 1         |
| 3    | loro   | 2         |

## Especie

* idespecie = llave primaria, entero
* nombre = texto (varchar)

| idespecie | nombre   |
| --------- | -------- |
| 1         | mamifero |
| 2         | ave      |
| 3         | reptil   |

* Agrega las dos tablas a nuestro codigo usando Scaffold-DbContext
* En el codigo, lista todas los animales donde el nombre de especie es "mamifero"

