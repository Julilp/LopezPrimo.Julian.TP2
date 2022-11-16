# SegundoParcial
## Sobre mi:
me llamo Julian Lopez Primo, tengo 20  años, recien termine el trabajo.
Al pricipio de ese pense que iba a ser todo facil, pero mas adelante me trabe mucho con la base de datos, mas alla de eso, me encanto la experiencia de crear un programa y tener tanta libertad para hacerlo.
## Resumen
primero pense la logica del juego, en base a eso me fije que tablas deberia crear en la base de datos para conectarlo, y luego optimice el codigo con todos los temas vistos en clase
## Justificacion tecnica
[manejo de excepciones]: lo use mucho en la parte de sql ya que es sumamente necesario para poder realizar los insert y select de manera eficaz, tambien lo use para atrapar la excepcion de un timer
[generic & Interfaces]: uso ambos juntos como el profesor dijo en clase, ayuda a ahorrar lineas de codigo, y simplificar la logica, use este para poder hacer los insert de manera mas rapida y facil
[serializacion]: esta se ve usada para guardar la baraja completa de cartas, y la deserealizo a una lista para poder ir modificandola
[Escritura de archivos]: en la parte de estadisticas guardo todo en un archivo el cual leo y mas tarde ordeno en un list box y muesto los 3 mejores tiempos del programa
[Delegados]: uso estos mismos para crear el timer, luego tambien, para hacer una funcion de sort y acomodar una lista
[task]: lo uso para comensar la tarea de sumar segundos en un contador mientras se juga una partida
[evento]: uso el evento action en el timer para poder hacer de motor de este mismo


![diagrama de clases](https://user-images.githubusercontent.com/98592297/202175014-98df4d47-a5c7-4bcd-ae0b-c779f4be2fa4.png)
