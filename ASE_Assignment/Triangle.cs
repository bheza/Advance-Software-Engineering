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
    /// for drawing the Triangle Shape
    /// </summary>
    public class Triangle : IShape
    {
        public int x, y, width, height;
        public Triangle() : base()
        {
            width = 0;
            height = 0;
        }
        /// <summary>
        /// This method takes the values of x-axis, y-axis, width and height of Shape Triangle as 
        /// a Parameter
        /// </summary>
        /// <param name="x">x-axis position</param>
        /// <param name="y">y-axix position</param>
        /// <param name="width">width of Shape</param>
        /// <param name="height">height of Shape</param>
        public Triangle(int x, int y, int width, int height)
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
                Point[] p = new Point[3];
                p[0].X = x;
                p[0].Y = y - (height / 2);

                p[1].X = x - (width / 2);
                p[1].Y = y + (height / 2);

                p[2].X = x + (width / 2);
                p[2].Y = y + (height / 2);
                Pen po = new Pen(Color.Red);
                g.DrawPolygon(po, p);
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
