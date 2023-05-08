using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class InventorySavesTest : MonoBehaviour
{
    [SerializeField] private InventoryItem[] _items;

    public void TestFilling()
    {
        InventoryController controller = GetComponent<InventoryController>();
        for(int i = 0; i < 6; i++)
        {
            //controller.SetNewItemToCell(i, _items[i]);
        }
    }
}
