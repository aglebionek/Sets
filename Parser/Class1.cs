using System;
using System.Collections.Generic;
using System.Linq;
using Symbols;
using Tokenizing;

namespace Parsing {
    public static class ExtensionMethods {

        public static void NameSets(this Set[] sets, Token[] tokens) {
            SortedSet<char> unique = new SortedSet<char>();
            foreach (Token t in tokens) {
                if (t.type == Token.Type.Set && t.value != Sign.EmptySet) unique.Add(t.value);
            }
            for(int i = 0; i < sets.Length; i++) {
                sets[i].Name = unique.ElementAt(i);
            }
        }
    }

    public class Set {
        public int[] Binary;
        public char Name;
        public Set(int[] binary) {
            Binary = binary;
        }
        public Set(int size) {
            Binary = new int[(int)Math.Pow(2, size)];
        }

        public static Set Empty(int size) {
            int len = (int)Math.Pow(2, size);
            int[] Binary = new int[(int)Math.Pow(2, size)];
            for (int i = 0; i < len; i++) {
                Binary[i] = 0;
            }
            return new Set(Binary);
        }
    }
    public class Parser {

        public static SortedSet<char> GetSetNames(Token[] tokens) {
            SortedSet<char> sets = new SortedSet<char>();
            foreach (Token t in tokens) {
                if (t.type == Token.Type.Set && t.value != Sign.EmptySet) sets.Add(t.value);
            }
            return sets;
        }

        public static Dictionary<char, Set> FillDictionary(SortedSet<char> setNames, Set[] setObjects) {
            Dictionary<char, Set> setDict = new Dictionary<char, Set>();
            for (int i = 0; i<setNames.Count; i++) {
                setDict[setNames.ElementAt(i)] = setObjects[i];
            }
            setDict[Sign.EmptySet] = Set.Empty(setNames.Count);
            return setDict;
        }

        public static Set[] GenerateSets(int size) {
            Set[] Sets = new Set[size];
            for (int i = 0; i < size; i++) {
                Sets[i] = new Set(size);
                for (int j = 0; j < Math.Pow(2, size); j++) {
                    Sets[i].Binary[j] = (j >> size - 1 - i) & 1;
                }
            }
            return Sets;
        }

        public static string Parse(Token[] tokens) {
            string output = string.Empty;
            List<Token> stack = new List<Token>();
            foreach (Token t in tokens) {
                if (t.type == Token.Type.Set) {
                    output += t.value;
                } else if (t.type == Token.Type.Operator) {
                    while (stack.Count > 0 && stack[0].precedence >= t.precedence && stack[0].value != Sign.LefrPar) {
                        output += stack[0].value;
                        stack.RemoveAt(0);
                    }
                    stack.Insert(0, t);
                } else if (t.type == Token.Type.LeftPar) {
                    stack.Insert(0, t);
                } else if (t.type == Token.Type.RightPar) {
                    while (stack[0].type != Token.Type.LeftPar) {
                        output += stack[0].value;
                        stack.RemoveAt(0);
                    }
                    if (stack[0].type == Token.Type.LeftPar) stack.RemoveAt(0);
                } else if (t.type == Token.Type.Complement) {
                    output += t.value;
                }
            }
            while (stack.Count > 0) {
                output += (stack[0].value);
                stack.RemoveAt(0);
            }
            return output;
        }
        /*public static string Parse(Token[] tokens) {
            string output = string.Empty;
            List<Token> stack = new List<Token>();
            foreach(Token t in tokens) {
                if(t.type == Token.Type.Set) {
                    output += t.value;
                } else if(t.type == Token.Type.LeftPar) {
                    stack.Insert(0, t);
                }
                else if(t.type == Token.Type.Operator) {
                    while(stack.Count > 0) {
                        output += stack[0].value;
                        stack.RemoveAt(0);
                    }
                    stack.Insert(0, t);
                
                } else if(t.type == Token.Type.RightPar) {
                    while(stack[0].type != Token.Type.LeftPar) {
                        output += stack[0].value;
                        stack.RemoveAt(0);
                    }
                    if(stack[0].type == Token.Type.LeftPar) stack.RemoveAt(0);
                } else if(t.type == Token.Type.Complement) {
                    output += t.value;
                }
            }
            while(stack.Count > 0) {
                output += (stack[0].value);
                stack.RemoveAt(0);
            }
            return output;
        }*/

    }
}
