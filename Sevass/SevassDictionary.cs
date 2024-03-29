﻿using Microsoft.CodeAnalysis.CSharp;

namespace Sevass;

/// <summary>
/// The SevassDictionary contains a dictionaries that map Sevass keywords to C# keywords and vice versa.
/// </summary>
public static class SevassDictionary
{
    /// <summary>
    /// A dictionary that maps a syntax kind to its corresponding sevass keyword.
    /// For example, SyntaxKind.DoubleKeyword maps to "dubbel".
    /// </summary>
    public static readonly Dictionary<SyntaxKind, string> SyntaxKindToSevass = new()
    {
        {SyntaxKind.BoolKeyword, "bool"},
        {SyntaxKind.ByteKeyword, "byte"},
        {SyntaxKind.SByteKeyword, "sbyte"},
        {SyntaxKind.ShortKeyword, "kort"},
        {SyntaxKind.UShortKeyword, "ukort"},
        {SyntaxKind.IntKeyword, "hel"},
        {SyntaxKind.UIntKeyword, "uhel"},
        {SyntaxKind.LongKeyword, "lång"},
        {SyntaxKind.ULongKeyword, "ulång"},
        {SyntaxKind.FloatKeyword, "flyttal"},
        {SyntaxKind.DoubleKeyword, "dubbel"},
        {SyntaxKind.DecimalKeyword, "decimal"},
        {SyntaxKind.StringKeyword, "sträng"},
        {SyntaxKind.CharKeyword, "tecken"},
        {SyntaxKind.VoidKeyword, "tomhet"},
        {SyntaxKind.ObjectKeyword, "objekt"},
        {SyntaxKind.TypeOfKeyword, "typav"},
        {SyntaxKind.SizeOfKeyword, "storlekav"},
        {SyntaxKind.NullKeyword, "noll"},
        {SyntaxKind.TrueKeyword, "sant"},
        {SyntaxKind.FalseKeyword, "falskt"},
        {SyntaxKind.IfKeyword, "om"},
        {SyntaxKind.ElseKeyword, "annars"},
        {SyntaxKind.WhileKeyword, "medan"},
        {SyntaxKind.ForKeyword, "för"},
        {SyntaxKind.ForEachKeyword, "förvarje"},
        {SyntaxKind.DoKeyword, "gör"},
        {SyntaxKind.SwitchKeyword, "växla"},
        {SyntaxKind.CaseKeyword, "fall"},
        {SyntaxKind.DefaultKeyword, "standard"},
        {SyntaxKind.TryKeyword, "försök"},
        {SyntaxKind.CatchKeyword, "fånga"},
        {SyntaxKind.FinallyKeyword, "slutligen"},
        {SyntaxKind.LockKeyword, "lås"},
        {SyntaxKind.BreakKeyword, "bryt"},
        {SyntaxKind.ContinueKeyword, "fortsätt"},
        {SyntaxKind.ReturnKeyword, "återvänd"},
        {SyntaxKind.ThrowKeyword, "kasta"},
        {SyntaxKind.PublicKeyword, "offentlig"},
        {SyntaxKind.PrivateKeyword, "privat"},
        {SyntaxKind.ProtectedKeyword, "skyddad"},
        {SyntaxKind.InternalKeyword, "intern"},
        {SyntaxKind.StaticKeyword, "statisk"},
        {SyntaxKind.ReadOnlyKeyword, "läsbar"},
        {SyntaxKind.SealedKeyword, "sluten"},
        {SyntaxKind.ConstKeyword, "konstant"},
        {SyntaxKind.FixedKeyword, "fast"},
        {SyntaxKind.StackAllocKeyword, "stackallokering"},
        {SyntaxKind.NewKeyword, "ny"},
        {SyntaxKind.OverrideKeyword, "överskugga"},
        {SyntaxKind.AbstractKeyword, "abstrakt"},
        {SyntaxKind.VirtualKeyword, "virtuell"},
        {SyntaxKind.EventKeyword, "händelse"},
        {SyntaxKind.ExternKeyword, "extern"},
        {SyntaxKind.RefKeyword, "ref"},
        {SyntaxKind.OutKeyword, "ut"},
        {SyntaxKind.InKeyword, "in"},
        {SyntaxKind.IsKeyword, "är"},
        {SyntaxKind.AsKeyword, "som"},
        {SyntaxKind.ParamsKeyword, "parametrar"},
        {SyntaxKind.ThisExpression, "detta"},
        {SyntaxKind.BaseExpression, "bas"},
        {SyntaxKind.NamespaceKeyword, "namnrymd"},
        {SyntaxKind.UsingKeyword, "använder"},
        {SyntaxKind.ClassKeyword, "klass"},
        {SyntaxKind.StructKeyword, "struktur"},
        {SyntaxKind.InterfaceKeyword, "gränssnitt"},
        {SyntaxKind.EnumKeyword, "enum"},
        {SyntaxKind.GetKeyword, "hämta"},
        {SyntaxKind.SetKeyword, "sätt"},
        {SyntaxKind.AddKeyword, "lägg"},
        {SyntaxKind.AwaitKeyword, "invänta"},
        {SyntaxKind.WhenKeyword, "när"},
        {SyntaxKind.NameOfKeyword, "namnav"},
        {SyntaxKind.GotoKeyword, "gåtill"},
    };

    /// <summary>
    /// A dictionary that maps a sevass keyword to its corresponding syntax kind.
    /// </summary>
    public static readonly Dictionary<string, string> SevassToSyntaxKind =
        SyntaxKindToSevass.ToDictionary(x => x.Value, x => SyntaxFacts.GetText(x.Key));
}