using System;
using System.Collections.Generic;

public class Cuentas
{
    public List<Cuenta> ListadeCuentas { get; set; }
    public Cuentas()
    {
        ListadeCuentas = new List<Cuenta>();

        Cuenta a = new Cuenta("001", "Deudas    ", 5000);
        Cuenta b = new Cuenta("002", "Pagos     ", 2500);
        Cuenta c = new Cuenta("003", "Inventario", 13000);
        Cuenta d = new Cuenta("004", "Utilidades", 4000);
        Cuenta e = new Cuenta("005", "Otros     ", 6000);
        

        ListadeCuentas.Add(a);
        ListadeCuentas.Add(b);
        ListadeCuentas.Add(c);
        ListadeCuentas.Add(d);
        ListadeCuentas.Add(e);
    }

    
    public void listarCuentas() {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Listado de Productos");
        Console.WriteLine("********************");
        Console.WriteLine("Codigo, Descripcion y Existencia");

        foreach (var cuenta in ListadeCuentas)
        {
            Console.WriteLine(cuenta.Codigo + " | " + cuenta.Descripcion );
        }

        Console.ReadLine();
    }

    private void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) {
        foreach (var cuenta in ListadeCuentas)
        {
            if (cuenta.Codigo == codigo) {
                if (tipoMovimiento == "+") {
                    cuenta.Efectivo = cuenta.Efectivo + cantidad;
                } else {
                    cuenta.Efectivo = cuenta.Efectivo - cantidad;
                }
            }         
        }
    }

    public void ingresoEfectivo()
     {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Ingreso de Productos  Inventario");
        Console.WriteLine("*******************************");
        Console.Write("Ingrese el codigo de producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad de producto: ");
        cantidad = Console.ReadLine();

        movimientoInventario(codigo, Int32.Parse(cantidad), "+");
    }


    public void Pagoefectivo()
     {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Ingreso de Productos  Inventario");
        Console.WriteLine("*******************************");
        Console.Write("Ingrese el codigo de producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad de producto: ");
        cantidad = Console.ReadLine();

        movimientoInventario(codigo, Int32.Parse(cantidad), "-");
    }
    public void Estadofinanciero() {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Listado de Productos");
        Console.WriteLine("********************");
        Console.WriteLine("Codigo, Descripcion y Existencia");

        foreach (var cuenta in ListadeCuentas)
        {
            Console.WriteLine(cuenta.Codigo + " | " + cuenta.Descripcion + " | " + cuenta.Efectivo.ToString());
        }

        Console.ReadLine();
    }
    
}

    