﻿using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class AccDisciplineTicketDocument
{
    public Guid? TicketId { get; set; }

    public int? OrderIndex { get; set; }

    public int? DocumentTypeId { get; set; }

    public string? FileLink { get; set; }

    public virtual GenDocument? DocumentType { get; set; }
}
