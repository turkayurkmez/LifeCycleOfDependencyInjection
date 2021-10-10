using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeCycleOfDependencyInjection.Models
{
    public class SingletonGuidGenerator : ISingleton
    {
        private Guid guid;
        public SingletonGuidGenerator()
        {
            guid = Guid.NewGuid();
        }
        public Guid Guid => guid;
    }


    public class ScopedGuidGenerator : IScoped
    {
        private Guid guid;
        public ScopedGuidGenerator()
        {
            guid = Guid.NewGuid();
        }
        public Guid Guid => guid;
    }

    public class TransientGuidGenerator : ITransient
    {
        private Guid guid;
        public TransientGuidGenerator()
        {
            guid = Guid.NewGuid();
        }
        public Guid Guid => guid;
    }
}
