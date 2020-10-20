# Práctica 1. Introducción a Unity
## Asignatura: Interfaces Inteligentes 2020/21
### Nombre: Rafael Cala González
### Alu: alu0101121901@ull.edu.es

## Objetivos de la práctica

Realizar una escena 3D básica utilizando exclusivamente el editor de escenas. La escena debe configurarse de la siguiente manera:

 - Incluir dos objetos 3D básicos, por ejemplo 2 esferas.
 - Incluir un personaje con Ethan, de los Standard Assets.
 - Incluir un objeto libre de la Asset Store que no sea de los Standard Assets.
 - Crear un terreno.
 - Cada objeto debe tener una etiqueta que lo identifique.
 - La escena debe tener 2 fuentes de luz.
 - Agregar un script que escriba en la consola los objetos que se han utilizado, un identificador numérico que le asignes a cada uno de los objetos  y el valor de un contador      que se actualiza en cada iteración para cada objeto. 
 
 ## Incluir dos objetos 3D básicos
 Para esta primera tarea, no se necesita importar ningún tipo de asset, pues los objetos 3d básicos se pueden utilizar por defecto en Unity. Se ha optado por incluir dos esferas, que han quedado dispuestas en el aire de la siguiente manera:
 
 ![Imagen de los objetos básicos]()
 
 ``` GameObject > 3D object > Sphere ```
 
 ## Incluir a Ethan, un characterModel de los Standard Assets
 En este segundo punto sí es necesario llevar a cabo una importación, por lo que se recurre a la Asset Store, donde se buscan, descargan e importan los Standard Asset y de los que podemos optar o bien importar todo lo descargado, o solo quedarnos con aquello que nos interese. A fin de evitar errores de compatibilidad que existen actualmente en los Standard Assets, se opta por importar únicamente los recursos referentes a Ethan y otros relacionados con el entorno que se verán más adelante.
 
 ![Imagen de Ethan]()
 
  ``` Assets > Standard Assets > Characters > ThirdPersonCharacter > Models > Ethan ```
  
 ## Incluir un objeto cualquiera de la Asset Store
 Para realizar esta tarea se ha decidido incluir un pequeño retrete para el personaje Ethan. Éste se ha importado del asset Hut, que incluía otros prefabs interesantes, pero que, no se incluyeron al importar por el mismo motivo que el punto anterior.
 
 ![Imagen del retrete]()
 
## Creación del terreno para los objetos
Se ha creado un terreno, al que, además de incluirle los objetos previamente mencionados, también se han añadido diversas texturas, árboles y césped con el mero objetivo de adaptación a las herramientas que proporcionan los componentes del Terrain. La escena queda de la siguiente forma:

 ![Imagen del terreno]()

## Etiquetado de los objetos
A cada objeto utilizado se le ha creado y asociado su propio Tag:
![Imagen del nombre de las etiquetas]()
![Imagen de etiqueta de un objeto]()

## Dos fuentes de luz en la escena

La realización del penúltimo punto viene dada por duplicar el Directional Light que se pone por defecto en la escena, de modo que al segundo se le ha modificado el color de emisión a un tono naranja oscuro, dando la sensación de que en dicha escena está atardeciendo. No obstante, las posibilidades son numerosas, también se podría haber jugado sencillamente con los colores para conseguir una escena nocturna.

## Scripts 
Como la tarea a realizar es la misma para todos los objetos (a excepción del identificador numérico correspondiente a cada uno), basta con mostrar la estructura del script de uno de ellos:

![Imagen de script]()
![Resultado script]()

## Extras añadidos
### OnMouseDown(), un poco de interactividad en los objetos

A fin de experimentar un poco con las posibilidades que ofrece el motor Unity, se ha añadido a los scripts pedidos la función OnMouseDown(), que imprimirá un mensaje cada vez que se clicke en el gameObject junto al número de veces clickado anteriormente. Dicha funcionalidad funciona perfectamente con los objetos básicos de Unity (nuestras esferas por ejemplo), pero para que funcionen con los otros objetos tales como Ethan o el retrete, es necesario que tengan un collider. Dicho esto, es destacable comentar que el área del collider comprenda la del propio objeto para que el resultado sea lo más satisfactorio posible.

![OnMouseDown]()
!gif

### Wind Zone
Se ha incluido en la escena un Wind Zone cuya función es, conferir a los árboles y hierbajos el efecto de que se mueven con la brisa, dando una sensación de realismo bastante interesante. El efecto de éste variará según cómo se modifiquen variables como su turbulencia, magnitud, etc...
### Water4
Tal y como se podía observar en imágenes anteriores, la escena tambíen cuenta con un pequeño estanque hecho con un Standard Asset llamado Water4, que cuenta con scripts de efectos de movimiento y reflexión de luz sobre el agua. Así, el agua mejora notablemente la calidad de la escena.

# Escena final en movimiento

!gif


