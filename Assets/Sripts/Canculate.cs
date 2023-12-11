using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canculate : MonoBehaviour
{
    [SerializeField] private bool _readyForCanculate;
    [SerializeField] private int _number1;
    [SerializeField] private int _number2;
    [SerializeField] private int _result;
    [SerializeField] Operation Operation_operation;
    private enum Operation
    {
        Sum,
        Substraction,
        Multiplication,
        Division
    }

    void Update()
    {
        if(_readyForCanculate == true)
        {
            Canculating(_number1, _number2, Operation_operation);
        }
    }

    private void Canculating(int firstNumber, int secondNumber, Operation operation)
    {
        switch (operation)
        {
            case Operation.Sum:
                _readyForCanculate = false;
                _result = Sum(firstNumber, secondNumber);
                Debug.Log(_result);
                break;

            case Operation.Substraction:
                _readyForCanculate = false;
                _result = Substraction(firstNumber, secondNumber);
                Debug.Log(_result);
                break;

            case Operation.Multiplication:
                _readyForCanculate = false;
                _result = Multiplication(firstNumber, secondNumber);
                Debug.Log(_result);
                break;

            case Operation.Division:
                _readyForCanculate = false;
                _result = Division(firstNumber, secondNumber);
                Debug.Log(_result);
                break;

        }
        static int Sum(int firstNumber, int secondNumber)
            => firstNumber + secondNumber;

        static int Substraction(int firstNumber, int secondNumber)
            => firstNumber - secondNumber;

        static int Multiplication(int firstNumber, int secondNumber)
            => firstNumber * secondNumber;

        static int Division(int firstNumber, int secondNumber)
            => firstNumber / secondNumber;

    }
}
