using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "NewQuestItem", menuName = "InventorySystem/QuestItem")]
public class QuestItem : InventoryItem
{
    public UnityEvent OnInteract;

    public virtual void Interact()
    {
        OnInteract?.Invoke();
    }
}
