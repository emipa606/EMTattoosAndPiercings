using Mlie;
using UnityEngine;
using Verse;

namespace BodyModTraits;

[StaticConstructorOnStartup]
internal class BodyModTraitsMod : Mod
{
    public static BodyModTraitsMod Instance;
    private static string currentVersion;

    private BodyModTraitsSettings settings;

    public BodyModTraitsMod(ModContentPack content)
        : base(content)
    {
        Instance = this;
        currentVersion =
            VersionFromManifest.GetVersionFromModMetaData(content.ModMetaData);
    }

    public BodyModTraitsSettings Settings
    {
        get
        {
            settings ??= GetSettings<BodyModTraitsSettings>();

            return settings;
        }
    }

    public override string SettingsCategory()
    {
        return "Scarification";
    }

    public override void DoSettingsWindowContents(Rect rect)
    {
        var listing_Standard = new Listing_Standard();
        listing_Standard.Begin(rect);
        listing_Standard.Gap();
        listing_Standard.CheckboxLabeled("EMTP_CountAsBad".Translate(), ref Settings.IsBad,
            "EMTP_CountAsBad_Tooltip".Translate());
        if (currentVersion != null)
        {
            listing_Standard.Gap();
            GUI.contentColor = Color.gray;
            listing_Standard.Label("EMTP_CurrentModVersion".Translate(currentVersion));
            GUI.contentColor = Color.white;
        }

        listing_Standard.End();
    }

    public override void WriteSettings()
    {
        base.WriteSettings();
        Internal.UpdateHediffs();
    }
}