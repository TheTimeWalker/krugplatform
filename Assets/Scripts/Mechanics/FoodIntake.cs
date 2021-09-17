using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodIntake : MonoBehaviour
{

    private NutrientSystem nutrientSystem;
    [SerializeField] public float portionSize;
    [SerializeField] public float energy;
    [SerializeField] public float fat;
    [SerializeField] public float saturates;
    [SerializeField] public float carbohydrate;
    [SerializeField] public float sugar;
    [SerializeField] public float protein;
    [SerializeField] public float salt;

    // Start is called before the first frame update
    void Start()
    {
        nutrientSystem = GameObject.Find("GameController").GetComponent<NutrientSystem>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddIntake()
    {
        nutrientSystem.AddEnergy(energy);
        nutrientSystem.AddFat(fat);
        nutrientSystem.AddSaturates(saturates);
        nutrientSystem.AddCarbohydrate(carbohydrate);
        nutrientSystem.AddSugar(sugar);
        nutrientSystem.AddProtein(protein);
        nutrientSystem.AddSalt(salt);
        GameObject.Find("FoodText").GetComponent<FoodPickUpUI>().UpdateText(gameObject.name, portionSize);
        GameObject.Find("EatingListText").GetComponent<EatingList>().UpdateText(gameObject.name, portionSize);
    }
}
