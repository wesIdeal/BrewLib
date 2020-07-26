using System;

namespace BrewLib.Models
{
    public class Color : IColor
    {
        protected bool Equals(Color other)
        {
            return SRM.Equals(other.SRM);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Color)obj);
        }

        public override int GetHashCode()
        {
            return SRM.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Math.Round(SRM, 1)} SRM";
        }

        public Color(double srm = 0)
        {
            _srm = srm;
        }

        private double _srm;
        public double SRM => _srm;

        public double EBC
        {
            get => Math.Round(SRM * 1.97, 1);
            set => _srm = Math.Round(value * 0.508, 1);
        }

        public double Lovibond
        {
            get => Math.Round((SRM + 0.76) / 1.3546, 1);
            set => _srm = (double)Math.Round((decimal)((1.3546 * value) - 0.76), 1);
        }

        public static explicit operator Color(double srm) => new Color(srm);
        public static explicit operator Color(int srm) => new Color(srm);
        public static implicit operator double(Color c) => c.SRM;

    }
}
