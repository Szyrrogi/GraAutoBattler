using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireStrzalaZaru : Spell
{
    public override IEnumerator Fight()
    {

        if(unit.findPole() != null && unit.findPole().GetComponent<Pole>().unit != null && unit.Enemy != unit.findPole().GetComponent<Pole>().unit.GetComponent<Unit>().Enemy)
        {
            Unit enemyUnit = unit.findPole().GetComponent<Pole>().unit.GetComponent<Unit>();
            yield return StartCoroutine(enemyUnit.TakeDamage(this, enemyUnit.BeforDamage(gameObject, BeforAttack(enemyUnit.gameObject, 50)),TypeDamage.typeDamage.Magic));
        }
        else
        {

            if(unit.findPole() != null)
            {
                GameObject pole = unit.findPole();
                if(unit.findPole(pole.GetComponent<Pole>()) != null && unit.findPole(pole.GetComponent<Pole>()).GetComponent<Pole>().unit != null && unit.Enemy != unit.findPole(pole.GetComponent<Pole>()).GetComponent<Pole>().unit.GetComponent<Unit>().Enemy)
                {
                    Unit enemyUnit = unit.findPole(pole.GetComponent<Pole>()).GetComponent<Pole>().unit.GetComponent<Unit>();
                    yield return StartCoroutine(enemyUnit.TakeDamage(this, enemyUnit.BeforDamage(gameObject ,BeforAttack(enemyUnit.gameObject, 50)),TypeDamage.typeDamage.Magic));
                }
            }
        }
        yield return null;
        if(unit.Health <= 0)
        {
            StartCoroutine(unit.Death());
        }
    }
}
