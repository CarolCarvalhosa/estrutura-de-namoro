using EstruturasDeNamoro.Models;
using Microsoft.Owin.Security.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstruturasDeNamoro.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BaseContext _dbContext;
        public UserRepository(BaseContext dbContext)
        {
            this._dbContext = dbContext;
        }
        void IUserRepository.DoSomething()
        {
            var test = _dbContext;
        }
    }
}