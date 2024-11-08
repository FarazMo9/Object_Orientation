using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object.Oriented.Programming
{
    //The abstract class named Shape can not be inherited
    //The abstract concepts can be a structure that other objects would be made base on their properties and behaviors
    internal abstract class Shape
    {
        public string Name { get; set; }
        public abstract void Draw(); // The drawing function must be customized base on the child's type. So, the polymorphism will be available now.
    }
}
