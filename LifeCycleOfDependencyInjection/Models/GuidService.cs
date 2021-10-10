using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeCycleOfDependencyInjection.Models
{
    public class GuidService 
    {
        private ISingleton singleton;
        private IScoped scoped;
        private ITransient transient;

        public GuidService(ISingleton singleton, IScoped scoped, ITransient transient)
        {
            this.singleton = singleton;
            this.scoped = scoped;
            this.transient = transient;
        }

        public Guid Singleton { get => this.singleton.Guid; }
        public Guid Scoped { get => this.scoped.Guid; }
        public Guid Transient { get => this.transient.Guid; }
    }
}
