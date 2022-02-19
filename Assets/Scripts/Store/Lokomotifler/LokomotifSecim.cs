using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LokomotifSecim : MonoBehaviour
{
    public GameObject store;
    public GameObject lokomotifStore;

    public GameObject classicLokomotif;
    public GameObject classicLokomotifCanvas;
    public GameObject classicSec;

    public GameObject hyrbidLokomotif;
    public GameObject hyrbidLokomotifCanvas;
    public GameObject hybridKilitAc;
    public GameObject hybridSec;
    public GameObject hybridKilit;
    public GameObject hybridUcret;
    public TextMeshProUGUI hybridUcretText;
    public bool hybridAlınabilir_mi = false;

    public GameObject exclusiveLokomotif;
    public GameObject exclusiveLokomotifCanvas;
    public GameObject exclusiveKilitAc;
    public GameObject exclusiveSec;
    public GameObject exclusiveKilit;
    public GameObject exclusiveUcret;
    public TextMeshProUGUI exclusiveUcretText;
    public bool exclusiveAlınabilir_mi = false;

    public GameObject capsuleLokomotif;
    public GameObject capsuleLokomotifCanvas;
    public GameObject capsuleKilitAc;
    public GameObject capsuleSec;
    public GameObject capsuleKilit;
    public GameObject capsuleUcret;
    public TextMeshProUGUI capsuleUcretText;
    public bool capsuleAlınabilir_mi = false;

    public GameObject kf2500Lokomotif;
    public GameObject kf2500LokomotifCanvas;
    public GameObject kf2500KilitAc;
    public GameObject kf2500Sec;
    public GameObject kf2500Kilit;
    public GameObject kf2500Ucret;
    public TextMeshProUGUI kf2500UcretText;
    public bool kf2500Alınabilir_mi = false;

    public GameObject tramLokomotif;
    public GameObject tramLokomotifCanvas;
    public GameObject tramKilitAc;
    public GameObject tramSec;
    public GameObject tramKilit;
    public GameObject tramUcret;
    public TextMeshProUGUI tramUcretText;
    public bool tramAlınabilir_mi = false;

    public GameObject tankLokomotif;
    public GameObject tankLokomotifCanvas;
    public GameObject tankKilitAc;
    public GameObject tankSec;
    public GameObject tankKilit;
    public GameObject tankUcret;
    public TextMeshProUGUI tankUcretText;
    public bool tankAlınabilir_mi = false;

    public GameObject spaceLokomotif;
    public GameObject spaceLokomotifCanvas;
    public GameObject spaceKilitAc;
    public GameObject spaceSec;
    public GameObject spaceKilit;
    public GameObject spaceUcret;
    public TextMeshProUGUI spaceUcretText;
    public bool spaceAlınabilir_mi = false;

    public GameObject toyLokomotif;
    public GameObject toyLokomotifCanvas;
    public GameObject toyKilitAc;
    public GameObject toySec;
    public GameObject toyKilit;
    public GameObject toyUcret;
    public TextMeshProUGUI toyUcretText;
    public bool toyAlınabilir_mi = false;

    int count = 0;
    public TextMeshProUGUI skor;

    public GameObject classicToggle;
    public GameObject hybridToggle;
    public GameObject exclusiveToggle;
    public GameObject capsuleToggle;
    public GameObject kf2500Toggle;
    public GameObject tramToggle;
    public GameObject tankToggle;
    public GameObject spaceToggle;
    public GameObject toyToggle;


    void Start()
    {
        if (PlayerPrefs.GetString("lokomotive") != "classic" && PlayerPrefs.GetString("lokomotive") != "hybrid" && PlayerPrefs.GetString("lokomotive") != "exclusive" && PlayerPrefs.GetString("lokomotive") != "capsule" && PlayerPrefs.GetString("lokomotive") != "kf2500" && PlayerPrefs.GetString("lokomotive") != "tram" && PlayerPrefs.GetString("lokomotive") != "tank" && PlayerPrefs.GetString("lokomotive") != "space" && PlayerPrefs.GetString("lokomotive") != "toy")
        {
            PlayerPrefs.SetString("lokomotive", "classic");
        }

        if (PlayerPrefs.GetString("lokomotive") == "classic")
        {
            count = 0;
        }
        else if (PlayerPrefs.GetString("lokomotive") == "hybrid")
        {
            count = 1;
        }
        else if (PlayerPrefs.GetString("lokomotive") == "exclusive")
        {
            count = 2;
        }
        else if (PlayerPrefs.GetString("lokomotive") == "capsule")
        {
            count = 3;
        }
        else if (PlayerPrefs.GetString("lokomotive") == "kf2500")
        {
            count = 4;
        }
        else if (PlayerPrefs.GetString("lokomotive") == "tram")
        {
            count = 5;
        }
        else if (PlayerPrefs.GetString("lokomotive") == "tank")
        {
            count = 6;
        }
        else if (PlayerPrefs.GetString("lokomotive") == "space")
        {
            count = 7;
        }
        else if (PlayerPrefs.GetString("lokomotive") == "toy")
        {
            count = 8;
        }
    }

    public void Update()
    {
        skor.text = "" + PlayerPrefs.GetFloat("ticket");

        ToggleChoose();

        if (count == 0)
        {
            ClassicAcık();

            HybridKapalı();

            ExclusiveKapalı();

            CapsuleKapalı();

            Kf2500Kapalı();

            TramKapalı();

            TankKapalı();

            SpaceKapalı();

            ToyKapalı();
        }
        else if (count == 1)
        {
            ClassicKapalı();

            HybridAcık();

            ExclusiveKapalı();

            CapsuleKapalı();

            Kf2500Kapalı();

            TramKapalı();

            TankKapalı();

            SpaceKapalı();

            ToyKapalı();

        }
        else if (count == 2)
        {
            ClassicKapalı();

            HybridKapalı();

            ExclusiveAcık();

            CapsuleKapalı();

            Kf2500Kapalı();

            TramKapalı();

            TankKapalı();

            SpaceKapalı();

            ToyKapalı();
        }
        else if (count == 3)
        {
            ClassicKapalı();

            HybridKapalı();

            ExclusiveKapalı();

            CapsuleAcık();

            Kf2500Kapalı();

            TramKapalı();

            TankKapalı();

            SpaceKapalı();

            ToyKapalı();
        }
        else if (count == 4)
        {
            ClassicKapalı();

            HybridKapalı();

            ExclusiveKapalı();

            CapsuleKapalı();

            Kf2500Acık();

            TramKapalı();

            TankKapalı();

            SpaceKapalı();

            ToyKapalı();
        }
        else if (count == 5)
        {
            ClassicKapalı();

            HybridKapalı();

            ExclusiveKapalı();

            CapsuleKapalı();

            Kf2500Kapalı();

            TramAcık();

            TankKapalı();

            SpaceKapalı();

            ToyKapalı();
        }
        else if (count == 6)
        {
            ClassicKapalı();

            HybridKapalı();

            ExclusiveKapalı();

            CapsuleKapalı();

            Kf2500Kapalı();

            TramKapalı();

            TankAcık();

            SpaceKapalı();

            ToyKapalı();
        }
        else if (count == 7)
        {
            ClassicKapalı();

            HybridKapalı();

            ExclusiveKapalı();

            CapsuleKapalı();

            Kf2500Kapalı();

            TramKapalı();

            TankKapalı();

            SpaceAcık();

            ToyKapalı();
        }
        else if (count == 8)
        {
            ClassicKapalı();

            HybridKapalı();

            ExclusiveKapalı();

            CapsuleKapalı();

            Kf2500Kapalı();

            TramKapalı();

            TankKapalı();

            SpaceKapalı();

            ToyAcık();
        }
        else if (count == 9)
        {
            count = 0;
        }
        else if (count == -1)
        {
            ClassicKapalı();

            HybridKapalı();

            ExclusiveKapalı();

            CapsuleKapalı();

            Kf2500Kapalı();

            TramKapalı();

            TankKapalı();

            SpaceKapalı();

            ToyAcık();
        }
        else if (count == -2)
        {
            ClassicKapalı();

            HybridKapalı();

            ExclusiveKapalı();

            CapsuleKapalı();

            Kf2500Kapalı();

            TramKapalı();

            TankKapalı();

            SpaceAcık();

            ToyKapalı();

        }
        else if (count == -3)
        {
            ClassicKapalı();

            HybridKapalı();

            ExclusiveKapalı();

            CapsuleKapalı();

            Kf2500Kapalı();

            TramKapalı();

            TankAcık();

            SpaceKapalı();

            ToyKapalı();
        }
        else if (count == -4)
        {
            ClassicKapalı();

            HybridKapalı();

            ExclusiveKapalı();

            CapsuleKapalı();

            Kf2500Kapalı();

            TramAcık();

            TankKapalı();

            SpaceKapalı();

            ToyKapalı();
        }
        else if (count == -5)
        {
            ClassicKapalı();

            HybridKapalı();

            ExclusiveKapalı();

            CapsuleKapalı();

            Kf2500Acık();

            TramKapalı();

            TankKapalı();

            SpaceKapalı();

            ToyKapalı();
        }
        else if (count == -6)
        {
            ClassicKapalı();

            HybridKapalı();

            ExclusiveKapalı();

            CapsuleAcık();

            Kf2500Kapalı();

            TramKapalı();

            TankKapalı();

            SpaceKapalı();

            ToyKapalı();
        }
        else if (count == -7)
        {
            ClassicKapalı();

            HybridKapalı();

            ExclusiveAcık();

            CapsuleKapalı();

            Kf2500Kapalı();

            TramKapalı();

            TankKapalı();

            SpaceKapalı();

            ToyKapalı();
        }
        else if (count == -8)
        {
            ClassicKapalı();

            HybridAcık();

            ExclusiveKapalı();

            CapsuleKapalı();

            Kf2500Kapalı();

            TramKapalı();

            TankKapalı();

            SpaceKapalı();

            ToyKapalı();
        }
        else if (count == -9)
        {
            count = 0;
        }
    }

    public void ClassicLokomotiveButton()
    {
        PlayerPrefs.SetString("lokomotive", "classic");
    }
    public void HyrbidLokomotiveButton()
    {
        PlayerPrefs.SetString("lokomotive", "hybrid");
    }
    public void ExclusiveLokomotiveButton()
    {
        PlayerPrefs.SetString("lokomotive", "exclusive");
    }
    public void CapsuleLokomotiveButton()
    {
        PlayerPrefs.SetString("lokomotive", "capsule");
    }
    public void KF2500LokomotiveButton()
    {
        PlayerPrefs.SetString("lokomotive", "kf2500");
    }
    public void TramLokomotiveButton()
    {
        PlayerPrefs.SetString("lokomotive", "tram");
    }
    public void TankLokomotiveButton()
    {
        PlayerPrefs.SetString("lokomotive", "tank");
    }
    public void SpaceLokomotiveButton()
    {
        PlayerPrefs.SetString("lokomotive", "space");
    }
    public void ToyLokomotiveButton()
    {
        PlayerPrefs.SetString("lokomotive", "toy");
    }

    public void HyrbidLokomotiveBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 5000)
        {
            hybridAlınabilir_mi = true;
            PlayerPrefs.SetString("hybridAlınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 5000);
        }
    }
    public void ExclusiveLokomotiveBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 50000)
        {
            exclusiveAlınabilir_mi = true;
            PlayerPrefs.SetString("exclusiveAlınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 50000);
        }
    }
    public void CapsuleLokomotiveBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 120000)
        {
            capsuleAlınabilir_mi = true;
            PlayerPrefs.SetString("capsuleAlınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 120000);
        }
    }
    public void KF2500LokomotiveBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 200000)
        {
            kf2500Alınabilir_mi = true;
            PlayerPrefs.SetString("kf2500Alınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 200000);
        }
    }
    public void TramLokomotiveBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 220000)
        {
            tramAlınabilir_mi = true;
            PlayerPrefs.SetString("tramAlınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 220000);
        }
    }
    public void TankLokomotiveBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 280000)
        {
            tankAlınabilir_mi = true;
            PlayerPrefs.SetString("tankAlınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 280000);
        }
    }
    public void SpaceLokomotiveBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 400000)
        {
            spaceAlınabilir_mi = true;
            PlayerPrefs.SetString("spaceAlınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 400000);
        }
    }
    public void ToyLokomotiveBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 1000000)
        {
            toyAlınabilir_mi = true;
            PlayerPrefs.SetString("toyAlınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 1000000);
        }
    }

    public void ClassicAcık()
    {
        classicLokomotif.SetActive(true);
        classicLokomotifCanvas.SetActive(true);
        classicSec.SetActive(true);
    }
    public void ClassicKapalı()
    {
        classicLokomotif.SetActive(false);
        classicLokomotifCanvas.SetActive(false);
        classicSec.SetActive(false);
    }

    public void HybridAcık()
    {
        hyrbidLokomotif.SetActive(true);
        hyrbidLokomotifCanvas.SetActive(true);
        if (PlayerPrefs.GetString("hybridAlınabilir_mi") != "true")
        {
            hybridKilitAc.SetActive(true);
            hybridSec.SetActive(false);
            hybridKilit.SetActive(true);
            hybridUcret.SetActive(true);
            hybridUcretText.text = "";
        }
        else
        {
            hybridKilitAc.SetActive(false);
            hybridSec.SetActive(true);
            hybridKilit.SetActive(false);
            hybridUcret.SetActive(false);
            hybridUcretText.text = "";
        }
    }
    public void HybridKapalı()
    {
        hyrbidLokomotif.SetActive(false);
        hyrbidLokomotifCanvas.SetActive(false);
        hybridKilitAc.SetActive(false);
        hybridSec.SetActive(false);
        hybridKilit.SetActive(false);
        hybridUcret.SetActive(false);
        hybridUcretText.text = "";
    }

    public void ExclusiveAcık()
    {
        exclusiveLokomotif.SetActive(true);
        exclusiveLokomotifCanvas.SetActive(true);
        if (PlayerPrefs.GetString("exclusiveAlınabilir_mi") != "true")
        {
            exclusiveKilitAc.SetActive(true);
            exclusiveSec.SetActive(false);
            exclusiveKilit.SetActive(true);
            exclusiveUcret.SetActive(true);
            exclusiveUcretText.text = "";
        }
        else
        {
            exclusiveKilitAc.SetActive(false);
            exclusiveSec.SetActive(true);
            exclusiveKilit.SetActive(false);
            exclusiveUcret.SetActive(false);
            exclusiveUcretText.text = "";
        }
    }
    public void ExclusiveKapalı()
    {
        exclusiveLokomotif.SetActive(false);
        exclusiveLokomotifCanvas.SetActive(false);
        exclusiveKilitAc.SetActive(false);
        exclusiveSec.SetActive(false);
        exclusiveKilit.SetActive(false);
        exclusiveUcret.SetActive(false);
        exclusiveUcretText.text = "";
    }

    public void CapsuleAcık()
    {
        capsuleLokomotif.SetActive(true);
        capsuleLokomotifCanvas.SetActive(true);
        if (PlayerPrefs.GetString("capsuleAlınabilir_mi") != "true")
        {
            capsuleKilitAc.SetActive(true);
            capsuleSec.SetActive(false);
            capsuleKilit.SetActive(true);
            capsuleUcret.SetActive(true);
            capsuleUcretText.text = "";
        }
        else
        {
            capsuleKilitAc.SetActive(false);
            capsuleSec.SetActive(true);
            capsuleKilit.SetActive(false);
            capsuleUcret.SetActive(false);
            capsuleUcretText.text = "";
        }
    }
    public void CapsuleKapalı()
    {
        capsuleLokomotif.SetActive(false);
        capsuleLokomotifCanvas.SetActive(false);
        capsuleKilitAc.SetActive(false);
        capsuleSec.SetActive(false);
        capsuleKilit.SetActive(false);
        capsuleUcret.SetActive(false);
        capsuleUcretText.text = "";
    }

    public void Kf2500Acık()
    {
        kf2500Lokomotif.SetActive(true);
        kf2500LokomotifCanvas.SetActive(true);
        if (PlayerPrefs.GetString("kf2500Alınabilir_mi") != "true")
        {
            kf2500KilitAc.SetActive(true);
            kf2500Sec.SetActive(false);
            kf2500Kilit.SetActive(true);
            kf2500Ucret.SetActive(true);
            kf2500UcretText.text = "";
        }
        else
        {
            kf2500KilitAc.SetActive(false);
            kf2500Sec.SetActive(true);
            kf2500Kilit.SetActive(false);
            kf2500Ucret.SetActive(false);
            kf2500UcretText.text = "";
        }
    }
    public void Kf2500Kapalı()
    {
        kf2500Lokomotif.SetActive(false);
        kf2500LokomotifCanvas.SetActive(false);
        kf2500KilitAc.SetActive(false);
        kf2500Sec.SetActive(false);
        kf2500Kilit.SetActive(false);
        kf2500Ucret.SetActive(false);
        kf2500UcretText.text = "";
    }

    public void TramAcık()
    {
        tramLokomotif.SetActive(true);
        tramLokomotifCanvas.SetActive(true);
        if (PlayerPrefs.GetString("tramAlınabilir_mi") != "true")
        {
            tramKilitAc.SetActive(true);
            tramSec.SetActive(false);
            tramKilit.SetActive(true);
            tramUcret.SetActive(true);
            tramUcretText.text = "";
        }
        else
        {
            tramKilitAc.SetActive(false);
            tramSec.SetActive(true);
            tramKilit.SetActive(false);
            tramUcret.SetActive(false);
            tramUcretText.text = "";
        }
    }
    public void TramKapalı()
    {
        tramLokomotif.SetActive(false);
        tramLokomotifCanvas.SetActive(false);
        tramKilitAc.SetActive(false);
        tramSec.SetActive(false);
        tramKilit.SetActive(false);
        tramUcret.SetActive(false);
        tramUcretText.text = "";
    }

    public void TankAcık()
    {
        tankLokomotif.SetActive(true);
        tankLokomotifCanvas.SetActive(true);
        if (PlayerPrefs.GetString("tankAlınabilir_mi") != "true")
        {
            tankKilitAc.SetActive(true);
            tankSec.SetActive(false);
            tankKilit.SetActive(true);
            tankUcret.SetActive(true);
            tankUcretText.text = "";
        }
        else
        {
            tankKilitAc.SetActive(false);
            tankSec.SetActive(true);
            tankKilit.SetActive(false);
            tankUcret.SetActive(false);
            tankUcretText.text = "";
        }
    }
    public void TankKapalı()
    {
        tankLokomotif.SetActive(false);
        tankLokomotifCanvas.SetActive(false);
        tankKilitAc.SetActive(false);
        tankSec.SetActive(false);
        tankKilit.SetActive(false);
        tankUcret.SetActive(false);
        tankUcretText.text = "";
    }

    public void SpaceAcık()
    {
        spaceLokomotif.SetActive(true);
        spaceLokomotifCanvas.SetActive(true);
        if (PlayerPrefs.GetString("spaceAlınabilir_mi") != "true")
        {
            spaceKilitAc.SetActive(true);
            spaceSec.SetActive(false);
            spaceKilit.SetActive(true);
            spaceUcret.SetActive(true);
            spaceUcretText.text = "";
        }
        else
        {
            spaceKilitAc.SetActive(false);
            spaceSec.SetActive(true);
            spaceKilit.SetActive(false);
            spaceUcret.SetActive(false);
            spaceUcretText.text = "";
        }
    }
    public void SpaceKapalı()
    {
        spaceLokomotif.SetActive(false);
        spaceLokomotifCanvas.SetActive(false);
        spaceKilitAc.SetActive(false);
        spaceSec.SetActive(false);
        spaceKilit.SetActive(false);
        spaceUcret.SetActive(false);
        spaceUcretText.text = "";
    }

    public void ToyAcık()
    {
        toyLokomotif.SetActive(true);
        toyLokomotifCanvas.SetActive(true);
        if (PlayerPrefs.GetString("toyAlınabilir_mi") != "true")
        {
            toyKilitAc.SetActive(true);
            toySec.SetActive(false);
            toyKilit.SetActive(true);
            toyUcret.SetActive(true);
            toyUcretText.text = "";
        }
        else
        {
            toyKilitAc.SetActive(false);
            toySec.SetActive(true);
            toyKilit.SetActive(false);
            toyUcret.SetActive(false);
            toyUcretText.text = "";
        }
    }
    public void ToyKapalı()
    {
        toyLokomotif.SetActive(false);
        toyLokomotifCanvas.SetActive(false);
        toyKilitAc.SetActive(false);
        toySec.SetActive(false);
        toyKilit.SetActive(false);
        toyUcret.SetActive(false);
        toyUcretText.text = "";
    }


    public void ToggleChoose()
    {
        if (PlayerPrefs.GetString("lokomotive") != "classic" && PlayerPrefs.GetString("lokomotive") != "hybrid" && PlayerPrefs.GetString("lokomotive") != "exclusive" && PlayerPrefs.GetString("lokomotive") != "capsule" && PlayerPrefs.GetString("lokomotive") != "kf2500" && PlayerPrefs.GetString("lokomotive") != "tram" && PlayerPrefs.GetString("lokomotive") != "tank" && PlayerPrefs.GetString("lokomotive") != "space" && PlayerPrefs.GetString("lokomotive") != "toy")
        {
            classicToggle.SetActive(true);
            hybridToggle.SetActive(false);
            exclusiveToggle.SetActive(false);
            capsuleToggle.SetActive(false);
            kf2500Toggle.SetActive(false);
            tramToggle.SetActive(false);
            tankToggle.SetActive(false);
            spaceToggle.SetActive(false);
            toyToggle.SetActive(false);
        }

        if (PlayerPrefs.GetString("lokomotive") == "classic")
        {
            classicToggle.SetActive(true);
            hybridToggle.SetActive(false);
            exclusiveToggle.SetActive(false);
            capsuleToggle.SetActive(false);
            kf2500Toggle.SetActive(false);
            tramToggle.SetActive(false);
            tankToggle.SetActive(false);
            spaceToggle.SetActive(false);
            toyToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("lokomotive") == "hybrid")
        {
            classicToggle.SetActive(false);
            hybridToggle.SetActive(true);
            exclusiveToggle.SetActive(false);
            capsuleToggle.SetActive(false);
            kf2500Toggle.SetActive(false);
            tramToggle.SetActive(false);
            tankToggle.SetActive(false);
            spaceToggle.SetActive(false);
            toyToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("lokomotive") == "exclusive")
        {
            classicToggle.SetActive(false);
            hybridToggle.SetActive(false);
            exclusiveToggle.SetActive(true);
            capsuleToggle.SetActive(false);
            kf2500Toggle.SetActive(false);
            tramToggle.SetActive(false);
            tankToggle.SetActive(false);
            spaceToggle.SetActive(false);
            toyToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("lokomotive") == "capsule")
        {
            classicToggle.SetActive(false);
            hybridToggle.SetActive(false);
            exclusiveToggle.SetActive(false);
            capsuleToggle.SetActive(true);
            kf2500Toggle.SetActive(false);
            tramToggle.SetActive(false);
            tankToggle.SetActive(false);
            spaceToggle.SetActive(false);
            toyToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("lokomotive") == "kf2500")
        {
            classicToggle.SetActive(false);
            hybridToggle.SetActive(false);
            exclusiveToggle.SetActive(false);
            capsuleToggle.SetActive(false);
            kf2500Toggle.SetActive(true);
            tramToggle.SetActive(false);
            tankToggle.SetActive(false);
            spaceToggle.SetActive(false);
            toyToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("lokomotive") == "tram")
        {
            classicToggle.SetActive(false);
            hybridToggle.SetActive(false);
            exclusiveToggle.SetActive(false);
            capsuleToggle.SetActive(false);
            kf2500Toggle.SetActive(false);
            tramToggle.SetActive(true);
            tankToggle.SetActive(false);
            spaceToggle.SetActive(false);
            toyToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("lokomotive") == "tank")
        {
            classicToggle.SetActive(false);
            hybridToggle.SetActive(false);
            exclusiveToggle.SetActive(false);
            capsuleToggle.SetActive(false);
            kf2500Toggle.SetActive(false);
            tramToggle.SetActive(false);
            tankToggle.SetActive(true);
            spaceToggle.SetActive(false);
            toyToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("lokomotive") == "space")
        {
            classicToggle.SetActive(false);
            hybridToggle.SetActive(false);
            exclusiveToggle.SetActive(false);
            capsuleToggle.SetActive(false);
            kf2500Toggle.SetActive(false);
            tramToggle.SetActive(false);
            tankToggle.SetActive(false);
            spaceToggle.SetActive(true);
            toyToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("lokomotive") == "toy")
        {
            classicToggle.SetActive(false);
            hybridToggle.SetActive(false);
            exclusiveToggle.SetActive(false);
            capsuleToggle.SetActive(false);
            kf2500Toggle.SetActive(false);
            tramToggle.SetActive(false);
            tankToggle.SetActive(false);
            spaceToggle.SetActive(false);
            toyToggle.SetActive(true);
        }
    }


    public void RightButton()
    {
        count++;
    }

    public void LeftButton()
    {
        count--;
    }

    public void BackButton()
    {
        lokomotifStore.SetActive(false);
        store.SetActive(true);
    }
}
