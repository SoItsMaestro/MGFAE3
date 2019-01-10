using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public GameObject Air;
    public GameObject Bolts;
    public GameObject Earth;
    public GameObject Bone;
    public GameObject Fire;
    public GameObject Pie;
    public GameObject Lava;
    public GameObject Mushroom;
    public GameObject Skull;
    public GameObject Spec;
    public GameObject Undead;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("AirEss") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.EssenceOfAir++;
            StaticInventory.InvStatic.InventorySpace++;
            Air.gameObject.SetActive(false);
            Debug.Log("AirEss Picked Up");
            
        }

        if (collision.gameObject.CompareTag("DummyBolts") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.DummyBolt++;
            StaticInventory.InvStatic.InventorySpace++;
            Bolts.gameObject.SetActive(false);
            Debug.Log("Bolts Picked Up");
        }

        if (collision.gameObject.CompareTag("EarthEss") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.EssanceOfEarth++;
            StaticInventory.InvStatic.InventorySpace++;
            Earth.gameObject.SetActive(false);
            Debug.Log("EarthEss Picked Up");
        }

        if (collision.gameObject.CompareTag("BoneDust") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.BoneDust++;
            StaticInventory.InvStatic.InventorySpace++;
            Bone.gameObject.SetActive(false);
            Debug.Log("BoneDust Picked Up");
        }

        if (collision.gameObject.CompareTag("FireEss") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.EssanceOfFire++;
            StaticInventory.InvStatic.InventorySpace++;
            Fire.gameObject.SetActive(false);
            Debug.Log("FireEss Picked Up");
        }

        if (collision.gameObject.CompareTag("Pie") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.GoblinPie++;
            StaticInventory.InvStatic.InventorySpace++;
            Pie.gameObject.SetActive(false);
            Debug.Log("Pie Picked Up");
        }

        if (collision.gameObject.CompareTag("LavaEss") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.VolcanicEssance++;
            StaticInventory.InvStatic.InventorySpace++;
            Lava.gameObject.SetActive(false);
            Debug.Log("LavaEss Picked Up");
        }

        if (collision.gameObject.CompareTag("MushroomHead") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.ShroomHead++;
            StaticInventory.InvStatic.InventorySpace++;
            Mushroom.gameObject.SetActive(false);
            Debug.Log("MushroomHead Picked Up");
        }

        if (collision.gameObject.CompareTag("Skull") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.Skull++;
            StaticInventory.InvStatic.InventorySpace++;
            Skull.gameObject.SetActive(false);
            Debug.Log("Skull Picked Up");
        }

        if (collision.gameObject.CompareTag("SpecDust") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.SpectralDust++;
            StaticInventory.InvStatic.InventorySpace++;
            Spec.gameObject.SetActive(false);
            Debug.Log("SpecDust Picked Up");
        }

        if (collision.gameObject.CompareTag("UndeadEss") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.EssenceOfUndeath++;
            StaticInventory.InvStatic.InventorySpace++;
            Undead.gameObject.SetActive(false);
            Debug.Log("UndeadEss Picked Up");
        }

    }
}
