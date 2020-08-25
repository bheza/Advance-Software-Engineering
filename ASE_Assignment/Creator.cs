using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Assignment
{
    /// <summary>
    /// It is used here to create objects
    /// </summary>
    abstract class Creator
    {
        /// <summary>
        /// This method is used for shaping an objects
        /// </summary>
        /// <param name="ShapeType"></param>
        /// <returns></returns>
        public abstract IShape getShape(string ShapeType);

    }
}
