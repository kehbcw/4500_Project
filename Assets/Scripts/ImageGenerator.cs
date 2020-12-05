using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageGenerator : MonoBehaviour
{
    public Sprite[] images;
    public Image randomImage;
    // Start is called before the first frame update
    void Start()
    {
        images = new Sprite[98];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void generateImage()
    {
        int num;
        //if(level difficulty == 1)
        //{
        // num = UnityEngine.Random.Range(65, images.Length);
        // }else if (level difficult == 2)
        //{
        // num = UnityEngine.Random.Range(32, 66);
        //}else 
        //num = UnityEngine.Random.Range(0, 32);
        num = UnityEngine.Random.Range(0, images.Length);
        randomImage.sprite = images[num];
    }
}
