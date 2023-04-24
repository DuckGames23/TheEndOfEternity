using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InventoryModel), typeof(InventoryView))]
public class InventoryController : MonoBehaviour
{
    private InventoryView _inventoryView;
    private InventoryModel _inventoryModel;

    /*public int CurrentItemNumber
    {
        set
        {
            _inventoryView.SetCurrentItem(CurrentItemNumber, value);
            _inventoryModel.Database.CurrentItem = value;
        }
        get
        {
            return _inventoryModel.Database.CurrentItem;
        }
    }

    public InventoryItem GetCurrentItem
    {
        get
        {
            return _inventoryModel.Database.Items[CurrentItemNumber];
        }
    }*/

    private void Awake()
    {
        InitializeController();
        //GetComponent<InventorySavesTest>().TestFilling();
        //SaveData();
    }

    public void InitializeController()
    {
        _inventoryModel = GetComponent<InventoryModel>();
        _inventoryView = GetComponent<InventoryView>();
        _inventoryModel.InitializeModel("inventoryDatabase", new InventoryDatabase());
    }

    /*public void SetNewItemToCell(int numberOfCell, InventoryItem item)
    {
        _inventoryModel.Database.Items[numberOfCell] = item;
        _inventoryView.SetNewItem(numberOfCell, item.Icon);
    }

    public void RemoveItemFromCell(int numberOfCell)
    {
        _inventoryView.RemoveItem(numberOfCell);
        //_inventoryHotBarModel.Items[]
    }*/

    public void SaveData()
    {
        _inventoryModel.SaveData();
    }
}
