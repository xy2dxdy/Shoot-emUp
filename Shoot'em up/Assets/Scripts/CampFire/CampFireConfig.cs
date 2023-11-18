using UnityEngine;

[CreateAssetMenu(fileName = "CampFireConfig", menuName = "Config/CampFire", order = 51)]
public class CampFireConfig : ScriptableObject
{
    [field: SerializeField] public float MaxHP { get; private set; }
    
    [field: SerializeField] public float MinHP { get; private set; }

    [field: SerializeField] public float DecreaseHPValue { get; private set; }

    [field: SerializeField] public float IncreaseHPValue { get; private set; }
}
