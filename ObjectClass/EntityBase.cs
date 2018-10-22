using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }

    // All of the entity classes will inherit from this abstract class
    public abstract class EntityBase
    {
        public EntityStateOption EntityState { get; set; }

        public bool IsNew { get; private set; }
        public bool HadChanged { get; set; }
        public bool IsValid
        {
            get
            {
                // For now we'll just return true here 
                return true;
            }
        }
    }
}
