using UnityEngine;

public class PORCENTAJE : MonoBehaviour
{
    // Arrastra el componente CalculatorUI desde el inspector
    public CalculatorUI calculatorUI;

    public void OnPercentagePressed()
    {
        if (calculatorUI == null)
        {
            Debug.LogWarning("CalculatorUI reference not set on PORCENTAJE.");
            return;
        }

        // Delegar la operación al componente que mantiene el estado (currentInput, displayText)
        calculatorUI.OnPercentagePressed();
    }   
}
