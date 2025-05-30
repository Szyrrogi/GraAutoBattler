using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrzewoZycia : Building
{
    public override IEnumerator OnBattleStart()
    {
        foreach(Unit unit in EventSystem.eventSystem.GetComponent<FightManager>().units)
        {
            if((unit.gameObject.GetComponent<Drzewo>()) && unit.Enemy == Enemy)
            {
                unit.gameObject.GetComponent<Drzewo>().HPBuff();
            }
        }
        yield return null;
    }
}
