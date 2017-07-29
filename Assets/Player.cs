using UnityEngine;

public class Player : MonoBehaviour
{

    public string currentColor;
    public float jumpForce = 10f;

    public SpriteRenderer sprenderer;
    public Rigidbody2D rigidBody;
    public GameObject deathPlayer;

    public Color[] colors;

    void Start()
    {
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
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rigidBody.velocity = Vector2.up * jumpForce * Time.deltaTime;
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
            deathPlayer.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
            Instantiate(deathPlayer, transform.position, transform.rotation);
            Destroy(gameObject);

        }

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