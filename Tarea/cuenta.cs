public class Cuenta
{
    public string Codigo { get; set; }
    public string Descripcion { get; set; }
    public double Efectivo { get; set; }

    public Cuenta (string codigo, string descripcion, double efectivo)
    {
        Codigo = codigo;
        Descripcion = descripcion;
        Efectivo = efectivo;
    }

}