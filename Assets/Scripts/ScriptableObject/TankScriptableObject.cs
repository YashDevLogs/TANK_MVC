
using UnityEngine;
[CreateAssetMenu(fileName = "TankScriptableobject",menuName ="ScriptableObjects/NewTanks")]
public class TankScriptableObject : ScriptableObject
{
    public TankTypes TankType;
    public float Movementspeed;
    public float RotationSpeed;
    public Material color;
}
