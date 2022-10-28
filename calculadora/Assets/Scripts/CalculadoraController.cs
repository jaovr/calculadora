using System.Data;
using System;
using UnityEngine;
using UnityEngine.UI;

public class CalculadoraController : MonoBehaviour
{

    [SerializeField] private Text TextDisplayI;
    [SerializeField] private Text TextDisplayII;
    private String _expression;

    void Start()
    {
        TextDisplayI.text = "";
        TextDisplayII.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void BtnCharacter(String character) {
        TextDisplayII.text = character;
        TextDisplayI.text = TextDisplayI.text + TextDisplayII.text;
    }

    public void ExpressionCalculator() {
        _expression = TextDisplayI.text;
        DataTable table = new DataTable("tabela");
        String _result = table.Compute(_expression, String.Empty).ToString();
        TextDisplayII.text = _result;
        Debug.Log(_result);
    }

    public void DeletePrevious() {
        TextDisplayI.text = TextDisplayI.text.Remove(TextDisplayI.text.Length - 1);
        TextDisplayII.text = "";
    }

    public void ClearAll() {
        TextDisplayI.text = "";
        TextDisplayII.text = "";
    }
}
