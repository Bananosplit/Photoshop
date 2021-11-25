using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop {
    public struct Pixel {
        //ctor
        public Pixel(double r, double g, double b): this() {
            ChanelR = r;
            ChanelG = g;
            ChanelB = b;
        }
        public Pixel(Pixel p): this() {
            ChanelR = p.ChanelR;
            ChanelG = p.ChanelG;
            ChanelB = p.ChanelB;
        }

        //Properties
        public double ChanelR {
            get { return chanelR; }
            set {
                 chanelR = CheckValue(value);
            }
        }
        double chanelR;

        public double ChanelG {
            get { return chanelG; }
            set {
                chanelG = CheckValue(value);
            }
        }
        double chanelG;

        public double ChanelB {
            get { return chanelB; }
            set { chanelB = CheckValue(value); }
        }
        double chanelB;

        //Help Metodths
        double CheckValue(double val) {
            if (val < 0 || val > 1)
                new ArgumentException();
            return val;
        }

        public static double Trim(double val) {
            if (val > 1) return 1;
            else if (val < 0) return 0;
            return val;
        }

        //Operators
        public static Pixel operator* (Pixel p, double value) {
            return new Pixel(
               Trim(p.ChanelR * value),
               Trim( p.ChanelG * value),
                Trim(p.ChanelB * value));
        }
        public static Pixel operator *(double value, Pixel p) {
            return p * value;
        }
        public static Pixel operator *(Pixel first, Pixel second) {
            var r = first.ChanelR * second.ChanelR;
            var g = first.ChanelG * second.ChanelG;
            var b = first.ChanelB * second.ChanelB;
            return new Pixel(r,g,b );
        }
        public static Pixel operator / (Pixel first, double second) {
            var r = first.ChanelR / second;
            var g = first.ChanelG / second;
            var b = first.ChanelB / second;
            return new Pixel(r, g, b);
        }
        public static Pixel operator /( double second, Pixel first) {
            return first / second;
        }
    }
}
