using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphQL.examples.Repository
{
    public interface IContext
    {
        DbContext Context { get; set; }
    }
}
