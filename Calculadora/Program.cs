using Calculadora.Models;

Calculator calc = new Calculator();
calc.getSum(1,2);
calc.getSubtraction(3,2);
calc.getMultiplication(4,2);

calc.OperationsHistoric();

calc.getDivision(6,2);
Console.WriteLine("\n");

calc.OperationsHistoric();
