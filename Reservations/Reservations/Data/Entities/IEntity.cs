﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data.Entities
{
    public interface IEntity<TKey>
    {
        int Id { get; set; }
    }
}
