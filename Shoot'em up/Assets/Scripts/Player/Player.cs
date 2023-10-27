using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerHealth _playerHealth;
    [SerializeField] private PlayerExperience _playerExperience;
    [SerializeField] private int _valueDecrease;
    [SerializeField] private int _valueIncrease;
    [SerializeField] private string _tag;
}
