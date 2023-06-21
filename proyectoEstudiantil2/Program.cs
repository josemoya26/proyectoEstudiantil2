namespace proyectoDeRegistroEstudiantil
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de varibales
            int opcion;
            int cantidadEstudiantes = 0;
            double promedio = 0;
            //Los arrays con los cuales iremos trabajando
            string[] matriculas = new string[100];
            string[] nombres = new string[100];
            string[] apellidos = new string[100];
            int[] edades = new int[100];
            char[] sexos = new char[100];
            string[] cursos = new string[100];
            string[][] materias = new string[100][];
            double[] notas = new double[5];


            /*Decidi utilizar la estructura do while,para la interaccion con el menus
            ademas obliga entral al bucle aunque sea una vez*/
            do
            {
                Console.WriteLine("======== Menú ========");
                Console.WriteLine("1. Crear estudiante");
                Console.WriteLine("2. Ver estudiantes");
                Console.WriteLine("3. Eliminar estudiante");
                Console.WriteLine("4. Estadisticas");
                Console.WriteLine("0. Salir");
                Console.WriteLine("=======================");

                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduce la matrícula del estudiante: "); /*En todo este CASE decidi utilizar Console.Write
                                                                                  para que cuando ingrese los datos no se vea tan cargado*/
                        matriculas[cantidadEstudiantes] = Console.ReadLine();

                        Console.Write("Introduce el nombre del estudiante: ");
                        nombres[cantidadEstudiantes] = Console.ReadLine();

                        Console.Write("Introduce el apellido del estudiante: ");
                        apellidos[cantidadEstudiantes] = Console.ReadLine();

                        Console.Write("Introduce la edad del estudiante: ");
                        edades[cantidadEstudiantes] = int.Parse(Console.ReadLine());

                        Console.Write("Introduce el sexo del estudiante (M/F): ");
                        sexos[cantidadEstudiantes] = char.Parse(Console.ReadLine());

                        Console.Write("Introduce el curso del estudiante: ");
                        cursos[cantidadEstudiantes] = Console.ReadLine();

                        Console.Write("Introduce el numero de materias que estas llevan: COLOCA 5, QUE TENGO UN FALLO EN SISTEMAS ");
                        int cantidadMaterias = int.Parse(Console.ReadLine());

                        materias[cantidadEstudiantes] = new string[cantidadMaterias];

                        for (int i = 0; i < cantidadMaterias; i++)
                        {
                            Console.Write($"Introduce la materia {i + 1}: ");
                            materias[cantidadEstudiantes][i] = Console.ReadLine();
                        }
                        //Aqui trabajares las notas y su promedio
                        for (int i = 0; i < notas.Length; i++)
                        {
                            Console.Write($"Ingrese la nota {i + 1}: ");
                            notas[i] = double.Parse(Console.ReadLine());
                            promedio += notas[i];
                        }
                        promedio /= notas.Length;
                        Console.WriteLine($"El promedio es {promedio}");
                        cantidadEstudiantes++;

                        break;
                    case 2:
                        for (int i = 0; i < cantidadEstudiantes; i++)
                        {
                            Console.WriteLine($"Matrícula: {matriculas[i]}");
                            Console.WriteLine($"Nombre completo: {nombres[i]} {apellidos[i]}");
                            Console.WriteLine($"Edad: {edades[i]}");
                            Console.WriteLine($"Sexo: {sexos[i]}");
                            Console.WriteLine($"Curso: {cursos[i]}");
                            Console.WriteLine($"Promedio General: {promedio}");

                            for (int j = 0; j < materias[i].Length; j++)
                            {
                                Console.WriteLine($"Materia {j + 1}: {materias[i][j]}");
                            }

                            Console.WriteLine();
                            Console.WriteLine($"Promedio General: {promedio}");
                        }

                        break;
                    case 3:
                        Console.Write("Introduce la matrícula del estudiante que deseas eliminar: ");
                        string matriculaEliminar = Console.ReadLine();

                        for (int i = 0; i < cantidadEstudiantes; i++)
                        {
                            if (matriculas[i] == matriculaEliminar)
                            {

                                Console.WriteLine("Matricula eliminada");
                            }

                        }
                        cantidadEstudiantes--;

                        break;

                    case 4:
                        Console.WriteLine("Reporte de estudiantes que son mujeres:");

                        int cantidadDeMujeres = CuantasSonMujeres(sexos);
                        Console.WriteLine($"Tenemos  {cantidadDeMujeres} un registro de genero Femenino ");

                        break;
                    default:
                        Console.WriteLine("Ha salido del sistema");
                        break;

                }



            } while (opcion < 10);





        }

        //Cree este metodo para determinar que cantidad de los estudiantes ingresados eran mujer
        static int CuantasSonMujeres(char[] sexos)
        {
            int count = 0;
            for (int i = 0; i < sexos.Length; i++)
            {
                if (sexos[i] == 'F')
                {
                    count++;
                }
            }
            return count;
        }
    }
}