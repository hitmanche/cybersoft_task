using CL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL.Business
{
    public class Analyze
    {
        private List<string> returnResult;
        private List<Alive> dataList;
        public string prmErrorMessage = "";
        public Analyze(object _dataList)
        {
            dataList = _dataList as List<Alive>;
            returnResult = new List<string>();
        }


        public bool ControlSystem()
        {
            List<Alive> hControl = dataList.Where(x => x.type == AliveType.Human).ToList();
            if (hControl.Count == 0)
            {
                prmErrorMessage = "Hero information was not available.";
                return true;
            }
            if (hControl.Count > 1)
            {
                prmErrorMessage = "There should not be more than one hero information.";
                return true;
            }
            Alive prmDes = dataList.Where(x => x.type == AliveType.Distance).First();
            if (prmDes == null && prmDes.position < 1)
            {
                prmErrorMessage = "The location information to go could not be accessed.";
                return true;
            }
            return false;
        }

        public List<string> Input()
        {
            List<string> inputString = new List<string>();
            Alive prmDes = dataList.Where(x => x.type == AliveType.Distance).First();
            inputString.Add("Resources are " + prmDes.position + " meters away");

            Alive prmHmn = dataList.Where(x => x.type == AliveType.Human).First();
            inputString.Add("Hero has " + prmHmn.health + " hp");
            inputString.Add("Hero attack is " + prmHmn.attack);

            foreach (Alive prmAlive in dataList)
            {
                if (prmAlive.type == AliveType.Enemy)
                {
                    inputString.Add(prmAlive.name + " is Enemy");
                    inputString.Add(prmAlive.name + " has 50 hp");
                    inputString.Add(prmAlive.name + " attack is " + prmAlive.attack);
                    inputString.Add("There is a " + prmAlive.name + " at position " + prmAlive.position);
                }
            }
            return inputString;
        }

        public List<string> Output()
        {
            List<string> outputString = new List<string>();
            Alive prmHmn = dataList.Where(x => x.type == AliveType.Human).First();
            outputString.Add("Hero started journey with " + prmHmn.health + " hp!");

            int lastPosition = 0;
            int health = prmHmn.health;
            foreach (Alive prmAlive in dataList.Where(x => x.type == AliveType.Enemy).OrderBy(x => x.position))
            {
                lastPosition = prmAlive.position;

                int humanStep = prmAlive.health / prmHmn.attack;
                int humanMode = prmAlive.health % prmHmn.attack;

                int enemyStep = health / prmAlive.attack;
                int enemyMode = health % prmAlive.attack;

                int alHealth = (prmAlive.health - prmAlive.attack * enemyStep);
                health -= (humanStep + 1) * prmAlive.attack;

                if (humanStep > enemyStep || health < 1)
                {
                    outputString.Add(prmAlive.name + " defeated Hero with " + alHealth + " HP remaining");
                    outputString.Add("Hero is Dead!! Last seen at position " + lastPosition + "!!");
                    break;
                }
                else
                {
                    outputString.Add("Hero defeated " + prmAlive.name + " with " + health + " hp remaining");
                }
            }
            if (health > 1)
            {
                outputString.Add("Hero Survived!");
            }

            return outputString;
        }
    }
}
