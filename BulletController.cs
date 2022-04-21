using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float Velocidad = 10;
    private Rigidbody2D _rb;
    private CatPlayerController _Catplayer;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        _rb.velocity = new Vector2(Velocidad, _rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var tag = other.gameObject.tag;
        Debug.Log(tag);

        if (tag == "Enemy")
        {
            _Catplayer.AumentarPuntaje(10);
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }

    }
    public void SetPlayerController(CatPlayerController player)
    {
        _Catplayer = player;
    }
}
