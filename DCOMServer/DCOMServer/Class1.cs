using System;
using System.Runtime.InteropServices;

namespace DCOMServer
{
    [ComVisible(true)]
    [Guid("B1234567-89AB-4CDE-8F01-234567890ABC")] // Genera un GUID único
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface ISumador
    {
        int Sumar(int a, int b);
    }

    [ComVisible(true)]
    [Guid("C1234567-89AB-4CDE-8F01-234567890ABC")]
    [ClassInterface(ClassInterfaceType.None)]
    public class Sumador : ISumador
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }
    }
}

