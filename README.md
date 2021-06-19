# Sets
<p>A project inspired by a type of set theory tasks I did a lot of during my discrete mathematics course at uni, made with C# and Windows Forms.</p>
<h2>Example</h2>
<p>Given sets A, B, C determine, whether the given statements are true or not:</p>
<p>A∩B=A\C⇒A\(B∩C)=∅</p>
<p>A∩B=A\C⇒A∩B∩C=∅</p>
<p>A∩B=A\C⇒A\(B∪C)=∅</p>
<h2>The program</h2>
<p>The program displays a GUI - simple, calculator-like window which has sets, set operators and logical operators instead of numbers and number operators. Users can input any expression they want, hit 'Parse' and get an answer if the expression is true or false.</p>
<p>It has self implemented sets, methods to perform set operations on them, a tokenizer and a parser. The expression provided by user is first tokenized - each character is classified as either a set or an oprator, with properties depending on the character, like precedence. Then, the parser converts the tokenized expression into Reversed Polish Notation. Finally, each operation is performed on the RPN expression, with the final result being either true or false. The RPN expression is displayed below the expression provided by the user.

https://user-images.githubusercontent.com/52157190/122651085-dceeaa80-d136-11eb-9aa4-6ade915a9113.mp4

</p>
<h2>In the future</h2>
<p>Probably this year (2021) I will rewrite some parts of it.</p>
<p>I would also like to rewrite it in something like Javascript, create a simple website that could run it and possibly host it somewhere. Most likely not this year tho.</p>
