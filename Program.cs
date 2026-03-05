Dictionary<string, double> estudiantes = new Dictionary<string, double>();

estudiantes.Add("Moisés", 89);
estudiantes.Add("Carlos", 70);
estudiantes.Add("Marcos", 61);

foreach(var item in estudiantes)
{
    Console.WriteLine($"Nombre: {item.Key}, Nota: {item.Value}. ");
}

estudiantes.Remove("Carlos");

Console.WriteLine("Presione cualquer tecla. ");
Console.ReadKey();

foreach(var item in estudiantes)
{
    Console.WriteLine($"Nombre: {item.Key}, Nota: {item.Value}. ");
}