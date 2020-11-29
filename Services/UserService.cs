using EstruturasDeNamoro.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstruturasDeNamoro.Services
{
    public class UserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        void DoSomething()
        {
            userRepository.DoSomething();
        }
    }
}