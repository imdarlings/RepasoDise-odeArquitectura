using TMPro;
using UnityEngine;

public class CALCULADOR_UI : MonoBehaviour
{

    public enum Operador
    {
        Suma,
        Resta,
        Multiplicacion,
        Division
    }

    [Header("Inputs")]
    [SerializeField] private TMP_InputField _inputA;
    [SerializeField] private TMP_InputField _inputB;

    [Header("Outputs")]
    [SerializeField] private TMP_Text _resultado;

    [Header("Config")]
    [SerializeField] private Operador _operador;

    public void SeleccionarOperador(Operador operador)
    {
        _operador = operador;
    }

    public void OperadorSuma() => _operador = Operador.Suma;
    public void OperadorResta()
    {
        _operador = Operador.Resta;
    }

    public void Calcular(string operador)
    { 
        float.TryParse(_inputA.text, out float a);
        float.TryParse(_inputB.text, out float b);

        switch (_operador)
        {
            case Operador.Suma:
                _resultado.text = (a + b).ToString();
                break;

            case Operador.Resta:
                _resultado.text = (a - b).ToString();
                break;

            case Operador.Multiplicacion:
                _resultado.text = (a * b).ToString();
                break;

            case Operador.Division:
                _resultado.text = (a / b).ToString();
                break;

        default:
                Debug.Log("Si no pones un operador tienes 0");
                break;

        }
    }

}