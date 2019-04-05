using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.Monetization;

public class playercontrolscript : MonoBehaviour
{
    private string rewardedvideo_ad = "rewardedVideo";
    private string storeid = "3105488";


    public Rigidbody2D rb2d;
    private float movementx;
    public float movespeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        Monetization.Initialize(storeid, true);

    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    private void movement()
    {
        movementx = Input.acceleration.x * movespeed;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -8f, 8f), transform.position.y);
    }
    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(movementx, 0f);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "icicle")
        {
            ShowAdPlacementContent ad = null;
            ad = Monetization.GetPlacementContent(rewardedvideo_ad) as ShowAdPlacementContent;
            if (ad != null)
            {
                ad.Show();
            }
            
        }
    }
}
