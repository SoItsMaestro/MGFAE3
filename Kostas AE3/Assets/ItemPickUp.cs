using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("AirEss") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.EssenceOfAir++;
            StaticInventory.InvStatic.InventorySpace++;
            Debug.Log("AirEss Picked Up");
        }

        if (collision.gameObject.CompareTag("DummyBolts") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.DummyBolt++;
            StaticInventory.InvStatic.InventorySpace++;
            Debug.Log("Bolts Picked Up");
        }

        if (collision.gameObject.CompareTag("EarthEss") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.EssanceOfEarth++;
            StaticInventory.InvStatic.InventorySpace++;
            Debug.Log("EarthEss Picked Up");
        }

        if (collision.gameObject.CompareTag("BoneDust") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.BoneDust++;
            StaticInventory.InvStatic.InventorySpace++;
            Debug.Log("BoneDust Picked Up");
        }

        if (collision.gameObject.CompareTag("FireEss") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.EssanceOfFire++;
            StaticInventory.InvStatic.InventorySpace++;
            Debug.Log("FireEss Picked Up");
        }

        if (collision.gameObject.CompareTag("Pie") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.GoblinPie++;
            StaticInventory.InvStatic.InventorySpace++;
            Debug.Log("Pie Picked Up");
        }

        if (collision.gameObject.CompareTag("LavaEss") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.VolcanicEssance++;
            StaticInventory.InvStatic.InventorySpace++;
            Debug.Log("LavaEss Picked Up");
        }

        if (collision.gameObject.CompareTag("MushroomHead") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.ShroomHead++;
            StaticInventory.InvStatic.InventorySpace++;
            Debug.Log("MushroomHead Picked Up");
        }

        if (collision.gameObject.CompareTag("Skull") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.Skull++;
            StaticInventory.InvStatic.InventorySpace++;
            Debug.Log("Skull Picked Up");
        }

        if (collision.gameObject.CompareTag("SpecDust") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.SpectralDust++;
            StaticInventory.InvStatic.InventorySpace++;
            Debug.Log("SpecDust Picked Up");
        }

        if (collision.gameObject.CompareTag("UndeadEss") && StaticInventory.InvStatic.InventorySpace < 8)
        {
            StaticInventory.InvStatic.EssenceOfUndeath++;
            StaticInventory.InvStatic.InventorySpace++;
            Debug.Log("UndeadEss Picked Up");
        }

    }
}
