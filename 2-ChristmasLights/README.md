# 🎄 Christmas Lights ‍🧑‍🎄

The elves 🧝 are bored with red and light. They want programmable christmas lights.


## Requirements

Write a parser function to parse user input of lighting instructions. Start with instructions for a row of Christmas lights that are hard-coded to swap colours every second.

1. The output you return is always `string[][]` where each inner row is a list of css colour names.

eg 1: Given input "red" return a 2-D array `[["red"]]`;
eg 2: Given input "red,white,red" return a 2-D array `[["red","white","red"]]`;
eg 3: Given input `"red,white,red\nwhite,red,white"` return a 2-D array `[["red","white","red"],["white","red","white"] ]`;


2. If an input alleged-colour is not recognised, replace it with white.


3. ...






## Rules (A first summary of TDD)

1. You must work on one requirement at a time. Do them in the order given. You must forget you have even seen the other requirements.
2. You may not write any production code until you have a failing test. (Failure to build or run counts as a failing test).
3. You may only write code to make the one failing test pass.
    - Note: Do not be afraid, for this step, to write code that does not work for other test cases. And as per rule 1, you can't write code for a future requirement.
4. Once you have a test pass, you may apply these refactorings:
    1. Eliminate all duplicate code
    2. Rewrite code to better express the intent to a future developer
    3. Simplify the code. This might mean, reducing the number of moving parts.
5. Check it in!
6. If any requirements remain, Goto 1
