using BookCatalog.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Ninject.Modules;
using BookCatalog.Services.Repositories;

namespace BookCatalog.Web.Infrastructure
{
    public class NinjectRegistrations : NinjectModule

    {
        public override void Load()
        {
            this.Kernel.Bind<IUnitOfWork>().To<Services.Repositories.UnitOfWork>();
            this.Kernel.Bind(typeof(IGenericRepository<>)).To(typeof(GenericRepository<>));
        }
    }
}