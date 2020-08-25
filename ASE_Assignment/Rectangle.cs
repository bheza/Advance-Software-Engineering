using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ASE_Assignment
{
    /// <summary>
    /// It is inherited from the parent class which has all the information about the guidelines
    /// for drawing the Rectangle Shape
    /// </summary>
    public class Rectangle : IShape
    {
        public int x, y, width, height;
        public Rectangle() : base()
        {
            width = 0;
            height = 0;
        }
        /// <summary>
        /// This method takes the values of x-axis, y-axis, width and height of Shape Rectangle as 
        /// a Parameter
        /// </summary>
        /// <param name="x">x-axis position</param>
        /// <param name="y">y-axix position</param>
        /// <param name="width">width of Shape</param>
        /// <param name="height">height of Shape</param>
        public Rectangle(int x, int y, int width, int height)
        {

            this.width = width; 
            this.height = height;
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
                g.DrawRectangle(p, x - (width / 2), y - (height / 2), width * 2, height * 2);
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
                this.width = list[2];
                this.height = list[3];
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
