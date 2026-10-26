using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1sem1block22026
{
    internal class TBall:TDiskF
    {
        protected double pointZ;
        public double PointZ
        {
            get { return pointZ; }
            set { pointZ = value; }
        }
        public TBall():base()
        {
            PointZ = 0;
        }
        public TBall(double radius, double poinX, double pointY, double pointZ):base(radius,poinX,pointY)
        {
            PointZ = pointZ;
        }
        public TBall(TBall ball):base(ball)
        {
            this.pointZ = ball.pointZ;
        }
        public override string ToString()
        {
            return $"Куля: Радіус = {radius}; Центр=({pointX},{pointY},{pointZ}).";
        }
        public void Input()
        {
            base.Input();
            Console.Write("Введіть координату Z центра: ");
            PointZ = double.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine(ToString());
        }
        public double GetVolume()
        { return (4.0* base.GetArea()* radius)/3.0; }
        public bool IsInside(double px, double py, double pz)
        {
            double dx = px - pointX;
            double dy = py - pointY;
            double dz = pz - pointZ;

            double distance = Math.Sqrt(dx * dx + dy * dy + dz * dz);

            return distance < radius - double.Epsilon;
        }
        public static TBall operator *(TBall disk, double number)
        {
            if (number <= 0)
                throw new ArgumentException("Множник має бути більшим за 0.");

            return new TBall(disk.Radius * number, disk.pointX, disk.pointY, disk.pointZ);
        }
        public static TBall operator *(double number, TBall ball)
        {
            return ball * number;
        }
    }
}
