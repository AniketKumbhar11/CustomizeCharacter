using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationScriptHolder : MonoBehaviour
{   public enum Accesories {
        Beard,
        Belt,
        Helmate,
        Scapular

    }
    public GameObject _Beard, _Belt, _Helmate, _Scapular;

    public int BeardIndex,BeltIndex,HelmateIndex, ScapularIndex;

    private Dictionary<Accesories ,int> AccDictionary;




    public void BeardForword()
    {
        if (BeardIndex < _Beard.transform.childCount - 1)
            BeardIndex++;
        else
            BeardIndex = 0;
        ActiveObj(Accesories.Beard, BeardIndex);

    }

    public void BeardBackword()
    {
        if (BeardIndex > 0)
            BeardIndex--;
        else
            BeardIndex = _Beard.transform.childCount - 1;

        ActiveObj(Accesories.Beard, BeardIndex);

    }



    public void BeltForword()
    {
        if (BeltIndex < _Belt.transform.childCount - 1)
            BeltIndex++;
        else
            BeltIndex = 0;
        ActiveObj(Accesories.Belt, BeltIndex);

    }

    public void BeltBackword()
    {
        if (BeltIndex > 0)
            BeltIndex--;
        else
            BeltIndex = _Belt.transform.childCount - 1;

        ActiveObj(Accesories.Belt, BeltIndex);

    }

    public void HelmateForword()
    {
        if (HelmateIndex < _Helmate.transform.childCount - 1)
            HelmateIndex++;
        else
            HelmateIndex = 0;
        ActiveObj(Accesories.Helmate, HelmateIndex);

    }

    public void HelmateBackword()
    {
        if (HelmateIndex > 0)
            HelmateIndex--;
        else
            HelmateIndex = _Helmate.transform.childCount - 1;

        ActiveObj(Accesories.Helmate, HelmateIndex);

    }

    public void ScapularForword()
    {
        if (ScapularIndex < _Scapular.transform.childCount - 1)
            ScapularIndex++;
        else
            ScapularIndex = 0;
        ActiveObj(Accesories.Scapular, ScapularIndex);

    }

    public void ScapularBackword()
    {
        if (ScapularIndex > 0)
            ScapularIndex--;
        else
            ScapularIndex = _Scapular.transform.childCount - 1;

        ActiveObj(Accesories.Scapular, ScapularIndex);

    }



    private void ActiveObj(Accesories acc, int index)
    {
       
        switch (acc)
        {
            case Accesories.Beard:
                {
                    AcessChild(_Beard);
                    _Beard.transform.GetChild(index).gameObject.SetActive(true);
                }
                break;

            case Accesories.Belt:
                {
                    AcessChild(_Belt);
                    _Belt.transform.GetChild(index).gameObject.SetActive(true);
                }
                break;
            case Accesories.Helmate:
                {
                    AcessChild(_Helmate);
                    _Helmate.transform.GetChild(index).gameObject.SetActive(true);

                }
                break;
            case Accesories.Scapular:
                {
                    AcessChild(_Scapular);
                    _Scapular.transform.GetChild(index).gameObject.SetActive(true);
                }
                break;
            default:
                break;
        }




    }





    public void AcessChild(GameObject Obj)
    {
      
        for (int i = 0; i < Obj.transform.childCount; i++)
        {
            Obj.transform.GetChild(i).gameObject.SetActive(false);
        }


    }

    public void Save()
    {
        AccDictionary = new Dictionary<Accesories, int>();
        AccDictionary.Add(Accesories.Beard, BeardIndex);
        AccDictionary.Add(Accesories.Belt, BeltIndex);
        AccDictionary.Add(Accesories.Scapular, ScapularIndex);
        AccDictionary.Add(Accesories.Helmate, HelmateIndex);

    }
}
