using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FoodPickUpUI : MonoBehaviour
{
    private TextMeshProUGUI textUI;

    // Start is called before the first frame update
    void Start()
    {
        textUI = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateText(string foodValue, float portionValue)
    {
        textUI.text = foodValue + "\n" + portionValue + "g";
    }
}
