using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Vector3
{
    internal class Vector
    {
        private int x;
        private int y;
        private int z;

        public Vector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double GetLength()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public Vector GetAddition(Vector a)
        {
            return new Vector(x + a.x, y + a.y, z + a.z);
        }
        public Vector GetSubtraction(Vector a)
        {
            return new Vector(x - a.x, y - a.y, z - a.z);
        }

        public double Dot(Vector a)
        {
            return x*a.x+ y*a.y + z*a.z;
        }


        public double GetAngle(Vector a)
        {
            return Math.Acos(this.Dot(a)/(this.GetLength()*a.GetLength()));
        }

        public double GetCos(Vector a)
        {
            return Math.Cos(GetAngle(a));
        }

        public string ToString()
        {
            return $"({this.x},{this.y},{this.z})";
        }
    }
}
