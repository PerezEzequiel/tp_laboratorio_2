using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void VerificarIgualdadInstrumento_OK()
        {
            Guitarra guitarra = new Guitarra(6, ETipoGuitarra.Electrica, 500, 1, "Fender", "Telecaster", false, 20, EOrigen.Mexico);
            Bateria bateria = new Bateria(4, 1, 1000, "DW", "ModeloDW", true, 20, EOrigen.Peru);
            bool rta;

            rta = guitarra == bateria;

            Assert.IsTrue(rta);
        }

        [TestMethod]
        public void VerificarIgualdadInstrumento_Falla()
        {
            Guitarra guitarra = new Guitarra(6, ETipoGuitarra.Electrica, 500, 2, "Fender", "Telecaster", false, 20, EOrigen.Mexico);
            Bateria bateria = new Bateria(4, 1, 1000, "DW", "ModeloDW", true, 20, EOrigen.Peru);
            bool rta;

            rta = guitarra == bateria;

            Assert.IsFalse(rta);
        }

        [TestMethod]
        public void VerificarIgualdadEmpleado_OK()
        {
            Empleado empleadoUno = new Empleado(43575182,"Ezequiel","Perez",40,ETipoEmpleado.AtencionAlCliente,DateTime.Now);
            Empleado empleadoDos = new Empleado(43575182, "Juana", "asd", 40, ETipoEmpleado.AtencionAlCliente, DateTime.Now);
            bool rta;

            rta = empleadoUno == empleadoDos;

            Assert.IsTrue(rta);
        }

        [TestMethod]
        public void VerificarIgualdadEmpleado_Falla()
        {
            Empleado empleadoUno = new Empleado(43575182, "Ezequiel", "Perez", 40, ETipoEmpleado.AtencionAlCliente, DateTime.Now);
            Empleado empleadoDos = new Empleado(43175182, "Juana", "asd", 40, ETipoEmpleado.AtencionAlCliente, DateTime.Now);
            bool rta;

            rta = empleadoUno == empleadoDos;

            Assert.IsFalse(rta);
        }

        [TestMethod]
        public void AgregarStock_OK()
        {
            Local<Instrumento> local = new Local<Instrumento>(3, "Lo de carlitos", "calle 123", 1000);
            Trompeta trompeta = new Trompeta("A",1,200,"MarcaTrompeta","ModeloTrompeta",false,20,EOrigen.Mexico);

            bool rta = local + trompeta;

            Assert.IsTrue(rta);
        }
        [TestMethod]
        public void AgregarStock_Falla()
        {
            Local<Instrumento> local = new Local<Instrumento>(3, "Lo de carlitos", "calle 123", 1000);
            Trompeta trompeta = new Trompeta("A", 1, 200, "MarcaTrompeta", "ModeloTrompeta", false, 20, EOrigen.Mexico);
            Trompeta trompetaDos = new Trompeta("A", 1, 200, "MarcaTrompeta", "ModeloTrompeta", false, 20, EOrigen.Mexico);
            bool rta;

            _ = local + trompeta;
            rta = local + trompetaDos;

            Assert.IsFalse(rta);
        }
    }
}
