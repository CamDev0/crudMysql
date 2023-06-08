using System;
using System.Collections.Generic;

namespace crudMysql.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Carrera { get; set; }

    public DateTime? Fecha { get; set; }
}
