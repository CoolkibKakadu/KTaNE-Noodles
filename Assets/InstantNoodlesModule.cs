using System;
using System.Collections.Generic;
using System.Linq;
using InstantNoodles;
using UnityEngine;
using Rnd = UnityEngine.Random;

/// <summary>
/// On the Subject of Instant Noodles
/// Created by CoolKibKakadu
/// </summary>
public class InstantNoodlesModule : MonoBehaviour
{
    public KMBombInfo Bomb;
    public KMBombModule Module;
    public KMAudio Audio;
    public KMSelectable solveButton;

    private static int _moduleIdCounter = 1;
    private int _moduleId;
    private string message;
    private object parameters;

    void Start()
    {

        solveButton.OnInteract = SolveModule;


    }

    private bool SolveModule()
    {
        Module.HandlePass();

        return false;
    }

    void ActivateModule()
    {

        Debug.LogFormat("[Instant Noodles #{0}] {1}", _moduleId, string.Format(message, parameters));
    }
}
//#pragma warning disable 414
//    private string TwitchHelpMessage = @"Hit the correct spots with “!{0} press bl mm tm tl”. (Locations are tl, tm, ml, mm, mr, bl, bm, br.)";
//#pragma warning restore 414
//
//    KMSelectable[] ProcessTwitchCommand(string command)
//    {
//        var split = command.Trim().ToLowerInvariant().Split(new[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
//        if (split.Length < 2 || split[0] != "press")
//            return null;
//
//        var btns = new List<KMSelectable>();
//        foreach (var cmd in split.Skip(1))
//            switch (cmd.Replace("center", "middle").Replace("centre", "middle"))
//            {
//                case "tl": case "lt": case "topleft": case "lefttop": btns.Add(Regions[0]); break;
//                case "tm": case "tc": case "mt": case "ct": case "topmiddle": case "middletop": btns.Add(Regions[1]); break;
//
//                case "ml": case "cl": case "lm": case "lc": case "middleleft": case "leftmiddle": btns.Add(Regions[2]); break;
//                case "mm": case "cm": case "mc": case "cc": case "middle": case "middlemiddle": btns.Add(Regions[3]); break;
//                case "mr": case "cr": case "rm": case "rc": case "middleright": case "rightmiddle": btns.Add(Regions[4]); break;
//
//                case "bl": case "lb": case "bottomleft": case "leftbottom": btns.Add(Regions[5]); break;
//                case "bm": case "bc": case "mb": case "cb": case "bottommiddle": case "middlebottom": btns.Add(Regions[6]); break;
//                case "br": case "rb": case "bottomright": case "rightbottom": btns.Add(Regions[7]); break;
//
//                default: return null;
//            }
//        return btns.ToArray();
//    }
//}
