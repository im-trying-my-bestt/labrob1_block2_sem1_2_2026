using System;

namespace Lab1sem1block22026
{
    internal class TBallF : TBall
    {
        public TBallF() : base()
        {
        }

        public TBallF(double radius, double pointX, double pointY, double pointZ)
            : base(radius, pointX, pointY, pointZ)
        {
        }

        public TBallF(TBallF copy) : base(copy)
        {
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            TBallF other = (TBallF)obj;
            return radius == other.radius && pointX == other.pointX 
                && pointY == other.pointY && pointZ == other.pointZ;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(radius, pointX, pointY, pointZ);
        }
    }
}