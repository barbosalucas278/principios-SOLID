# L - Liskov Substitution

“Toda clase que es hija de otra clase, debe poder utilizarse como si fuese el mismo padre”

Ejemplo:

Tenemos la clase `Duck`, con sus propio metodos entre ellos el metodo `fly()` , ahora queremos representar la clase `RubberDuck` que hereda de `Duck` , tenemos un problema la clase `RubberDuck` es un patito de goma, no puede volar.

```jsx
class Duck {
	function fly ();
	function swim();
	function cuack();
}

class RubberDuck extends Duck {
	function fly(){
		throw new Error();
	}
	function swim() {
		console.log("go swim!");	
	}
	function cuack() {
		console.log("say cuack!");
	}
}
```

Estariamos violando el principio de sustitucion de liskov, ya que el pato de goma no se comportaría igual a un pato convencional, para solventar este error lanzado por el pato de goma al no poder volar deberiamos controlar ese excepcion.

```jsx
class DuckProcesser {
	function makeDucksFly(ducks: Duck[]) {
		for (let duck of ducks){
			try {
				duck.fly();
			}
			catch(error) {
				console.log('RubberDuck cant fly!");
			}
		}
	}
}
```

La solución y aplicación dle principio de sustitución de liskiv sería diseñando interfaces individuales de forma que cada clase pueda implementar lo que le corresponde.

```jsx
interface IFly {
	function fly(): void;
}

interface ISwim {
	function swim(): void;
}

interface ICuack{
	function cuack(): void;
}

class Duck implements IFly, ISwim, ICuack {
	function fly();
	function swim();
	function cuack();
}

class RubberDuck implements ISwim, ICuack {
	function swim() {
		console.log("go swim!");	
	}
	function cuack() {
		console.log("say cuack!");
	}
}

class DuckProcesser {
	function makeDucksFly(ducks: IFly[]){
		for (let duck of ducks){
			duck.fly();
		}
	}
}
```

el metodo `makeDucksFly` solamente admitira classes que implementen la interface IFly.