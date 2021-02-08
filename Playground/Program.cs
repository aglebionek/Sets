using System;
using System.Collections.Generic;
using Symbols;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground {
    class Program {

        public class Set {
            public int[] Binary;

            public Set() {
                Binary = new int[4];
            }
            public Set(int[] binary) {
                Binary = binary;
            }

            public int full;
            
        }

        public static Set ComplementSet(Set A, Set B) {
            Set result = new Set();
            for (int i = 0; i < 4; i++) {
                A.full = (i >> 1) & 1;
                B.full = i & 1;
                if ((A.full & ~B.full) == 1) result.Binary[i] = 1;
                else result.Binary[i] = 0;
            }
            return result;
        }

        public static Set UnionSet(Set A, Set B) {
            Set result = new Set();
            for (int i = 0; i < 4; i++) {
                A.full = (i >> 1) & 1;
                B.full = i & 1;
                if ((A.full | B.full) == 1) result.Binary[i] = 1;
                else result.Binary[i] = 0;
            }
            return result;
        }
        static string ZwrocBinarnie(int liczba) {
            string t = null;
            int cyfra;

            while (liczba != 0) {
                cyfra = liczba & 1;
                t = cyfra + t;
                liczba >>= 1;
            }

            if (t == null) {
                return "0";
            }

            return t;
        }
        public static int[] Union(Set A, Set B) {
            int[] result = new int[4]; //tab with size 2 to the number of args (sets)
            int x = 4; //2 to the number of arguments (sets)
            for (int i = 0; i < x; i++) {
                A.full = (i >> 1) & 1;
                B.full = i & 1; //... C.full etc. for all arguments (sets)
                if ((A.full | B.full) == 1) {
                    result[i] = 1;
                } else {
                    result[i] = 0;
                }
            }
            return result;
        }

        public static int[] Complement(Set A, Set B) {
            int[] result = new int[4];
            for (int i = 0; i<4; i++) {
                A.full = (i >> 1) & 1;
                B.full = i & 1;
                if ((A.full & ~B.full) == 1) result[i] = 1;
                else result[i] = 0;
            }
            return result;
        }

        public static int[] Intersection(Set A, Set B) {
            int[] result = new int[4];
            for (int i = 0; i < 4; i++) {
                A.full = (i >> 1) & 1;
                B.full = i & 1;
                if ((A.full & B.full) == 1) result[i] = 1;
                else result[i] = 0;
            }
            return result;
        }
        public static int[] Inclusion(Set A, Set B) {
            int[] result = new int[4];
            for (int i = 0; i < 4; i++) {
                A.full = (i >> 1) & 1;
                B.full = i & 1;
                if (A.full == 1 && B.full==0) result[i] = 0;
                else result[i] = 1;
            }
            return result;
        }

        public static int[] Equality(Set A, Set B) {
            int[] result = new int[4];
            for (int i = 0; i < 4; i++) {
                A.full = (i >> 1) & 1;
                B.full = i & 1;
                if ((A.full == B.full)) result[i] = 1;
                else result[i] = 0;
            }
            return result;
        }

        public static void DisplayArray(int[] array) {
            foreach (int num in array) Console.WriteLine(num);
        }
        

        static void Main(string[] args) {
            
            Console.ReadKey();
        }
    }
}
