using UnityEngine;

public class CampFire : MonoBehaviour
{
    [SerializeField] private CampFireConfig _config;
    [SerializeField] private CampFireHealth _health;
    [SerializeField] private int _woodsLayerID;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer != _woodsLayerID)
        {
            return;
        }
        _health.Increase(_config.IncreaseHPValue);
    }

    private void Update()
    {
        _health.Decrease(_config.DecreaseHPValue);
    }
}
