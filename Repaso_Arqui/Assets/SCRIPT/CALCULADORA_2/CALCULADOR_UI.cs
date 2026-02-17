using TMPro;
using UnityEngine;

public class CALCULADOR_UI : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputA;
    [SerializeField] private TMP_InputField _inputB;

    public float MOMO(string input)
        {
        return float.Parse(input);
    }

    public string Calcular(string operador, float inputA , float inputB)
    { 
        switch (operador)
        {
            case "+":
                return inputA + inputB). ToString();
                break;

            case "-":
                return inputA - inputB). ToString();
                break;

            case "*":
                return inputA * inputB). ToString();
                break;

            case "/":
                return inputA / inputB). ToString();
                break;
        default:
                Debug.Log("Si no pones un operador tienes 0");
                break;

        }
    }

}