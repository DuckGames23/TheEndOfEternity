using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryView : MonoBehaviour
{
    [SerializeField] private GameObject inventoryCell;
    [SerializeField] private Transform meeleWeaponsContainer;
    [SerializeField] private InventoryCell selectedMeeleWeaponCell;
    [SerializeField] private Transform shieldsContainer;
    [SerializeField] private InventoryCell selectedShieldCell;
    [SerializeField] private Transform rangeWeaponsContainer;
    [SerializeField] private InventoryCell selectedRangeWeaponCell;
    [SerializeField] private Transform arrowsContainer;
    [SerializeField] private InventoryCell selectedArrowCell;
    [SerializeField] private Transform clothesContainer;
    [SerializeField] private InventoryCell selectedHeadClothesCell;
    [SerializeField] private InventoryCell selectedBodyClothesCell;
    [SerializeField] private InventoryCell selectedAmuletClothesCell;
    [SerializeField] private Transform foodItemsContainer;
    [SerializeField] private InventoryCell selectedFoodItemCell;
    [SerializeField] private Transform questItemsContainer;

    public void InitializeView(InventoryDatabase inventoryDatabase)
    {
        InitializateContainer(meeleWeaponsContainer, inventoryDatabase.MeeleWeaponsCapacity, inventoryDatabase.MeeleWeapons);
        selectedMeeleWeaponCell.Item = inventoryDatabase.MeeleWeapons[inventoryDatabase.SelectedMeeleWeapon];
        InitializateContainer(shieldsContainer, inventoryDatabase.ShieldsCapacity, inventoryDatabase.Shields);
        selectedShieldCell.Item = inventoryDatabase.Shields[inventoryDatabase.SelectedShield];
        InitializateContainer(rangeWeaponsContainer, inventoryDatabase.RangedWeaponsCapacity, inventoryDatabase.RangedWeapons);
        selectedRangeWeaponCell.Item = inventoryDatabase.RangedWeapons[inventoryDatabase.SelectedRangedWeapon];
        InitializateContainer(arrowsContainer, inventoryDatabase.ArrowsCapacity, inventoryDatabase.Arrows);
        selectedArrowCell.Item = inventoryDatabase.Arrows[inventoryDatabase.SelectedArrow];
        InitializateContainer(clothesContainer, inventoryDatabase.ClothesCapacity, inventoryDatabase.Clothes);
        selectedHeadClothesCell.Item = inventoryDatabase.Clothes[inventoryDatabase.SelectedHeadClothe];
        selectedBodyClothesCell.Item = inventoryDatabase.Clothes[inventoryDatabase.SelectedBodyClothe];
        selectedAmuletClothesCell.Item = inventoryDatabase.Clothes[inventoryDatabase.SelectedAmulet];
        InitializateContainer(foodItemsContainer, inventoryDatabase.FoodItemsCapacity, inventoryDatabase.FoodItems);
        selectedFoodItemCell.Item = inventoryDatabase.FoodItems[inventoryDatabase.SelectedFoodItem];
        InitializateContainer(questItemsContainer, inventoryDatabase.QuestItemsCapacity, inventoryDatabase.QuestItems);
    }

    private void InitializateContainer(Transform contatiner, int capacity, InventoryItem[] items)
    {
        for (int i = 0; i < capacity; i++)
        {
            GameObject newCell = Instantiate(inventoryCell, contatiner);
            if (i <= items.Length - 1)
            {
                newCell.GetComponent<InventoryCell>().Item = items[i];
            }
        }
    }

    /*public void SetCurrentItem(int oldItem, int newItem)
    {
        _highlightings[oldItem].enabled = false;
        _highlightings[newItem].enabled = true;
    }

    public void SetNewItem(int numberOfCell, Sprite itemSprite)
    {
        _itemsIcons[numberOfCell].sprite = itemSprite;
        _itemsIcons[numberOfCell].enabled = true;
    }

    public void RemoveItem(int numberOfCell)
    {
        _itemsIcons[numberOfCell].enabled = false;
    }*/
}
