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
                GameObject.Find("GameManager 1").GetComponent<GameManangerScript>().getNameTag = true;

            }
            else if (gameObject.name == "riphand")
            {
                GameObject.Find("GameManager 1").GetComponent<GameManangerScript>().getRipHand = true;
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
