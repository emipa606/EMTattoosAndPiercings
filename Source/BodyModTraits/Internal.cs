using System.Collections.Generic;
using System.Linq;
using Verse;

namespace BodyModTraits;

public static class Internal
{
    public static int CountBodyMods(HediffSet hediffSet)
    {
        var num = 0;
        var hediffs = hediffSet.hediffs;
        foreach (var item in hediffs)
        {
            if (item.def.defName is "Tattooed" or "Scarified" || item is Hediff_Implant &&
                item.def.defName.StartsWith("EM") && (item.def.defName.EndsWith("Sma") ||
                                                      item.def.defName.EndsWith("Med") ||
                                                      item.def.defName.EndsWith("Big")))
            {
                num++;
            }
        }

        return num;
    }

    public static void UpdateHediffs()
    {
        var listOfHediffs = new List<string> { "Tattooed", "Scarified" };
        var enumerable = from HediffDef hediff in DefDatabase<HediffDef>.AllDefsListForReading
            where listOfHediffs.Contains(hediff.defName)
            select hediff;
        foreach (var item in enumerable)
        {
            item.isBad = BodyModTraitsMod.Instance.Settings.IsBad;
        }
    }
}