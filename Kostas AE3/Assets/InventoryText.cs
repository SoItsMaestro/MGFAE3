using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryText : MonoBehaviour {

    public Text AirEssText;
    public Text EarthEssText;
    public Text LavaEssText;
    public Text FireEssText;
    public Text UndeathEssText;
    public Text BoltsText;
    public Text BoneDustText;
    public Text GoblinPieText;
    public Text MushroomHeadText;
    public Text SkullText;
    public Text SpecDustText;
    public Text InventorySpaceText;

    public Button AirDelete;
    public Button EarthDelete;
    public Button LavaDelete;
    public Button FireDelete;
    public Button UndeadDelete;
    public Button BoltsDelete;
    public Button BoneDustDelete;
    public Button PieDelete;
    public Button MushroomDelete;
    public Button SkullDelete;
    public Button SpecDustDelete;



    void Start()
    {
        AirDelete.onClick.AddListener(AirDeleteFunc);
        EarthDelete.onClick.AddListener(EarthDeleteFunc);
        LavaDelete.onClick.AddListener(LavaDeleteFunc);
        FireDelete.onClick.AddListener(FireDeleteFunc);
        UndeadDelete.onClick.AddListener(UndeadDeleteFunc);
        BoltsDelete.onClick.AddListener(BoltsDeleteFunc);
        BoneDustDelete.onClick.AddListener(BoneDustDeleteFunc);
        PieDelete.onClick.AddListener(PieDeleteFunc);
        MushroomDelete.onClick.AddListener(MushroomDeleteFunc);
        SkullDelete.onClick.AddListener(SkullDeleteFunc);
        SpecDustDelete.onClick.AddListener(SpecDustDeleteFunc);
    }


    public void AirDeleteFunc()
    {
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0 && StaticInventory.InvStatic.EssenceOfAir >0)
        {
            StaticInventory.InvStatic.EssenceOfAir--;
            StaticInventory.InvStatic.InventorySpace--;
        }
    }

    public void EarthDeleteFunc()
    {
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0 && StaticInventory.InvStatic.EssanceOfEarth >0)
        {
            StaticInventory.InvStatic.EssanceOfEarth--;
            StaticInventory.InvStatic.InventorySpace--;
        }
    }

    public void LavaDeleteFunc()
    {
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0 && StaticInventory.InvStatic.VolcanicEssance >0)
        {
            StaticInventory.InvStatic.VolcanicEssance--;
            StaticInventory.InvStatic.InventorySpace--;
        }
    }

    public void FireDeleteFunc()
    {
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0 && StaticInventory.InvStatic.EssanceOfFire >0)
        {
            StaticInventory.InvStatic.EssanceOfFire--;
            StaticInventory.InvStatic.InventorySpace--;
        }
    }

    public void UndeadDeleteFunc()
    {
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0 && StaticInventory.InvStatic.EssenceOfUndeath >0)
        {
            StaticInventory.InvStatic.EssenceOfUndeath--;
            StaticInventory.InvStatic.InventorySpace--;
        }
    }

    public void BoltsDeleteFunc()
    {
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0 && StaticInventory.InvStatic.DummyBolt >0)
        {
            StaticInventory.InvStatic.DummyBolt--;
            StaticInventory.InvStatic.InventorySpace--;
        }
    }

    public void BoneDustDeleteFunc()
    {
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0 && StaticInventory.InvStatic.BoneDust >0)
        {
            StaticInventory.InvStatic.BoneDust--;
            StaticInventory.InvStatic.InventorySpace--;
        }
    }

    public void PieDeleteFunc()
    {
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0 && StaticInventory.InvStatic.GoblinPie >0)
        {
            StaticInventory.InvStatic.GoblinPie--;
            StaticInventory.InvStatic.InventorySpace--;
        }
    }

    public void MushroomDeleteFunc()
    {
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0 && StaticInventory.InvStatic.ShroomHead >0)
        {
            StaticInventory.InvStatic.ShroomHead--;
            StaticInventory.InvStatic.InventorySpace--;
        }
    }

    public void SkullDeleteFunc()
    {
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0 && StaticInventory.InvStatic.Skull >0)
        {
            StaticInventory.InvStatic.Skull--;
            StaticInventory.InvStatic.InventorySpace--;
        }
    }

    public void SpecDustDeleteFunc()
    {
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0 && StaticInventory.InvStatic.SpectralDust >0)
        {
            StaticInventory.InvStatic.SpectralDust--;
            StaticInventory.InvStatic.InventorySpace--;
        }
    }


    // Update is called once per frame
    void Update () {

        AirEssText.text = "Air Essence: " + StaticInventory.InvStatic.EssenceOfAir.ToString();
        EarthEssText.text = "Earth Essence: " + StaticInventory.InvStatic.EssanceOfEarth.ToString();
        LavaEssText.text = "Lava Essence: " + StaticInventory.InvStatic.VolcanicEssance.ToString();
        FireEssText.text = "Fire Essence: " + StaticInventory.InvStatic.EssanceOfFire.ToString();
        UndeathEssText.text = "Undeath Essence: " + StaticInventory.InvStatic.EssenceOfUndeath.ToString();
        BoltsText.text = "Dummy Bolts: " + StaticInventory.InvStatic.DummyBolt.ToString();
        BoneDustText.text = "Bone Dust: " + StaticInventory.InvStatic.BoneDust.ToString();
        GoblinPieText.text = "Goblin Pie: " + StaticInventory.InvStatic.GoblinPie.ToString();
        MushroomHeadText.text = "Mushroom Head: " + StaticInventory.InvStatic.ShroomHead.ToString();
        SkullText.text = "Skulls: " + StaticInventory.InvStatic.Skull.ToString();
        SpecDustText.text = "Spectral Dust: " + StaticInventory.InvStatic.SpectralDust.ToString();
        InventorySpaceText.text = "Inventory Space: " + StaticInventory.InvStatic.InventorySpace.ToString() + "/8";


	}
}
