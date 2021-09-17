using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NutrientUpdateText : MonoBehaviour
{
    [SerializeField] private string nutrientText;
    [SerializeField] private TextMeshProUGUI textUI;
    [SerializeField] private string maxValue;

    // Start is called before the first frame update
    void Start()
    {
        textUI = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateText(float newValue, float addedValue)
    {
        textUI.text = nutrientText + ": " + newValue + " / " + maxValue + " | + " + addedValue;
    }
}
