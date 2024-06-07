# Task 
  
## 1. Может ли переменная быть одновременно True и False?

       * Нет, это нелогично потому что если преобразовать логическое True к типу int , то получится 1 ,
			  а преобразование False даст 0 , переменная не может быть одновременно True и False.
       * Переменная типа bool может принимать только одно из двух значений - True или False.
   
   ### Определите someBool так, чтобы следующее выражение возвращало true: someBool == true && someBool == false

         => to save your time I will include this task in the code.

## 2. Implement a simple calculator with fluent syntax:
   
        var FluentCalculator = /* Some magic */🪄🔮;
        FluentCalculator should be separated in two, the Values and the Operations, one can call the other, but cannot call one of his own.
        A Value can call an Operation, but cannot call a value
        FluentCalculator.one.plus FluentCalculator.one.one // error or "undefined", it's up to you.
        An Operation can call a Value, but cannot call a operation
        FluentCalculator.one.plus.two // this should have a value of 3
        FluentCalculator.one.plus.plus // error or "undefined", it's up to you
        Pairs of Value and Operation should be stackable to infinity
        FluentCalculator.one.plus.two.plus.three.minus.one.minus.two.minus.four // Should be -1
        A Value should resolve to a primitive integer
        FluentCalculator.one.plus.ten - 10 // Should be 1
        Rules:
          * Values in FluentCalculator should go from zero to ten.
          * Supported Operations are plus, minus, times, dividedBy.
          * FluentCalculator should be stackable to infinity.
          * A Value can only call an Operation.
          * An Operation can only call a Value.
          * A Value should be resolvable to a primitive integer, if needed as such.


### FluentCalculator
    FluentCalculator is a simple calculator implemented in C# with a fluent syntax. It allows you to perform basic arithmetic operations (addition,       subtraction, multiplication, and division) using a fluent interface. The calculator supports values from zero to ten and ensures that values can only call operations and operations can only call values.

#### Features
    Fluent syntax for arithmetic operations.
    Supports addition, subtraction, multiplication, and division.
    Values from zero to ten.
    Ensures values can only call operations and operations can only call values.
    Stackable to infinity.
    Values resolve to primitive integers.

#### Usage

    just save it as zip and run. 
    you can ignore test project it's not connected to main project (i did it for helping others).

#### Result 
<img src="https://github.com/dragonblue327/FluentCalculator/blob/main/picFromConsole.png?raw=true">
