public class Oficina
{
    public Oficina(string ciudad, string departamente, string despacho)
    {
        Ciudad = ciudad;
        Departamento = departamente;
        Despacho = despacho;
    }

    public string Ciudad { get; }
    public string Departamento { get; }
    public string Despacho { get; }

    public override string ToString() => $"Oficina: [ {Ciudad} {Departamento} {Despacho} ]";
}
