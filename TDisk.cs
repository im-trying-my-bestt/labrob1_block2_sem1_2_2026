using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1sem1block22026
{
    internal class TDisk
    {
        protected double radius;
        protected double pointX;
        protected double pointY;

        public double Radius
        {
            get { return radius; }
            set 
            { 
                if(value>0)this.radius = value;
            else throw new ArgumentException("Радіус має бути більше за 0");
            }
        }
        public double PointX
        {
            get { return pointX; }
            set { pointX = value; }
        }

        public double PointY
        {
            get { return pointY; }
            set { pointY = value; }
        }
        public TDisk(double radius, double pointX, double pointY)
        {
            Radius = radius;
            PointX = pointX;
            PointY = pointY;
        }
        public TDisk()
        {
            this.radius = 1;
            this.pointX = 0;
            this.pointY = 0;
        }

        public TDisk(TDisk copy)
        {
            radius = copy.radius;
            pointX = copy.pointX;
            pointY = copy.pointY;
            
        }
        public virtual bool IsEqual(TDisk other)
        {
            if (other == null) return false;
            return radius == other.radius
                && pointX == other.pointX
                && pointY == other.pointY;
        }

        public double GetArea()
        { return Math.PI * radius * radius; }

        public override string ToString()
        {
            return $"Круг: Радіус = {radius}; Центр=({pointX},{pointY}).";
        }
        public void Input()
        {
            Console.Write("Введіть радіус: ");
            Radius = double.Parse(Console.ReadLine());

            Console.Write("Введіть координату Х центра: ");
            PointX = double.Parse(Console.ReadLine());

            Console.Write("Введіть координату Y центра: ");
            PointY = double.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine(ToString());
        }
        public bool IsInside(double px, double py)
        {
            double dx = px - pointX;
            double dy = py - pointY;

            double distance = Math.Sqrt(dx * dx + dy * dy);

            return distance < radius - double.Epsilon;
        }
        public static TDisk operator *(TDisk disk, double number)
        {
            if (number <= 0)
                throw new ArgumentException("Множник має бути більшим за 0.");

            return new TDisk(disk.radius * number,disk.pointX,disk.pointY);
        }
        public static TDisk operator *(double number, TDisk disk)
        {
            return disk * number;
        }
    }

}
