# Celebrity
---
## Juego similar al juego de cartas Time's Up! 
Los jugadores, divididos en dos equipos, intentan adivinar personajes, títulos, para conseguir puntos para su equipo

---
**Iteración 1**

El juego debe ser capaz de seleccionar un número de tarjetas (entre 15 y 30) y realizar varias rondas en una partida. Irá mostrando las cartas disponibles, y ofrecerá tres opciones:

- *Acierto*. El equipo ha acertado. Un punto para el equipo

- *Pasar / Fallo*. El jugador decide pasar porque no adivinarán la tarjeta en tiempo / O el equipo ha fallado y se pasa a la siguiente tarjeta

- *Fin de turno*  El tiempo del equipo ha finalizado.

Cada acierto será un punto para el equipo con el turno en curso. Cuando finalice el tiempo (30 segundos normalmente), se mostrará un resumen de turno (Aciertos realizados, y puntuación general).
Después, si quedan cartas, continuará el otro equipo.

Se realizarán 3 rondas (Y una cuarta ronda opcional). Cada ronda tendrá una pantalla de presentación de ronda, con una pequeña explicación de lo que hay que hacer.

| Ronda     | Descripción    | Nº de Respuestas aceptadas | Se pude pasar |
| --------|---------|-------|------|
| 1  | Describir el concepto pudiendo hablar con libertad, pero sin utilizar partes de la palabra o su traducción en otro idioma.   | Sin límite | NO    |
| 2 | Solo una palabra para describir el personaje | 1 | SÍ |
| 3 | Mímica y sonidos para describir el personaje | 1 | SÍ |
| 4 | Escenificar una posición, como si el jugador fuese una estatua, para describir el personaje | 1 | SÍ |

---
**Iteración 2**

Organizar las tarjetas por categorías. Cada tarjeta tendrá, además, una dificultad, en virtud de lo conocido que sea el concepto. (1 -> Muy conocido, 3-> poco conocido)

Al iniciar el juego, los jugadores podrán seleccionar la dificultad y las categorías con las que quieren jugar.

Las categorías serán las siguientes:

Categorías:

- Personajes históricos famosos

- Personajes contemporaneos famosos

- Películas

- Series

- Literatura

- Teatro

- Comic

- Música

- Videojuegos

- Juegos de mesa

- Lugares

- Proverbios y refranes


---
**Iteración 3**

Añadir un contador a cada tarjeta. Cada vez que una tarjeta sea acertada, este contador aumentará. De esta manera, cada vez que se recuperen cartas para un nuevo juego, las cartas que menos veces hayan salido tendrán prioridad sobre las ya acertadas.

---
**Iteración 4**

Permitir la personalización de tarjetas.

- Añadir, editar y borrar categorías

- Añadir, editar y borrar tarjetas

**Iteración 5 **

Permitir la edición durante la partida. Para errores realizados al darle a acierto o fallo, permitir la edición de algún resultado

