using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public string currentColor;
    public float jumpForce = 10f;

    private bool start;


    //variables para el control de la hp bar y la hp
    public float hp = 100f;
    public float maxHP = 100f;
    public float minHP = 0f;
    public Slider hpBar;
    private float decreaseSpeed = 1f;
    private GameObject percentText;
    private GameObject scoreText;
    private int score;

    public SpriteRenderer sprenderer;
    public Rigidbody2D rigidBody;
    public GameObject deathPlayer;
    public GameObject Spawnspawn;
    public GameObject DestroyPoint;
    public GameObject Changer;

    public Color[] colors;

    void Start()
    {
        score = 0;
        percentText = GameObject.Find("Percent");
        scoreText = GameObject.Find("Score");

        percentText.GetComponent<Text>().text = hp.ToString() + "%";
        scoreText.GetComponent<Text>().text = "Score: " + score;

        hpBar.value = hp;
        start = false;
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
        /*  ---ALTERNATE WAY OF DEFINING COLORS PRIVATELY
        colors = new Color[4];
        colors[0] = new Color(255, 255, 255);
        colors[1] = new Color(255, 0, 0);
        colors[2] = new Color(0, 255, 0);
        colors[3] = new Color(0, 0, 255);
        */
        //setRandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        //comenzamos a perder energia cuando empieza el juego
        if (start) { 
            hp = hp - (decreaseSpeed * Time.deltaTime);
            decreaseSpeed += (1f * Time.deltaTime);

            hpBar.value = hp;
            percentText.GetComponent<Text>().text = hp.ToString("#") + "%";

            if (hp <= 0)
            {
                killPlayer();
            }
        }
        if (Camera.main.gameObject.transform.position.y - gameObject.transform.position.y > Camera.main.gameObject.GetComponent<Camera>().orthographicSize)
        {
            killPlayer();
        }
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            //al empezar se pone la gravedad a 0 hasta la primera ejecucion del update donde se pone su valor normal
            //esto evita que pasen cosas raras al empezar
            if (start)
            {
                rigidBody.velocity = Vector2.up * jumpForce * Time.deltaTime;
            }
            else
            {
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 3;
                start = true;
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if (collision.tag == "Changer")
        {
            setRandomColor();
            Destroy(collision.gameObject);
            return;
        }

        if (collision.tag!=currentColor)
        {
            killPlayer();
        }*/
        if (collision.tag == "RedBattery")
        {
            hp -= 20;
            if (score >= 5)
            {
                score = score - 5;
            }
            scoreText.GetComponent<Text>().text = "Score: " + score;
        }
        if (collision.tag == "BlueBattery")
        {
            hp += 20;
        }
        if (collision.tag == "Changer")
        {
            score = score + 10;
            scoreText.GetComponent<Text>().text = "Score: " + score;
            Destroy(collision.gameObject);
            CollisionChanger();

        }

    }

    void killPlayer()
    {
        //deathPlayer.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
        hp = 0;
        hpBar.value = hp;
        percentText.GetComponent<Text>().text =  "0%";
        Instantiate(deathPlayer, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    void setRandomColor()
    {
        int index = Random.Range(0, 4); //random number used for assigning a color to the player
        sprenderer.color = colors[index];
      
        switch (index)
        {
            case 0:
                this.currentColor = "Cyan";
                break;
            case 1:
                this.currentColor = "Yellow";
                break;
            case 2:
                this.currentColor = "Magenta";
                break;
            case 3:
                this.currentColor = "Purple";
                break;
            default:
                break;
        }
    }
    void CollisionChanger()
    {
        Debug.Log("asañlkjdf");
        Vector3 variable = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 6, gameObject.transform.position.z);
        Instantiate(Changer, variable, gameObject.transform.rotation);
        Spawnspawn.GetComponent<spawnSpawn>().condition = true;
        Debug.Log(Spawnspawn.GetComponent<spawnSpawn>().condition);
        DestroyPoint.GetComponent<SpawnDestroy>().condition = true;
    }
}