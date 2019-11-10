using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // 쉴드
    PlayerControl player;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerControl>();
    }

    public IEnumerator Shield()
    {
        // 무적시간
        player.shield = true;
        player.shieldObject.SetActive(true);
        player.gameObject.layer = 11;
        yield return new WaitForSeconds(time);

        player.shield = false;
        player.shieldObject.SetActive(false);
        player.gameObject.layer = 10;
        yield return null;
        
    }
}
