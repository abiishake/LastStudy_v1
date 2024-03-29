﻿using LastStudy.Core.Entities;
using LastStudy.Core.Interfaces.DependencyInjector;
using LastStudy.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class InstituteUserRepository : RepositoryWithId<InstituteUser>, IInstituteUserRepository
    {
        public InstituteUserRepository(IServiceLocator serviceLocator) : base(serviceLocator)
        {
        }
    }
}
