using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryPatternTest.Repository.Interfaces
{
    public interface IRepositoryDelete
    {
        bool Delete(object obj);
    }
}
