using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCell : MonoBehaviour
{
    private InventoryItem _item;
    public InventoryItem Item
    {
        set
        {
            _item = value;
        }
        get
        {
            return _item;
        }
    }
}
