using TMPro;
using UnityEngine;
using static CALCULADORA;

public class CalculatorUI : MonoBehaviour
{
    public TMP_Text displayText;

    private string currentInput = "";
    private float firstNumber = 0f;
    private string currentOperator = "";

    private Calculadora calculadora = new Calculadora();

    public void OnNumberPressed(string number)
    {
        currentInput += number;
        displayText.text = currentInput;
    }

    public void OnOperatorPressed(string op)
    {
        if (currentInput == "") return;

        firstNumber = float.Parse(currentInput);
        currentOperator = op;
        currentInput = "";
    }

    public void OnEqualsPressed()
    {
        if (currentInput == "") return;

        float secondNumber = float.Parse(currentInput);
        float result = 0f;

        switch (currentOperator)
        {
            case "+":
                result = calculadora.Sumar(firstNumber, secondNumber);
                break;

            case "-":
                result = calculadora.Restar(firstNumber, secondNumber);
                break;

            case "*":
                result = calculadora.Multiplicar(firstNumber, secondNumber);
                break;

            case "/":
                result = calculadora.Dividir(firstNumber, secondNumber);
                break;
        }

        displayText.text = result.ToString();
        currentInput = result.ToString();
    }

    public void OnClearPressed()
    {
        currentInput = "";
        firstNumber = 0f;
        currentOperator = "";
        displayText.text = "0";
    }

    public void OnBackspacePressed()
    {
        if (currentInput.Length > 0)
        {
            currentInput = currentInput.Substring(0, currentInput.Length - 1);
            displayText.text = currentInput;

            if (currentInput == "")
                displayText.text = "0";
        }
    }
}
