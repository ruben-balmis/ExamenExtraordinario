public class Principal
{
    static void Main()
    {
        // Consulta 1: Nombre de los empleados que se incorporaron a la empresa después de 2013
        // ordenados por nombre.
        var resultado1 = RegistroTrabajo.Empleados().Where(x => x.AñoContrato > 2013)
                                                    .OrderBy(x => x.Nombre)
                                                    .Select(x => x.Nombre);
        Console.WriteLine(string.Join("\n", resultado1));

        // Consulta 2: Nombre, ciudad y despacho de aquellos empleados que trabajan en el departamento de ventas.
        var resultado2 =  RegistroTrabajo.Empleados().Where(x=> x.Oficina.Departamento == "ventas")
                                                     .Select(x => new {
                                                        Nombre = x.Nombre,
                                                        Ciudad = x.Oficina.Ciudad,
                                                        Despacho = x.Oficina.Despacho
                                                     });
        Console.WriteLine(string.Join("\n", resultado2));

        // Consulta 3: Muestra el total de días trabajados por ciudad.
        var resultado3 =  RegistroTrabajo.Empleados().Select(x => new {
                                                                Ciudad = x.Oficina.Ciudad,
                                                                TotalDiasTrabajados = x.DiasTrabajados.Count()
                                                            })
                                                     ;
        Console.WriteLine(string.Join("\n", resultado3));

        // Consulta 4: Muestra día/mes/año de los días trabajados por todos los departamentos sin repeticiones y ordenados
        // empezando por el más reciente.
        var resultado4 =  "";
        Console.WriteLine(string.Join(", ", resultado4));
    }
}
