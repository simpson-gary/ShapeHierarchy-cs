//Developer 	Gary Simpson
//Due Date		3-29-2015
//Name          Program.cs
/*Purpose   	Text book exercise 12.10

			
                12.10 (Shape Hierarchy) Implement the Shape hierarchy of Fig. 11.3.  ---page 408--	
                   Omit the Triangle and Tetrahedron classes.		
               Each TwoDimensionalShape should contain read-only abstract property
                    Area to calculate the area of the two-dimensional shape.
               Each ThreeDimensionalShape should have read- only abstract properties
                   Area and Volume to calculate the surface area and volume, respectively,
                   of the three-dimensional shape. Create an app that uses an array of Shape
                   references to objects of each concrete class in the hierarchy. 
                Display a text description of the object to which each array element refers.
                Also, in the loop that processes all the shapes in the array, determine whether
                   each shape is a TwoDimensionalShape or a ThreeDimensionalShape.
                If a shape is a TwoDimensionalShape, display its area.
                If a shape is a ThreeDimensionalShape, display its area and volume.
		
                                NOTE: add Console.ReadKey() to stop program execution in main Method.

*/
using System;

namespace ShapeHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            const  double measurement = 2;
            Circle circle = new Circle(measurement);
            Square square = new Square(measurement);
            Sphere sphere = new Sphere(measurement);
            Cube cube = new Cube(measurement);

            Shape [] shapes = new Shape[4];
            shapes[0] = circle;
            shapes[1] = square;
            shapes[2] = sphere;
            shapes[3] = cube;
            int i = 0;// counter used to count array position

            // foreach statement used to increment through Array of Shapes
            foreach (Shape currentShape in shapes)
            {
                
                        Console.Write("\nA {0} with a {1} of {2} has the area of {3:0.##}", shapes[i].GetType().Name,
                            currentShape.MeasurmentName, measurement, currentShape.Area);
                        i++;       
                if (currentShape is ThreeDimensionalShape)
                        {
                            if (currentShape is Sphere)
                            {
                                Sphere shape = (Sphere) currentShape;
                                Console.Write(" and a volume of {0:0.##}", shape.Volume);
                            }
                            else
                            {
                                Cube shape = (Cube) currentShape;
                                Console.Write(" and a volume of {0:0.##}", shape.Volume);
                            }
                        }// end if for dimension check
 
            }// end foreach
                    Console.ReadLine(); // added to pause console per instruction
        }// end method Main

    }// end class Program
}
