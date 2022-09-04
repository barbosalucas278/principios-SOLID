Como ejemplo tenemos una clase que se encarga de la creacion de un nuevo usuario, podemos ver que la clase `UserRegistry` se encarga de crear el usuario como tambien de encriptar su contraseña, esto estaria rompiendo el principio de Single Responsability.

![Untitled](https://github.com/barbosalucas278/principios-SOLID/blob/main/assets/images/Untitled.png)

Para poder aplicar el primer principio, tendriamos que crear la clase `PasswordEncrypter`  para poder delegar esta accion y que esta nueva clase sea la encargada de encriptar la contraseña del usuario.

![Untitled](https://github.com/barbosalucas278/principios-SOLID/blob/main/assets/images/Untitled%201.png)

![Untitled](https://github.com/barbosalucas278/principios-SOLID/blob/main/assets/images/Untitled%202.png)
