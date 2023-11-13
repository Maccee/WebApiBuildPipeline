using System;
using System.Collections.Generic;

namespace Azure_02_Web_API_Build_Pipeline.Models;

public partial class Paavontunnit
{
    public int Id { get; set; }

    public string? Msg { get; set; }

    public DateTime? Date { get; set; }
}
