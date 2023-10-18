using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeBehaviour : MeleeWeaponBehaviour
{ 
    //private MeleeWeaponController mvc;
    //[SerializeField] GameObject player;

    void Start()
     {
         //mvc = FindObjectOfType<MeleeWeaponController>();
     }
    void Update()
    {
        //transform.position = player.transform.position;
        transform.rotation = Quaternion.Lerp(transform.rotation, transform.rotation * Quaternion.Euler(0, 0, -45), Time.deltaTime);
    }
}
