using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class CameraManagerScript : MonoBehaviour
{
    public Camera mainCam;
    private GameObject telposGameObj1;
    private GameObject telposGameObj2;
    private GameObject telposGameObj3;
    private GameObject zoomObj;
    private GameObject backZoomBtn;
    private GameObject cameraDefaultPos1;
    private GameObject cameraDefaultPos2;
    private GameObject puzzle1;

    private void Awake()
    {
        Camera camera = GetComponent<Camera>();
        Rect rect = camera.rect;
        float scaleheight = ((float)Screen.width / Screen.height) / ((float)16 / 9);
        float scalewidth = 1f / scaleheight;
        if (scaleheight < 1)
        {
            rect.height = scaleheight;
            rect.y = (1f - scaleheight) / 2f;

        }
        else
        {
            rect.width = scalewidth;
            rect.x = (scaleheight - 1f) / 2f;
        }
        camera.rect = rect;

    }
    private void OnPreCull() => GL.Clear(true, true, Color.black);

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("Puzzle1"))
        {
            puzzle1 = GameObject.Find("Puzzle1");
            puzzle1.SetActive(false);
        }
        mainCam = Camera.main;
        telposGameObj1 = GameObject.Find("camera_ZoomPos1");
        telposGameObj2 = GameObject.Find("camera_ZoomPos2");
        zoomObj = GameObject.Find("ZoomClick");
        backZoomBtn = GameObject.Find("zoomBackBtn");
        if(backZoomBtn == null){}
        else backZoomBtn.SetActive(false);
        cameraDefaultPos1 = GameObject.Find("camera_defaultPos");
        if (GameObject.Find("CameraPosition1"))
        {
            cameraDefaultPos2 = GameObject.Find("CameraPosition1");
            telposGameObj3 = GameObject.Find("camera_ZoomPos3");
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                //Debug.Log(hit.transform.gameObject);
                if (hit.transform.gameObject.tag=="telpos")
                {
                    if (hit.transform.GetSiblingIndex() == 0)
                    {
                        mainCam.gameObject.transform.position = telposGameObj1.transform.position;
                        mainCam.gameObject.transform.rotation = telposGameObj1.transform.rotation;
                    }
                    else if(hit.transform.GetSiblingIndex() == 1)
                    {
                        mainCam.gameObject.transform.position = telposGameObj2.transform.position;
                        mainCam.gameObject.transform.rotation = telposGameObj2.transform.rotation;
                        if(puzzle1) puzzle1.SetActive(true);
                    }
                    else if (hit.transform.GetSiblingIndex() == 2)
                    {
                        mainCam.gameObject.transform.position = telposGameObj3.transform.position;
                        mainCam.gameObject.transform.rotation = telposGameObj3.transform.rotation;
                        cameraDefaultPos1 = cameraDefaultPos2;
                    }
                    backZoomBtn.SetActive(true);
                    zoomObj.SetActive(false);
                    
                    Debug.Log("¼º°ø");

                }
            }
        }
    }
    public void zoomBackBtn()
    {
        zoomObj.SetActive(true);
        backZoomBtn.SetActive(false);
        mainCam.gameObject.transform.position = cameraDefaultPos1.transform.position;
        mainCam.gameObject.transform.rotation = cameraDefaultPos1.transform.rotation;

    }
}
