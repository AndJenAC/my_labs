function agregar() {
    var lista = document.getElementById("lista");

    var elementoActual = lista.getElementsByTagName("li").length;
    var newElemento = document.createElement("li");

    newElemento.textContent = "Elemento" + (elementoActual + 1);
    lista.appendChild(newElemento);
}



const colores = ["lightblue", "lightgreen", "lightpink", "lightyellow", "lavender"];
function cambiarFondo() {
	
	
	
	if (document.body.style.backgroundColor != "white"){
		document.body.style.backgroundColor = "white";
	}else{
		const colorRandom = colores[Math.floor(Math.random() * colores.length)];
		document.body.style.backgroundColor = colorRandom;
	}
}

function borrar() {
    var lista = document.getElementById("lista");
    if (lista.getElementsByTagName("li").length > 0) {
        lista.removeChild(lista.lastChild);
    }
}
