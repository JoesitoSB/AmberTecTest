using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TowerInfo", menuName = "ScriptableObjects/Tower Info")]
public class TowerInfoScriptableObject : ScriptableObject
{
    [SerializeField] private string name = "";
    [SerializeField] private Sprite icon = null;
    [SerializeField] private GameObject prefab = null;


    public string Name => name;
    public Sprite Icon => icon;
    public GameObject Prefab => prefab;
}
