using PooDemo.Interfaces;
using PooDemo.Models;

namespace PooDemo
{
    internal class ImprimirInfo
    {
        internal static void ImprimirCelular(Car iphone14)
        {
            throw new NotImplementedException();
        }

        public void ImprimirCelular(ICelulares info)
        {
            Console.WriteLine($"ID: {info.Id}");
            Console.WriteLine($"Nombre: {info.Nombre}");
        }
    }
}