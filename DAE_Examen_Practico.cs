using System;

class Program
{
    struct Alumno
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Grado { get; set; }
        public int AñoRegistro { get; set; }
    }

    static Alumno[] listaAlumnos = new Alumno[100]; // Arreglo para almacenar información de alumnos
    static int contadorAlumnos = 0; // Contador para llevar un registro de los alumnos agregados

    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Menú Principal:");
            Console.WriteLine("1. Agregar un alumno");
            Console.WriteLine("2. Mostrar listado de alumnos");
            Console.WriteLine("3. Buscar alumno por código");
            Console.WriteLine("4. Editar información de un alumno por código");
            Console.WriteLine("5. Registrar una canción MP3");
            Console.WriteLine("6. Mostrar datos de la canción MP3");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarAlumno();
                    break;
                case 2:
                    MostrarListadoAlumnos();
                    break;
                case 3:
                    BuscarAlumnoPorCodigo();
                    break;
                case 4:
                    EditarAlumnoPorCodigo();
                    break;
                case 5:
                    RegistrarCancionMP3();
                    break;
                case 6:
                    MostrarDatosCancionMP3();
                    break;
                case 7:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
    }

    static void AgregarAlumno()
    {
        if (contadorAlumnos < listaAlumnos.Length)
        {
            Console.Write("Ingrese el código del alumno: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre completo del alumno: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la fecha de nacimiento del alumno (YYYY-MM-DD): ");
            DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());

            Console.Write("Ingrese el grado del alumno: ");
            string grado = Console.ReadLine();

            Console.Write("Ingrese el año de registro del alumno: ");
            int añoRegistro = int.Parse(Console.ReadLine());

            Alumno nuevoAlumno = new Alumno
            {
                Codigo = codigo,
                Nombre = nombre,
                FechaNacimiento = fechaNacimiento,
                Grado = grado,
                AñoRegistro = añoRegistro
            };

            listaAlumnos[contadorAlumnos] = nuevoAlumno;
            contadorAlumnos++;

            Console.WriteLine("Alumno agregado correctamente.");
        }
        else
        {
            Console.WriteLine("La lista de alumnos está llena. No se pueden agregar más alumnos.");
        }
    }

    static void MostrarListadoAlumnos()
    {
        Console.WriteLine("Listado de Alumnos:");
        Console.WriteLine("Código\tNombre\t\tFecha Nacimiento\tGrado\tAño Registro");

        for (int i = 0; i < contadorAlumnos; i++)
        {
            Console.WriteLine($"{listaAlumnos[i].Codigo}\t{listaAlumnos[i].Nombre}\t{listaAlumnos[i].FechaNacimiento.ToString("yyyy-MM-dd")}\t{listaAlumnos[i].Grado}\t{listaAlumnos[i].AñoRegistro}");
        }
    }

    static void BuscarAlumnoPorCodigo()
    {
        Console.Write("Ingrese el código del alumno a buscar: ");
        int codigoBuscado = int.Parse(Console.ReadLine());

        bool alumnoEncontrado = false;

        Console.WriteLine("Alumnos encontrados:");
        Console.WriteLine("Código\tNombre\t\tFecha Nacimiento\tGrado\tAño Registro");

        for (int i = 0; i < contadorAlumnos; i++)
        {
            if (listaAlumnos[i].Codigo == codigoBuscado)
            {
                Console.WriteLine($"{listaAlumnos[i].Codigo}\t{listaAlumnos[i].Nombre}\t{listaAlumnos[i].FechaNacimiento.ToString("yyyy-MM-dd")}\t{listaAlumnos[i].Grado}\t{listaAlumnos[i].AñoRegistro}");
                alumnoEncontrado = true;
                break;
            }
        }

        if (!alumnoEncontrado)
        {
            Console.WriteLine("Alumno no encontrado.");
        }
    }

    static void EditarAlumnoPorCodigo()
    {
        Console.Write("Ingrese el código del alumno a editar: ");
        int codigoBuscado = int.Parse(Console.ReadLine());

        bool alumnoEncontrado = false;

        for (int i = 0; i < contadorAlumnos; i++)
        {
            if (listaAlumnos[i].Codigo == codigoBuscado)
            {
                Console.WriteLine("Alumno encontrado:");
                Console.WriteLine($"Código: {listaAlumnos[i].Codigo}");
                Console.WriteLine($"Nombre actual: {listaAlumnos[i].Nombre}");
                Console.Write("Ingrese el nuevo nombre del alumno: ");
                listaAlumnos[i].Nombre = Console.ReadLine();

                Console.WriteLine($"Fecha de Nacimiento actual: {listaAlumnos[i].FechaNacimiento.ToString("yyyy-MM-dd")}");
                Console.Write("Ingrese la nueva fecha de nacimiento del alumno (YYYY-MM-DD): ");
                listaAlumnos[i].FechaNacimiento = DateTime.Parse(Console.ReadLine());

                Console.WriteLine($"Grado actual: {listaAlumnos[i].Grado}");
                Console.Write("Ingrese el nuevo grado del alumno: ");
                listaAlumnos[i].Grado = Console.ReadLine();

                Console.WriteLine($"Año de Registro actual: {listaAlumnos[i].AñoRegistro}");
                Console.Write("Ingrese el nuevo año de registro del alumno: ");
                listaAlumnos[i].AñoRegistro = int.Parse(Console.ReadLine());

                Console.WriteLine("Alumno editado correctamente.");
                alumnoEncontrado = true;
                break;
            }
        }

        if (!alumnoEncontrado)
        {
            Console.WriteLine("Alumno no encontrado. No se puede editar.");
        }
    }

    static void RegistrarCancionMP3()
    {
        Console.WriteLine("Ingrese los datos de una canción en formato MP3:");

        Console.Write("Artista: ");
        string artista = Console.ReadLine();

        Console.Write("Título: ");
        string titulo = Console.ReadLine();

        Console.Write("Duración (segundos): ");
        int duracionSegundos = int.Parse(Console.ReadLine());

        Console.Write("Tamaño del fichero (KB): ");
        double tamañoKB = double.Parse(Console.ReadLine());


        Console.WriteLine("Canción MP3 registrada correctamente.");
    }

    static void MostrarDatosCancionMP3()
    {
    }
}
