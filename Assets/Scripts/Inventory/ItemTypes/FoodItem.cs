using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "NewFoodItem", menuName = "InventorySystem/FoodItem")]
public class FoodItem : InventoryItem
{
    public UnityEvent OnEaten;
    [Space]
    public int HealingStrengthHP = 1;

    private void Awake()
    {
        OnEaten.AddListener(Heal);
    }

    public virtual void Eat()
    {
        OnEaten?.Invoke();
    }

    public virtual void Heal()
    {
        //TODO: add healing logic
    }
}
