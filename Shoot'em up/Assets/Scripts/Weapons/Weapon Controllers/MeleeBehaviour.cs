using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeBehaviour : MeleeWeaponBehaviour
{ 
    private MeleeWeaponController mvc;
    //[SerializeField] GameObject player;

    void Start()
     {
         mvc = FindObjectOfType<MeleeWeaponController>();
     }
    void Update()
    {
        //if (mvc.isAttack)
        //{
        //    transform.rotation = Quaternion.Lerp(transform.rotation, /*transform.rotation **/ Quaternion.Euler(0, 0, -90), currentSpeed * Time.deltaTime);
        //}
        //if(mvc.isAttack == true && transform.rotation.eulerAngles.z <= Quaternion.Euler(0, 0, -85).eulerAngles.z)
        //    mvc.isAttack = false;
        //if (mvc.isAttack == false && transform.rotation != Quaternion.Euler(0, 0, 0))
        //{
        //    transform.rotation = Quaternion.Lerp(transform.rotation, /*transform.rotation * */Quaternion.Euler(0, 0, 0), currentSpeed * Time.deltaTime);
        //}
    }
}
