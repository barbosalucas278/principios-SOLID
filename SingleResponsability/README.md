# O - Open Closed

“Una entidad debe quedarse abierta para su extensión y cerrada para su modificación”

Esto hace que nuestro sistema sea mas robusto, protegiendo las funcionalidades basicas de nuestro sistema. Haciendo que cada vez que los requerimientos cambien, o se tenga que aagregar una nueva funcionalidad las funcionalidades existentes no se vean afectadas. Para poder aplicar este principio se puede usar Herencia y Polimorfismo.

Ejemplo:

Tenemos la clase Rectangley la clase AreaCalculator que calcula el area de cada Shape

```jsx
class Rectangle {
	width:number;
	heigth:number;
}

class AreaCalculator {
	function computeArea(shapes: Rectangles[]){}
		let area = 0;
		for (let shape of shapes){
				area += (shape.width * shape.heigth);
			}
		return area;
	}
}
```

en este caso no tendríamos problemas con nuestro sistema, ¿pero que pasaria que queremos implementar la forma Triangle y calcular tambien su area? No sencontraríamos con un problema, debido a que el area de un triangulo se calcula de distinta forma a la de un rectangulo.

```jsx
class AreaCalculator {
	function computeArea(shapes: Rectangle[]){}
		let area = 0;
		for (let shape of shapes){
				if(typeof shape === "Rectangle"){
					area += (shape.width * shape.heigth);	
				}
				if(typeof shape === "Triangle"){
					area += (shape.width * shape.heigth)/2;
				}				
			}
		return area;
	}
}
```

Así nuestra clase `AreaCalculator` queda abierta a modificaciones cada vez que nosotros queramos agregar nuevas Shapes, esto da lugar a posibles bugs y codigo complejo de entender.

Para poder lidiar con este problema y aplicar el principio de Open Closed tendríamos que aplicar polimorfismo, creando una clase o en este caso una interface que contenga ese metodo de calcular el area de manera generica, asi cada objeto puede hacer una implementacion mas especifica de ese método.

```jsx
interface IShape {
	function area(): number;
}

class Rectangle implements IShape {
	width: number;
	heigth: number;

	function area() {
		return this.width * this.heigth
	}
}

class Triangle implements IShape {
	width: number;
	heigth: number;

	function area() {
		return this.width * this.heigth / 2
	}
}

class AreaCalculator {
	function computeArea(shapes: IShape[]){
		let area = 0;
		for (let shape of shapes){
			area += shape.area();
		}
		return area;
	}
}
```

De este modo a `AreaCalculator` no tiene ni idea, ni tampoco le interesa que tipo de shape son las shapes que le pasaron para sumar las areas, esto es porque cada una implementa la interface IShape que asegura/determina el comportamiento de dicha clase haciendo que deba implementar el metodo de calclar el area.
