using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraChange : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;
    public GameObject camera5;
    public GameObject camera6;

    void Start()
    {
        camera1.SetActive(true); 
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(false);
        camera5.SetActive(false);
        camera6.SetActive(false);


    }

    public void Camera1()
    {
        camera1.SetActive(true);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(false);
        camera5.SetActive(false);
        camera6.SetActive(false);
    }
    public void Camera2()
    {
        camera1.SetActive(false);
        camera2.SetActive(true);
        camera3.SetActive(false);
        camera4.SetActive(false);
        camera5.SetActive(false);
        camera6.SetActive(false);
    }
    public void Camera3()
    {
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(true);
        camera4.SetActive(false);
        camera5.SetActive(false);
        camera6.SetActive(false);
    }
    public void Camera4()
    {
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(true);
        camera5.SetActive(false);
        camera6.SetActive(false);
    }
    public void Camera5()
    {
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(false);
        camera5.SetActive(true);
        camera6.SetActive(false);
    }
    public void Camera6()
    {
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(false);
        camera5.SetActive(false);
        camera6.SetActive(true);
    }
    public void CloseScene()
    {
        Application.Quit();
    }

}
