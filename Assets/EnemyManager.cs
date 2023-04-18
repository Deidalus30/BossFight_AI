using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    public Image hpBar;
    public float maxHP;
    public float curHP;
    public int MAttkCounter;

    public ParticleSystem MeleeBoom;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hpBar.fillAmount = curHP / maxHP;
    }

    public void MExplosion()
    {
        MeleeBoom.Play();
    }

    public void MeleeAttackCounter()
    {
        MAttkCounter++;
    }
}
