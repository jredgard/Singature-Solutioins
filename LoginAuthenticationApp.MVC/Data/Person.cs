using System;
using System.Collections.Generic;

namespace LoginAuthenticationApp.MVC.Data;

public partial class Person
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime LastLogin { get; set; }

    public virtual Info IdNavigation { get; set; } = null!;

    public virtual Info? Info { get; set; }
}
