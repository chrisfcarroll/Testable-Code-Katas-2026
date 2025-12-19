# FizzBuzz

## Requirements

1. Write a “FizzBuzz” method that accepts a number as input and returns it as a String.
    - Example : 1 -> "1", 2 => "2"
2. Exception: If the number is a multiple of 3, return "Fizz" instead of the number.
    - Example : 3 -> "Fizz", 12 => "Fizz"
3. Exception: If the number is a multiple of 5, return "Buzz" instead of the number.
    - Example : 5 -> "Buzz", 20 => "Buzz"
4. Exception: If rules 2 and 3 both apply return "Fizz Buzz" instead.
    - Example : 15 -> "Fizz Buzz", 3000030 => "Fizz Buzz"

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
