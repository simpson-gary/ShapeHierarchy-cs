//Developer 	Gary Simpson
//Due Date		3-29-2015
//Name        Cube.cs
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
    class Cube : ThreeDimensionalShape
    {

       private double edge;// size of an edge
       const string measurementName = "edge";
         // constructor
        public Cube(double edge)
        {

            this.edge = edge;
        }// end constructor

        public override double Area
        {
            get
            {
                return CalculateArea();
            }
        }// end property Area

        public override double  Volume
        {
            get
            {
            return CalculateVolume();
            }//end get
        }// end property Volume
        public override string MeasurmentName
        {
            get 
            {
                return measurementName;
            }// end get
        } // end property MeasurementName

        public override double CalculateArea()
        {
            return 6*(Math.Pow(edge,2));
        }// end method Area
        public override double CalculateVolume()
        {
            return  Math.Pow(edge,3); 
        }// end method Area


    } // end class Cube
}
