using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    internal class Money24:Pair
    {
        public Money24(double a, double b) : base(a, b)
        {
        }
        public override Pair Add(Pair p)
        {

            if (this.B + p.B >= 100)
            {
                return new Money24(this.A + p.A + 1, (this.B + p.B) - 100);
            }
            else return new Money24(this.A + p.A + 1, (this.B + p.B));
        }

        public override Pair Conj()
        {
            throw new NotImplementedException();
        }

        public override Pair Div(Pair p)
        {
            return new Money24(this.A / p.A, this.B / p.B);
        }

        public override bool Equ(Pair p)
        {
            if (this.A == p.A && this.B == p.B) return true; 
            else return false;
        }

        public override Pair Mul(Pair p)
        {
            if (this.B * p.B < 100)
            {
                return new Money24(this.A * p.A, this.B * p.B);
            }
            else
            {
                double temp = this.B * p.B / 100;
                return new Money24(this.A * p.A + temp, (this.B * p.B) - temp * 100);
            }
        }

        public override Pair Sub(Pair p)
        {
            if (this.A - p.A >= 0 && this.B - p.B < 0)
            {
                return new Money24(this.A - p.A - 1, ((this.B + 100) - p.B));
            }
            else if (this.A - p.A < 0)
            {
                return new Money24(0, 0);
            }
            else return new Money24(this.A + p.A + 1, (this.B + p.B));
        }
    }
}
