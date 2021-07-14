using System.Collections;
using System.Collections.Generic;
using CivilizationClicker;
using UnityEngine;

public class UnitCollection : MonoBehaviour
{
    //public GameObject unitSpawner;
    public List<GameObject> unitPrefabs;
    private void Start()
    {
        for (int i = 0; i < unitPrefabs.Count; i++)
        {
            Instantiate(unitPrefabs[i], transform.parent);
        }
    }
}