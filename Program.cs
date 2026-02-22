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
switch (rol)
{
    case 1:
        if (dia <= 5 && (hora >= 7 && hora <= 18) && carnet == "Si")
        {
            if (traeUsb == "Si")
            {
                Console.Write("¿Está acompañado? (Si/No): ");
                string acompañado = (Console.ReadLine());

                if (acompañado == "Si" && autorizacion == "Si")
                {
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Acceso permitido");
                    Console.WriteLine("Nivel de permiso: Estudiante con periféricos");
                    Console.WriteLine("-------------------------------------------");
                }
                else
                {
                    Console.WriteLine("Acceso denegado: USB requiere acompañamiento y autorización");
                }
            }
            else
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Acceso permitido");
                Console.WriteLine("Nivel de permiso: Estudiante Estándar");
                Console.WriteLine("-------------------------------------------");
            }
        }
        else
        {
            Console.WriteLine("Acceso denegado: Fuera de horario o carnet no vigente");
        }
        break;
    case 2:
        if (carnet == "S")
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Acceso permitido");
            Console.WriteLine("Nivel de permiso: Docente - Acceso Total");
            Console.WriteLine("-------------------------------------------");
        }
        else
        {
            Console.WriteLine("Acceso denegado: Carnet obligatorio");
        }
        break;

    case 3:
        if ((hora >= 7 && hora <= 18) || autorizacion == "S")
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Acceso permitido");
            Console.WriteLine("Nivel de permiso: Técnico - Mantenimiento");
            Console.WriteLine("-------------------------------------------");
        }
        else
        {
            Console.WriteLine("Acceso denegado: Requiere autorización para horario nocturno");
        }
        break;
    case 4:
        if (autorizacion == "S")
        {
            Console.Write("¿Está acompañado por personal autorizado? (S/N): ");
            string acompañado = Console.ReadLine().ToUpper();

            if (acompañado == "S")
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Acceso permitido");
                Console.WriteLine("Nivel de permiso: Visitante Temporal");
                Console.WriteLine("-------------------------------------------");
            }
            else
            {
                Console.WriteLine("Acceso denegado: Visitante requiere acompañamiento");
            }
        }
        else
        {
            Console.WriteLine("Acceso denegado: Visitante requiere autorización escrita");
        }
        break;
}