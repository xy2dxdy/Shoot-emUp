using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeaponBehaviour : MonoBehaviour
{
    public WeaponConfig weaponData;
    private MeleeWeaponController controller;
    protected Vector3 direction;
    private BoxCollider2D player;

    protected float currentDamage;
    protected float currentSpeed;
    protected float currentCooldownDuration;
    protected float currentPierce;

    private void Awake()
    {
        controller = FindObjectOfType<MeleeWeaponController>();
        player = controller.GetComponentInParent<BoxCollider2D>();
        currentDamage = weaponData.Damage;
        currentSpeed = weaponData.Speed;
        currentCooldownDuration = weaponData.CooldownDuration;
        currentPierce = weaponData.Pierce;
    }

    public void DirectionChecker(Vector3 dir)
    {
        direction = dir;

        float dirX = direction.x;
        float dirY = direction.y;

        Vector3 scale = transform.localScale;
        Vector3 rotation = transform.rotation.eulerAngles;

        if (dirX < 0 && dirY == 0) //left
        {
            controller.offset = -new Vector3(controller.PlayerSize.x / 2 + controller.WeaponSize.x / 2, 0, 0);
            scale.x = -1;
        }
        else if (dirX > 0 && dirY == 0)
        {
            controller.offset = new Vector3(controller.PlayerSize.x / 2 + controller.WeaponSize.x / 2, 0, 0);
            scale.x = 1;
        }
        else if (dirX == 0 && dirY < 0) // down
        {
            scale.y *= -1;
        }
        else if (dirX == 0 && dirY > 0)//up
        {
            scale.x *= -1;
        }
        else if (dirX > 0 && dirY > 0) // right up
        {
            rotation.z = 0;
        }
        else if (dirX > 0 && dirY < 0)//right down
        {
            rotation.z = 0;
            scale.y *= -1;
        }
        else if (dirX < 0 && dirY > 0)//left up
        {
            rotation.z = 0;
            scale.x *= -1;
        }
        else if (dirX < 0 && dirY < 0)//left down
        {
            rotation.z = 0;
            scale.y *= -1;
            scale.x *= -1;
        }
        transform.localScale = scale;
        transform.rotation = Quaternion.Euler(rotation);

    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            EnemyStats enemyStats = collision.GetComponent<EnemyStats>();
            enemyStats.TakeDamage(currentDamage);
        }
    }

}
