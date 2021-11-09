using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{

    public GameControll GC;
    public List<GameObject> balls = new List<GameObject>();
    public GameObject choosedBall;
 

    public int ballId;
    public int ballcost;
    PlayerController Pc;
    public Text playerCountUI;
    public int playerCount;

    public void Awake()
    {
        DontDestroyOnLoad(this);
        playerCountUI.text = playerCount.ToString();
    }
    // Start is called before the first frame update

    // Update is called once per frame
    public void UpdateScenesSpawnObject(GameObject obj)
    {
        choosedBall = obj;
    }

    public void chooseBallType1()
    {
        ballId = 0;
        UpdateScenesSpawnObject(balls[ballId]);
        ballcost = 3;
        playerCount-=ballcost;
        playerCountUI.text = playerCount.ToString();
        // if(Pc.Coins < ballcost)
        {
            //Debug.Log("You dont have anoug coins");
        }
       // Pc.Coins -= ballcost;
        Debug.Log("id changed");

    }
    public void chooseBallType2()
    {
        ballId = 1;
        UpdateScenesSpawnObject(balls[ballId]);
        ballcost = 5;
        playerCount -= ballcost;
        playerCountUI.text = playerCount.ToString();
        if (Pc.Coins < ballcost)
        {
            Debug.Log("You dont have anoug coins");
        }
        Pc.Coins -= ballcost;
       
    }
    public void chooseBallType3()
    {
        ballId = 2;
        UpdateScenesSpawnObject(balls[ballId]);
        ballcost = 6;
        playerCount -= ballcost;
        playerCountUI.text = playerCount.ToString();
        if (Pc.Coins < ballcost)
        {
            Debug.Log("You dont have anoug coins");
        }
        Pc.Coins -= ballcost;
        
    }
    public void chooseBallType4()
    {
        ballId = 3;
        UpdateScenesSpawnObject(balls[ballId]);
        ballcost = 7;
        playerCount -= ballcost;
        playerCountUI.text = playerCount.ToString();
        if (Pc.Coins < ballcost)
        {
            Debug.Log("You dont have anoug coins");
        }
        Pc.Coins -= ballcost;
       
    }
    public void exitShop()
    {
    }
    }
