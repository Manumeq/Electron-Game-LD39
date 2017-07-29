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

    public SpriteRenderer sprenderer;
    public Rigidbody2D rigidBody;
    public GameObject deathPlayer;

    public Color[] colors;

    void Start()
    {
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
        setRandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        //comenzamos a perder energia cuando empieza el juego
        if (start) { 
            hp = hp - (decreaseSpeed * Time.deltaTime);
            decreaseSpeed += (1f * Time.deltaTime);

            hpBar.value = hp;
            if (hp <= 0)
            {
                killPlayer();
            }
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
        if (collision.tag == "Changer")
        {
            setRandomColor();
            Destroy(collision.gameObject);
            return;
        }

        if (collision.tag!=currentColor)
        {
            killPlayer();
        }

    }

    void killPlayer()
    {
        //deathPlayer.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
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
}