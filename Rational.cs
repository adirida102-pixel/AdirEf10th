using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf10th
{
    public class Rational
    {
        private int x;
        private int y;

        public static void RationalUT()
        {
            //Rational r1 = new Rational(3, 4);
            //Rational r2 = new Rational(1, 2);
            //Rational r3 = new Rational(5, 7);
            //Rational r4 = new Rational(6);
            //Rational a = r1.Add(r2);
            //Rational s = r3.Substract(r1);
            //Rational m = r2.Multiply(r3);
            //Rational d = r2.Divide(r1);
            //Rational m2 = r4.Multiply(r1);
            //double dec = m2.GetDecimal();
            //Console.WriteLine(r1);
            //Console.WriteLine(r2);
            //Console.WriteLine(r3);
            //Console.WriteLine(a);
            //Console.WriteLine(s);
            //Console.WriteLine(m);
            //Console.WriteLine(d);
            //Console.WriteLine(m2);
            //Console.WriteLine(dec);
            //m2.Reduct();
            //Console.WriteLine(m2);
            //Rational r5 = new Rational(9, 12);
            //Console.WriteLine(r1.IsEqual(r5));
        }
        
        public Rational(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Rational() : this(1, 1)
        {

        }

        public Rational(Rational r) : this(r.x, r.y)
        {

        }

        public Rational(int num) : this(num, 1)
        {

        }

        public int GetNumerator()
        {
            return this.x;
        }

        public int GetDenom() //Denominator
        {
            return this.y;
        }

        public void SetNumerator(int x)
        {
            this.x = x;
        }

        public void SetDenom(int y) //Denominator
        {
            this.y = y;
        }

        public bool IsEqual(Rational num)
        {
            bool equal = false;
            if (this.GetNumerator() * num.GetDenom() == this.GetDenom() * num.GetNumerator())
            {
                equal = true;
            }
            return equal;
        }

        public Rational Multiply(Rational num)
        {
            Rational mult = new Rational();
            mult.SetNumerator(this.GetNumerator() * num.GetNumerator());
            mult.SetDenom(this.GetDenom() * num.GetDenom());
            return mult;
        }

        public Rational Divide(Rational num)
        {
            Rational secUD = new Rational(num);
            Rational div = new Rational();
            int tmp = num.GetNumerator();
            secUD.SetNumerator(num.GetDenom());
            secUD.SetDenom(tmp);
            div = this.Multiply(secUD);
            return div;
        }

        public Rational Add(Rational num)
        {
            Rational sum = new Rational();
            sum.SetDenom(this.GetDenom() * num.GetDenom());
            sum.SetNumerator(this.GetNumerator() * num.GetDenom() + this.GetDenom() * num.GetNumerator());
            return sum;
        }

        public Rational Substract(Rational num)
        {
            Rational minus = new Rational(num);
            Rational sub = new Rational();
            minus.SetNumerator(-1 * minus.GetNumerator());
            sub = this.Add(minus);
            return sub;
        }

        public double GetDecimal()
        {
            double dec = this.GetNumerator() / (double)this.GetDenom();
            return dec;
        }

        public void Reduct()
        {
            int reductor = 0;
            for (int i = 1; i < Math.Min(this.GetNumerator(), this.GetDenom()); i++)
            {
                if (this.GetNumerator() % i == 0 && this.GetDenom() % i == 0)
                {
                    reductor = i;
                }
            }
            this.SetNumerator(this.GetNumerator() / reductor);
            this.SetDenom(this.GetDenom() / reductor);
        }

        public override string ToString()
        {
            string str = $"{this.GetNumerator()} / {this.GetDenom()}";
            return str;
        }
    }
}
