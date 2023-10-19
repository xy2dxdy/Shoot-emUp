using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public EnemyConfig enemyData;
    Transform player;

    private void Start()
    {
        player = FindObjectOfType<PlayerMovement>().transform;
    }
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, enemyData.MoveSpeed * Time.deltaTime);
    }
}
