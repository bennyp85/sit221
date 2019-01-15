using DataStructures_Algorithms.Week01;
using System;
using System.Collections.Generic;

namespace DataStructures_Algorithms.Week05
{
    public class RPNCalculator
    {

        MyStack<int> operands = new MyStack<int>();
        MyStack<char> operators = new MyStack<char>();

        public RPNCalculator(Vector<string> expression)
        {
            int _operand;
            char _operator;
            for (int i = 0; i < expression.Count; i++)
            {
                if (int.TryParse(expression[i], out _operand) == true)
                {
                    operands.Push(_operand);
                }
                else if (char.TryParse(expression[i], out _operator) == true)
                {
                    switch (_operator)
                    {
                        case '+': Add(); break;
                        case '-': Subtract(); break;
                        case '*': Multiple(); break;
                        case '/': Divide(); break;
                    }
                }
                else
                    throw new Exception("Invald data type");
            }
        }

        public int GetResult()
        {
            if (operands.Count == 0) throw new Exception("No value available");
            return operands.Pop();
        }

        void Divide()
        {
            if (operands.Count < 2) throw new Exception("no enough operands");
            int op1 = operands.Pop();
            int op2 = operands.Pop();
            operands.Push(op2 / op1);
        }

        void Multiple()
        {
            if (operands.Count < 2) throw new Exception("no enough operands");
            int op1 = operands.Pop();
            int op2 = operands.Pop();
            operands.Push(op2 * op1);
        }

        void Subtract()
        {
            if (operands.Count < 2) throw new Exception("no enough operands");
            int op1 = operands.Pop();
            int op2 = operands.Pop();
            operands.Push(op2 - op1);
        }

        void Add()
        {
            if (operands.Count < 2) throw new Exception("no enough operands");
            int op1 = operands.Pop();
            int op2 = operands.Pop();
            operands.Push(op1 + op2);
        }

    }

}
