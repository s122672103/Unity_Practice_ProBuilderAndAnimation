

using UnityEngine;

public class 生成金幣 : MonoBehaviour
{

    public GameObject coin;
    public AudioSource aud;
    public AudioClip coinsound;

    private void Start()
    {
     
    }

 

    public void SpawnCoin() {

        Vector3 pos = new Vector3(0,0,0);
        Instantiate(coin,pos,Quaternion.identity);
        aud.PlayOneShot(coinsound, 1f);
    }

}
