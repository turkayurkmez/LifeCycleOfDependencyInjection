using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeCycleOfDependencyInjection.Models
{
   public interface IGuidGenerator
    {
        public Guid Guid { get; }
    }

    public interface ISingleton: IGuidGenerator { }
    public interface IScoped : IGuidGenerator { }
    public interface ITransient : IGuidGenerator { }





}
