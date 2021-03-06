﻿using UnityEngine;
using System.Collections;

public class MeleeHit : MonoBehaviour {

    public GameObject player;
    public int meleeMultiplier = 2;
    public Sprite[] dmg;
    public GameObject damageIndicator;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Called when melee hits an object
    void OnTriggerEnter2D(Collider2D hit)
    {
        //If the hit object is an enemy
        if (hit.gameObject.layer == LayerMask.NameToLayer("Enemies") || hit.gameObject.layer == LayerMask.NameToLayer("Boss"))
        {
            //Display damage given
            Instantiate(damageIndicator, hit.gameObject.transform.position, hit.gameObject.transform.rotation);
            SpriteRenderer renderer = GameObject.Find("numeric-1").GetComponent<SpriteRenderer>();

            //Tell the meleed object that it has taken damage
            //Damage is equal to players strength
            int meleeDmg = meleeMultiplier * player.GetComponent<Player>().strength;
            hit.gameObject.SendMessage("takeDamage", meleeDmg);
            if (meleeDmg < dmg.Length - 1)
            {
                renderer.sprite = dmg[meleeDmg];
            }
            else
            {
                SpriteRenderer renderer2 = GameObject.Find("numeric-0b").GetComponent<SpriteRenderer>();
                SpriteRenderer renderer3 = GameObject.Find("numeric-0a").GetComponent<SpriteRenderer>();
                renderer.sprite = dmg[9];
                renderer2.sprite = dmg[9];
                renderer3.sprite = dmg[9];
            }
        }
    } 
}
