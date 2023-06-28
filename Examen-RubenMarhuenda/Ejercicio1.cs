
using System.Text;

class Program
{
    static void Main()
    {
        DateTime[] fechas = new[]
        {
            new DateTime(2023, 1, 1),
            new DateTime(2023, 1, 2),
            new DateTime(2023, 1, 3),
            new DateTime(2023, 1, 4),
            new DateTime(2023, 1, 5),
            new DateTime(2023, 2, 1),
            new DateTime(2023, 2, 2),
            new DateTime(2023, 2, 3),
            new DateTime(2023, 2, 4),
            new DateTime(2023, 2, 5),
            new DateTime(2023, 3, 1),
            new DateTime(2023, 3, 2),
            new DateTime(2023, 3, 3),
            new DateTime(2023, 3, 4),
            new DateTime(2023, 3, 5),
            new DateTime(2023, 4, 1),
            new DateTime(2023, 4, 2),
            new DateTime(2023, 4, 3),
            new DateTime(2023, 4, 4),
            new DateTime(2023, 4, 5)
        };
        DateTime[][] fechasPorDiaSemana = TablaFechasPorDiaSemana(fechas);
        Console.WriteLine(FormateaACadena(fechasPorDiaSemana));
    }
    public static DateTime[][] TablaFechasPorDiaSemana(DateTime[] fechas)
    {
        DateTime[][] fechasDiaSemana = new DateTime[7][];
        for (int i = 0; i < fechas.Length; i++)
        {
            if(fechas[i].DayOfWeek == DayOfWeek.Monday)
            {
                if(fechasDiaSemana[0].Length > 0)
                {
                    Array.Resize(ref fechasDiaSemana[0], fechasDiaSemana[0].Length + 1);
                    fechasDiaSemana[0][fechasDiaSemana[0].Length - 1] = fechas[i];
                }
                else
                {
                    fechasDiaSemana[0] = new DateTime[1];
                    fechasDiaSemana[0][0] = fechas[i];
                }
            }
            else if(fechas[i].DayOfWeek == DayOfWeek.Tuesday)
            {
                if(fechasDiaSemana[1].Length > 0)
                {
                    Array.Resize(ref fechasDiaSemana[1], fechasDiaSemana[1].Length + 1);
                    fechasDiaSemana[1][fechasDiaSemana[1].Length - 1] = fechas[i];
                }
                else
                {
                    fechasDiaSemana[1] = new DateTime[1];
                    fechasDiaSemana[1][0] = fechas[i];
                } 
            }
            else if(fechas[i].DayOfWeek == DayOfWeek.Wednesday)
            {
                if(fechasDiaSemana[2].Length > 0)
                {
                    Array.Resize(ref fechasDiaSemana[2], fechasDiaSemana[2].Length + 1);
                    fechasDiaSemana[2][fechasDiaSemana[2].Length - 1] = fechas[i];
                }
                else
                {
                    fechasDiaSemana[2] = new DateTime[1];
                    fechasDiaSemana[2][0] = fechas[i];
                } 
            }
            else if(fechas[i].DayOfWeek == DayOfWeek.Thursday)
            {
                if(fechasDiaSemana[3].Length > 0)
                {
                    Array.Resize(ref fechasDiaSemana[3], fechasDiaSemana[3].Length + 1);
                    fechasDiaSemana[3][fechasDiaSemana[3].Length - 1] = fechas[i];
                }
                else
                {
                    fechasDiaSemana[3] = new DateTime[1];
                    fechasDiaSemana[3][0] = fechas[i];
                } 
            }
            else if(fechas[i].DayOfWeek == DayOfWeek.Friday)
            {
                if(fechasDiaSemana[4].Length > 0)
                {
                    Array.Resize(ref fechasDiaSemana[4], fechasDiaSemana[4].Length + 1);
                    fechasDiaSemana[4][fechasDiaSemana[4].Length - 1] = fechas[i];
                }
                else
                {
                    fechasDiaSemana[4] = new DateTime[1];
                    fechasDiaSemana[4][0] = fechas[i];
                } 
            }
            else if(fechas[i].DayOfWeek == DayOfWeek.Saturday)
            {
                if(fechasDiaSemana[5].Length > 0)
                {
                    Array.Resize(ref fechasDiaSemana[5], fechasDiaSemana[5].Length + 1);
                    fechasDiaSemana[5][fechasDiaSemana[5].Length - 1] = fechas[i];
                }
                else
                {
                    fechasDiaSemana[5] = new DateTime[1];
                    fechasDiaSemana[5][0] = fechas[i];
                } 
            }
            else if(fechas[i].DayOfWeek == DayOfWeek.Sunday)
            {
                if(fechasDiaSemana[6].Length > 0)
                {
                    Array.Resize(ref fechasDiaSemana[6], fechasDiaSemana[6].Length + 1);
                    fechasDiaSemana[6][fechasDiaSemana[6].Length - 1] = fechas[i];
                }
                else
                {
                    fechasDiaSemana[6] = new DateTime[1];
                    fechasDiaSemana[6][0] = fechas[i];
                } 
            }
        }
        return fechasDiaSemana;
    }
    public static string FormateaACadena(DateTime[][] fechas)
    {
        return $"";
    }
}
