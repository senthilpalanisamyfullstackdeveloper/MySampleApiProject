﻿using System;

namespace CreditCheck.Data
{
    public interface IEntity
    {
        int Id { get; set; }
        Nullable<DateTime> CreatedOn { get; set; }
        string CreatedBy { get; set; }
        Nullable<DateTime> UpdatedOn { get; set; }
        string UpdatedBy { get; set; }
    }
}
