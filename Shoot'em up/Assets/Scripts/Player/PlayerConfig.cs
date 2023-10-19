using UnityEngine;

[CreateAssetMenu(fileName = "PlayerConfig", menuName = "Config/Player", order = 51)]
public class PlayerConfig : ScriptableObject
{
    [field: SerializeField] public float MoveSpeed { get; private set; }
}
