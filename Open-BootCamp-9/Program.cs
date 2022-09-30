using Open_BootCamp_9;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Cliente objCliente = new Cliente();
objCliente.Edad = 30;
objCliente.Nombre = "Juan";
objCliente.Telefono = "+51 657 7687 768";
objCliente.Credito = 12132.45M;

Console.WriteLine(objCliente);


Trabajador objTrabajador = new Trabajador();
objTrabajador.Edad = 30;
objTrabajador.Nombre = "Mariana";
objTrabajador.Telefono = "+51 657 7687 768";
objTrabajador.Salario = 32132.678M;

Console.WriteLine(objTrabajador);

Console.ReadLine();