﻿using Domain.ProvaDev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ProvaDev.Interfaces
{
    public interface IClienteRepository : IRepository<Guid, Cliente>
    {

    }
}