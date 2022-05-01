using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Tasks
{
    public class TaskHelper<T>
    {
        public int Id { get; set; }
        public T Task { get; set; }
    }
}
