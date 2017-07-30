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

    public AudioSource pickScore;
    public AudioSource getHealth;
    public AudioSource loseHealth;
    public AudioSource Death;
    public AudioSource pickHealth;
    public AudioSource salto;
    public SpriteRenderer sprenderer;
    public Rigidbody2D rigidBody;
    public GameObject deathPlayer;
    public GameObject Spawnspawn;
    public GameObject DestroyPoint;
    public GameObject Changer;
    public GameObject spawnCirculo;
    public GameObject spawnMolinoI;
    public GameObject spawnMolinoD;
    public GameObject spawnRombo;
    ToolBox toolbox;
    public Color[] colors;

    void Start()
    {
        toolbox = ToolBox.Instance;
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
            decreaseSpeed += (0.05f * Time.deltaTime - toolbox.aceleracion);

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

                rigidBody.velocity = Vector2.up * jumpForce;
               
            }
            else
            {
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 3;
                start = true;
            }
        }

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "RedBattery")
        {
            hp -= 40 * Time.deltaTime;
            if (score >= 5)
            {
                score = score - 1;
                toolbox.puntuacion = score;
                Debug.Log(toolbox.puntuacion);
            }
            scoreText.GetComponent<Text>().text = "Score: " + score;
        }
        if (other.tag == "BlueBattery")
        {
            hp += 40 * Time.deltaTime;
            if (hp > 100)
            {
                hp = 100;
            }
        }
        if (other.tag == "Changer")
        {
            score = score + 10*toolbox.multiScore;
            toolbox.puntuacion = score;
            scoreText.GetComponent<Text>().text = "Score: " + score;
            Destroy(other.gameObject);
            CollisionChanger();

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
         getHealth.Stop();
         loseHealth.Stop();
        
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
            loseHealth.Play();
        }
        if (collision.tag == "BlueBattery")
        {
            getHealth.Play();
        }
        /*if (collision.tag == "Changer")
        {
            score = score + 10;
            scoreText.GetComponent<Text>().text = "Score: " + score;
            Destroy(collision.gameObject);
            CollisionChanger();

        }
        */
        if (collision.tag == "BlueDes")
        {
            if (hp < 80)
            {
                hp += 20;
            }
            else
            {
                hp = 100;
            }
            pickHealth.Play();
            Destroy(collision.gameObject);
            
        }

    }

    void killPlayer()
    {
        //deathPlayer.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
        hp = 0;
        hpBar.value = hp;
        Death.Play();
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
        pickScore.Play();
        Vector3 variable = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 8, gameObject.transform.position.z);
        Instantiate(Changer, variable, gameObject.transform.rotation);
        int random = Random.Range(0, 4);
        int random2 = Random.Range(0, 2);
        switch (random)
        {
            case 0:
                Spawnspawn.GetComponent<spawnSpawn>().condition = true;
                DestroyPoint.GetComponent<SpawnDestroy>().condition = true;
                break;
            case 1:
                spawnCirculo.GetComponent<SpawnCircle>().condition = true;
                break;
            case 2:
                
                if (random2 == 0)
                {
                    spawnMolinoI.GetComponent<spawnMolino>().condition = true;
                }
                else
                {
                    spawnMolinoD.GetComponent<spawnMolino>().condition = true;
                }
                break;
            case 3:
                spawnRombo.GetComponent<spawnRombo>().condition = true;
                break;
        }
    }
}