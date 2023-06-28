
class Program
{
    static void Main()
    {
        Empresa empresa = new("IES Doctor Balmis");
        empresa.AgregarEmpleado(new Empleado(123, "María Pérez", 2015, 35.5D, new SalarioFijoStrategy()));
        empresa.AgregarEmpleado(new Empleado(456, "Juan Martínez", 2017, 40D, new SalarioPorDiasStrategy()));
        empresa.AgregarEmpleado(new JefeDepartamento("ventas", 789, "Ana López", 2019, 45D, new SalarioFijoStrategy()));


        empresa.GetEmpleado(123)?.AsignarOficina(new Oficina("madrid", "ventas", "M1"));
        empresa.GetEmpleado(456)?.AsignarOficina(new Oficina("valencia", "compras", "V1"));
        empresa.GetEmpleado(789)?.AsignarOficina(new Oficina("alicante", "ventas", "A1"));

        try
        {
            empresa.RegistrarDiaTrabajado(123, new DateTime(2023, 1, 1));
            empresa.RegistrarDiaTrabajado(456, new DateTime(2023, 1, 1));
            empresa.RegistrarDiaTrabajado(789, new DateTime(2023, 1, 3));
            empresa.RegistrarDiaTrabajado(123, new DateTime(2023, 1, 3));
            empresa.RegistrarDiaTrabajado(456, new DateTime(2023, 1, 3));
            empresa.RegistrarDiaTrabajado(789, new DateTime(2023, 1, 5));
            empresa.RegistrarDiaTrabajado(123, new DateTime(2023, 1, 5));
            empresa.RegistrarDiaTrabajado(456, new DateTime(2023, 1, 5));
            empresa.RegistrarDiaTrabajado(789, new DateTime(2023, 2, 1));
            empresa.RegistrarDiaTrabajado(123, new DateTime(2023, 2, 1));
            empresa.RegistrarDiaTrabajado(456, new DateTime(2023, 2, 1));
            empresa.RegistrarDiaTrabajado(789, new DateTime(2023, 2, 3));
            empresa.RegistrarDiaTrabajado(123, new DateTime(2023, 2, 3));
            empresa.RegistrarDiaTrabajado(456, new DateTime(2023, 2, 3));
            empresa.RegistrarDiaTrabajado(789, new DateTime(2023, 2, 5));
            empresa.RegistrarDiaTrabajado(123, new DateTime(2023, 2, 5));
            empresa.RegistrarDiaTrabajado(456, new DateTime(2023, 2, 5));
            empresa.RegistrarDiaTrabajado(789, new DateTime(2023, 3, 1));
            empresa.RegistrarDiaTrabajado(123, new DateTime(2023, 3, 1));
            empresa.RegistrarDiaTrabajado(456, new DateTime(2023, 3, 1));
            empresa.RegistrarDiaTrabajado(789, new DateTime(2023, 3, 3));
            empresa.RegistrarDiaTrabajado(123, new DateTime(2023, 3, 3));
            empresa.RegistrarDiaTrabajado(456, new DateTime(2023, 3, 3));
            empresa.RegistrarDiaTrabajado(789, new DateTime(2023, 3, 5));
            empresa.RegistrarDiaTrabajado(123, new DateTime(2023, 3, 5));
            empresa.RegistrarDiaTrabajado(456, new DateTime(2023, 3, 5));
            empresa.RegistrarDiaTrabajado(789, new DateTime(2023, 4, 1));
            empresa.RegistrarDiaTrabajado(123, new DateTime(2023, 4, 1));
            empresa.RegistrarDiaTrabajado(456, new DateTime(2023, 4, 1));
            empresa.RegistrarDiaTrabajado(789, new DateTime(2023, 4, 3));
            empresa.RegistrarDiaTrabajado(123, new DateTime(2023, 4, 3));
            empresa.RegistrarDiaTrabajado(456, new DateTime(2023, 4, 3));
            empresa.RegistrarDiaTrabajado(789, new DateTime(2023, 4, 5));
            empresa.RegistrarDiaTrabajado(123, new DateTime(2023, 4, 5));
            empresa.RegistrarDiaTrabajado(456, new DateTime(2023, 4, 5));
        }
        catch (EmpresaException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine(empresa);
    }
}
class JefeDepartamento : Empleado
{
    public class EmpresaException : Exception
    {
        public EmpresaException(string mensaje) : base(mensaje){}
    }
    public JefeDepartamento(string departamento, int Dni, string Nombre, int AñoContrato, double HorasSemanales, List<DateTime> DiasTrabajados, ISalarioStrategy salario): base (Dni, Nombre,  AñoContrato, HorasSemanales, salario)
    {
        Departamento = departamento;
    }

    public override void AsignarOficina(Oficina oficina)
    {
        throw new EmpresaException("La oficina no pertenece al departamento del jefe");
    }
    public string Departamento { get; }

    public override string ToString()
    {
        return $"Jefe de Departamento: {Departamento}\n" + base.ToString();
    }
}
public interface ISalarioStrategy
{
    double CalculaSalarioBase(Empleado empleado);
}
class SalarioFijoStrategy : ISalarioStrategy
{
    public abstract double CalculaSalarioBase(Empleado empleado) => empleado.HorasSemanales * 50;
}
class SalarioPorDiasStrategy : ISalarioStrategy
{
    public double CalculaSalarioBase(Empleado empleado)
    {
        double precioPorDia = empleado.HorasSemanales / 7 * 50;
        double salario = 0;
        double salarioBase = 0;
        double plus = 0;
        foreach (DateTime dia in empleado.DiasTrabajados)
        {
            if(dia.DayOfWeek == DayOfWeek.Sunday)
                salario = precioPorDia * 2;
            else 
                salario = precioPorDia;
            salarioBase =+ salario;
        }
        plus = salarioBase * 0.15;
        if (empleado.Oficina.Ciudad == "madrid")
            salarioBase = salarioBase + plus;
        return salarioBase;
    }
}
class Empresa
{
    private Dictionary<int, Empleado> Empleados;
    public string Nombre { get; }
    
    public Empresa(string nombre)
    {
        Nombre = nombre;
    }
    public void AgregarEmpleado(Empleado empleado)
    {
        Empleados.Add(empleado.Dni, empleado);
    }
    public void RegistrarDiaTrabajado(int dni, DateTime fecha)
    {
        foreach(int d in Empleados.Keys)
        {
            if (dni == Empleados[d].Dni)
            {
                
                Empleados[d].DiasTrabajados.Add(fecha);
            }
            else if (dni != Empleados[d].Dni)
                break;
            else 
                throw new JefeDepartamento.EmpresaException("El empleado no existe");
            
        }
    }
    public Empleado GetEmpleado(int dni)
    {
        if(dni == Empleados[dni].Dni)
            return Empleados[dni];
        else
            return null;
    }
    public override string ToString()
    {
        return $"";
    }
}