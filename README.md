# Celebrity
**Juego similar al juego de cartas Time's Up!**

*Nota a futuro: Quizá sería buena idea encapsular el back en una api rest (aspnet core, tirando de ficheros para no tener que pagar BBDD), y el hacerlo mediante un fwk tipo vue.*

Los jugadores, divididos en dos equipos, intentan adivinar conceptos (Personajes, títulos de obras, etc) para conseguir puntos para su equipo.
El equipo que más puntos consiga a lo largo de tres rondas, será el ganador.

---

**Selección de conceptos**

Estarán disponibles varias opciones para seleccionar los conceptos. Se puede seleccionar el número de tarjetas que se quieran.

- Seleccionar al azar tarjetas de una o varias categorías

- Navegar por los conceptos y que cada jugador seleccione numero total de tarjetas / numero de jugadores

**Juego**

El juego irá mostrando los conceptos disponibles, y ofrecerá las siguientes opciones:

- *Acierto*. El equipo ha acertado. Un punto para el equipo

- *Pasar / Fallo*. El jugador decide pasar porque no adivinarán la tarjeta en tiempo / O el equipo ha fallado y se pasa a la siguiente tarjeta

Cuando el tiempo establecido termine, se contabilizarán los aciertos y se pasará el turno al siguiente equipo. Así, hasta que todas las tarjetas hayan sido acertadas, y se pasará a la siguiente ronda.

Se realizarán 3 rondas (Y una cuarta ronda opcional). Cada ronda tendrá una pantalla de presentación de ronda, con una pequeña explicación de lo que hay que hacer.

| Ronda     | Descripción    | Nº de Respuestas aceptadas | Se puede pasar |
| --------|---------|-------|------|
| 1  | Describir el concepto pudiendo hablar con libertad, pero sin utilizar partes de la palabra o su traducción en otro idioma.   | Sin límite | NO    |
| 2 | Solo una palabra para describir el personaje | 1 | SÍ |
| 3 | Mímica y sonidos para describir el personaje | 1 | SÍ |
| 4 | Escenificar una posición, como si el jugador fuese una estatua, para describir el personaje | 1 | SÍ |

---
