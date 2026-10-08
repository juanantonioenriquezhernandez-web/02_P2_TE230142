Console.WriteLine("SISTEMA DE CÁLCULO DE FUERZA EN CILINDRO NEUMÁTICO");
Console.WriteLine();

CilindroNeumatico cilindro1 = new CilindroNeumatico();// se crea un objeto de la clase CilindroNeumatico

Console.Write("Ingrese la presión en kPa: ");// se solicita al usuario que ingrese la presión en kPa
cilindro1.PresionKpa = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el área efectiva del pistón en cm²: ");// se solicita al usuario que ingrese el área efectiva del pistón en cm²
cilindro1.AreaCm2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el requerimiento mínimo de fuerza en N: ");// se solicita al usuario que ingrese el requerimiento mínimo de fuerza en N
double fuerzaMinima = Convert.ToDouble(Console.ReadLine());

double fuerzaCalculada = cilindro1.CalcularFuerza();// se calcula la fuerza del cilindro utilizando el método CalcularFuerza()

Console.WriteLine();
Console.WriteLine($"Presión convertida: {cilindro1.PresionKpa * 1000:F2} Pa");// se muestra la presión convertida a Pa
Console.WriteLine($"Área convertida: {cilindro1.AreaCm2 / 10000:F4} m²");// se muestra el área convertida a m²
Console.WriteLine($"Fuerza calculada del cilindro: {fuerzaCalculada:F2} N");// se muestra la fuerza calculada del cilindro
Console.WriteLine($"Evaluación: {cilindro1.EvaluarRequerimiento(fuerzaMinima)}");// se muestra la evaluación del requerimiento mínimo de fuerza

class CilindroNeumatico// se define la clase CilindroNeumatico
{
    public double PresionKpa { get; set; }// propiedad para almacenar la presión en kPa
    public double AreaCm2 { get; set; }// propiedad para almacenar el área efectiva del pistón en cm²

    public double CalcularFuerza()// método para calcular la fuerza del cilindro
    {
        double presionPa = PresionKpa * 1000.0; // se convierte la presión de kPa a Pa
        double areaM2 = AreaCm2 / 10000.0;     // se convierte el área de cm² a m²
        return presionPa * areaM2;              // se calcula la fuerza utilizando la fórmula F = P * A
    }

    public string EvaluarRequerimiento(double fuerzaMinima)// método para evaluar si la fuerza calculada cumple con el requerimiento mínimo
    {
        double fuerza = CalcularFuerza();// se calcula la fuerza del cilindro
        if (fuerza >= fuerzaMinima)
            return "El cilindro CUMPLE con el requerimiento mínimo de fuerza.";// se evalúa si la fuerza calculada es mayor o igual al requerimiento mínimo
        else
            return "El cilindro NO CUMPLE con el requerimiento mínimo de fuerza.";// se evalúa si la fuerza calculada es menor al requerimiento mínimo
    }
}