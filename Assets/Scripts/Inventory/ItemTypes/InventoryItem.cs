using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
[CreateAssetMenu(fileName = "NewInventoryItem", menuName = "InventorySystem/InventoryItem", order = 1)]
public class InventoryItem : ScriptableObject
{
    public string Name = "itemName";
    public Sprite Icon;
    public UnityEvent OnPicked;
    public UnityEvent OnDropped;

    public virtual void Pick()
    {
        OnPicked?.Invoke();
    }

    public virtual void Drop()
    {
        OnDropped?.Invoke();
    }
}
