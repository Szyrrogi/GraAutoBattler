using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strzelnica : Building
{
    public override IEnumerator OnBattleStart()
    {
        foreach(Pole pole in GetComponent<DragObject>().pole.GetComponent<Pole>().line.GetComponent<Linia>().pola)
        {
            if(pole.unit != null)
            {
                if(pole.unit.GetComponent<Unit>().Range > 0)
                {
                    pole.unit.GetComponent<Unit>().Attack += 30;
                    GameObject pop = Instantiate(PopUp, pole.unit.gameObject.transform.position, Quaternion.identity);
                    pop.GetComponent<PopUp>().SetText("+30", Color.green);
                    yield return new WaitForSeconds(0.7f);
                }
            }
        }
        yield return null;
    }
}