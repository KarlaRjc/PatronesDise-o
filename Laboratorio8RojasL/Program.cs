﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8RojasL
{
    class Program
    {

        public interface IExpresion
        {
            //metodo para evaluar una expresion matematica y el interpreter va a devolver  un entero
            int interpret();
        }

        public class NumericExpression : IExpresion
        {
            public int _number;

            public NumericExpression(int number)
            {
                _number = number;
            }

            public NumericExpression(string number)
            {
                _number = int.Parse(number);

            }

            public int interpret()
            {
                return _number;
            }
        }

        public class AdditionExpression : IExpresion
        {
            private IExpresion _firstExpression, _secondExpression;
            
            public AdditionExpression(IExpresion firstExpression, IExpresion secondExpression)
            {
                _firstExpression = firstExpression;
                _secondExpression = secondExpression;
            }

            public int interpret()
            {
                return _firstExpression.interpret() + _secondExpression.interpret() ;
            }
            public override string ToString()
            {
                return "+";
            }
        }


        public class SubstractionExpression : IExpresion
        {
            private IExpresion _firstExpression, _secondExpression;

            public SubstractionExpression(IExpresion firstExpression, IExpresion secondExpression)
            {
                _firstExpression = firstExpression;
                _secondExpression = secondExpression;
            }

            public int interpret()
            {
                return _firstExpression.interpret() - _secondExpression.interpret();
            }
            public override string ToString()
            {
                return "-";
            }
        }


        public class MultiplicationExpression : IExpresion
        {
            private IExpresion _firstExpression, _secondExpression;

            public MultiplicationExpression(IExpresion firstExpression, IExpresion secondExpression)
            {
                _firstExpression = firstExpression;
                _secondExpression = secondExpression;
            }

            public int interpret()
            {
                return _firstExpression.interpret() * _secondExpression.interpret();
            }
            public override string ToString()
            {
                return "*";
            }
        }


        public class ExpressionParser
        {
            //crear el parser va a tirar el string posicion por posicion y va a llamar este metodo para validar si es un operador o no
            private static bool IsOperator(string input) => (input.Equals("+") || input.Equals("-") || input.Equals("*"));

            private static IExpresion GetExpresionObject(IExpresion firstExpresion, IExpresion secondEspression, string symbol)
            {

                if (symbol.Equals("+"))
                   return new AdditionExpression(firstExpresion, secondEspression);
                else if (symbol.Equals("-"))
                    return new SubstractionExpression(firstExpresion, secondEspression);
                else
                    return new MultiplicationExpression(firstExpresion, secondEspression);

            }

            Stack<IExpresion> stack = new Stack<IExpresion>();

            public int Parse(string input)
            {

                string[] tokenlist = input.Split(' ');
                foreach(string symbol in tokenlist)
                {
                    if (!IsOperator(symbol))
                    {
                        IExpresion numberExpression = new NumericExpression(symbol);
                        stack.Push(numberExpression);
                        Console.WriteLine($"Agregando al stack: {numberExpression.interpret()}");
                    }else if (IsOperator(symbol)){
                        IExpresion firstExpression = stack.Pop();
                        IExpresion secondExpression = stack.Pop();
                        Console.WriteLine($"Operadores para{firstExpression.interpret()}, {secondExpression.interpret()}");
                        IExpresion expressionObject = GetExpresionObject(firstExpression, secondExpression, symbol);
                        Console.WriteLine($"Aplicando operadores: {expressionObject}");

                        NumericExpression resultExpression = new NumericExpression(expressionObject.interpret());
                        stack.Push(resultExpression);
                        Console.WriteLine($"Agregando resultado al stack {resultExpression.interpret()}");
                    }

                }
                return stack.Pop().interpret();
            }

        }


        static void Main(string[] args)
        {
            string input = "2 1 5 + *";
            ExpressionParser expressionParser = new ExpressionParser();
            int result = expressionParser.Parse(input);
            Console.WriteLine($"Resultado final: {result}");
            Console.ReadLine();
        }
    }
}
