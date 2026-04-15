using UnityEngine;
using TMPro;

public class BrickScript : MonoBehaviour
{
    public int  hp =  1;
    public TextMeshPro hpText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hpText.text = hp.ToString();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3) {
            hp --;
            if (hp <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
