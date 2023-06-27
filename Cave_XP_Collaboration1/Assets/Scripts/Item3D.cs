using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Item3D : MonoBehaviour
{
    private GameObject gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    private void OnMouseDown()
    {
        //ui뒤에 물체는 눌리지 않게 하는 코드
        if (!EventSystem.current.IsPointerOverGameObject())
        {
       
            if (gameObject.name == "nametag")
            {
                gameManager.GetComponent<GameManangerScript>().getNameTag = true;
                gameManager.GetComponent<GameManangerScript>().itemCount += 1;
            }
            else if (gameObject.name == "footprint1")
            {
                gameManager.GetComponent<GameManangerScript>().getFoot01 = true;
                gameManager.GetComponent<GameManangerScript>().itemCount += 1;
            }
            else if (gameObject.name == "footprint2")
            {
                gameManager.GetComponent<GameManangerScript>().getFoot02 = true;
                gameManager.GetComponent<GameManangerScript>().itemCount += 1;
            }
            else if (gameObject.name == "footprint3")
            {
                gameManager.GetComponent<GameManangerScript>().getFoot03 = true;
                gameManager.GetComponent<GameManangerScript>().itemCount += 1;
            }
            else if (gameObject.name == "riphand")
            {
                gameManager.GetComponent<GameManangerScript>().getRipHand = true;
                gameManager.GetComponent<GameManangerScript>().itemCount += 1;
            }
            else if (gameObject.name == "monsterFootprint")
            {
                gameManager.GetComponent<GameManangerScript>().getMonsterFoot = true;
                gameManager.GetComponent<GameManangerScript>().itemCount += 1;
            }
            else if (gameObject.name == "handcloth")
            {
                gameManager.GetComponent<GameManangerScript>().getHandcloth = true;
                gameManager.GetComponent<GameManangerScript>().itemCount += 1;
            }
            else if(gameObject.name == "saw")
            {
                gameManager.GetComponent<GameManangerScript>().getSaw = true;
                gameManager.GetComponent<GameManangerScript>().itemCount += 1;
                gameManager.GetComponent<Dialogue>().sceneNum = 5;
                gameManager.GetComponent<Dialogue>().d_num = 5;
            }
            Destroy(gameObject);

        }


    }
}
