using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HikayeButon : MonoBehaviour
{
    [SerializeField] Text konusma;
    [SerializeField] Image AnaKarakter;
    [SerializeField] Image YanKarakter;
    private int sayac = 0;
    private void Start()
    {
        AnaKarakter.enabled = false;
        YanKarakter.enabled = true;

    }
    void Update()
    {
        if(sayac == 0)
        {
            YanKarakter.enabled = true;
            konusma.text = "Akademide olmak için ne kadar güzel bir gün :)";
        }
        else if(sayac == 1)
        {
            YanKarakter.enabled = false;
            AnaKarakter.enabled = true;
            konusma.text = "Bence de hem hava da çok güzel. Peki çýkýþta bir yerlere gitmek ister misin?";
        }
        else if (sayac == 2)
        {
            YanKarakter.enabled = true;
            AnaKarakter.enabled = false;
            konusma.text = "Þeyy... !!! O SESLER DE NE!!!";
        }
        else if (sayac == 3)
        {
            YanKarakter.enabled = true;
            AnaKarakter.enabled = true;
            konusma.text = "'!' AKADEMÝYÝ ÝSTÝLA EDÝYORLAR'!'";
        }
        else if (sayac == 4)
        {
            AnaKarakter.enabled = true;
            YanKarakter.enabled = false;
            konusma.text = "ÝÞTE BENÝM SIRAM!! HEP HAYALÝNÝ KURDUÐUM HÝKAYE, TÜM AKADEMÝYÝ ÝSTÝLADAN KURTARMALIYIM!!";
        }
        else if (sayac == 5)
        {
            SceneManager.LoadScene(2);
        }
    }
    public void TusaBasildi()
    {
        sayac++;
        

    }
}
