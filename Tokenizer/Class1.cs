using System.Collections.Generic;
using Symbols;

namespace Tokenizing {
    public static class ExtensionMethods {
        public static int Count(this Token[] tokens) {
            HashSet<char> sets = new HashSet<char>();
            foreach (Token t in tokens) {
                if (t.type == Token.Type.Set && t.value != Sign.EmptySet) sets.Add(t.value);
            }
            return sets.Count;
        }
    }

    public class Token {
        public enum Type {
            None, Set, Operator, LeftPar, RightPar, Complement
        }

        public char value;
        public Type type = Type.None;
        public int precedence = 0;
       // public int parameterCount = 0;

        public Token() { }
    }

    public class Tokenizer {
        public static bool IsSet(char letter) {
            if (letter >= 65 && letter <= 90 || letter == Sign.EmptySet) return true;
            return false;
        }

        private static Dictionary<char, int> Precedences = new Dictionary<char, int> { { Sign.Implication, 1 },
        { Sign.Complement, 50 }, { Sign.Union, 20 }, { Sign.Equal, 2 }, { Sign.LefrPar, 100 }, { Sign.RightPar, 100 },
        { Sign.Intersection, 20 }, {Sign.Difference, 20 }, {Sign.Inclusion, 2 }, {Sign.NegInclusion, 2 }, {Sign.SharpInclusion, 2 },
        { Sign.SharpNegInclusion, 2 } };


        /*public static Token[] Tokenize(string str) {
            List<Token> tokens = new List<Token>();
            foreach (char symbol in str) {
                Token t = new Token();
                if (IsSet(symbol)) {
                    t.type = Token.Type.Set;
                } else if (symbol == Sign.LefrPar) {
                    t.type = Token.Type.LeftPar;
                } else if (symbol == Sign.RightPar) {
                    t.type = Token.Type.RightPar;
                } else if (symbol == Sign.Complement) {
                    t.type = Token.Type.Complement;
                } else {
                    t.type = Token.Type.Operator;
                    t.precedence = Precedences[symbol];
                }
                t.value = symbol;
                tokens.Add(t);
            }
            return tokens.ToArray();
        }*/
        public static Token[] Tokenize(string str) {
            //str = Parenthesize(str);
            List<Token> tokens = new List<Token>();
            foreach(char symbol in str) {
                Token t = new Token();
                if(IsSet(symbol)) {
                    t.type = Token.Type.Set;
                } else if(symbol == Sign.LefrPar) {
                    t.type = Token.Type.LeftPar;
                } else if(symbol == Sign.RightPar) {
                    t.type = Token.Type.RightPar;
                } else if(symbol == Sign.Complement) {
                    t.type = Token.Type.Complement;
                } else {
                    t.type = Token.Type.Operator;
                    t.precedence = Precedences[symbol];
                }
                t.value = symbol;
                tokens.Add(t);
            }
            return tokens.ToArray();
        }

        private static string Parenthesize(string str) {
            string output = "((((";
            foreach (char c in str) {
                if(c == Sign.Complement) output += ")" + c + "(";
                else if(c == Sign.Equal || c == Sign.Inclusion || c == Sign.NegInclusion || c == Sign.SharpInclusion || c == Sign.SharpNegInclusion) {
                    output += ")))" + c + "(((";
                } else if(c == Sign.Union || c == Sign.Difference || c == Sign.Intersection) output += "))" + c + "((";
                else if(c == Sign.Implication) output += "))))" + c + "((((";
                else output += c;
            }
            output += "))))";
            return output;
        }
    }
}