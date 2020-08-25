using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ASE_Assignment
{
    /// <summary>
    /// It contains all the methods and function related to circle class
    /// </summary>
    public class Circle : IShape
    {
        public int x, y, radius;
        public Circle() : base()
        {

        }
        /// <summary>
        /// This method takes the values of x-axis, y-axis, width and height of Shape Rectangle as 
        /// a Parameter
        /// </summary>
        /// <param name="x">x-axis cordinate</param>
        /// <param name="y">y-axis cordinate</param>
        /// <param name="radius">Radius of the Circle</param>
        public Circle(int x, int y, int radius)
        {

            this.radius = radius;
        }

        /// <summary>
        /// This method draws the Shape
        /// </summary>
        /// <param name="g">Its takes variable of type Graphics</param>
        public void draw(Graphics g)
        {
            try
            {
                Pen p = new Pen(Color.Black, 2);
                SolidBrush b = new SolidBrush(Color.Red);
                g.DrawEllipse(p, x - radius, y - radius, radius * 2, radius * 2);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        /// <summary>
        /// Passing an Array
        /// </summary>
        /// <param name="list">pass parameters in an Array</param>
        public void set(params int[] list)
        {
            try
            {
                this.x = list[0];
                this.y = list[1];
                this.radius = list[2];

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
