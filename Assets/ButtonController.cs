using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonController : MonoBehaviour
{
    public void GoToScene1()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void GoToScene2()
    {
        SceneManager.LoadScene("Level_2");
    }
    public void GoToScene3()
    {
        SceneManager.LoadScene("Level_3");
    }
}
