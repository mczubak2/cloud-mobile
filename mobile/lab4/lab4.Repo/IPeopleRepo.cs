using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestEase;

namespace lab4.Repo
{
    public interface IPeopleRepository
    {
        [Post("people")]
        Task AddPersonAsync([Body] Person person);
    }
}
