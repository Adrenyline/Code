using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase {

    static private List<Item> _items;
    static private bool _databaseLoaded = false;


    static private void ValidateDatabase()
    {
        if(_items == null)
        {
            _items = new List<Item>();
        }
        if (!_databaseLoaded)
        {
            LoadDatabase();
        }
    }
    
    static public void LoadDatabase()
    {
        if (_databaseLoaded)
        {
            return;
        }
        else
        {
            _databaseLoaded = true;
            LoadDatabaseForce();
        }
    }

    static public void LoadDatabaseForce()
    {
        ValidateDatabase();
        Item[] resources = Resources.LoadAll<Item>(@"Items");
    }

    static public void ClearDatabase()
    {

    }

    static public Item GetItem(int id)
    {

    }
}
