using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.Api.Entities;

namespace DatingApp.Api.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}