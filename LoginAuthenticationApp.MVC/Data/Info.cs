using System;
using System.Collections.Generic;

namespace LoginAuthenticationApp.MVC.Data;

public partial class Info
{
    public int PersonId { get; set; }

    public string TellNo { get; set; } = null!;

    public string CellNo { get; set; } = null!;

    public string AddressLine1 { get; set; } = null!;

    public string AddressLine2 { get; set; } = null!;

    public string AddressLine3 { get; set; } = null!;

    public string AddressCode { get; set; } = null!;

    public string? PostalAddress1 { get; set; }

    public string? PostalAddress2 { get; set; }

    public string? PostalAddress3 { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual Person? PersonNavigation { get; set; }
}
