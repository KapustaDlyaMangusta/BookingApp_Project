using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dоmain.Entities
{
    public abstract class BasicEntity
    {
        public Guid Id { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
