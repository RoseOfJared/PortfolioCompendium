using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents : MonoBehaviour {
    public static Action<Item> ItemAddedToInventory;
    public static Action<string> TooltipActivated;
    public static Action TooltipDeactivated;
    public static Action SaveInitiated;

    public static void OnItemAddedToInventory(Item item)
    {
        ItemAddedToInventory?.Invoke(item);
    }

    public static void OnTooltipActivated(string text)
    {
        TooltipActivated?.Invoke(text);
    }

    public static void OnTooltipDeactivated()
    {
        TooltipDeactivated?.Invoke();
    }

    public static void OnSaveInitiated()
    {
        SaveInitiated?.Invoke();
    }

}