using System;
using Symbols;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using Parsing;
using System.Threading.Tasks;
using Tokenizing;
namespace GUI {
    
    public partial class Form1 : Form {

        bool operation;
        bool first = true;
        int leftPars = 0;
        private Size formOriginalSize;

        private Rectangle TableOR;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            backspaceButton.Text = Sign.Backspace.ToString();
            clearButton.Text = "CE";
            parseButton.Text = "Parse";
            equalityButton.Text = Sign.Equal.ToString();
            intersectionButton.Text = Sign.Intersection.ToString();
            inclusionButton.Text = Sign.Inclusion.ToString();
            sharpinclusionButton.Text = Sign.SharpInclusion.ToString();
            differenceButton.Text = Sign.Difference.ToString();
            unionButton.Text = Sign.Union.ToString();
            rightparButton.Text = Sign.RightPar.ToString();
            emptysetButton.Text = Sign.EmptySet.ToString();
            leftparButton.Text = Sign.LefrPar.ToString();
            implicationButton.Text = Sign.Implication.ToString();
            neginclusionButton.Text = Sign.NegInclusion.ToString();
            sharpneginclusionButton.Text = Sign.SharpNegInclusion.ToString();
            complementButton.Text = Sign.Complement.ToString();

            formOriginalSize = Size;

            TableOR = new Rectangle(tableLayoutPanel1.Location.X, tableLayoutPanel1.Location.Y, tableLayoutPanel1.Width, tableLayoutPanel1.Height);
        }


        private void resizeControl(Rectangle originalControlRect, Control control) {
            float xRatio = Width / (float)(formOriginalSize.Width);
            float yRatio = Height / (float)(formOriginalSize.Height);

            int newX = (int)(originalControlRect.X * xRatio);
            int newY = (int)(originalControlRect.Y * yRatio);
            int newWidth = (int)(originalControlRect.Width * xRatio);
            int newHeight = (int)(originalControlRect.Height * yRatio);

            /*
            if (control is TextBox) {
                float heightRatio = formOriginalSize.Height / originalControlRect.Height;
                newHeight = (int)(Height / heightRatio);
                if (newHeight < 8) newHeight = 8;
                float fontEmSize = control.Font.FontFamily.GetEmHeight(control.Font.Style);
                float fontLineSpacing = control.Font.FontFamily.GetLineSpacing(control.Font.Style);
                float fontSize = (newHeight - 7) * fontEmSize / fontLineSpacing;
                control.Font = new Font(control.Font.FontFamily, fontSize, control.Font.Style, GraphicsUnit.Pixel);
            }*/
           //control.Location = new Point(newX, newY);
           // control.Size = new Size(newWidth, newHeight);
            
        }

        private void ResizeChildren() {
            resizeControl(TableOR, tableLayoutPanel1);
        }
        private void Form1_Resize(object sender, EventArgs e) {
            Task.Run(() => ResizeChildren());
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            
        }
        
        private bool isLeftParInString() {
            foreach (char letter in textDisplay.Text) {
                if (letter == Sign.LefrPar) return true;
            }
            return false;
        } 
        private void clearButton_Click(object sender, EventArgs e) {
            textDisplay.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            first = true;
        }

        private void backspaceButton_Click(object sender, EventArgs e) {
            char lastChar;
            if (first) return;
            else {
                lastChar = textDisplay.Text[textDisplay.Text.Length - 1];
                if (lastChar == Sign.LefrPar && leftPars > 0) leftPars--;
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1);
                if (lastChar != Sign.Complement && lastChar != Sign.RightPar && lastChar != Sign.LefrPar) operation = !operation;
            }
            if (textDisplay.Text == "") first = true;
        }

        private void operationSign(object sender, EventArgs e) {
            Button s = (Button)sender;
            if (first) return;
            if (operation) {
                if (textDisplay.Text[textDisplay.Text.Length - 1] != Sign.LefrPar)
                    textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1) + s.Text;
            } else {
                textDisplay.Text += s.Text;
                operation = !operation;
            }
        }

        private void setSign(object sender, EventArgs e) {
            Button s = (Button)sender;
            string lastChar;
            if (first) {
                operation = true;
                first = false;
                lastChar = "";
            } else {
                lastChar = textDisplay.Text[textDisplay.Text.Length - 1].ToString();
            }

            if (!operation) {
                if (lastChar != Sign.Complement.ToString())
                    textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1) + s.Text;
            } else {
                    textDisplay.Text += s.Text;
                    operation = !operation;  
            }
        }

        private void leftparSign(object sender, EventArgs e) {
            Button s = (Button)sender;
            char lastChar = '0';
            if (first) {
                operation = true;
                first = !first;
            } else {
                lastChar = textDisplay.Text[textDisplay.Text.Length - 1];
            }
            if (!operation) {
                if (lastChar != Sign.Complement && lastChar != Sign.RightPar) { 
                    textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1) + s.Text;
                    operation = !operation;
                    leftPars++;
                }
            } else {
                if (lastChar != Sign.RightPar) {
                    textDisplay.Text += s.Text;
                    leftPars++;
                }
            }
        }

        private void rightparSign(object sender, EventArgs e) {
            Button s = (Button)sender;
            if (first) return;
            if (!operation) {
                if (textDisplay.Text[textDisplay.Text.Length - 1] != Sign.Complement && leftPars > 0) {
                    textDisplay.Text += s.Text;
                    leftPars--;
                }
            } else {
                if (textDisplay.Text[textDisplay.Text.Length - 1] != Sign.LefrPar && leftPars > 0) {
                    textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1) + s.Text;
                    leftPars--;
                }
            }
        }

        private void complementSign(object sender, EventArgs e) {
            Button s = (Button)sender;
            if (first) return;
            if (!operation) {
                if (textDisplay.Text[textDisplay.Text.Length - 1]!= Sign.Complement)
                    textDisplay.Text += s.Text;
            }
        }

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

        private void parseButton_Click(object sender, EventArgs e) {
            string str = textDisplay.Text;
            
            Console.WriteLine(str);
            Token[] tokens = Tokenizer.Tokenize(str);
            Set[] sets = Parser.GenerateSets(tokens.Count());
            SortedSet<char> sorted = Parser.GetSetNames(tokens);
            Dictionary<char, Set> dict = Parser.FillDictionary(sorted, sets);

            List<Set> setList = new List<Set>();
            string parsed = Parser.Parse(tokens);
            textBox1.Text = parsed;

            foreach (char c in dict.Keys) {
                Console.WriteLine(c);
                DisplayBinary(dict[c]);
                Console.WriteLine();
            }

            for (int i = 0; i < parsed.Length; i++) {
                char c = parsed[i];
                if (Tokenizer.IsSet(c)) setList.Add(dict[c]);
                else {
                    switch (c) {
                        case Sign.Union:
                            setList.Add(UnionSet(setList[setList.Count - 2], setList[setList.Count - 1]));
                            DisplayBinary(setList[setList.Count - 1]);
                            setList.RemoveAt(setList.Count - 3);
                            setList.RemoveAt(setList.Count - 2);
                            break;
                        case Sign.Complement:
                            setList.Add(Falsify(setList[setList.Count - 1]));
                            DisplayBinary(setList[setList.Count - 1]);
                            setList.RemoveAt(setList.Count - 2);
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
                textBox2.Text = IsTrue(setList[setList.Count - 1]).ToString();
            }
        }
    }
}
