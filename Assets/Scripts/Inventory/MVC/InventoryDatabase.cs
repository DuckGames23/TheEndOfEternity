using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class InventoryDatabase
{
    public InventoryItem[] MeeleWeapons;
    public int MeeleWeaponsCapacity;
    public int SelectedMeeleWeapon;
    public InventoryItem[] Shields;
    public int ShieldsCapacity;
    public int SelectedShield;
    public InventoryItem[] RangedWeapons;
    public int RangedWeaponsCapacity;
    public int SelectedRangedWeapon;
    public InventoryItem[] Arrows;
    public int ArrowsCapacity;
    public int SelectedArrow;
    public InventoryItem[] Clothes;
    public int ClothesCapacity;
    public int SelectedHeadClothe;
    public int SelectedBodyClothe;
    public int SelectedAmulet;
    public InventoryItem[] FoodItems;
    public int FoodItemsCapacity;
    public int SelectedFoodItem;
    public InventoryItem[] QuestItems;
    public int QuestItemsCapacity;
}