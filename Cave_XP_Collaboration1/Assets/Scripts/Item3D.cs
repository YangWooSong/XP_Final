using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Item3D : MonoBehaviour
{

    private void OnMouseDown()
    {
        //ui뒤에 물체는 눌리지 않게 하는 코드
        if (!EventSystem.current.IsPointerOverGameObject())
        {
       
            if (gameObject.name == "nametag")
            {
                GameObject.Find("GameManager 1").GetComponent<GameManangerScript>().getNameTag = true;

            }
            else if (gameObject.name == "footprint1")
            {
                GameObject.Find("GameManager 1").GetComponent<GameManangerScript>().getFoot01 = true;
            }
            else if (gameObject.name == "footprint2")
            {
                GameObject.Find("GameManager 1").GetComponent<GameManangerScript>().getFoot02 = true;
            }
            else if (gameObject.name == "footprint3")
            {
                GameObject.Find("GameManager 1").GetComponent<GameManangerScript>().getFoot03 = true;
            }
            else if (gameObject.name == "riphand")
            {
                GameObject.Find("GameManager 1").GetComponent<GameManangerScript>().getRipHand = true;
            }
            else if (gameObject.name == "monsterFootprint")
            {
                GameObject.Find("GameManager 1").GetComponent<GameManangerScript>().getMonsterFoot = true;
            }
            else if (gameObject.name == "handcloth")
            {
                GameObject.Find("GameManager 1").GetComponent<GameManangerScript>().getHandcloth = true;
            }
            else if(gameObject.name == "saw")
            {
               GameObject.Find("GameManager 1").GetComponent<GameManangerScript>().getSaw = true;
            }
            Destroy(gameObject);

        }


    }
}
