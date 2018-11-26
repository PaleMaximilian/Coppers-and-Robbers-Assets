﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour {

    float blocksToTp = EntityController.secondLevel - EntityController.firstLevel;

    public PlayerMovement player;
    public EntityMovement entity;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.playerElevatorChecked = true;
            Debug.Log(player.playerElevatorChecked);
        }
        else if (collision.gameObject.tag == "Entity")
        {
            entity = collision.GetComponent<EntityMovement>();
            entity.entityElevatorChecked = true;
            Debug.Log(entity.entityElevatorChecked);
        }
    }

   void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.playerElevatorChecked = false;
        }
        if (collision.gameObject.tag == "Entity")
        {
            entity = collision.GetComponent<EntityMovement>();
            entity.entityElevatorChecked = false;
        }
    }

    public void Elevate(GameObject character)
    {
        character.transform.position = new Vector2(character.transform.position.x, character.transform.position.y + blocksToTp);
    }

    public void Elevate(EntityMovement character)
    {
        character.transform.position = new Vector2(character.transform.position.x, character.transform.position.y + blocksToTp);
    }

    public void Lower(GameObject character)
    {
        character.transform.position = new Vector2(character.transform.position.x, character.transform.position.y - blocksToTp);
    }

    public void Lower(EntityMovement character)
    {
        character.transform.position = new Vector2(character.transform.position.x, character.transform.position.y - blocksToTp);
    }
}
