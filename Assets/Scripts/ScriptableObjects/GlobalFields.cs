using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GlobalFields", menuName = "Avia Flight 3D/GlobalFields", order = 0)]
public class GlobalFields : ScriptableObject 
{
    [SerializeField] public List<GameObject> cities;
}
