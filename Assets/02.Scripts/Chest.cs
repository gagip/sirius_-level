using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject item;
    public bool isOpen;
    public bool isShowItem;
    Animator anim;
    AudioSource sound;
    private void Start()
    {
        isOpen = false;
        isShowItem = false;
        anim = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (isOpen & !isShowItem)
        {
            anim.SetTrigger("isOpen");
            sound.Play();
            StartCoroutine(CreateItem());
        }
    }

    IEnumerator CreateItem()
    {
        if (item != null)
        {
            isShowItem = true;
            GameObject inGameItem = Instantiate(item, transform.position + (Vector3.up * 1.5f), Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            if (inGameItem.GetComponent <CapsuleCollider2D>() != null)
            {
                inGameItem.GetComponent<CapsuleCollider2D>().enabled = true;
            }
            
            yield return null;
        }
        yield return null;
    }
}
