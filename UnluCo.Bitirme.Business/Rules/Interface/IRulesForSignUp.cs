using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.DataAcces.Dtoes;

namespace UnluCo.Bitirme.Business.Rules.Interface
{
    public interface IRulesForSignUp
    {
        bool handle(UsersDto model);
        bool isValidPass(UsersDto model);

        bool isValidMail(UsersDto model);

        bool isValidGsm(UsersDto model);

        bool isValidUserName(UsersDto model);

    }
}
