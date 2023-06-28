public class Empleado
{
    public Empleado(int dni, string nombre, int añoContrato, double horasSemanales, //List<DateTime> diasTrabajados
    ISalarioStrategy salario)
    {
        Dni = dni;
        Nombre = nombre;
        AñoContrato = añoContrato;
        HorasSemanales = horasSemanales;
        SalarioStrategy = salario;
        //DiasTrabajados = diasTrabajados;
    }

    public int Dni { get; }
    public string Nombre { get; }
    public int AñoContrato { get; }
    public double HorasSemanales { get; }
    public Oficina? Oficina;
    public List<DateTime> DiasTrabajados { get; }
    private ISalarioStrategy SalarioStrategy { get; }
    
    
     

    public virtual void AsignarOficina(Oficina oficina)
    {
        Oficina = oficina;
    }
    public override string ToString()
    {
        return $"\n{Dni} {Nombre} {AñoContrato} {HorasSemanales} {Oficina}\nDías Trabajados: {string.Join(", ", DiasTrabajados)}\n";
    }
}
