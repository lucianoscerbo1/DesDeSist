// See https://aka.ms/new-console-template for more information

Tienda tienda1= new Tienda("Pawn Shop",new Direccion("Avenida Jujuy",255,1423),new List<Articulo>{});
Articulo articulo1 = new Articulo("Pistola WWII",150.22,true,Categoria.ANTIGUEDAD,Condicion.REGULAR);
Articulo articulo2 = new Articulo("Moneda Bingo", 5.21, false,Categoria.ANTIGUEDAD,Condicion.BUENO);
Articulo articulo3 = new Articulo("", 2.50, true,Categoria.ALHAJAS,Condicion.BUENO);

tienda1.AgregarArticulo(articulo1);
tienda1.AgregarArticulo(articulo2);
tienda1.AgregarArticulo(articulo3);
articulo3.setNombre("Collar");

tienda1.RemoverArticulo("Moneda Bingo");
tienda1.buscarArticulo("Collar");
tienda1.buscarArticulo("Machete");

