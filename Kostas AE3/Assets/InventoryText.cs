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
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0)
        {
            StaticInventory.InvStatic.EssenceOfAir--;
        }
    }

    public void EarthDeleteFunc()
    {
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0)
        {
            StaticInventory.InvStatic.EssanceOfEarth--;
        }
    }

    public void LavaDeleteFunc()
    {
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0)
        {
            StaticInventory.InvStatic.VolcanicEssance--;
        }
    }

    public void FireDeleteFunc()
    {
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0)
        {
            StaticInventory.InvStatic.EssanceOfFire--;
        }
    }

    public void UndeadDeleteFunc()
    {
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0)
        {
            StaticInventory.InvStatic.EssenceOfUndeath--;
        }
    }

    public void BoltsDeleteFunc()
    {
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0)
        {
            StaticInventory.InvStatic.DummyBolt--;
        }
    }

    public void BoneDustDeleteFunc()
    {
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0)
        {
            StaticInventory.InvStatic.BoneDust--;
        }
    }

    public void PieDeleteFunc()
    {
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0)
        {
            StaticInventory.InvStatic.GoblinPie--;
        }
    }

    public void MushroomDeleteFunc()
    {
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0)
        {
            StaticInventory.InvStatic.ShroomHead--;
        }
    }

    public void SkullDeleteFunc()
    {
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0)
        {
            StaticInventory.InvStatic.Skull--;
        }
    }

    public void SpecDustDeleteFunc()
    {
        if (StaticInventory.InvStatic.InventorySpace <= 8 && StaticInventory.InvStatic.InventorySpace > 0)
        {
            StaticInventory.InvStatic.SpectralDust--;
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
