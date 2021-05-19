using System;
using System.Threading.Tasks;
using RestEase;

namespace lab3.Repo
{
    class IPeopleRepo
    {
        [Post("people")]
        Task AddPersonAsync([Body] Person person);
    }
}
