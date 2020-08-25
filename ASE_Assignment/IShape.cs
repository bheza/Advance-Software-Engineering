using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ASE_Assignment
{
    /// <summary>
    /// Here we are using important concept of OOP Inheritance. This is the interface which is inherited by
    /// child classes
    /// </summary>
    public interface IShape
    {   
        /// <summary>
        /// This is the method declaration whose code is written inside 
        /// the inherited class
        /// </summary>
        /// <param name="g">Object Passed</param>
        void draw(Graphics g);

        /// <summary>
        /// This is the method declaration whose code is written inside 
        /// the inherited class
        /// </summary>
        /// <param name="list">Co-ordinates of x-axis and y-axis</param>
        void set(params int[] list);
    }
}
