# NumberToWordWordToNumber(Probando paquete nuget)
Convert Number to Word and convert Word to Number (0-999999999)

Este nuget puede ser usado de la siguiente forma:

Primero debe ser descargado, buscando NumberToWorsWordToNumber en el buscador de nugets, este solo funciona en .net core c#

luego de esto, para implementar el convertidor de Numero a palabras se debera de hacer lo siguiente:

primero:
Declarar una instancia de la clase converter

![image](https://github.com/Whisman21/Kata-DDD-paquete-nugget/assets/144621111/703a1427-60e1-4baa-97b6-0e5424403afa)

Segundo:
Declarar una instancia de la clase Input y en esta donde se encuentra (n.value) ahi se debera de poner el numero que se quiere convertir

![image](https://github.com/Whisman21/Kata-DDD-paquete-nugget/assets/144621111/6ebebb3e-df8d-48b2-8b80-ce401ab8fc32)

Tercero:
Declarar una instancia de la clase Output y esta igualarla a la instancia de la clase converter segudio de la llamada de la funcion .Result() y dentro del parentesis poner la instancia declarada de la clase Input

![image](https://github.com/Whisman21/Kata-DDD-paquete-nugget/assets/144621111/b10b6413-6f07-4325-b6b2-ee88c013eb2b)

Cuarto:
Declaras una variable string, la llamas como quieras, y la igualas a la instancia declarada de la clase Output seguido de .GetResult()

![image](https://github.com/Whisman21/Kata-DDD-paquete-nugget/assets/144621111/a0a1a3bf-54b8-4a50-8ff6-e6c9cad97f76)


y ya ahi se tiene el convertor de numeros a palabras, con el convertor de palabra a numeros se hace el mismo procedimiento solo que con otras clases:

![image](https://github.com/Whisman21/Kata-DDD-paquete-nugget/assets/144621111/30e3611b-d46b-4d6e-98ab-c53f1956a0b9)

Algo por aclarar, a la hora de convertir de palabras a numeros, deben de poner la variable que tomara el numero devuelto como dynamic, ya que si la palabra ingresada es invalida, esta regresara "Invalid Input", por lo cual si igualan un int a esto, les saldra un error 




------------------------------


This nuget can be used as follows:

First, it must be downloaded by searching for NumberToWordsWordToNumber in the NuGet searcher. This only works in .NET Core C#.

After this, to implement the number-to-words converter, you should do the following:

First:
Declare an instance of the converter class.

![image](https://github.com/Whisman21/Kata-DDD-paquete-nugget/assets/144621111/703a1427-60e1-4baa-97b6-0e5424403afa)

Second:
Declare an instance of the Input class, and in it, where (n.value) is located, put the number you want to convert.

![image](https://github.com/Whisman21/Kata-DDD-paquete-nugget/assets/144621111/6ebebb3e-df8d-48b2-8b80-ce401ab8fc32)

Third:
Declare an instance of the Output class and set it equal to the instance of the converter class followed by the call to the .Result() function, and within the parentheses, put the declared instance of the Input class.

![image](https://github.com/Whisman21/Kata-DDD-paquete-nugget/assets/144621111/b10b6413-6f07-4325-b6b2-ee88c013eb2b)

Fourth:
Declare a string variable, name it as you like, and set it equal to the declared instance of the Output class followed by .GetResult().

![image](https://github.com/Whisman21/Kata-DDD-paquete-nugget/assets/144621111/a0a1a3bf-54b8-4a50-8ff6-e6c9cad97f76)

And there you have the number-to-words converter. For the word-to-number converter, follow the same procedure but with different classes:

![image](https://github.com/Whisman21/Kata-DDD-paquete-nugget/assets/144621111/30e3611b-d46b-4d6e-98ab-c53f1956a0b9)

One thing to clarify, when converting from words to numbers, you should set the variable that will take the returned number as dynamic. If the entered word is invalid, it will return "Invalid Input", so if you set an int to this, you will get an error.
