using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] private cardCreator cardCreator;
    [SerializeField] private GameObject back;
    [SerializeField] private GameObject frame;
    [SerializeField] private GameObject art;
    private int _id;

    // Start is called before the first frame update
    void Start()
    {
        //Vector3 startPos = this.transform.position;

        //setting up the card assets for layered appearance
        //back.transform.position = new Vector3(startPos.x, startPos.Y, (startPos.z - 10));
        //frame.transform.position = new Vector3(startPos.x, startPos.Y, (startPos.z - 1));
        //art.transform.position = new Vector3(startPos.x, startPos.Y, startPos.z);
    }

    public int id
    {
        get { return _id; }
    }

    public void setCardBack(Sprite image)
    {
        back.GetComponent<SpriteRenderer>().sprite = image;
        //back.SetActive(false);
    }

    public void setCardFrame(int id, Sprite image)
    {
        _id = id;
        frame.GetComponent<SpriteRenderer>().sprite = image;
    }

    public void setCardArt(int id, Sprite image)
    {
        _id = id;
        art.GetComponent<SpriteRenderer>().sprite = image;
    }

    
    public void OnMouseDown()
    {
        if (back.activeSelf)
        {
            back.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
