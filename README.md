# Sets
<p>A project inspired by a type of set theory tasks I did a lot during my discrete mathematics course at uni, made with C# and Windows Forms.</p>
<h2>Example</h2>
<p>Given sets A, B, C determine, whether the given statements are true or not:</p>
<p>A∩B=A\C⇒A\(B∩C)=∅</p>
<p>A∩B=A\C⇒A∩B∩C=∅</p>
<p>A∩B=A\C⇒A\(B∪C)=∅</p>
<h2>The program</h2>
<p>The program displays a GUI - simple, calculator-like window which has sets, set operators and logical operators instead of numbers and number operators. Users can input any expression they want, hit 'Parse' and get a result if the expression is true or false.</p>
<p>It has self implemented sets, methods to perform set operations on them, a tokenizer and a parser with predefined precedence for each operation.</p>
