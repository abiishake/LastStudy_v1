﻿using LastStudy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastStudy.Core.Interfaces.Repositories
{
    public interface IInstituteRepository : IRepositoryWithId<Institute>
    {
        Institute FindById(int instituteId);
    }
}
