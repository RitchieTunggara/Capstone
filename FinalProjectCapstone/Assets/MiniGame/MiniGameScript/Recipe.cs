using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Recipe", menuName = "LittleAlchemy/Recipe", order = 0)]
public class Recipe : ScriptableObject
{
    public Item result;
    public Item ingredient1;
    public Item ingredient2;
}
