using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Turret", order = 1)]
public class turretData : ScriptableObject
{
    public bool isAlive;
    public int poisitionNumber;
    
}
