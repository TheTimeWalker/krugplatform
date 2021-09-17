using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NutrientSystem : MonoBehaviour
{
    [SerializeField] private NutrientUpdateText energyUI;
    [SerializeField] private NutrientUpdateText fatUI;
    [SerializeField] private NutrientUpdateText saturatesUI;
    [SerializeField] private NutrientUpdateText carbohydrateUI;
    [SerializeField] private NutrientUpdateText sugarUI;
    [SerializeField] private NutrientUpdateText proteinUI;
    [SerializeField] private NutrientUpdateText saltUI;

    [SerializeField] private float energy;
    [SerializeField] private float fat;
    [SerializeField] private float saturates;
    [SerializeField] private float carbohydrate;
    [SerializeField] private float sugar;
    [SerializeField] private float protein;
    [SerializeField] private float salt;

    [Header("Goal")]
    [SerializeField] public float energyGoal = 2000;
    [SerializeField] public float fatGoal = 70;
    [SerializeField] public float saturatesGoal = 20;
    [SerializeField] public float carbohydrateGoal = 260;
    [SerializeField] public float sugarGoal = 90;
    [SerializeField] public float proteinGoal = 50;
    [SerializeField] public float saltGoal = 6;

    [Header("Maximum")]
    [SerializeField] public float energyMax;
    [SerializeField] public float fatMax;
    [SerializeField] public float saturatesMax;
    [SerializeField] public float carbohydrateMax;
    [SerializeField] public float sugarMax;
    [SerializeField] public float proteinMax;
    [SerializeField] public float saltMax;

    private GameObject winLosePanel;
    private TextMeshProUGUI winLoseText;
    private bool endOfGame;


    // Start is called before the first frame update
    void Start()
    {
        winLosePanel = GameObject.Find("WinLosePanel");
        winLoseText = GameObject.Find("WinLoseText").GetComponent<TextMeshProUGUI>();
        winLosePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!endOfGame)
        {
            if (energy >= energyGoal && fat >= fatGoal && saturates >= saturatesGoal && carbohydrate >= carbohydrateGoal && sugar >= sugarGoal && protein >= proteinGoal && salt >= saltGoal)
            {
                winLosePanel.SetActive(true);
                winLoseText.text = "You win!";
                endOfGame = true;
            }
            if (energy > energyMax || fat > fatMax || saturates > saturatesMax || carbohydrate > carbohydrateMax || sugar > sugarMax || protein > proteinMax || salt > saltMax)
            {
                winLosePanel.SetActive(true);
                winLoseText.text = "Game Over";
                endOfGame = true;
            }
        }
    }

    public void AddEnergy(float value)
    {
        energy = energy + value;
        energyUI.UpdateText(energy, value);
    }

    public void AddFat(float value)
    {
        fat = fat + value;
        fatUI.UpdateText(fat, value);
    }

    public void AddSaturates(float value)
    {
        saturates = saturates + value;
        saturatesUI.UpdateText(saturates, value);
    }

    public void AddCarbohydrate(float value)
    {
        carbohydrate = carbohydrate + value;
        carbohydrateUI.UpdateText(carbohydrate, value);
    }

    public void AddSugar(float value)
    {
        sugar = sugar + value;
        sugarUI.UpdateText(sugar, value);
    }

    public void AddProtein(float value)
    {
        protein = protein + value;
        proteinUI.UpdateText(protein, value);
    }

    public void AddSalt(float value)
    {
        salt = salt + value;
        saltUI.UpdateText(salt, value);
    }
}
