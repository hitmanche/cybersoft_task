using CL.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace BL.Business.Converter
{
    class ConverterTXT : AConverter
    {
        private readonly string _prmReadFile;
        public ConverterTXT(string prmReadFile)
        {
            _prmReadFile = prmReadFile;
        }
        public override void Converter(ref List<Alive> returnData)
        {
            string[] readText = File.ReadAllLines(_prmReadFile);
            if (readText.Length > 0)
            {
                returnData = new List<Alive>();
                for (int x = 0; x < readText.Length; x++)
                {
                    string[] sLine = readText[x].Split("|");
                    switch (Functions.GetAliveType(sLine[0]))
                    {
                        case AliveType.Enemy:
                            returnData.Add(new Alive
                            {
                                type = AliveType.Enemy,
                                name = sLine[1],
                                health = Convert.ToInt32(sLine[2]),
                                position = Convert.ToInt32(sLine[4]),
                                attack = Convert.ToInt32(sLine[3])
                            });
                            break;
                        case AliveType.Human:
                            returnData.Add(new Alive
                            {
                                type = AliveType.Human,
                                name = sLine[1],
                                health = Convert.ToInt32(sLine[2]),
                                attack = Convert.ToInt32(sLine[3])
                            });
                            break;
                        case AliveType.Distance:
                            returnData.Add(new Alive
                            {
                                type = AliveType.Distance,
                                position = Convert.ToInt32(sLine[1]),
                            });
                            break;
                        case AliveType.None:
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
