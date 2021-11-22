using Entidades;
using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    ///Creo instrumentos
            //    Guitarra guitarra = new Guitarra(6, ETipoGuitarra.Electrica, 500, 1, "Fender", "Telecaster", false, 20, EOrigen.Mexico);
            //    Bateria bateria = new Bateria(4, 2, 1000, "DW", "ModeloDW", true, 20, EOrigen.Peru);
            //    Trompeta trompeta = new Trompeta("Sol", 3, 100, "Bach", "modeloBach", false, 20, EOrigen.EstadosUnidos);

            //    //Creo instrumentos con el mismo codigo NO se va a poder agregar.

            //    Guitarra guitarraDos = new Guitarra(6, ETipoGuitarra.Electrica, 200, 1, "Ephipone", "SG", false, 20, EOrigen.EstadosUnidos);
            //    Bateria bateriaDos = new Bateria(4, 2, 1000, "Yamaha", "ModeloYamaha", true, 20, EOrigen.Peru);
            //    Trompeta trompetaDos = new Trompeta("Sol", 3, 100, "Bach", "modeloBach", false, 20, EOrigen.EstadosUnidos);

            //    //Creo empleados

            //    Empleado empleado = new Empleado(12345678, "Juana", "Lopez", 50, ETipoEmpleado.AtencionAlCliente, DateTime.Now);
            //    Empleado empleadoDos = new Empleado(12415118, "Roberto", "Lopez", 50, ETipoEmpleado.Luthier, DateTime.Now);

            //    //Creo un local
            //    Local<Instrumento> miLocal = new Local<Instrumento>(6, "Lo de carlitos", "Av. Montes de oca 123", 10000);

            //    //Agrego Instrumentos al stock
            //    if (miLocal + guitarra && miLocal + bateria && miLocal + trompeta)
            //    {
            //        Console.WriteLine("Agregados a la lista de stock!");
            //    }
            //    //Agrego instrumentos con codigo repetido
            //    if (!(miLocal + guitarraDos) && !(miLocal + bateriaDos)&& !(miLocal + trompetaDos))
            //    {
            //        Console.WriteLine("No se pudieron agregar instrumentos por codigo repetido");
            //    }

            //    //Muestro El stock

            //    Console.Write(Local<Instrumento>.MostrarStock(miLocal));

            //    Console.ReadKey();
            //    Console.Clear();



            //    //Vendo Instrumentos

            //    if (miLocal - guitarra && miLocal - bateria && miLocal - trompeta)
            //    {
            //        Console.WriteLine("Instrumentos vendidos!");
            //    }

            //    //Muestro las ventas

            //    Console.Write(Local<Instrumento>.MostrarVentas(miLocal));

            //    Console.ReadKey();
            //    Console.Clear();

            //    //Agrego empleados a mi local

            //    if (Local<Instrumento>.AgregarEmpleado(miLocal,empleado) && Local<Instrumento>.AgregarEmpleado(miLocal,empleadoDos))
            //    {
            //        Console.Write("Empleados agregados");
            //    }

            //    //Muestro empleados
            //    Console.Write(Local<Instrumento>.MostrarEmpleados(miLocal));

            //    Console.ReadKey();
            //    Console.Clear();

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //ADOTrompeta aDOBateria = new ADOTrompeta();
            //Trompeta trompeta = new Trompeta("Sol", 3, 100, "Bach", "modeloBach", false, 20, EOrigen.EstadosUnidos);
            //aDOBateria.AgregarTrompeta(trompeta);

            ////aDOGuitarra.ModificarGuitarra(guitarraDos);
            ////aDOGuitarra.BorrarGuitarra(guitarraDos);
            //List<Trompeta> lista = aDOBateria.ObtenerListaTrompeta();

            //foreach (Trompeta item in lista)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            ADOTrompeta adoTrompeta= new ADOTrompeta();
            Trompeta trompeta = adoTrompeta.ObtenerTrompeta(3);

            adoTrompeta.BorrarTrompeta(trompeta);

        }
    }
}
