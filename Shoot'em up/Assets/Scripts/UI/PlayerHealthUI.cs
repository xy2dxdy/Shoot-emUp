using UnityEngine.UI;
using UnityEngine;

public class PlayerHealthUI : MonoBehaviour
{
    [SerializeField] private Image _healthUI;
    [SerializeField] private PlayerConfig _config;
    [SerializeField] private PlayerHealth _health;

    private void OnEnable()
    {
        _health.OnDecrease += UpdateHealthBar;
    }

    private void OnDisable()
    {
        _health.OnDecrease -= UpdateHealthBar;
    }

    private void UpdateHealthBar(int value)
    {
        _healthUI.fillAmount = _health.Current / _config.MaxHP;
        if (_healthUI.fillAmount == _config.MinHP)
        {
            EndGame();
        }
    }

    private void EndGame()
    {

    }
}
