using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{

    public GameObject ThePlayer;
    public GameObject TheEnemy;
    public float EnemySpeed;
    public bool AttackTrigger = false;
    public bool IsAttacking = false;
    public AudioSource HurtSound1;
    public AudioSource HurtSound2;
    public AudioSource HurtSound3;
    public int HurtGen;
    public GameObject TheFlash;
    
    void Update()
    {
        transform.LookAt(ThePlayer.transform);
        if(AttackTrigger == false){
            TheEnemy.GetComponent<Animation>().Play("walk_in_place");
            transform.position = Vector3.MoveTowards(transform.position,ThePlayer.transform.position, EnemySpeed);
        }
        if (AttackTrigger == true && IsAttacking == false){
            EnemySpeed = 0;
            TheEnemy.GetComponent<Animation>().Play("attack");
            StartCoroutine(InflictDamage());
        }
    }

    void OnTriggerEnter(){
        AttackTrigger = true;
    }

    void OnTriggerExit(){
        AttackTrigger = false;
    }

    IEnumerator InflictDamage(){
        IsAttacking = true;
        HurtGen = Random.Range(1,4);
        if (HurtGen == 1){
            HurtSound1.Play();
        } 
        if (HurtGen == 2){
            HurtSound2.Play();
        } 
        if (HurtGen == 3){
            HurtSound3.Play();
        } 
        TheFlash.SetActive(true);
        
        yield return new WaitForSeconds(0.1f);
        GlobalHealth.CurrentHealth -= 5;
        TheFlash.SetActive(false);

        yield return new WaitForSeconds(1.1f);
        IsAttacking = false;
    }
}
