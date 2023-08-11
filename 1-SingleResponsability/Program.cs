using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper.ExportStudent(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");