
import sqlite3 as basedatos

# me conecto a SQLite
conexion = basedatos.connect("loterias.sqlite3")

# siempre tengo que hacer un cursor cuando llamo a la base de datos
cursor = conexion.cursor()

def calculaNumero(numero):
    # le pido algo con un select
    cursor.execute('''
        SELECT *
        FROM Euromillones
        LIMIT 100;
        ''')


    # recupero la informacion en un bucle for   
    suma= 0
    numeroelmentos = 100
    datos = cursor.fetchall()
    for i in datos:
         print(i[1])
         suma = suma + int(i[1])

    # hago operaciones con esa información
    media= suma/numeroelementos

    # y la saco por pantalla
    print("La suma de todos los numeros es",suma)

    print("El numero al que debes jugar en la casilla 1 es: ",numero,round(media))

calculaNumero(1)
calculaNumero(2)
calculaNumero(3)
calculaNumero(4)
calculaNumero(5)

calculaNumero(6)
calculaNumero(7)
