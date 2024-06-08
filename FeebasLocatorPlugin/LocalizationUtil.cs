using System;
using System.Collections.Generic;

namespace FeebasLocatorPlugin;

// Partially based on PKHeX's LocalizationUtil, thanks Kaphotics!
// https://github.com/kwsch/PKHeX/blob/master/PKHeX.Core/Util/ResourceUtil.cs
// https://github.com/kwsch/PKHeX/blob/master/PKHeX.Core/Util/Localization/LocalizationUtil.cs
public static class LocalizationUtil
{
    private const string TranslationSplitter = " = ";
    private const string LineSplitter = "\n";

    public static void SetLocalization(string currentCultureCode)
    {
        var txt = Properties.Resources.ResourceManager.GetObject($"lang_{currentCultureCode}")?.ToString();
        SetLocalization(txt == null ? [] : txt.Split(LineSplitter, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries));
    }

    private static void SetLocalization(IReadOnlyCollection<string> lines)
    {
        if (lines.Count == 0)
            return;

        Dictionary<string, string> dict = [];
        foreach (var line in lines)
        {
            var index = line.IndexOf(TranslationSplitter, StringComparison.Ordinal);
            if (index < 0)
                continue;

            dict.Add(line[..index], line[(index + TranslationSplitter.Length)..]);
        }

        TranslationStrings.PluginName = dict[nameof(TranslationStrings.PluginName)];
        TranslationStrings.FeebasSeed = dict[nameof(TranslationStrings.FeebasSeed)];
        TranslationStrings.SaveSeed = dict[nameof(TranslationStrings.SaveSeed)];
        TranslationStrings.Route119 = dict[nameof(TranslationStrings.Route119)];
        TranslationStrings.MtCoronet = dict[nameof(TranslationStrings.MtCoronet)];
    }
}
