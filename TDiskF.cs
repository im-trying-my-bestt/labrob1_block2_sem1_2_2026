using System;

namespace Lab1sem1block22026
{
    internal class TDiskF : TDisk
    {
        public TDiskF() : base()
        {
        }

        public TDiskF(double radius, double pointX, double pointY)
            : base(radius, pointX, pointY)
        {
        }

        public TDiskF(TDiskF copy) : base(copy)
        {
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            TDiskF other = (TDiskF)obj;
            return radius == other.radius && pointX == other.pointX && pointY == other.pointY;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(radius, pointX, pointY);
        }
    }
}