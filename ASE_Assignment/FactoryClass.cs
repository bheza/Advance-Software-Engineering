using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Assignment
{
    /// <summary>
    /// It passes the values on class of an objects
    /// </summary>
    class FactoryClass : Creator
    {
        /// <summary>
        /// It passes the shape of any objects
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
        public override IShape getShape(string shapeType)
        {
            shapeType = shapeType.ToLower().Trim(); //To get rid of Case Sensitivity


            if (shapeType.Equals("circle"))
            {
                return new Circle();

            }
            else if (shapeType.Equals("rectangle"))
            {
                return new Rectangle();

            }
            else if (shapeType.Equals("triangle"))
            {
                return new Triangle();

            }
            else
            {
                //If the shape doesnot have any defination in our project throw an appropriate exception
                System.ArgumentException argEx = new System.ArgumentException("Factory error: " + shapeType + " does not exist");
                throw argEx;
            }
        }
    }
}
