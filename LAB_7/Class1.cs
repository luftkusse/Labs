using System;

namespace LAB_7
{
    public class RationalNumber : IComparable, IEquatable<RationalNumber>
    {
        private int a_;
        private int b_;

        public RationalNumber(int a, int b)
        {
            if (a % 1 == 0 && b % 1 == 0)
            {
                a_ = a;
                b_ = b;
            }
            else
                throw new Exception("Числа не целые !");
        }
        public int Name { get; set; }
        public int CompareTo(object obj)
        {
            if (obj is RationalNumber p)
            {
                if (this > p)
                    return 1;
                else if (this < p)
                    return -1;
                else return 0;
            }
            else
                throw new Exception("Невозможно сравнить эти два объекта !");
        }
        public bool Equals(RationalNumber other)
        {
            if (other == null)
                return false;
            if (this.a_ == other.a_)
                return true;
            else
                return false;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            RationalNumber exObj = obj as RationalNumber;
            if (exObj == null)
                return false;
            else
                return Equals(exObj);
        }
        public override int GetHashCode()
        {
            if (this.Name == 0)
            {
                return 0;
            }
            else
            {
                return this.Name.GetHashCode();
            }
        }

        public static bool operator ==(RationalNumber security1, RationalNumber security2)
        {
            if (security1 is null || (security2) is null)
            {
                return Object.Equals(security1, security2);
            }

            return security1.Equals(security2);
        }
        public static bool operator !=(RationalNumber security1, RationalNumber security2) => !(security1 == security2);

        public static RationalNumber operator +(RationalNumber o1, RationalNumber o2)
        {
            RationalNumber result;

            if (o1.b_ == o2.b_)
                result = new RationalNumber(o1.a_ + o2.a_, o1.a_);
            else
                result = new RationalNumber((o1.a_ * o2.b_) + (o2.a_ * o1.b_), o1.b_ * o2.b_);

            return result;
        }
        public static RationalNumber operator -(RationalNumber o1, RationalNumber o2)
        {
            RationalNumber result;

            if (o1.b_ == o2.b_)
                result = new RationalNumber(o1.a_ - o2.a_, o1.b_);
            else
                result = new RationalNumber((o1.a_ * o2.b_) - (o1.b_ * o2.a_), o1.b_ * o2.b_);
            return result;
        }

        public static RationalNumber operator *(RationalNumber o1, RationalNumber o2)
        {
            RationalNumber result = new RationalNumber(o1.a_ * o2.a_, o1.b_ * o2.b_);
            return result;
        }

        public static RationalNumber operator /(RationalNumber o1, RationalNumber o2)
        {
            RationalNumber result = new RationalNumber(o1.a_ * o2.b_, o1.b_ * o2.a_);
            return result;
        }

        public static bool operator >(RationalNumber o1, RationalNumber o2)
        {
            if (o1.a_ == o2.a_ && o1.b_ == o2.b_)
                return false;
            else if (o1.b_ == o2.b_ & o1.a_ > o2.a_)
                return true;
            else if (o1.a_ == o2.a_ & o1.b_ < o2.b_)
                return true;
            else if (o1.a_ != o2.a_ & o1.b_ != o2.b_)
            {
                RationalNumber resultOne = new RationalNumber(o1.a_ * o2.b_, o1.b_ * o2.b_);
                RationalNumber resultTwo = new RationalNumber(o2.a_ * o1.b_, o1.b_ * o2.b_);

                if (resultOne.a_ > resultTwo.a_)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public static bool operator <(RationalNumber o1, RationalNumber o2)
        {
            if (o1.a_ == o2.a_ & o1.b_ == o2.b_)
                return false;
            else if (o1.b_ == o2.b_ && o1.a_ < o2.a_)
                return true;
            else if (o1.a_ == o2.a_ & o1.a_ > o2.b_)
                return true;
            else if (o1.a_ != o2.a_ & o1.b_ != o2.b_)
            {
                RationalNumber resultOne = new RationalNumber(o1.a_ * o2.b_, o1.b_ * o2.b_);
                RationalNumber resultTwo = new RationalNumber(o2.a_ * o1.b_, o1.b_ * o2.b_);

                if (resultOne.a_ < resultTwo.a_)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static bool operator >=(RationalNumber o1, RationalNumber o2)
        {
            if (o1.a_ == o2.a_ && o1.b_ == o2.b_)
                return true;
            else if (o1.b_ == o2.b_ & o1.a_ > o2.a_)
                return true;
            else if (o1.a_ == o2.a_ & o1.b_ < o2.b_)
                return true;
            else if (o1.a_ != o2.a_ & o1.a_ != o2.a_)
            {
                RationalNumber resultOne = new RationalNumber(o1.a_ * o2.b_, o1.b_ * o2.b_);
                RationalNumber resultTwo = new RationalNumber(o2.b_ * o1.b_, o1.b_ * o2.b_);

                if (resultOne.a_ > resultTwo.a_)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public static bool operator <=(RationalNumber o1, RationalNumber o2)
        {
            if (o1.a_ == o2.a_ & o1.b_ == o2.b_)
                return true;
            else if (o1.b_ == o2.b_ && o1.a_ < o2.a_)
                return true;
            else if (o1.a_ == o2.a_ & o1.b_ > o2.b_)
                return true;
            else if (o1.a_ != o2.a_ & o1.b_ != o2.b_)
            {
                RationalNumber resultOne = new RationalNumber(o1.a_ * o2.b_, o1.b_ * o2.b_);
                RationalNumber resultTwo = new RationalNumber(o2.a_ * o1.b_, o1.b_ * o2.b_);

                if (resultOne.a_ < resultTwo.a_)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public override string ToString()
        {
            return $"{a_} / {b_}";
        }

        public static implicit operator int(RationalNumber fraction)
        {
            return (fraction.a_ / fraction.b_);
        }

        public static explicit operator double(RationalNumber fraction)
        {
            return (double)fraction.a_ / fraction.b_;
        }

    }
}