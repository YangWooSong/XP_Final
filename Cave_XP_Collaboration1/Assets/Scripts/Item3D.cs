using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Item3D : MonoBehaviour
{

    private void OnMouseDown()
    {
        //ui�ڿ� ��ü�� ������ �ʰ� �ϴ� �ڵ�
        if (!EventSystem.current.IsPointerOverGameObject())
        {
       
            if (gameObject.name == "nametag")
            {
                GameObject.Find("GameManager").GetComponent<GameManangerScript>().getNameTag = true;

            }
            else if (gameObject.name == "footprint1")
            {
                GameObject.Find("GameManager").GetComponent<GameManangerScript>().getFoot01 = true;
            }
            else if (gameObject.name == "footprint2")
            {
                GameObject.Find("GameManager").GetComponent<GameManangerScript>().getFoot02 = true;
            }
            else if (gameObject.name == "footprint3")
            {
                GameObject.Find("GameManager").GetComponent<GameManangerScript>().getFoot03 = true;
            }
            else if (gameObject.name == "riphand")
            {
                GameObject.Find("GameManager").GetComponent<GameManangerScript>().getRipHand = true;
            }
            else if (gameObject.name == "monsterFootprint")
            {
                GameObject.Find("GameManager").GetComponent<GameManangerScript>().getMonsterFoot = true;
            }
            else if (gameObject.name == "handcloth")
            {
                GameObject.Find("GameManager").GetComponent<GameManangerScript>().getHandcloth = true;
            }
            else if(gameObject.name == "saw")
            {
               GameObject.Find("GameManager").GetComponent<GameManangerScript>().getSaw = true;
            }
            Destroy(gameObject);

        }


    }
}
