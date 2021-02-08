using Symbols;
using System;
using System.Collections.Generic;
using System.Text;
using Parsing;

namespace Someneatness {

    class Test {

    }
    class Program {
        public static Set UnionSet(Set A, Set B) {
            int size = A.Binary.Length;
            int[] binary = new int[size];
            for (int i = 0; i < size; i++) {
                if ((A.Binary[i] | B.Binary[i]) == 1) binary[i] = 1;
                else binary[i] = 0;
            }
            return new Set(binary);
        }

        public static Set DiffSet(Set A, Set B) {
            int size = A.Binary.Length;
            int[] binary = new int[size];
            for (int i = 0; i < size; i++) {
                if ((A.Binary[i] & ~B.Binary[i]) == 1) binary[i] = 1;
                else binary[i] = 0;
            }
            return new Set(binary);
        }
        public static Set ImplicationSet(Set A, Set B) {
            int size = A.Binary.Length;
            int[] binary = new int[size];
            for (int i = 0; i < size; i++) {
                if ((A.Binary[i] & ~B.Binary[i]) == 1) binary[i] = 0;
                else binary[i] = 1;
            }
            return new Set(binary);
        }
        public static Set IntersectionSet(Set A, Set B) {
            int size = A.Binary.Length;
            int[] binary = new int[size];
            for (int i = 0; i < size; i++) {
                if ((A.Binary[i] & B.Binary[i]) == 1) binary[i] = 1;
                else binary[i] = 0;
            }
            return new Set(binary);
        }

        public static Set InclusionSet(Set A, Set B) {
            int size = A.Binary.Length;
            int[] binary = new int[size];
            for (int i = 0; i < size; i++) {
                if (A.Binary[i] == 1 && B.Binary[i] == 0) binary[i] = 0;
                else binary[i] = 1;
            }
            return new Set(binary);
        }

        public static Set EqualitySet(Set A, Set B) {
            int size = A.Binary.Length;
            int[] binary = new int[size];
            for (int i = 0; i < size; i++) {
                if ((A.Binary[i] == B.Binary[i])) binary[i] = 1;
                else binary[i] = 0;
            }
            return new Set(binary);
        }

        public static Set EmptySet(Set A) {
            int size = A.Binary.Length;
            int[] binary = new int[size];
            for (int i = 0; i < size; i++) {
                if (A.Binary[i] == 1) binary[i] = 0;
                else binary[i] = 1;
            }
            return new Set(binary);
        }
        public static Set Falsify(Set A) {
            int size = A.Binary.Length;
            int[] binary = new int[size];
            for (int i = 0; i < size; i++) {
                if (A.Binary[i] == 1) binary[i] = 0;
                else binary[i] = 1;
            }
            return new Set(binary);
        }
        public static bool IsTrue(Set set) {
            foreach (int num in set.Binary) if (num == 0) return false;
            return true;
        }
        
        public static void DisplayBinary(Set set) {
            foreach (int num in set.Binary) Console.WriteLine(num);
            Console.WriteLine();
        }

        public static void DisplayTable(params Set[] sets) {
            for (int i = 0; i < sets[0].Binary.Length; i++) {
                for (int j = 0; j < sets.Length; j++) {
                    Console.Write(sets[j].Binary[i]+" ");
                }
                Console.WriteLine();
            }
        }

        public static bool IsDisjoint(int a, int b) {
            if (a == 1 && b == 1) return false;
            return true;
        }

        public static bool IsInclusive(int a, int b) {
            if (a == 1 && b == 0) return false;
            return true;
        }

        public static bool IsEqual(int a, int b) {
            if (a == b) return true;
            return false;
        }

        public static bool IsEmpty(int a) {
            if (a == 0) return true;
            return false;
        }

        public static Set[] FindFalse(params Set[] sets) {
            List<Set> result = new List<Set>();
            int[] binary = new int[sets.Length];
            for (int i = 0; i < sets[0].Binary.Length; i++) {
                if (sets[sets.Length - 1].Binary[i] == 1) {
                    continue;
                } else {
                    for (int j = 0; j < sets.Length; j++) {
                        binary[j] = sets[j].Binary[i];
                    }
                    result.Add(new Set(binary));
                    binary = new int[sets.Length];
                }
            }
            return result.ToArray();
        }

        static void Main() {
            Console.OutputEncoding = Encoding.Unicode;

            Test test = new Test();


            /*
            Set[] sets = Parser.GenerateSets(2);
            Set A = sets[0];
            Set B = sets[1];
            Set Left = IntersectionSet(A, B);

            Set Right = UnionSet(Falsify(A), B);
            Set implication = ImplicationSet(Left, Right);
            Console.WriteLine(IsTrue(implication));

            Right = IntersectionSet(Falsify(A), B);
            implication = ImplicationSet(Left, Right);
            Console.WriteLine(IsTrue(implication));

            Right = ImplicationSet(B, Falsify(A));
            implication = ImplicationSet(Left, Right);
            Console.WriteLine(IsTrue(implication));

            Right = EqualitySet(A, Falsify(B));
            implication = ImplicationSet(Left, Right);
            Console.WriteLine(IsTrue(implication));

            Right = IntersectionSet(A, Falsify(B));
            implication = ImplicationSet(Left, Right);
            Console.WriteLine(IsTrue(implication));

            Right = ImplicationSet(A, Falsify(B));
            implication = ImplicationSet(Left, Right);
            Console.WriteLine(IsTrue(implication));
            
            List<char> output = new List<char>();
            List<Token> stack = new List<Token>();

            string str = "A" + Sign.Union + "B" + Sign.Complement + Sign.Equal + "A" + Sign.Complement + Sign.Intersection + "C";
            Console.WriteLine(str);
            Token[] tokens = Parser.Tokenize(str);
            Set[] sets = Parser.GenerateSets(tokens.Count());
            SortedSet<char> sorted = Parser.GetSetNames(tokens);
            Dictionary<char, Set> dict = Parser.FillDictionary(sorted, sets);

            List<Set> setList = new List<Set>();
            string parsed = Parser.Parse(tokens);
            Console.WriteLine(parsed);

            foreach (char c in dict.Keys) {
                Console.WriteLine(c);
                DisplayBinary(dict[c]);
                Console.WriteLine();
            }

            for (int i = 0; i < parsed.Length; i++) { 
                char c = parsed[i];
                if (Parser.IsSet(c)) setList.Add(dict[c]);
                else {
                    switch (c) {
                        case Sign.Union:
                            setList.Add(UnionSet(setList[setList.Count-2], setList[setList.Count-1]));
                            DisplayBinary(setList[setList.Count-1]);
                            setList.RemoveAt(setList.Count - 3);
                            setList.RemoveAt(setList.Count - 2);
                            break;
                        case Sign.Complement:
                            setList.Add(Falsify(setList[setList.Count - 1]));
                            DisplayBinary(setList[setList.Count - 1]);
                            setList.RemoveAt(setList.Count-2);
                            break;
                        case Sign.Equal:
                            setList.Add(EqualitySet(setList[setList.Count - 2], setList[setList.Count - 1]));
                            DisplayBinary(setList[setList.Count - 1]);
                            setList.RemoveAt(setList.Count - 3);
                            setList.RemoveAt(setList.Count - 2);
                            break;
                        case Sign.Intersection:
                            setList.Add(IntersectionSet(setList[setList.Count - 2], setList[setList.Count - 1]));
                            DisplayBinary(setList[setList.Count - 1]);
                            setList.RemoveAt(setList.Count - 3);
                            setList.RemoveAt(setList.Count - 2);
                            break;
                        case Sign.Difference:
                            setList.Add(DiffSet(setList[setList.Count - 2], setList[setList.Count - 1]));
                            DisplayBinary(setList[setList.Count - 1]);
                            setList.RemoveAt(setList.Count - 3);
                            setList.RemoveAt(setList.Count - 2);
                            break;
                        case Sign.Implication:
                            setList.Add(ImplicationSet(setList[setList.Count - 2], setList[setList.Count - 1]));
                            DisplayBinary(setList[setList.Count - 1]);
                            setList.RemoveAt(setList.Count - 3);
                            setList.RemoveAt(setList.Count - 2);
                            break;
                        case Sign.Inclusion:
                            setList.Add(InclusionSet(setList[setList.Count - 2], setList[setList.Count - 1]));
                            DisplayBinary(setList[setList.Count - 1]);
                            setList.RemoveAt(setList.Count - 3);
                            setList.RemoveAt(setList.Count - 2);
                            break;
                    }
                }
                Console.WriteLine(IsTrue(setList[setList.Count - 1]));
            }
            //TODO 
            /* Pozmieniać nazwy funkcji logicznych, pozmieniać nazwych funkcji z namespace Parsing żeby było jaśniejsze co co robi 
             * Posprzątać GUI, Parsing i Someneatness
             * Make the UI work smoothly
             */
            string s = "adamaszek";

            s.Remove(0, 1);

            Console.WriteLine(s);
            Console.ReadKey();

            /*
            
            DisplayTable(sets);
            Console.ReadKey();
            */
            
            /*
            Set A = Sets[0];
            Set B = Sets[1];
            Set L = UnionSet(A, B);
            Set Equation = EqualitySet(L, B);
            DisplayTable(A, B, Equation);
            Console.WriteLine();

            Set L2 = ComplementSet(B, A);
            Set Equation2 = EqualitySet(L2, B);
            DisplayTable(A, B, Equation2);
            Console.WriteLine();
            

            Set L3 = ComplementSet(A, B);
            Set R3 = ComplementSet(B, A);
            Set Equation3 = EqualitySet(L3, R3);

            DisplayTable(A, B, Equation3);
            Console.WriteLine("Here");
            Set[] False = FindFalse(A, B, Equation3);
            DisplayTable(False);

            Set L4 = ComplementSet(B, A);
            Set Equation4 = EqualitySet(L4, Set.Empty(2));

            DisplayTable(A, B, Equation4);
            DisplayBinary(Set.Empty(2));
            Console.WriteLine(Sign.Union);
            Console.WriteLine(Sign.Implication);
            HashSet<char> test = new HashSet<char>();

            
            Token[] tokens = Parser.Tokenize(str);

            foreach (Token t in tokens) {
                if (t.type == Token.Type.Set) test.Add(t.value);
                Console.WriteLine(t.GetInfo());
            }

            foreach (char c in test) {
                Console.WriteLine(c);
            }
            
            
            Console.WriteLine(test.Count);
            int[] d = new int[1];
            Console.ReadKey();
            */
        }
    }
}
