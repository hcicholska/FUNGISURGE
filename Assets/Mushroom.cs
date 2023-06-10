using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewMushroom", menuName = "Inventory/Mushroom")]
public class Mushroom : ScriptableObject
{
    public string mushroomName;
    public int damage;
    public float range;
    public Sprite icon;
}
