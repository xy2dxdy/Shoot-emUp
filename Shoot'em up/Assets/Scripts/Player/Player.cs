using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerHealth _playerHealth;
    [SerializeField] private PlayerExperience _playerExperience;
    [SerializeField] private int _valueDecrease;
    [SerializeField] private int _valueIncrease;
    [SerializeField] private string _tag;

    private void GetHit()
    {
        _playerHealth.Decrease(_valueDecrease);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(_tag))
        {
            _playerExperience.Increase(_valueIncrease);
        }
    }
}
