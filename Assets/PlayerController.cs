    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float speed = 800.0f;
    //public bool canFly=false;
    public int Coins =0;
    public Text CoinsUI;
    public Text TotalScore;
    public Vector3 DirectionVector;
    float moveHorizontal;
    float moveVertical;

    
    public GameObject dialogPanel;
    public GameObject GCer;
  
    public GameObject TeleportTarget;
    public ParticleSystem particles;

    public GameControll GC;
    //public PlayerJump PJ;

    public GameObject scene;
    public GameObject TextOut;
    public Text TextOutput;

    public void Awake()
    {
        DontDestroyOnLoad(this);
    }
    private void Start()
    {
        dialogPanel.SetActive(false);
        GCer = GameObject.Find("GameController");
        GC = GCer.GetComponent<GameControll>();
        //PJ = GetComponent<PlayerJump>();


    }
    void FixedUpdate()
    {
       
        Transform cTransform = GameObject.Find("Camera").transform;
        Vector3 movement = new Vector3(0f, 0.0f, 0f);
        if (Input.GetKey( "w"))
        {
            movement = cTransform.forward;
        }
        if (Input.GetKey("s"))
        {
            movement = -cTransform.forward;
        }
        if (Input.GetKey("a"))
        {
            movement = -cTransform.right;
        }
        if (Input.GetKey("d"))
        {
            movement = cTransform.right;
        }
        if (Input.GetKey("x"))
        {
            SceneManager.LoadScene("EndScene", LoadSceneMode.Additive);
        }
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");


        //Debug.Log("Transit"+ DirectionVector);
        GetComponent<Rigidbody>().AddForce(movement* speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Debug.Log("Coin collide");
            Destroy(collision.gameObject, 0.1f);
            Coins += 1;
            TextOut = GameObject.FindGameObjectWithTag("CountUi");
            TextOutput = TextOut.GetComponent<Text>();
            TextOutput.text = Coins.ToString();
        }
        if (collision.gameObject.tag == "Goal" && Coins >= 2)
        {
            scene = GameObject.Find("Canvas0");
            //scene.SetActive(true);
            SceneManager.LoadScene("EndScene", LoadSceneMode.Additive);
     
        }
        if(collision.gameObject.tag == "Goal" && Coins < 3)
        {
         
            dialogPanel.SetActive(true);
            StartCoroutine(CloseWindow());
            Debug.Log("Not enough coins");
        }

        if (collision.gameObject.tag == "sharpObstacle")
        {
           // Destroy(gameObject);
            SceneManager.LoadScene("SampleScene");
        }
        if (collision.gameObject.tag == "teleport")
        {
            
            particles.Play();
            transform.position = TeleportTarget.transform.position;
        }

        //if (collision.gameObject.tag == "flyactivator")
        //{
        //    PJ.flyMode = true;
        //    canFly = true;
        //}
    }
    public IEnumerator CloseWindow ()
    {
        yield return new WaitForSeconds(5);
        dialogPanel.SetActive(false);
    }
    
}
