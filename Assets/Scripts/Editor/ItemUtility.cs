﻿using UnityEngine;
using System.Collections;
using UnityEditor;

public class ItemUtility {

	[MenuItem("Assets/Create/RPG/Item")]
    static public void CreateItem()
    {
        ScriptableObjectUtility.CreateAsset<Item>();
    }
}
