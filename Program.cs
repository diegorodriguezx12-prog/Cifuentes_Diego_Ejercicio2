Console.WriteLine("=== Control de Acceso a Laboratorio Universitario ===");
Console.WriteLine("Seleccione su Rol:");
Console.WriteLine("Estudiante(1) -- Docente(2) -- Técnico IT(3) -- Visitante(4)");
Console.Write("Opción: ");
int rol = int.Parse(Console.ReadLine());

Console.Write("Hora (0-23): ");
int hora = int.Parse(Console.ReadLine());

Console.Write("Día (1-7 / 1 = Lunes, 2 = Martes...): ");
int dia = int.Parse(Console.ReadLine());

Console.Write("¿Carnet vigente? (Si/No): ");
string carnet = (Console.ReadLine());

Console.Write("¿Autorización escrita? (Si/No): ");
string autorizacion = (Console.ReadLine());

Console.Write("¿Trae USB? (Si/No): ");
string traeUsb = (Console.ReadLine());

if (hora < 0 || hora > 23)
{
    Console.WriteLine("Error: hora fuera de rango");
    return;
}
else if (dia < 1 || dia > 7)
{
    Console.WriteLine("Error: día fuera de rango");
    return;
}
else if (rol < 1 || rol > 4)
{
    Console.WriteLine("Error: opción de rol no válida");
    return;
}