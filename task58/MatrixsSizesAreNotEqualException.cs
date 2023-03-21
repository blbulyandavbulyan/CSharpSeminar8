using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task58
{
    internal class MatrixsSizesAreNotEqualException : ArgumentException
    {
        public MatrixsSizesAreNotEqualException(string msg) : base(msg) { 
        }
    }
}
