using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyDrops : MonoBehaviour
{
    private Enemy Health;
    public GameObject DummyDrop;
    public GameObject Air;
    public GameObject Earth;
    public GameObject BoneDust;
    public GameObject Fire;
    public GameObject GoblinPie;
    public GameObject Lava;
    public GameObject Mushroom;
    public GameObject Skull;
    public GameObject Dust;
    public GameObject Death;
    public GameObject Gold;

    int DummyBolt;
    int EssAir;
    int EssEarth;
    int BDust;
    int EssFire;
    int Goblin;
    int EssLavet;
    int MushroomHead;
    int SSkull;
    int OtherDust;
    int DieBoi;
    int GoldBoi;

    private string Name;
    private void Start()
    {
        Name = GetComponent<Enemy>().EnemyName;

        DummyBolt = Random.Range(0, 100);
        EssAir = Random.Range(0, 100);
        EssEarth = Random.Range(0, 100);
        BDust = Random.Range(0, 100);
        EssFire = Random.Range(0, 100);
        Goblin = Random.Range(0, 100);
        EssLavet = Random.Range(0, 100);
        MushroomHead = Random.Range(0, 100);
        SSkull = Random.Range(0, 100);
        OtherDust = Random.Range(0, 100);
        DieBoi = Random.Range(0, 100);
        GoldBoi = Random.Range(0, 100);
    }
    void Update()
    {
        switch(Name)
        {
            case "Dummy":
                {
                    if (DummyBolt >= 0 && DummyBolt <= 25)
                    {
                        Instantiate(DummyDrop);
                    }
                    break;
                }
            case "Goblin":
                {
                    if (Goblin >= 0 && Goblin <= 20)
                    {
                        Instantiate(GoblinPie);
                    }
                    break;
                }
            case "CloudBoi":
                {
                    if (EssAir >= 0 && EssAir <= 60)
                    {
                        Instantiate(GoblinPie);
                    }
                    break;
                }
            case "Flame":
                {
                    if (EssFire >= 0 && EssFire <= 50)
                    {
                        Instantiate(GoblinPie);
                    }
                    break;
                }
            case "BoneyBoi":
                {
                    if (DieBoi >= 0 && DieBoi <= 30)
                    {
                        Instantiate(GoblinPie);
                    }
                    if (BDust >= 0 && BDust <= 60)
                    {
                        Instantiate(GoblinPie);
                    }
                    if (SSkull >= 0 && SSkull <= 70)
                    {
                        Instantiate(GoblinPie);
                    }
                    break;
                }
            case "Ghost":
                {
                    if (DieBoi >= 0 && DieBoi <= 30)
                    {
                        Instantiate(GoblinPie);
                    }
                    if (OtherDust >= 0 && OtherDust <= 20)
                    {
                        Instantiate(GoblinPie);
                    }
                    break;
                }
            case "BouncyBoi":
                {
                    if (EssLavet >= 0 && EssLavet <= 60)
                    {
                        Instantiate(GoblinPie);
                    }
                    break;
                }
            case "RockBoi":
                {
                    if (EssEarth >= 0 && EssEarth <= 40)
                    {
                        Instantiate(GoblinPie);
                    }
                    break;
                }
            case "Shrooooms":
                {
                    if (MushroomHead >= 0 && MushroomHead <= 85)
                    {
                        Instantiate(GoblinPie);
                    }
                    break;
                }
        }

               
    }
}
