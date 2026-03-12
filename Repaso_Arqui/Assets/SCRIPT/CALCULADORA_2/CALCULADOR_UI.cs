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

    
    
    // SELECCIÓN DE OPERADOR

    public void SeleccionarOperador(Operador operador)
    {
        _operador = operador;
    }

    public void OperadorSuma() => _operador = Operador.Suma;
    public void OperadorResta() => _operador = Operador.Resta;
    public void OperadorMultiplicacion() => _operador = Operador.Multiplicacion;
    public void OperadorDivision() => _operador = Operador.Division;

   
    
    // CALCULAR

    public void Calcular()
    {
        // Validación con early return
        if (!float.TryParse(_inputA.text, out float a) ||
            !float.TryParse(_inputB.text, out float b))
        {
            _resultado.text = "Vaya a estudiar.";
            return;
        }

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
                if (b == 0)
                {
                    _resultado.text = "No se divide entre 0.";
                }
                else
                {
                    _resultado.text = (a / b).ToString();
                }
                break;

            default:
                _resultado.text = "Seleccione un operador.";
                break;
        }
    }

    // BOTÓN AC (BORRAR TODO)

    public void LimpiarTodo()
    {
        _inputA.text = "";
        _inputB.text = "";
        _resultado.text = "0";
    }
}