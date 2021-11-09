using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControll : MonoBehaviour
{
    public GameObject spawnObject;

    public GameObject startPoint;
    public GameObject scene;

    public Shop shop;
   
    private void Start()
    {

        shop = GameObject.Find("Canvas0").GetComponent<Shop>();
        spawnObject = shop.choosedBall;
        SpawnPlayer(spawnObject);
        scene = GameObject.Find("Canvas0");
        scene.SetActive(false);

    }
    public void SpawnPlayer (GameObject obj)
    {
        Instantiate(obj, startPoint.transform.position, Quaternion.identity);
    }

    public void transferCoins (int coinCount)
    {
        shop.playerCount = coinCount;
    }
}
