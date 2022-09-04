# S - Single Responsability

“una clase debería tener **una, y solo una, razón para cambiar**”

“Cada clase debe tener una unica responsabilidad en el sistema, y de esta manera asegurarnos de que la cumple muy bien”

Como ejemplo tenemos una clase que se encarga de la creacion de un nuevo usuario, podemos ver que la clase `UserRegistry` se encarga de crear el usuario como tambien de encriptar su contraseña, esto estaria rompiendo el principio de Single Responsability.

![Untitled](S%20-%20Single%20Responsability%201f23d03f292a4364bb6734b668784692/Untitled.png)

Para poder aplicar el primer principio, tendriamos que crear la clase `PasswordEncrypter`  para poder delegar esta accion y que esta nueva clase sea la encargada de encriptar la contraseña del usuario.

![Untitled](S%20-%20Single%20Responsability%201f23d03f292a4364bb6734b668784692/Untitled%201.png)

![Untitled](S%20-%20Single%20Responsability%201f23d03f292a4364bb6734b668784692/Untitled%202.png)
