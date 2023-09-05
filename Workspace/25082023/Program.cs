// See https://aka.ms/new-console-template for more information

Jugador jugador1 = new Jugador("Luciano", "Scerbo", 10);
Jugador jugador2 = new Jugador("Tobias", "Gimenez", 7);
Jugador jugador3 = new Jugador("Luis", "Rodriguez", 5);
Jugador jugador4 = new Jugador("John", "Lopez", 3);
Jugador jugador5 = new Jugador("Carlos", "Martinez", 8);
Jugador jugador6 = new Jugador("Pedro", "Garcia", 9);
Jugador jugador7 = new Jugador("Alberto", "Fernandez", 11);
Jugador jugador8 = new Jugador("Esteban", "Torres", 4);
Jugador jugador9 = new Jugador("Diego", "Diaz", 6);
Jugador jugador10 = new Jugador("Leandro", "Sanchez", 2);


Entrenador entrenador1 = new Entrenador ("Francisco", "Heili", Tactica.DEFENSIVA);  
Entrenador entrenador2 = new Entrenador("Lionel", "Scaloni", Tactica.OFENSIVA);
Entrenador entrenador3 = new Entrenador("Eduardo", "Gonzalez", Tactica.EQUILIBRADA);

Empleado empleado1 = new Empleado("Miguel", "Gomez", "Administrativo");
Empleado empleado2 = new Empleado("Ana", "Martinez", "Contador");
Empleado empleado3 = new Empleado("Marta", "Lopez", "Jefe de operaciones");

Direccion direccion1 = new Direccion("Brandsen", 805, "Ciudad Autonoma de Buenos Aires");

Equipo equipo1 = new Equipo(Categoria.PRIMERA,  entrenador1,new List<Jugador>{jugador1, jugador2, jugador3} );
Equipo equipo2 = new Equipo(Categoria.SEGUNDA, entrenador2, new List<Jugador> { jugador4, jugador5, jugador6 });
Equipo equipo3 = new Equipo(Categoria.TERCERA, entrenador3, new List<Jugador> { jugador7, jugador8, jugador9, jugador10 });

Club club1 = new Club("Boca Juniors", 1905, direccion1, new List<Empleado>{empleado1, empleado2, empleado3}, new List<Equipo>{equipo1, equipo2, equipo3} );




club1.AgregarEquipo(equipo1);
var  jugadores = equipo1.getListaJugadores();
var empleados = club1.getListaEmpleados();
equipo1.getEntrenador().presentar();

foreach (var jugador in jugadores)
{
    jugador.presentar();
}
foreach (var empleado in empleados)
{
    empleado.presentar();
}