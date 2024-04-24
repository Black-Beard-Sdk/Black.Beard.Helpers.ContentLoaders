<a name='assembly'></a>
# Black.Beard.Helpers.Randoms

## Contents

- [Automaton](#T-Fare-Automaton 'Fare.Automaton')
  - [#ctor()](#M-Fare-Automaton-#ctor 'Fare.Automaton.#ctor')
  - [MinimizeBrzozowski](#F-Fare-Automaton-MinimizeBrzozowski 'Fare.Automaton.MinimizeBrzozowski')
  - [MinimizeHopcroft](#F-Fare-Automaton-MinimizeHopcroft 'Fare.Automaton.MinimizeHopcroft')
  - [MinimizeHuffman](#F-Fare-Automaton-MinimizeHuffman 'Fare.Automaton.MinimizeHuffman')
  - [allowMutation](#F-Fare-Automaton-allowMutation 'Fare.Automaton.allowMutation')
  - [hashCode](#F-Fare-Automaton-hashCode 'Fare.Automaton.hashCode')
  - [initial](#F-Fare-Automaton-initial 'Fare.Automaton.initial')
  - [minimizeAlways](#F-Fare-Automaton-minimizeAlways 'Fare.Automaton.minimizeAlways')
  - [AllowMutation](#P-Fare-Automaton-AllowMutation 'Fare.Automaton.AllowMutation')
  - [Initial](#P-Fare-Automaton-Initial 'Fare.Automaton.Initial')
  - [IsDebug](#P-Fare-Automaton-IsDebug 'Fare.Automaton.IsDebug')
  - [IsDeterministic](#P-Fare-Automaton-IsDeterministic 'Fare.Automaton.IsDeterministic')
  - [IsEmpty](#P-Fare-Automaton-IsEmpty 'Fare.Automaton.IsEmpty')
  - [IsSingleton](#P-Fare-Automaton-IsSingleton 'Fare.Automaton.IsSingleton')
  - [Minimization](#P-Fare-Automaton-Minimization 'Fare.Automaton.Minimization')
  - [NumberOfStates](#P-Fare-Automaton-NumberOfStates 'Fare.Automaton.NumberOfStates')
  - [NumberOfTransitions](#P-Fare-Automaton-NumberOfTransitions 'Fare.Automaton.NumberOfTransitions')
  - [Singleton](#P-Fare-Automaton-Singleton 'Fare.Automaton.Singleton')
  - [AddEpsilons(pairs)](#M-Fare-Automaton-AddEpsilons-System-Collections-Generic-ICollection{Fare-StatePair}- 'Fare.Automaton.AddEpsilons(System.Collections.Generic.ICollection{Fare.StatePair})')
  - [CheckMinimizeAlways()](#M-Fare-Automaton-CheckMinimizeAlways 'Fare.Automaton.CheckMinimizeAlways')
  - [ClearHashCode()](#M-Fare-Automaton-ClearHashCode 'Fare.Automaton.ClearHashCode')
  - [Clone()](#M-Fare-Automaton-Clone 'Fare.Automaton.Clone')
  - [CloneExpanded()](#M-Fare-Automaton-CloneExpanded 'Fare.Automaton.CloneExpanded')
  - [CloneExpandedIfRequired()](#M-Fare-Automaton-CloneExpandedIfRequired 'Fare.Automaton.CloneExpandedIfRequired')
  - [CloneIfRequired()](#M-Fare-Automaton-CloneIfRequired 'Fare.Automaton.CloneIfRequired')
  - [Complement()](#M-Fare-Automaton-Complement 'Fare.Automaton.Complement')
  - [Concatenate(a)](#M-Fare-Automaton-Concatenate-Fare-Automaton- 'Fare.Automaton.Concatenate(Fare.Automaton)')
  - [Determinize()](#M-Fare-Automaton-Determinize 'Fare.Automaton.Determinize')
  - [ExpandSingleton()](#M-Fare-Automaton-ExpandSingleton 'Fare.Automaton.ExpandSingleton')
  - [GetAcceptStates()](#M-Fare-Automaton-GetAcceptStates 'Fare.Automaton.GetAcceptStates')
  - [GetHashCode()](#M-Fare-Automaton-GetHashCode 'Fare.Automaton.GetHashCode')
  - [GetLiveStates()](#M-Fare-Automaton-GetLiveStates 'Fare.Automaton.GetLiveStates')
  - [GetSortedTransitions(states)](#M-Fare-Automaton-GetSortedTransitions-System-Collections-Generic-HashSet{Fare-State}- 'Fare.Automaton.GetSortedTransitions(System.Collections.Generic.HashSet{Fare.State})')
  - [GetStartPoints()](#M-Fare-Automaton-GetStartPoints 'Fare.Automaton.GetStartPoints')
  - [GetStates()](#M-Fare-Automaton-GetStates 'Fare.Automaton.GetStates')
  - [Intersection(a)](#M-Fare-Automaton-Intersection-Fare-Automaton- 'Fare.Automaton.Intersection(Fare.Automaton)')
  - [IsEmptyString()](#M-Fare-Automaton-IsEmptyString 'Fare.Automaton.IsEmptyString')
  - [MakeChar(c)](#M-Fare-Automaton-MakeChar-System-Char- 'Fare.Automaton.MakeChar(System.Char)')
  - [MakeCharSet(set)](#M-Fare-Automaton-MakeCharSet-System-String- 'Fare.Automaton.MakeCharSet(System.String)')
  - [MakeString(s)](#M-Fare-Automaton-MakeString-System-String- 'Fare.Automaton.MakeString(System.String)')
  - [Minimize(a)](#M-Fare-Automaton-Minimize-Fare-Automaton- 'Fare.Automaton.Minimize(Fare.Automaton)')
  - [Minimize()](#M-Fare-Automaton-Minimize 'Fare.Automaton.Minimize')
  - [Optional()](#M-Fare-Automaton-Optional 'Fare.Automaton.Optional')
  - [RecomputeHashCode()](#M-Fare-Automaton-RecomputeHashCode 'Fare.Automaton.RecomputeHashCode')
  - [Reduce()](#M-Fare-Automaton-Reduce 'Fare.Automaton.Reduce')
  - [RemoveDeadTransitions()](#M-Fare-Automaton-RemoveDeadTransitions 'Fare.Automaton.RemoveDeadTransitions')
  - [Repeat(min,max)](#M-Fare-Automaton-Repeat-System-Int32,System-Int32- 'Fare.Automaton.Repeat(System.Int32,System.Int32)')
  - [Repeat()](#M-Fare-Automaton-Repeat 'Fare.Automaton.Repeat')
  - [Repeat(min)](#M-Fare-Automaton-Repeat-System-Int32- 'Fare.Automaton.Repeat(System.Int32)')
  - [Run(s)](#M-Fare-Automaton-Run-System-String- 'Fare.Automaton.Run(System.String)')
  - [SetAllowMutate(flag)](#M-Fare-Automaton-SetAllowMutate-System-Boolean- 'Fare.Automaton.SetAllowMutate(System.Boolean)')
  - [SetMinimizeAlways(flag)](#M-Fare-Automaton-SetMinimizeAlways-System-Boolean- 'Fare.Automaton.SetMinimizeAlways(System.Boolean)')
  - [SetStateNumbers(states)](#M-Fare-Automaton-SetStateNumbers-System-Collections-Generic-IEnumerable{Fare-State}- 'Fare.Automaton.SetStateNumbers(System.Collections.Generic.IEnumerable{Fare.State})')
  - [Totalize()](#M-Fare-Automaton-Totalize 'Fare.Automaton.Totalize')
- [BasicAutomata](#T-Fare-BasicAutomata 'Fare.BasicAutomata')
  - [AnyOfRightLength(x,n)](#M-Fare-BasicAutomata-AnyOfRightLength-System-String,System-Int32- 'Fare.BasicAutomata.AnyOfRightLength(System.String,System.Int32)')
  - [AtLeast(x,n,initials,zeros)](#M-Fare-BasicAutomata-AtLeast-System-String,System-Int32,System-Collections-Generic-ICollection{Fare-State},System-Boolean- 'Fare.BasicAutomata.AtLeast(System.String,System.Int32,System.Collections.Generic.ICollection{Fare.State},System.Boolean)')
  - [AtMost(x,n)](#M-Fare-BasicAutomata-AtMost-System-String,System-Int32- 'Fare.BasicAutomata.AtMost(System.String,System.Int32)')
  - [Between(x,y,n,initials,zeros)](#M-Fare-BasicAutomata-Between-System-String,System-String,System-Int32,System-Collections-Generic-ICollection{Fare-State},System-Boolean- 'Fare.BasicAutomata.Between(System.String,System.String,System.Int32,System.Collections.Generic.ICollection{Fare.State},System.Boolean)')
  - [MakeAnyChar()](#M-Fare-BasicAutomata-MakeAnyChar 'Fare.BasicAutomata.MakeAnyChar')
  - [MakeAnyString()](#M-Fare-BasicAutomata-MakeAnyString 'Fare.BasicAutomata.MakeAnyString')
  - [MakeChar(c)](#M-Fare-BasicAutomata-MakeChar-System-Char- 'Fare.BasicAutomata.MakeChar(System.Char)')
  - [MakeCharRange(min,max)](#M-Fare-BasicAutomata-MakeCharRange-System-Char,System-Char- 'Fare.BasicAutomata.MakeCharRange(System.Char,System.Char)')
  - [MakeCharSet(set)](#M-Fare-BasicAutomata-MakeCharSet-System-String- 'Fare.BasicAutomata.MakeCharSet(System.String)')
  - [MakeDecimalValue(value)](#M-Fare-BasicAutomata-MakeDecimalValue-System-String- 'Fare.BasicAutomata.MakeDecimalValue(System.String)')
  - [MakeEmpty()](#M-Fare-BasicAutomata-MakeEmpty 'Fare.BasicAutomata.MakeEmpty')
  - [MakeEmptyString()](#M-Fare-BasicAutomata-MakeEmptyString 'Fare.BasicAutomata.MakeEmptyString')
  - [MakeFractionDigits(i)](#M-Fare-BasicAutomata-MakeFractionDigits-System-Int32- 'Fare.BasicAutomata.MakeFractionDigits(System.Int32)')
  - [MakeIntegerValue(value)](#M-Fare-BasicAutomata-MakeIntegerValue-System-String- 'Fare.BasicAutomata.MakeIntegerValue(System.String)')
  - [MakeInterval(min,max,digits)](#M-Fare-BasicAutomata-MakeInterval-System-Int32,System-Int32,System-Int32- 'Fare.BasicAutomata.MakeInterval(System.Int32,System.Int32,System.Int32)')
  - [MakeMaxInteger(n)](#M-Fare-BasicAutomata-MakeMaxInteger-System-String- 'Fare.BasicAutomata.MakeMaxInteger(System.String)')
  - [MakeMinInteger(n)](#M-Fare-BasicAutomata-MakeMinInteger-System-String- 'Fare.BasicAutomata.MakeMinInteger(System.String)')
  - [MakeString(s)](#M-Fare-BasicAutomata-MakeString-System-String- 'Fare.BasicAutomata.MakeString(System.String)')
  - [MakeStringMatcher(s)](#M-Fare-BasicAutomata-MakeStringMatcher-System-String- 'Fare.BasicAutomata.MakeStringMatcher(System.String)')
  - [MakeStringUnion(strings)](#M-Fare-BasicAutomata-MakeStringUnion-System-Char[][]- 'Fare.BasicAutomata.MakeStringUnion(System.Char[][])')
  - [MakeTotalDigits(i)](#M-Fare-BasicAutomata-MakeTotalDigits-System-Int32- 'Fare.BasicAutomata.MakeTotalDigits(System.Int32)')
- [BasicOperations](#T-Fare-BasicOperations 'Fare.BasicOperations')
  - [AddEpsilons(a,pairs)](#M-Fare-BasicOperations-AddEpsilons-Fare-Automaton,System-Collections-Generic-ICollection{Fare-StatePair}- 'Fare.BasicOperations.AddEpsilons(Fare.Automaton,System.Collections.Generic.ICollection{Fare.StatePair})')
  - [Complement(a)](#M-Fare-BasicOperations-Complement-Fare-Automaton- 'Fare.BasicOperations.Complement(Fare.Automaton)')
  - [Concatenate(a1,a2)](#M-Fare-BasicOperations-Concatenate-Fare-Automaton,Fare-Automaton- 'Fare.BasicOperations.Concatenate(Fare.Automaton,Fare.Automaton)')
  - [Concatenate(l)](#M-Fare-BasicOperations-Concatenate-System-Collections-Generic-IList{Fare-Automaton}- 'Fare.BasicOperations.Concatenate(System.Collections.Generic.IList{Fare.Automaton})')
  - [Determinize(a)](#M-Fare-BasicOperations-Determinize-Fare-Automaton- 'Fare.BasicOperations.Determinize(Fare.Automaton)')
  - [Determinize(a,initialset)](#M-Fare-BasicOperations-Determinize-Fare-Automaton,System-Collections-Generic-List{Fare-State}- 'Fare.BasicOperations.Determinize(Fare.Automaton,System.Collections.Generic.List{Fare.State})')
  - [Intersection(a1,a2)](#M-Fare-BasicOperations-Intersection-Fare-Automaton,Fare-Automaton- 'Fare.BasicOperations.Intersection(Fare.Automaton,Fare.Automaton)')
  - [IsEmpty(a)](#M-Fare-BasicOperations-IsEmpty-Fare-Automaton- 'Fare.BasicOperations.IsEmpty(Fare.Automaton)')
  - [IsEmptyString(a)](#M-Fare-BasicOperations-IsEmptyString-Fare-Automaton- 'Fare.BasicOperations.IsEmptyString(Fare.Automaton)')
  - [Optional(a)](#M-Fare-BasicOperations-Optional-Fare-Automaton- 'Fare.BasicOperations.Optional(Fare.Automaton)')
  - [Repeat(a)](#M-Fare-BasicOperations-Repeat-Fare-Automaton- 'Fare.BasicOperations.Repeat(Fare.Automaton)')
  - [Repeat(a,min)](#M-Fare-BasicOperations-Repeat-Fare-Automaton,System-Int32- 'Fare.BasicOperations.Repeat(Fare.Automaton,System.Int32)')
  - [Repeat(a,min,max)](#M-Fare-BasicOperations-Repeat-Fare-Automaton,System-Int32,System-Int32- 'Fare.BasicOperations.Repeat(Fare.Automaton,System.Int32,System.Int32)')
  - [Run(a,s)](#M-Fare-BasicOperations-Run-Fare-Automaton,System-String- 'Fare.BasicOperations.Run(Fare.Automaton,System.String)')
  - [Union(automatons)](#M-Fare-BasicOperations-Union-System-Collections-Generic-IList{Fare-Automaton}- 'Fare.BasicOperations.Union(System.Collections.Generic.IList{Fare.Automaton})')
- [CardIssuer](#T-RandomDataGenerator-CreditCardValidator-CardIssuer 'RandomDataGenerator.CreditCardValidator.CardIssuer')
  - [AmericanExpress](#F-RandomDataGenerator-CreditCardValidator-CardIssuer-AmericanExpress 'RandomDataGenerator.CreditCardValidator.CardIssuer.AmericanExpress')
  - [Any](#F-RandomDataGenerator-CreditCardValidator-CardIssuer-Any 'RandomDataGenerator.CreditCardValidator.CardIssuer.Any')
  - [ChinaUnionPay](#F-RandomDataGenerator-CreditCardValidator-CardIssuer-ChinaUnionPay 'RandomDataGenerator.CreditCardValidator.CardIssuer.ChinaUnionPay')
  - [Dankort](#F-RandomDataGenerator-CreditCardValidator-CardIssuer-Dankort 'RandomDataGenerator.CreditCardValidator.CardIssuer.Dankort')
  - [DinersClub](#F-RandomDataGenerator-CreditCardValidator-CardIssuer-DinersClub 'RandomDataGenerator.CreditCardValidator.CardIssuer.DinersClub')
  - [Discover](#F-RandomDataGenerator-CreditCardValidator-CardIssuer-Discover 'RandomDataGenerator.CreditCardValidator.CardIssuer.Discover')
  - [Hipercard](#F-RandomDataGenerator-CreditCardValidator-CardIssuer-Hipercard 'RandomDataGenerator.CreditCardValidator.CardIssuer.Hipercard')
  - [JCB](#F-RandomDataGenerator-CreditCardValidator-CardIssuer-JCB 'RandomDataGenerator.CreditCardValidator.CardIssuer.JCB')
  - [Laser](#F-RandomDataGenerator-CreditCardValidator-CardIssuer-Laser 'RandomDataGenerator.CreditCardValidator.CardIssuer.Laser')
  - [Maestro](#F-RandomDataGenerator-CreditCardValidator-CardIssuer-Maestro 'RandomDataGenerator.CreditCardValidator.CardIssuer.Maestro')
  - [MasterCard](#F-RandomDataGenerator-CreditCardValidator-CardIssuer-MasterCard 'RandomDataGenerator.CreditCardValidator.CardIssuer.MasterCard')
  - [RuPay](#F-RandomDataGenerator-CreditCardValidator-CardIssuer-RuPay 'RandomDataGenerator.CreditCardValidator.CardIssuer.RuPay')
  - [Switch](#F-RandomDataGenerator-CreditCardValidator-CardIssuer-Switch 'RandomDataGenerator.CreditCardValidator.CardIssuer.Switch')
  - [Visa](#F-RandomDataGenerator-CreditCardValidator-CardIssuer-Visa 'RandomDataGenerator.CreditCardValidator.CardIssuer.Visa')
- [CreditCardData](#T-RandomDataGenerator-CreditCardValidator-CreditCardData 'RandomDataGenerator.CreditCardValidator.CreditCardData')
  - [GenerateRange(start,end)](#M-RandomDataGenerator-CreditCardValidator-CreditCardData-GenerateRange-System-Int32,System-Int32- 'RandomDataGenerator.CreditCardValidator.CreditCardData.GenerateRange(System.Int32,System.Int32)')
- [CustomIntrospectionExtensions](#T-System-Reflection-CustomIntrospectionExtensions 'System.Reflection.CustomIntrospectionExtensions')
- [FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
  - [Seed](#P-RandomDataGenerator-FieldOptions-FieldOptionsAbstract-Seed 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract.Seed')
  - [UseNullValues](#P-RandomDataGenerator-FieldOptions-FieldOptionsAbstract-UseNullValues 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract.UseNullValues')
  - [ValueAsString](#P-RandomDataGenerator-FieldOptions-FieldOptionsAbstract-ValueAsString 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract.ValueAsString')
  - [Clone()](#M-RandomDataGenerator-FieldOptions-FieldOptionsAbstract-Clone 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract.Clone')
- [FieldOptionsBoolean](#T-RandomDataGenerator-FieldOptions-FieldOptionsBoolean 'RandomDataGenerator.FieldOptions.FieldOptionsBoolean')
- [FieldOptionsByte](#T-RandomDataGenerator-FieldOptions-FieldOptionsByte 'RandomDataGenerator.FieldOptions.FieldOptionsByte')
  - [Max](#P-RandomDataGenerator-FieldOptions-FieldOptionsByte-Max 'RandomDataGenerator.FieldOptions.FieldOptionsByte.Max')
  - [Min](#P-RandomDataGenerator-FieldOptions-FieldOptionsByte-Min 'RandomDataGenerator.FieldOptions.FieldOptionsByte.Min')
- [FieldOptionsBytes](#T-RandomDataGenerator-FieldOptions-FieldOptionsBytes 'RandomDataGenerator.FieldOptions.FieldOptionsBytes')
  - [Max](#P-RandomDataGenerator-FieldOptions-FieldOptionsBytes-Max 'RandomDataGenerator.FieldOptions.FieldOptionsBytes.Max')
  - [Min](#P-RandomDataGenerator-FieldOptions-FieldOptionsBytes-Min 'RandomDataGenerator.FieldOptions.FieldOptionsBytes.Min')
- [FieldOptionsCCN](#T-RandomDataGenerator-FieldOptions-FieldOptionsCCN 'RandomDataGenerator.FieldOptions.FieldOptionsCCN')
  - [CardIssuer](#P-RandomDataGenerator-FieldOptions-FieldOptionsCCN-CardIssuer 'RandomDataGenerator.FieldOptions.FieldOptionsCCN.CardIssuer')
  - [Length](#P-RandomDataGenerator-FieldOptions-FieldOptionsCCN-Length 'RandomDataGenerator.FieldOptions.FieldOptionsCCN.Length')
- [FieldOptionsCity](#T-RandomDataGenerator-FieldOptions-FieldOptionsCity 'RandomDataGenerator.FieldOptions.FieldOptionsCity')
- [FieldOptionsCountry](#T-RandomDataGenerator-FieldOptions-FieldOptionsCountry 'RandomDataGenerator.FieldOptions.FieldOptionsCountry')
- [FieldOptionsDateTime](#T-RandomDataGenerator-FieldOptions-FieldOptionsDateTime 'RandomDataGenerator.FieldOptions.FieldOptionsDateTime')
  - [DefaultFormat](#F-RandomDataGenerator-FieldOptions-FieldOptionsDateTime-DefaultFormat 'RandomDataGenerator.FieldOptions.FieldOptionsDateTime.DefaultFormat')
  - [Format](#P-RandomDataGenerator-FieldOptions-FieldOptionsDateTime-Format 'RandomDataGenerator.FieldOptions.FieldOptionsDateTime.Format')
  - [From](#P-RandomDataGenerator-FieldOptions-FieldOptionsDateTime-From 'RandomDataGenerator.FieldOptions.FieldOptionsDateTime.From')
  - [IncludeTime](#P-RandomDataGenerator-FieldOptions-FieldOptionsDateTime-IncludeTime 'RandomDataGenerator.FieldOptions.FieldOptionsDateTime.IncludeTime')
  - [To](#P-RandomDataGenerator-FieldOptions-FieldOptionsDateTime-To 'RandomDataGenerator.FieldOptions.FieldOptionsDateTime.To')
- [FieldOptionsDouble](#T-RandomDataGenerator-FieldOptions-FieldOptionsDouble 'RandomDataGenerator.FieldOptions.FieldOptionsDouble')
  - [Max](#P-RandomDataGenerator-FieldOptions-FieldOptionsDouble-Max 'RandomDataGenerator.FieldOptions.FieldOptionsDouble.Max')
  - [Min](#P-RandomDataGenerator-FieldOptions-FieldOptionsDouble-Min 'RandomDataGenerator.FieldOptions.FieldOptionsDouble.Min')
- [FieldOptionsEmailAddress](#T-RandomDataGenerator-FieldOptions-FieldOptionsEmailAddress 'RandomDataGenerator.FieldOptions.FieldOptionsEmailAddress')
  - [Female](#P-RandomDataGenerator-FieldOptions-FieldOptionsEmailAddress-Female 'RandomDataGenerator.FieldOptions.FieldOptionsEmailAddress.Female')
  - [Left2Right](#P-RandomDataGenerator-FieldOptions-FieldOptionsEmailAddress-Left2Right 'RandomDataGenerator.FieldOptions.FieldOptionsEmailAddress.Left2Right')
  - [Male](#P-RandomDataGenerator-FieldOptions-FieldOptionsEmailAddress-Male 'RandomDataGenerator.FieldOptions.FieldOptionsEmailAddress.Male')
- [FieldOptionsFactory](#T-RandomDataGenerator-FieldOptions-FieldOptionsFactory 'RandomDataGenerator.FieldOptions.FieldOptionsFactory')
  - [GetFieldOptions(subFieldType)](#M-RandomDataGenerator-FieldOptions-FieldOptionsFactory-GetFieldOptions-RandomDataGenerator-Enums-SubFieldType- 'RandomDataGenerator.FieldOptions.FieldOptionsFactory.GetFieldOptions(RandomDataGenerator.Enums.SubFieldType)')
  - [GetFieldOptions(name,properties)](#M-RandomDataGenerator-FieldOptions-FieldOptionsFactory-GetFieldOptions-System-String,System-Collections-Generic-Dictionary{System-String,System-Object}- 'RandomDataGenerator.FieldOptions.FieldOptionsFactory.GetFieldOptions(System.String,System.Collections.Generic.Dictionary{System.String,System.Object})')
- [FieldOptionsFirstName](#T-RandomDataGenerator-FieldOptions-FieldOptionsFirstName 'RandomDataGenerator.FieldOptions.FieldOptionsFirstName')
  - [Female](#P-RandomDataGenerator-FieldOptions-FieldOptionsFirstName-Female 'RandomDataGenerator.FieldOptions.FieldOptionsFirstName.Female')
  - [Male](#P-RandomDataGenerator-FieldOptions-FieldOptionsFirstName-Male 'RandomDataGenerator.FieldOptions.FieldOptionsFirstName.Male')
- [FieldOptionsFloat](#T-RandomDataGenerator-FieldOptions-FieldOptionsFloat 'RandomDataGenerator.FieldOptions.FieldOptionsFloat')
  - [Max](#P-RandomDataGenerator-FieldOptions-FieldOptionsFloat-Max 'RandomDataGenerator.FieldOptions.FieldOptionsFloat.Max')
  - [Min](#P-RandomDataGenerator-FieldOptions-FieldOptionsFloat-Min 'RandomDataGenerator.FieldOptions.FieldOptionsFloat.Min')
- [FieldOptionsFullName](#T-RandomDataGenerator-FieldOptions-FieldOptionsFullName 'RandomDataGenerator.FieldOptions.FieldOptionsFullName')
  - [Female](#P-RandomDataGenerator-FieldOptions-FieldOptionsFullName-Female 'RandomDataGenerator.FieldOptions.FieldOptionsFullName.Female')
  - [Left2Right](#P-RandomDataGenerator-FieldOptions-FieldOptionsFullName-Left2Right 'RandomDataGenerator.FieldOptions.FieldOptionsFullName.Left2Right')
  - [Male](#P-RandomDataGenerator-FieldOptions-FieldOptionsFullName-Male 'RandomDataGenerator.FieldOptions.FieldOptionsFullName.Male')
- [FieldOptionsGuid](#T-RandomDataGenerator-FieldOptions-FieldOptionsGuid 'RandomDataGenerator.FieldOptions.FieldOptionsGuid')
  - [Format](#P-RandomDataGenerator-FieldOptions-FieldOptionsGuid-Format 'RandomDataGenerator.FieldOptions.FieldOptionsGuid.Format')
  - [Uppercase](#P-RandomDataGenerator-FieldOptions-FieldOptionsGuid-Uppercase 'RandomDataGenerator.FieldOptions.FieldOptionsGuid.Uppercase')
- [FieldOptionsIBAN](#T-RandomDataGenerator-FieldOptions-FieldOptionsIBAN 'RandomDataGenerator.FieldOptions.FieldOptionsIBAN')
  - [CountryCode](#P-RandomDataGenerator-FieldOptions-FieldOptionsIBAN-CountryCode 'RandomDataGenerator.FieldOptions.FieldOptionsIBAN.CountryCode')
  - [Type](#P-RandomDataGenerator-FieldOptions-FieldOptionsIBAN-Type 'RandomDataGenerator.FieldOptions.FieldOptionsIBAN.Type')
- [FieldOptionsIPv4Address](#T-RandomDataGenerator-FieldOptions-FieldOptionsIPv4Address 'RandomDataGenerator.FieldOptions.FieldOptionsIPv4Address')
  - [Max](#P-RandomDataGenerator-FieldOptions-FieldOptionsIPv4Address-Max 'RandomDataGenerator.FieldOptions.FieldOptionsIPv4Address.Max')
  - [Min](#P-RandomDataGenerator-FieldOptions-FieldOptionsIPv4Address-Min 'RandomDataGenerator.FieldOptions.FieldOptionsIPv4Address.Min')
- [FieldOptionsIPv6Address](#T-RandomDataGenerator-FieldOptions-FieldOptionsIPv6Address 'RandomDataGenerator.FieldOptions.FieldOptionsIPv6Address')
  - [Max](#P-RandomDataGenerator-FieldOptions-FieldOptionsIPv6Address-Max 'RandomDataGenerator.FieldOptions.FieldOptionsIPv6Address.Max')
  - [Min](#P-RandomDataGenerator-FieldOptions-FieldOptionsIPv6Address-Min 'RandomDataGenerator.FieldOptions.FieldOptionsIPv6Address.Min')
  - [Uppercase](#P-RandomDataGenerator-FieldOptions-FieldOptionsIPv6Address-Uppercase 'RandomDataGenerator.FieldOptions.FieldOptionsIPv6Address.Uppercase')
- [FieldOptionsInteger](#T-RandomDataGenerator-FieldOptions-FieldOptionsInteger 'RandomDataGenerator.FieldOptions.FieldOptionsInteger')
  - [Max](#P-RandomDataGenerator-FieldOptions-FieldOptionsInteger-Max 'RandomDataGenerator.FieldOptions.FieldOptionsInteger.Max')
  - [Min](#P-RandomDataGenerator-FieldOptions-FieldOptionsInteger-Min 'RandomDataGenerator.FieldOptions.FieldOptionsInteger.Min')
- [FieldOptionsLastName](#T-RandomDataGenerator-FieldOptions-FieldOptionsLastName 'RandomDataGenerator.FieldOptions.FieldOptionsLastName')
- [FieldOptionsLong](#T-RandomDataGenerator-FieldOptions-FieldOptionsLong 'RandomDataGenerator.FieldOptions.FieldOptionsLong')
  - [Max](#P-RandomDataGenerator-FieldOptions-FieldOptionsLong-Max 'RandomDataGenerator.FieldOptions.FieldOptionsLong.Max')
  - [Min](#P-RandomDataGenerator-FieldOptions-FieldOptionsLong-Min 'RandomDataGenerator.FieldOptions.FieldOptionsLong.Min')
- [FieldOptionsMACAddress](#T-RandomDataGenerator-FieldOptions-FieldOptionsMACAddress 'RandomDataGenerator.FieldOptions.FieldOptionsMACAddress')
  - [Max](#P-RandomDataGenerator-FieldOptions-FieldOptionsMACAddress-Max 'RandomDataGenerator.FieldOptions.FieldOptionsMACAddress.Max')
  - [Min](#P-RandomDataGenerator-FieldOptions-FieldOptionsMACAddress-Min 'RandomDataGenerator.FieldOptions.FieldOptionsMACAddress.Min')
  - [Separator](#P-RandomDataGenerator-FieldOptions-FieldOptionsMACAddress-Separator 'RandomDataGenerator.FieldOptions.FieldOptionsMACAddress.Separator')
  - [Uppercase](#P-RandomDataGenerator-FieldOptions-FieldOptionsMACAddress-Uppercase 'RandomDataGenerator.FieldOptions.FieldOptionsMACAddress.Uppercase')
- [FieldOptionsNumber\`1](#T-RandomDataGenerator-FieldOptions-FieldOptionsNumber`1 'RandomDataGenerator.FieldOptions.FieldOptionsNumber`1')
  - [Max](#P-RandomDataGenerator-FieldOptions-FieldOptionsNumber`1-Max 'RandomDataGenerator.FieldOptions.FieldOptionsNumber`1.Max')
  - [Min](#P-RandomDataGenerator-FieldOptions-FieldOptionsNumber`1-Min 'RandomDataGenerator.FieldOptions.FieldOptionsNumber`1.Min')
- [FieldOptionsShort](#T-RandomDataGenerator-FieldOptions-FieldOptionsShort 'RandomDataGenerator.FieldOptions.FieldOptionsShort')
  - [Max](#P-RandomDataGenerator-FieldOptions-FieldOptionsShort-Max 'RandomDataGenerator.FieldOptions.FieldOptionsShort.Max')
  - [Min](#P-RandomDataGenerator-FieldOptions-FieldOptionsShort-Min 'RandomDataGenerator.FieldOptions.FieldOptionsShort.Min')
- [FieldOptionsStringList](#T-RandomDataGenerator-FieldOptions-FieldOptionsStringList 'RandomDataGenerator.FieldOptions.FieldOptionsStringList')
  - [Values](#P-RandomDataGenerator-FieldOptions-FieldOptionsStringList-Values 'RandomDataGenerator.FieldOptions.FieldOptionsStringList.Values')
- [FieldOptionsText](#T-RandomDataGenerator-FieldOptions-FieldOptionsText 'RandomDataGenerator.FieldOptions.FieldOptionsText')
  - [Max](#P-RandomDataGenerator-FieldOptions-FieldOptionsText-Max 'RandomDataGenerator.FieldOptions.FieldOptionsText.Max')
  - [Min](#P-RandomDataGenerator-FieldOptions-FieldOptionsText-Min 'RandomDataGenerator.FieldOptions.FieldOptionsText.Min')
  - [UseLetter](#P-RandomDataGenerator-FieldOptions-FieldOptionsText-UseLetter 'RandomDataGenerator.FieldOptions.FieldOptionsText.UseLetter')
  - [UseLowercase](#P-RandomDataGenerator-FieldOptions-FieldOptionsText-UseLowercase 'RandomDataGenerator.FieldOptions.FieldOptionsText.UseLowercase')
  - [UseNumber](#P-RandomDataGenerator-FieldOptions-FieldOptionsText-UseNumber 'RandomDataGenerator.FieldOptions.FieldOptionsText.UseNumber')
  - [UseSpace](#P-RandomDataGenerator-FieldOptions-FieldOptionsText-UseSpace 'RandomDataGenerator.FieldOptions.FieldOptionsText.UseSpace')
  - [UseSpecial](#P-RandomDataGenerator-FieldOptions-FieldOptionsText-UseSpecial 'RandomDataGenerator.FieldOptions.FieldOptionsText.UseSpecial')
  - [UseUppercase](#P-RandomDataGenerator-FieldOptions-FieldOptionsText-UseUppercase 'RandomDataGenerator.FieldOptions.FieldOptionsText.UseUppercase')
- [FieldOptionsTextLipsum](#T-RandomDataGenerator-FieldOptions-FieldOptionsTextLipsum 'RandomDataGenerator.FieldOptions.FieldOptionsTextLipsum')
  - [Paragraphs](#P-RandomDataGenerator-FieldOptions-FieldOptionsTextLipsum-Paragraphs 'RandomDataGenerator.FieldOptions.FieldOptionsTextLipsum.Paragraphs')
- [FieldOptionsTextNaughtyStrings](#T-RandomDataGenerator-FieldOptions-FieldOptionsTextNaughtyStrings 'RandomDataGenerator.FieldOptions.FieldOptionsTextNaughtyStrings')
  - [Categories](#P-RandomDataGenerator-FieldOptions-FieldOptionsTextNaughtyStrings-Categories 'RandomDataGenerator.FieldOptions.FieldOptionsTextNaughtyStrings.Categories')
- [FieldOptionsTextRegex](#T-RandomDataGenerator-FieldOptions-FieldOptionsTextRegex 'RandomDataGenerator.FieldOptions.FieldOptionsTextRegex')
  - [Pattern](#P-RandomDataGenerator-FieldOptions-FieldOptionsTextRegex-Pattern 'RandomDataGenerator.FieldOptions.FieldOptionsTextRegex.Pattern')
- [FieldOptionsTextWords](#T-RandomDataGenerator-FieldOptions-FieldOptionsTextWords 'RandomDataGenerator.FieldOptions.FieldOptionsTextWords')
  - [Max](#P-RandomDataGenerator-FieldOptions-FieldOptionsTextWords-Max 'RandomDataGenerator.FieldOptions.FieldOptionsTextWords.Max')
  - [Min](#P-RandomDataGenerator-FieldOptions-FieldOptionsTextWords-Min 'RandomDataGenerator.FieldOptions.FieldOptionsTextWords.Min')
- [FieldOptionsTimeSpan](#T-RandomDataGenerator-FieldOptions-FieldOptionsTimeSpan 'RandomDataGenerator.FieldOptions.FieldOptionsTimeSpan')
  - [DefaultFormat](#F-RandomDataGenerator-FieldOptions-FieldOptionsTimeSpan-DefaultFormat 'RandomDataGenerator.FieldOptions.FieldOptionsTimeSpan.DefaultFormat')
  - [Format](#P-RandomDataGenerator-FieldOptions-FieldOptionsTimeSpan-Format 'RandomDataGenerator.FieldOptions.FieldOptionsTimeSpan.Format')
  - [From](#P-RandomDataGenerator-FieldOptions-FieldOptionsTimeSpan-From 'RandomDataGenerator.FieldOptions.FieldOptionsTimeSpan.From')
  - [IncludeMilliseconds](#P-RandomDataGenerator-FieldOptions-FieldOptionsTimeSpan-IncludeMilliseconds 'RandomDataGenerator.FieldOptions.FieldOptionsTimeSpan.IncludeMilliseconds')
  - [To](#P-RandomDataGenerator-FieldOptions-FieldOptionsTimeSpan-To 'RandomDataGenerator.FieldOptions.FieldOptionsTimeSpan.To')
- [FieldType](#T-RandomDataGenerator-Enums-FieldType 'RandomDataGenerator.Enums.FieldType')
  - [Human](#F-RandomDataGenerator-Enums-FieldType-Human 'RandomDataGenerator.Enums.FieldType.Human')
  - [IT](#F-RandomDataGenerator-Enums-FieldType-IT 'RandomDataGenerator.Enums.FieldType.IT')
  - [Location](#F-RandomDataGenerator-Enums-FieldType-Location 'RandomDataGenerator.Enums.FieldType.Location')
  - [None](#F-RandomDataGenerator-Enums-FieldType-None 'RandomDataGenerator.Enums.FieldType.None')
  - [Numbers](#F-RandomDataGenerator-Enums-FieldType-Numbers 'RandomDataGenerator.Enums.FieldType.Numbers')
  - [Set](#F-RandomDataGenerator-Enums-FieldType-Set 'RandomDataGenerator.Enums.FieldType.Set')
  - [Text](#F-RandomDataGenerator-Enums-FieldType-Text 'RandomDataGenerator.Enums.FieldType.Text')
  - [Time](#F-RandomDataGenerator-Enums-FieldType-Time 'RandomDataGenerator.Enums.FieldType.Time')
- [IFieldOptionsBytes](#T-RandomDataGenerator-FieldOptions-IFieldOptionsBytes 'RandomDataGenerator.FieldOptions.IFieldOptionsBytes')
  - [Max](#P-RandomDataGenerator-FieldOptions-IFieldOptionsBytes-Max 'RandomDataGenerator.FieldOptions.IFieldOptionsBytes.Max')
  - [Min](#P-RandomDataGenerator-FieldOptions-IFieldOptionsBytes-Min 'RandomDataGenerator.FieldOptions.IFieldOptionsBytes.Min')
- [IFieldOptionsDateTime](#T-RandomDataGenerator-FieldOptions-IFieldOptionsDateTime 'RandomDataGenerator.FieldOptions.IFieldOptionsDateTime')
  - [From](#P-RandomDataGenerator-FieldOptions-IFieldOptionsDateTime-From 'RandomDataGenerator.FieldOptions.IFieldOptionsDateTime.From')
  - [IncludeTime](#P-RandomDataGenerator-FieldOptions-IFieldOptionsDateTime-IncludeTime 'RandomDataGenerator.FieldOptions.IFieldOptionsDateTime.IncludeTime')
  - [To](#P-RandomDataGenerator-FieldOptions-IFieldOptionsDateTime-To 'RandomDataGenerator.FieldOptions.IFieldOptionsDateTime.To')
- [IFieldOptionsGuid](#T-RandomDataGenerator-FieldOptions-IFieldOptionsGuid 'RandomDataGenerator.FieldOptions.IFieldOptionsGuid')
  - [Uppercase](#P-RandomDataGenerator-FieldOptions-IFieldOptionsGuid-Uppercase 'RandomDataGenerator.FieldOptions.IFieldOptionsGuid.Uppercase')
- [IFieldOptionsNumber\`1](#T-RandomDataGenerator-FieldOptions-IFieldOptionsNumber`1 'RandomDataGenerator.FieldOptions.IFieldOptionsNumber`1')
- [IFieldOptionsString](#T-RandomDataGenerator-FieldOptions-IFieldOptionsString 'RandomDataGenerator.FieldOptions.IFieldOptionsString')
- [IFieldOptionsTimeSpan](#T-RandomDataGenerator-FieldOptions-IFieldOptionsTimeSpan 'RandomDataGenerator.FieldOptions.IFieldOptionsTimeSpan')
  - [Format](#P-RandomDataGenerator-FieldOptions-IFieldOptionsTimeSpan-Format 'RandomDataGenerator.FieldOptions.IFieldOptionsTimeSpan.Format')
  - [From](#P-RandomDataGenerator-FieldOptions-IFieldOptionsTimeSpan-From 'RandomDataGenerator.FieldOptions.IFieldOptionsTimeSpan.From')
  - [To](#P-RandomDataGenerator-FieldOptions-IFieldOptionsTimeSpan-To 'RandomDataGenerator.FieldOptions.IFieldOptionsTimeSpan.To')
- [IRandomizerBytes](#T-RandomDataGenerator-Randomizers-IRandomizerBytes 'RandomDataGenerator.Randomizers.IRandomizerBytes')
  - [Generate()](#M-RandomDataGenerator-Randomizers-IRandomizerBytes-Generate 'RandomDataGenerator.Randomizers.IRandomizerBytes.Generate')
  - [GenerateAsASCIIString()](#M-RandomDataGenerator-Randomizers-IRandomizerBytes-GenerateAsASCIIString 'RandomDataGenerator.Randomizers.IRandomizerBytes.GenerateAsASCIIString')
  - [GenerateAsBase64String()](#M-RandomDataGenerator-Randomizers-IRandomizerBytes-GenerateAsBase64String 'RandomDataGenerator.Randomizers.IRandomizerBytes.GenerateAsBase64String')
  - [GenerateAsString(encoding)](#M-RandomDataGenerator-Randomizers-IRandomizerBytes-GenerateAsString-System-Text-Encoding- 'RandomDataGenerator.Randomizers.IRandomizerBytes.GenerateAsString(System.Text.Encoding)')
  - [GenerateAsUTF8String()](#M-RandomDataGenerator-Randomizers-IRandomizerBytes-GenerateAsUTF8String 'RandomDataGenerator.Randomizers.IRandomizerBytes.GenerateAsUTF8String')
- [IRandomizerDateTime](#T-RandomDataGenerator-Randomizers-IRandomizerDateTime 'RandomDataGenerator.Randomizers.IRandomizerDateTime')
  - [Generate()](#M-RandomDataGenerator-Randomizers-IRandomizerDateTime-Generate 'RandomDataGenerator.Randomizers.IRandomizerDateTime.Generate')
  - [GenerateAsString()](#M-RandomDataGenerator-Randomizers-IRandomizerDateTime-GenerateAsString 'RandomDataGenerator.Randomizers.IRandomizerDateTime.GenerateAsString')
- [IRandomizerGuid](#T-RandomDataGenerator-Randomizers-IRandomizerGuid 'RandomDataGenerator.Randomizers.IRandomizerGuid')
  - [Generate()](#M-RandomDataGenerator-Randomizers-IRandomizerGuid-Generate 'RandomDataGenerator.Randomizers.IRandomizerGuid.Generate')
  - [GenerateAsString()](#M-RandomDataGenerator-Randomizers-IRandomizerGuid-GenerateAsString 'RandomDataGenerator.Randomizers.IRandomizerGuid.GenerateAsString')
- [IRandomizerNumber\`1](#T-RandomDataGenerator-Randomizers-IRandomizerNumber`1 'RandomDataGenerator.Randomizers.IRandomizerNumber`1')
  - [Generate()](#M-RandomDataGenerator-Randomizers-IRandomizerNumber`1-Generate 'RandomDataGenerator.Randomizers.IRandomizerNumber`1.Generate')
- [IRandomizerString](#T-RandomDataGenerator-Randomizers-IRandomizerString 'RandomDataGenerator.Randomizers.IRandomizerString')
  - [Generate()](#M-RandomDataGenerator-Randomizers-IRandomizerString-Generate 'RandomDataGenerator.Randomizers.IRandomizerString.Generate')
  - [Generate(upperCase)](#M-RandomDataGenerator-Randomizers-IRandomizerString-Generate-System-Boolean- 'RandomDataGenerator.Randomizers.IRandomizerString.Generate(System.Boolean)')
- [IRandomizerTimeSpan](#T-RandomDataGenerator-Randomizers-IRandomizerTimeSpan 'RandomDataGenerator.Randomizers.IRandomizerTimeSpan')
  - [Generate()](#M-RandomDataGenerator-Randomizers-IRandomizerTimeSpan-Generate 'RandomDataGenerator.Randomizers.IRandomizerTimeSpan.Generate')
  - [GenerateAsString()](#M-RandomDataGenerator-Randomizers-IRandomizerTimeSpan-GenerateAsString 'RandomDataGenerator.Randomizers.IRandomizerTimeSpan.GenerateAsString')
- [ListEqualityComparer\`1](#T-Fare-ListEqualityComparer`1 'Fare.ListEqualityComparer`1')
  - [Equals()](#M-Fare-ListEqualityComparer`1-Equals-System-Collections-Generic-List{`0},System-Collections-Generic-List{`0}- 'Fare.ListEqualityComparer`1.Equals(System.Collections.Generic.List{`0},System.Collections.Generic.List{`0})')
  - [Equals()](#M-Fare-ListEqualityComparer`1-Equals-Fare-ListEqualityComparer{`0}- 'Fare.ListEqualityComparer`1.Equals(Fare.ListEqualityComparer{`0})')
  - [Equals()](#M-Fare-ListEqualityComparer`1-Equals-System-Object- 'Fare.ListEqualityComparer`1.Equals(System.Object)')
  - [GetHashCode()](#M-Fare-ListEqualityComparer`1-GetHashCode-System-Collections-Generic-List{`0}- 'Fare.ListEqualityComparer`1.GetHashCode(System.Collections.Generic.List{`0})')
  - [GetHashCode()](#M-Fare-ListEqualityComparer`1-GetHashCode 'Fare.ListEqualityComparer`1.GetHashCode')
  - [op_Equality(left,right)](#M-Fare-ListEqualityComparer`1-op_Equality-Fare-ListEqualityComparer{`0},Fare-ListEqualityComparer{`0}- 'Fare.ListEqualityComparer`1.op_Equality(Fare.ListEqualityComparer{`0},Fare.ListEqualityComparer{`0})')
  - [op_Inequality(left,right)](#M-Fare-ListEqualityComparer`1-op_Inequality-Fare-ListEqualityComparer{`0},Fare-ListEqualityComparer{`0}- 'Fare.ListEqualityComparer`1.op_Inequality(Fare.ListEqualityComparer{`0},Fare.ListEqualityComparer{`0})')
- [MinimizationOperations](#T-Fare-MinimizationOperations 'Fare.MinimizationOperations')
  - [Minimize(a)](#M-Fare-MinimizationOperations-Minimize-Fare-Automaton- 'Fare.MinimizationOperations.Minimize(Fare.Automaton)')
  - [MinimizeBrzozowski(a)](#M-Fare-MinimizationOperations-MinimizeBrzozowski-Fare-Automaton- 'Fare.MinimizationOperations.MinimizeBrzozowski(Fare.Automaton)')
  - [MinimizeHopcroft(a)](#M-Fare-MinimizationOperations-MinimizeHopcroft-Fare-Automaton- 'Fare.MinimizationOperations.MinimizeHopcroft(Fare.Automaton)')
  - [MinimizeHuffman(a)](#M-Fare-MinimizationOperations-MinimizeHuffman-Fare-Automaton- 'Fare.MinimizationOperations.MinimizeHuffman(Fare.Automaton)')
- [RandomStringGenerator](#T-RandomDataGenerator-Generators-RandomStringGenerator 'RandomDataGenerator.Generators.RandomStringGenerator')
  - [RepeatCharacters](#F-RandomDataGenerator-Generators-RandomStringGenerator-RepeatCharacters 'RandomDataGenerator.Generators.RandomStringGenerator.RepeatCharacters')
  - [UniqueStrings](#F-RandomDataGenerator-Generators-RandomStringGenerator-UniqueStrings 'RandomDataGenerator.Generators.RandomStringGenerator.UniqueStrings')
  - [LowerCaseCharacters](#P-RandomDataGenerator-Generators-RandomStringGenerator-LowerCaseCharacters 'RandomDataGenerator.Generators.RandomStringGenerator.LowerCaseCharacters')
  - [MinLowerCaseCharacters](#P-RandomDataGenerator-Generators-RandomStringGenerator-MinLowerCaseCharacters 'RandomDataGenerator.Generators.RandomStringGenerator.MinLowerCaseCharacters')
  - [MinNumericCharacters](#P-RandomDataGenerator-Generators-RandomStringGenerator-MinNumericCharacters 'RandomDataGenerator.Generators.RandomStringGenerator.MinNumericCharacters')
  - [MinSpaceCharacters](#P-RandomDataGenerator-Generators-RandomStringGenerator-MinSpaceCharacters 'RandomDataGenerator.Generators.RandomStringGenerator.MinSpaceCharacters')
  - [MinSpecialCharacters](#P-RandomDataGenerator-Generators-RandomStringGenerator-MinSpecialCharacters 'RandomDataGenerator.Generators.RandomStringGenerator.MinSpecialCharacters')
  - [MinUpperCaseCharacters](#P-RandomDataGenerator-Generators-RandomStringGenerator-MinUpperCaseCharacters 'RandomDataGenerator.Generators.RandomStringGenerator.MinUpperCaseCharacters')
  - [NumericCharacters](#P-RandomDataGenerator-Generators-RandomStringGenerator-NumericCharacters 'RandomDataGenerator.Generators.RandomStringGenerator.NumericCharacters')
  - [Pattern](#P-RandomDataGenerator-Generators-RandomStringGenerator-Pattern 'RandomDataGenerator.Generators.RandomStringGenerator.Pattern')
  - [SpaceCharacters](#P-RandomDataGenerator-Generators-RandomStringGenerator-SpaceCharacters 'RandomDataGenerator.Generators.RandomStringGenerator.SpaceCharacters')
  - [SpecialCharacters](#P-RandomDataGenerator-Generators-RandomStringGenerator-SpecialCharacters 'RandomDataGenerator.Generators.RandomStringGenerator.SpecialCharacters')
  - [UpperCaseCharacters](#P-RandomDataGenerator-Generators-RandomStringGenerator-UpperCaseCharacters 'RandomDataGenerator.Generators.RandomStringGenerator.UpperCaseCharacters')
  - [UseLowerCaseCharacters](#P-RandomDataGenerator-Generators-RandomStringGenerator-UseLowerCaseCharacters 'RandomDataGenerator.Generators.RandomStringGenerator.UseLowerCaseCharacters')
  - [UseNumericCharacters](#P-RandomDataGenerator-Generators-RandomStringGenerator-UseNumericCharacters 'RandomDataGenerator.Generators.RandomStringGenerator.UseNumericCharacters')
  - [UseSpaces](#P-RandomDataGenerator-Generators-RandomStringGenerator-UseSpaces 'RandomDataGenerator.Generators.RandomStringGenerator.UseSpaces')
  - [UseSpecialCharacters](#P-RandomDataGenerator-Generators-RandomStringGenerator-UseSpecialCharacters 'RandomDataGenerator.Generators.RandomStringGenerator.UseSpecialCharacters')
  - [UseUpperCaseCharacters](#P-RandomDataGenerator-Generators-RandomStringGenerator-UseUpperCaseCharacters 'RandomDataGenerator.Generators.RandomStringGenerator.UseUpperCaseCharacters')
  - [AddExistingString()](#M-RandomDataGenerator-Generators-RandomStringGenerator-AddExistingString-System-String- 'RandomDataGenerator.Generators.RandomStringGenerator.AddExistingString(System.String)')
  - [Generate(pattern)](#M-RandomDataGenerator-Generators-RandomStringGenerator-Generate-System-String- 'RandomDataGenerator.Generators.RandomStringGenerator.Generate(System.String)')
  - [Generate(minLength,maxLength)](#M-RandomDataGenerator-Generators-RandomStringGenerator-Generate-System-Int32,System-Int32- 'RandomDataGenerator.Generators.RandomStringGenerator.Generate(System.Int32,System.Int32)')
  - [Generate(fixedLength)](#M-RandomDataGenerator-Generators-RandomStringGenerator-Generate-System-Int32- 'RandomDataGenerator.Generators.RandomStringGenerator.Generate(System.Int32)')
  - [GenerateAlgoWithLimits()](#M-RandomDataGenerator-Generators-RandomStringGenerator-GenerateAlgoWithLimits-System-Int32- 'RandomDataGenerator.Generators.RandomStringGenerator.GenerateAlgoWithLimits(System.Int32)')
  - [GenerateString()](#M-RandomDataGenerator-Generators-RandomStringGenerator-GenerateString-System-Int32- 'RandomDataGenerator.Generators.RandomStringGenerator.GenerateString(System.Int32)')
  - [GetRandomCharFromArray(array,existentItems)](#M-RandomDataGenerator-Generators-RandomStringGenerator-GetRandomCharFromArray-System-Char[],System-Collections-Generic-List{System-Char}- 'RandomDataGenerator.Generators.RandomStringGenerator.GetRandomCharFromArray(System.Char[],System.Collections.Generic.List{System.Char})')
  - [GetRandomInt()](#M-RandomDataGenerator-Generators-RandomStringGenerator-GetRandomInt 'RandomDataGenerator.Generators.RandomStringGenerator.GetRandomInt')
  - [PatternDrivenAlgo()](#M-RandomDataGenerator-Generators-RandomStringGenerator-PatternDrivenAlgo-System-String- 'RandomDataGenerator.Generators.RandomStringGenerator.PatternDrivenAlgo(System.String)')
  - [SimpleGenerateAlgo()](#M-RandomDataGenerator-Generators-RandomStringGenerator-SimpleGenerateAlgo-System-Int32- 'RandomDataGenerator.Generators.RandomStringGenerator.SimpleGenerateAlgo(System.Int32)')
- [RandomValueGenerator](#T-RandomDataGenerator-Generators-RandomValueGenerator 'RandomDataGenerator.Generators.RandomValueGenerator')
  - [Next()](#M-RandomDataGenerator-Generators-RandomValueGenerator-Next 'RandomDataGenerator.Generators.RandomValueGenerator.Next')
  - [Next()](#M-RandomDataGenerator-Generators-RandomValueGenerator-Next-System-Byte,System-Byte- 'RandomDataGenerator.Generators.RandomValueGenerator.Next(System.Byte,System.Byte)')
  - [Next()](#M-RandomDataGenerator-Generators-RandomValueGenerator-Next-System-Int16,System-Int16- 'RandomDataGenerator.Generators.RandomValueGenerator.Next(System.Int16,System.Int16)')
  - [Next()](#M-RandomDataGenerator-Generators-RandomValueGenerator-Next-System-Int32,System-Int32- 'RandomDataGenerator.Generators.RandomValueGenerator.Next(System.Int32,System.Int32)')
  - [Next()](#M-RandomDataGenerator-Generators-RandomValueGenerator-Next-System-Int64,System-Int64- 'RandomDataGenerator.Generators.RandomValueGenerator.Next(System.Int64,System.Int64)')
  - [Next()](#M-RandomDataGenerator-Generators-RandomValueGenerator-Next-System-Single,System-Single- 'RandomDataGenerator.Generators.RandomValueGenerator.Next(System.Single,System.Single)')
  - [Next()](#M-RandomDataGenerator-Generators-RandomValueGenerator-Next-System-Double,System-Double- 'RandomDataGenerator.Generators.RandomValueGenerator.Next(System.Double,System.Double)')
  - [Next()](#M-RandomDataGenerator-Generators-RandomValueGenerator-Next-System-DateTime,System-DateTime- 'RandomDataGenerator.Generators.RandomValueGenerator.Next(System.DateTime,System.DateTime)')
  - [Next()](#M-RandomDataGenerator-Generators-RandomValueGenerator-Next-System-TimeSpan,System-TimeSpan- 'RandomDataGenerator.Generators.RandomValueGenerator.Next(System.TimeSpan,System.TimeSpan)')
  - [NextBoolean()](#M-RandomDataGenerator-Generators-RandomValueGenerator-NextBoolean 'RandomDataGenerator.Generators.RandomValueGenerator.NextBoolean')
  - [NextBytes(min,max)](#M-RandomDataGenerator-Generators-RandomValueGenerator-NextBytes-System-Int32,System-Int32- 'RandomDataGenerator.Generators.RandomValueGenerator.NextBytes(System.Int32,System.Int32)')
  - [NextDouble()](#M-RandomDataGenerator-Generators-RandomValueGenerator-NextDouble 'RandomDataGenerator.Generators.RandomValueGenerator.NextDouble')
  - [NextEnum()](#M-RandomDataGenerator-Generators-RandomValueGenerator-NextEnum-System-Type- 'RandomDataGenerator.Generators.RandomValueGenerator.NextEnum(System.Type)')
  - [NextExponential()](#M-RandomDataGenerator-Generators-RandomValueGenerator-NextExponential 'RandomDataGenerator.Generators.RandomValueGenerator.NextExponential')
  - [NextNormal()](#M-RandomDataGenerator-Generators-RandomValueGenerator-NextNormal 'RandomDataGenerator.Generators.RandomValueGenerator.NextNormal')
  - [NextUniform()](#M-RandomDataGenerator-Generators-RandomValueGenerator-NextUniform 'RandomDataGenerator.Generators.RandomValueGenerator.NextUniform')
  - [Next\`\`1(min,max)](#M-RandomDataGenerator-Generators-RandomValueGenerator-Next``1-``0,``0- 'RandomDataGenerator.Generators.RandomValueGenerator.Next``1(``0,``0)')
- [Randomizer](#T-Bb-Randomizer 'Bb.Randomizer')
  - [GenerateBinary(min,max)](#M-Bb-Randomizer-GenerateBinary-System-Int32,System-Int32- 'Bb.Randomizer.GenerateBinary(System.Int32,System.Int32)')
  - [GenerateBoolean()](#M-Bb-Randomizer-GenerateBoolean 'Bb.Randomizer.GenerateBoolean')
  - [GenerateByte(min,max,useNullValues)](#M-Bb-Randomizer-GenerateByte-System-Byte,System-Byte- 'Bb.Randomizer.GenerateByte(System.Byte,System.Byte)')
  - [GenerateCard(cardIssuer,length)](#M-Bb-Randomizer-GenerateCard-RandomDataGenerator-CreditCardValidator-CardIssuer,System-Int32- 'Bb.Randomizer.GenerateCard(RandomDataGenerator.CreditCardValidator.CardIssuer,System.Int32)')
  - [GenerateCity()](#M-Bb-Randomizer-GenerateCity 'Bb.Randomizer.GenerateCity')
  - [GenerateCountry(options)](#M-Bb-Randomizer-GenerateCountry 'Bb.Randomizer.GenerateCountry')
  - [GenerateDateTime(includeTime,from,to)](#M-Bb-Randomizer-GenerateDateTime-System-Boolean,System-Nullable{System-DateTime},System-Nullable{System-DateTime}- 'Bb.Randomizer.GenerateDateTime(System.Boolean,System.Nullable{System.DateTime},System.Nullable{System.DateTime})')
  - [GenerateDouble(min,max)](#M-Bb-Randomizer-GenerateDouble-System-Double,System-Double- 'Bb.Randomizer.GenerateDouble(System.Double,System.Double)')
  - [GenerateEmailAddress(female,male,left2Right)](#M-Bb-Randomizer-GenerateEmailAddress-System-Boolean,System-Boolean,System-Boolean- 'Bb.Randomizer.GenerateEmailAddress(System.Boolean,System.Boolean,System.Boolean)')
  - [GenerateFirstName(options)](#M-Bb-Randomizer-GenerateFirstName 'Bb.Randomizer.GenerateFirstName')
  - [GenerateFloat(min,max)](#M-Bb-Randomizer-GenerateFloat-System-Single,System-Single- 'Bb.Randomizer.GenerateFloat(System.Single,System.Single)')
  - [GenerateFullName(options)](#M-Bb-Randomizer-GenerateFullName 'Bb.Randomizer.GenerateFullName')
  - [GenerateIbanBban(countryCode)](#M-Bb-Randomizer-GenerateIbanBban-System-String- 'Bb.Randomizer.GenerateIbanBban(System.String)')
  - [GenerateIbanBoth(countryCode)](#M-Bb-Randomizer-GenerateIbanBoth-System-String- 'Bb.Randomizer.GenerateIbanBoth(System.String)')
  - [GenerateInteger(min,max)](#M-Bb-Randomizer-GenerateInteger-System-Int32,System-Int32- 'Bb.Randomizer.GenerateInteger(System.Int32,System.Int32)')
  - [GenerateIpV4(min,max)](#M-Bb-Randomizer-GenerateIpV4-System-String,System-String- 'Bb.Randomizer.GenerateIpV4(System.String,System.String)')
  - [GenerateIpV6(min,max,upperCase)](#M-Bb-Randomizer-GenerateIpV6-System-String,System-String,System-Boolean- 'Bb.Randomizer.GenerateIpV6(System.String,System.String,System.Boolean)')
  - [GenerateLastName()](#M-Bb-Randomizer-GenerateLastName 'Bb.Randomizer.GenerateLastName')
  - [GenerateLong(min,max)](#M-Bb-Randomizer-GenerateLong-System-Int64,System-Int64- 'Bb.Randomizer.GenerateLong(System.Int64,System.Int64)')
  - [GenerateNaughtyStrings(categories)](#M-Bb-Randomizer-GenerateNaughtyStrings-System-String- 'Bb.Randomizer.GenerateNaughtyStrings(System.String)')
  - [GeneratePassword(length,charsetAvailables)](#M-Bb-Randomizer-GeneratePassword-System-Int32,System-String- 'Bb.Randomizer.GeneratePassword(System.Int32,System.String)')
  - [GenerateShort(min,max)](#M-Bb-Randomizer-GenerateShort-System-Int16,System-Int16- 'Bb.Randomizer.GenerateShort(System.Int16,System.Int16)')
  - [GenerateStringList(list)](#M-Bb-Randomizer-GenerateStringList-System-Collections-Generic-IEnumerable{System-String}- 'Bb.Randomizer.GenerateStringList(System.Collections.Generic.IEnumerable{System.String})')
  - [GenerateText(min,max,context)](#M-Bb-Randomizer-GenerateText-System-Int32,System-Int32,RandomDataGenerator-FieldOptions-TextRandomizeContextEnum- 'Bb.Randomizer.GenerateText(System.Int32,System.Int32,RandomDataGenerator.FieldOptions.TextRandomizeContextEnum)')
  - [GenerateTextByRegex(pattern)](#M-Bb-Randomizer-GenerateTextByRegex-System-String- 'Bb.Randomizer.GenerateTextByRegex(System.String)')
  - [GenerateTextWords(min,max)](#M-Bb-Randomizer-GenerateTextWords-System-Int32,System-Int32- 'Bb.Randomizer.GenerateTextWords(System.Int32,System.Int32)')
  - [GenerateTimeSpan(includeMilliseconds,from,to)](#M-Bb-Randomizer-GenerateTimeSpan-System-Boolean,System-Nullable{System-TimeSpan},System-Nullable{System-TimeSpan},System-String- 'Bb.Randomizer.GenerateTimeSpan(System.Boolean,System.Nullable{System.TimeSpan},System.Nullable{System.TimeSpan},System.String)')
- [RandomizerDateTime](#T-RandomDataGenerator-Randomizers-RandomizerDateTime 'RandomDataGenerator.Randomizers.RandomizerDateTime')
  - [#ctor(options)](#M-RandomDataGenerator-Randomizers-RandomizerDateTime-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsDateTime- 'RandomDataGenerator.Randomizers.RandomizerDateTime.#ctor(RandomDataGenerator.FieldOptions.FieldOptionsDateTime)')
  - [Generate()](#M-RandomDataGenerator-Randomizers-RandomizerDateTime-Generate 'RandomDataGenerator.Randomizers.RandomizerDateTime.Generate')
  - [GenerateAsString()](#M-RandomDataGenerator-Randomizers-RandomizerDateTime-GenerateAsString 'RandomDataGenerator.Randomizers.RandomizerDateTime.GenerateAsString')
- [RandomizerEmailAddress](#T-RandomDataGenerator-Randomizers-RandomizerEmailAddress 'RandomDataGenerator.Randomizers.RandomizerEmailAddress')
  - [#ctor(options)](#M-RandomDataGenerator-Randomizers-RandomizerEmailAddress-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsEmailAddress- 'RandomDataGenerator.Randomizers.RandomizerEmailAddress.#ctor(RandomDataGenerator.FieldOptions.FieldOptionsEmailAddress)')
  - [Generate()](#M-RandomDataGenerator-Randomizers-RandomizerEmailAddress-Generate 'RandomDataGenerator.Randomizers.RandomizerEmailAddress.Generate')
  - [Generate(upperCase)](#M-RandomDataGenerator-Randomizers-RandomizerEmailAddress-Generate-System-Boolean- 'RandomDataGenerator.Randomizers.RandomizerEmailAddress.Generate(System.Boolean)')
- [RandomizerFactory](#T-RandomDataGenerator-Randomizers-RandomizerFactory 'RandomDataGenerator.Randomizers.RandomizerFactory')
  - [GetRandomizer(fieldOptions)](#M-RandomDataGenerator-Randomizers-RandomizerFactory-GetRandomizer-RandomDataGenerator-FieldOptions-IFieldOptionsBytes- 'RandomDataGenerator.Randomizers.RandomizerFactory.GetRandomizer(RandomDataGenerator.FieldOptions.IFieldOptionsBytes)')
  - [GetRandomizer(fieldOptions)](#M-RandomDataGenerator-Randomizers-RandomizerFactory-GetRandomizer-RandomDataGenerator-FieldOptions-IFieldOptionsString- 'RandomDataGenerator.Randomizers.RandomizerFactory.GetRandomizer(RandomDataGenerator.FieldOptions.IFieldOptionsString)')
  - [GetRandomizer(fieldOptions)](#M-RandomDataGenerator-Randomizers-RandomizerFactory-GetRandomizer-RandomDataGenerator-FieldOptions-IFieldOptionsGuid- 'RandomDataGenerator.Randomizers.RandomizerFactory.GetRandomizer(RandomDataGenerator.FieldOptions.IFieldOptionsGuid)')
  - [GetRandomizer(fieldOptions)](#M-RandomDataGenerator-Randomizers-RandomizerFactory-GetRandomizer-RandomDataGenerator-FieldOptions-IFieldOptionsDateTime- 'RandomDataGenerator.Randomizers.RandomizerFactory.GetRandomizer(RandomDataGenerator.FieldOptions.IFieldOptionsDateTime)')
  - [GetRandomizer(fieldOptions)](#M-RandomDataGenerator-Randomizers-RandomizerFactory-GetRandomizer-RandomDataGenerator-FieldOptions-IFieldOptionsTimeSpan- 'RandomDataGenerator.Randomizers.RandomizerFactory.GetRandomizer(RandomDataGenerator.FieldOptions.IFieldOptionsTimeSpan)')
  - [GetRandomizerAsDynamic(fieldOptions)](#M-RandomDataGenerator-Randomizers-RandomizerFactory-GetRandomizerAsDynamic-System-Object- 'RandomDataGenerator.Randomizers.RandomizerFactory.GetRandomizerAsDynamic(System.Object)')
  - [GetRandomizer\`\`1(fieldOptions)](#M-RandomDataGenerator-Randomizers-RandomizerFactory-GetRandomizer``1-RandomDataGenerator-FieldOptions-IFieldOptionsNumber{``0}- 'RandomDataGenerator.Randomizers.RandomizerFactory.GetRandomizer``1(RandomDataGenerator.FieldOptions.IFieldOptionsNumber{``0})')
- [RandomizerFirstName](#T-RandomDataGenerator-Randomizers-RandomizerFirstName 'RandomDataGenerator.Randomizers.RandomizerFirstName')
  - [#ctor(options)](#M-RandomDataGenerator-Randomizers-RandomizerFirstName-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsFirstName- 'RandomDataGenerator.Randomizers.RandomizerFirstName.#ctor(RandomDataGenerator.FieldOptions.FieldOptionsFirstName)')
  - [Generate()](#M-RandomDataGenerator-Randomizers-RandomizerFirstName-Generate 'RandomDataGenerator.Randomizers.RandomizerFirstName.Generate')
  - [Generate(upperCase)](#M-RandomDataGenerator-Randomizers-RandomizerFirstName-Generate-System-Boolean- 'RandomDataGenerator.Randomizers.RandomizerFirstName.Generate(System.Boolean)')
- [RandomizerFullName](#T-RandomDataGenerator-Randomizers-RandomizerFullName 'RandomDataGenerator.Randomizers.RandomizerFullName')
  - [#ctor(options)](#M-RandomDataGenerator-Randomizers-RandomizerFullName-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsFullName- 'RandomDataGenerator.Randomizers.RandomizerFullName.#ctor(RandomDataGenerator.FieldOptions.FieldOptionsFullName)')
  - [Generate()](#M-RandomDataGenerator-Randomizers-RandomizerFullName-Generate 'RandomDataGenerator.Randomizers.RandomizerFullName.Generate')
  - [Generate(upperCase)](#M-RandomDataGenerator-Randomizers-RandomizerFullName-Generate-System-Boolean- 'RandomDataGenerator.Randomizers.RandomizerFullName.Generate(System.Boolean)')
- [RandomizerGuid](#T-RandomDataGenerator-Randomizers-RandomizerGuid 'RandomDataGenerator.Randomizers.RandomizerGuid')
  - [#ctor(options)](#M-RandomDataGenerator-Randomizers-RandomizerGuid-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsGuid- 'RandomDataGenerator.Randomizers.RandomizerGuid.#ctor(RandomDataGenerator.FieldOptions.FieldOptionsGuid)')
  - [Generate()](#M-RandomDataGenerator-Randomizers-RandomizerGuid-Generate 'RandomDataGenerator.Randomizers.RandomizerGuid.Generate')
  - [GenerateAsString()](#M-RandomDataGenerator-Randomizers-RandomizerGuid-GenerateAsString 'RandomDataGenerator.Randomizers.RandomizerGuid.GenerateAsString')
- [RandomizerIBAN](#T-RandomDataGenerator-Randomizers-RandomizerIBAN 'RandomDataGenerator.Randomizers.RandomizerIBAN')
  - [#ctor(options)](#M-RandomDataGenerator-Randomizers-RandomizerIBAN-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsIBAN- 'RandomDataGenerator.Randomizers.RandomizerIBAN.#ctor(RandomDataGenerator.FieldOptions.FieldOptionsIBAN)')
  - [Generate()](#M-RandomDataGenerator-Randomizers-RandomizerIBAN-Generate 'RandomDataGenerator.Randomizers.RandomizerIBAN.Generate')
  - [Generate(upperCase)](#M-RandomDataGenerator-Randomizers-RandomizerIBAN-Generate-System-Boolean- 'RandomDataGenerator.Randomizers.RandomizerIBAN.Generate(System.Boolean)')
- [RandomizerIPv4Address](#T-RandomDataGenerator-Randomizers-RandomizerIPv4Address 'RandomDataGenerator.Randomizers.RandomizerIPv4Address')
  - [Generate()](#M-RandomDataGenerator-Randomizers-RandomizerIPv4Address-Generate 'RandomDataGenerator.Randomizers.RandomizerIPv4Address.Generate')
  - [Generate(upperCase)](#M-RandomDataGenerator-Randomizers-RandomizerIPv4Address-Generate-System-Boolean- 'RandomDataGenerator.Randomizers.RandomizerIPv4Address.Generate(System.Boolean)')
- [RandomizerIPv6Address](#T-RandomDataGenerator-Randomizers-RandomizerIPv6Address 'RandomDataGenerator.Randomizers.RandomizerIPv6Address')
  - [#ctor(options)](#M-RandomDataGenerator-Randomizers-RandomizerIPv6Address-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsIPv6Address- 'RandomDataGenerator.Randomizers.RandomizerIPv6Address.#ctor(RandomDataGenerator.FieldOptions.FieldOptionsIPv6Address)')
  - [Generate()](#M-RandomDataGenerator-Randomizers-RandomizerIPv6Address-Generate 'RandomDataGenerator.Randomizers.RandomizerIPv6Address.Generate')
  - [Generate(upperCase)](#M-RandomDataGenerator-Randomizers-RandomizerIPv6Address-Generate-System-Boolean- 'RandomDataGenerator.Randomizers.RandomizerIPv6Address.Generate(System.Boolean)')
- [RandomizerLastName](#T-RandomDataGenerator-Randomizers-RandomizerLastName 'RandomDataGenerator.Randomizers.RandomizerLastName')
  - [#ctor(options)](#M-RandomDataGenerator-Randomizers-RandomizerLastName-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsLastName- 'RandomDataGenerator.Randomizers.RandomizerLastName.#ctor(RandomDataGenerator.FieldOptions.FieldOptionsLastName)')
  - [Generate()](#M-RandomDataGenerator-Randomizers-RandomizerLastName-Generate 'RandomDataGenerator.Randomizers.RandomizerLastName.Generate')
  - [Generate(upperCase)](#M-RandomDataGenerator-Randomizers-RandomizerLastName-Generate-System-Boolean- 'RandomDataGenerator.Randomizers.RandomizerLastName.Generate(System.Boolean)')
- [RandomizerMACAddress](#T-RandomDataGenerator-Randomizers-RandomizerMACAddress 'RandomDataGenerator.Randomizers.RandomizerMACAddress')
  - [#ctor(options)](#M-RandomDataGenerator-Randomizers-RandomizerMACAddress-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsMACAddress- 'RandomDataGenerator.Randomizers.RandomizerMACAddress.#ctor(RandomDataGenerator.FieldOptions.FieldOptionsMACAddress)')
  - [Generate()](#M-RandomDataGenerator-Randomizers-RandomizerMACAddress-Generate 'RandomDataGenerator.Randomizers.RandomizerMACAddress.Generate')
  - [Generate(upperCase)](#M-RandomDataGenerator-Randomizers-RandomizerMACAddress-Generate-System-Boolean- 'RandomDataGenerator.Randomizers.RandomizerMACAddress.Generate(System.Boolean)')
- [RandomizerNumber\`1](#T-RandomDataGenerator-Randomizers-RandomizerNumber`1 'RandomDataGenerator.Randomizers.RandomizerNumber`1')
  - [#ctor(options)](#M-RandomDataGenerator-Randomizers-RandomizerNumber`1-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsNumber{`0}- 'RandomDataGenerator.Randomizers.RandomizerNumber`1.#ctor(RandomDataGenerator.FieldOptions.FieldOptionsNumber{`0})')
  - [Generate()](#M-RandomDataGenerator-Randomizers-RandomizerNumber`1-Generate 'RandomDataGenerator.Randomizers.RandomizerNumber`1.Generate')
- [RandomizerStringList](#T-RandomDataGenerator-Randomizers-RandomizerStringList 'RandomDataGenerator.Randomizers.RandomizerStringList')
  - [#ctor(options)](#M-RandomDataGenerator-Randomizers-RandomizerStringList-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsStringList- 'RandomDataGenerator.Randomizers.RandomizerStringList.#ctor(RandomDataGenerator.FieldOptions.FieldOptionsStringList)')
  - [Generate()](#M-RandomDataGenerator-Randomizers-RandomizerStringList-Generate 'RandomDataGenerator.Randomizers.RandomizerStringList.Generate')
  - [Generate(upperCase)](#M-RandomDataGenerator-Randomizers-RandomizerStringList-Generate-System-Boolean- 'RandomDataGenerator.Randomizers.RandomizerStringList.Generate(System.Boolean)')
- [RandomizerText](#T-RandomDataGenerator-Randomizers-RandomizerText 'RandomDataGenerator.Randomizers.RandomizerText')
  - [#ctor(options)](#M-RandomDataGenerator-Randomizers-RandomizerText-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsText- 'RandomDataGenerator.Randomizers.RandomizerText.#ctor(RandomDataGenerator.FieldOptions.FieldOptionsText)')
  - [Generate()](#M-RandomDataGenerator-Randomizers-RandomizerText-Generate 'RandomDataGenerator.Randomizers.RandomizerText.Generate')
  - [Generate(upperCase)](#M-RandomDataGenerator-Randomizers-RandomizerText-Generate-System-Boolean- 'RandomDataGenerator.Randomizers.RandomizerText.Generate(System.Boolean)')
- [RandomizerTextLipsum](#T-RandomDataGenerator-Randomizers-RandomizerTextLipsum 'RandomDataGenerator.Randomizers.RandomizerTextLipsum')
  - [#ctor(options)](#M-RandomDataGenerator-Randomizers-RandomizerTextLipsum-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsTextLipsum- 'RandomDataGenerator.Randomizers.RandomizerTextLipsum.#ctor(RandomDataGenerator.FieldOptions.FieldOptionsTextLipsum)')
  - [Generate()](#M-RandomDataGenerator-Randomizers-RandomizerTextLipsum-Generate 'RandomDataGenerator.Randomizers.RandomizerTextLipsum.Generate')
  - [Generate(upperCase)](#M-RandomDataGenerator-Randomizers-RandomizerTextLipsum-Generate-System-Boolean- 'RandomDataGenerator.Randomizers.RandomizerTextLipsum.Generate(System.Boolean)')
- [RandomizerTextNaughtyStrings](#T-RandomDataGenerator-Randomizers-RandomizerTextNaughtyStrings 'RandomDataGenerator.Randomizers.RandomizerTextNaughtyStrings')
  - [#ctor(options)](#M-RandomDataGenerator-Randomizers-RandomizerTextNaughtyStrings-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsTextNaughtyStrings- 'RandomDataGenerator.Randomizers.RandomizerTextNaughtyStrings.#ctor(RandomDataGenerator.FieldOptions.FieldOptionsTextNaughtyStrings)')
  - [Generate()](#M-RandomDataGenerator-Randomizers-RandomizerTextNaughtyStrings-Generate 'RandomDataGenerator.Randomizers.RandomizerTextNaughtyStrings.Generate')
  - [Generate(upperCase)](#M-RandomDataGenerator-Randomizers-RandomizerTextNaughtyStrings-Generate-System-Boolean- 'RandomDataGenerator.Randomizers.RandomizerTextNaughtyStrings.Generate(System.Boolean)')
- [RandomizerTextRegex](#T-RandomDataGenerator-Randomizers-RandomizerTextRegex 'RandomDataGenerator.Randomizers.RandomizerTextRegex')
  - [#ctor(options)](#M-RandomDataGenerator-Randomizers-RandomizerTextRegex-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsTextRegex- 'RandomDataGenerator.Randomizers.RandomizerTextRegex.#ctor(RandomDataGenerator.FieldOptions.FieldOptionsTextRegex)')
  - [Generate()](#M-RandomDataGenerator-Randomizers-RandomizerTextRegex-Generate 'RandomDataGenerator.Randomizers.RandomizerTextRegex.Generate')
  - [Generate(upperCase)](#M-RandomDataGenerator-Randomizers-RandomizerTextRegex-Generate-System-Boolean- 'RandomDataGenerator.Randomizers.RandomizerTextRegex.Generate(System.Boolean)')
- [RandomizerTextWords](#T-RandomDataGenerator-Randomizers-RandomizerTextWords 'RandomDataGenerator.Randomizers.RandomizerTextWords')
  - [#ctor(options)](#M-RandomDataGenerator-Randomizers-RandomizerTextWords-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsTextWords- 'RandomDataGenerator.Randomizers.RandomizerTextWords.#ctor(RandomDataGenerator.FieldOptions.FieldOptionsTextWords)')
  - [Generate()](#M-RandomDataGenerator-Randomizers-RandomizerTextWords-Generate 'RandomDataGenerator.Randomizers.RandomizerTextWords.Generate')
  - [Generate(upperCase)](#M-RandomDataGenerator-Randomizers-RandomizerTextWords-Generate-System-Boolean- 'RandomDataGenerator.Randomizers.RandomizerTextWords.Generate(System.Boolean)')
- [RandomizerTimeSpan](#T-RandomDataGenerator-Randomizers-RandomizerTimeSpan 'RandomDataGenerator.Randomizers.RandomizerTimeSpan')
  - [#ctor(options)](#M-RandomDataGenerator-Randomizers-RandomizerTimeSpan-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsTimeSpan- 'RandomDataGenerator.Randomizers.RandomizerTimeSpan.#ctor(RandomDataGenerator.FieldOptions.FieldOptionsTimeSpan)')
  - [Generate()](#M-RandomDataGenerator-Randomizers-RandomizerTimeSpan-Generate 'RandomDataGenerator.Randomizers.RandomizerTimeSpan.Generate')
  - [GenerateAsString()](#M-RandomDataGenerator-Randomizers-RandomizerTimeSpan-GenerateAsString 'RandomDataGenerator.Randomizers.RandomizerTimeSpan.GenerateAsString')
- [RegExp](#T-Fare-RegExp 'Fare.RegExp')
  - [#ctor()](#M-Fare-RegExp-#ctor 'Fare.RegExp.#ctor')
  - [#ctor(s)](#M-Fare-RegExp-#ctor-System-String- 'Fare.RegExp.#ctor(System.String)')
  - [#ctor(s,syntaxFlags)](#M-Fare-RegExp-#ctor-System-String,Fare-RegExpSyntaxOptions- 'Fare.RegExp.#ctor(System.String,Fare.RegExpSyntaxOptions)')
  - [GetIdentifiers()](#M-Fare-RegExp-GetIdentifiers 'Fare.RegExp.GetIdentifiers')
  - [SetAllowMutate(flag)](#M-Fare-RegExp-SetAllowMutate-System-Boolean- 'Fare.RegExp.SetAllowMutate(System.Boolean)')
  - [ToAutomaton()](#M-Fare-RegExp-ToAutomaton 'Fare.RegExp.ToAutomaton')
  - [ToAutomaton(minimize)](#M-Fare-RegExp-ToAutomaton-System-Boolean- 'Fare.RegExp.ToAutomaton(System.Boolean)')
  - [ToAutomaton(automatonProvider)](#M-Fare-RegExp-ToAutomaton-Fare-IAutomatonProvider- 'Fare.RegExp.ToAutomaton(Fare.IAutomatonProvider)')
  - [ToAutomaton(automatonProvider,minimize)](#M-Fare-RegExp-ToAutomaton-Fare-IAutomatonProvider,System-Boolean- 'Fare.RegExp.ToAutomaton(Fare.IAutomatonProvider,System.Boolean)')
  - [ToAutomaton(automata)](#M-Fare-RegExp-ToAutomaton-System-Collections-Generic-IDictionary{System-String,Fare-Automaton}- 'Fare.RegExp.ToAutomaton(System.Collections.Generic.IDictionary{System.String,Fare.Automaton})')
  - [ToAutomaton(automata,minimize)](#M-Fare-RegExp-ToAutomaton-System-Collections-Generic-IDictionary{System-String,Fare-Automaton},System-Boolean- 'Fare.RegExp.ToAutomaton(System.Collections.Generic.IDictionary{System.String,Fare.Automaton},System.Boolean)')
  - [ToString()](#M-Fare-RegExp-ToString 'Fare.RegExp.ToString')
- [RegExpMatchingOptions](#T-Fare-RegExpMatchingOptions 'Fare.RegExpMatchingOptions')
  - [ExplicitCapture](#F-Fare-RegExpMatchingOptions-ExplicitCapture 'Fare.RegExpMatchingOptions.ExplicitCapture')
  - [IgnoreCase](#F-Fare-RegExpMatchingOptions-IgnoreCase 'Fare.RegExpMatchingOptions.IgnoreCase')
  - [IgnorePatternWhitespace](#F-Fare-RegExpMatchingOptions-IgnorePatternWhitespace 'Fare.RegExpMatchingOptions.IgnorePatternWhitespace')
  - [Multiline](#F-Fare-RegExpMatchingOptions-Multiline 'Fare.RegExpMatchingOptions.Multiline')
  - [Singleline](#F-Fare-RegExpMatchingOptions-Singleline 'Fare.RegExpMatchingOptions.Singleline')
  - [All()](#M-Fare-RegExpMatchingOptions-All 'Fare.RegExpMatchingOptions.All')
- [RegExpSyntaxOptions](#T-Fare-RegExpSyntaxOptions 'Fare.RegExpSyntaxOptions')
  - [All](#F-Fare-RegExpSyntaxOptions-All 'Fare.RegExpSyntaxOptions.All')
  - [Anystring](#F-Fare-RegExpSyntaxOptions-Anystring 'Fare.RegExpSyntaxOptions.Anystring')
  - [Automaton](#F-Fare-RegExpSyntaxOptions-Automaton 'Fare.RegExpSyntaxOptions.Automaton')
  - [Complement](#F-Fare-RegExpSyntaxOptions-Complement 'Fare.RegExpSyntaxOptions.Complement')
  - [Empty](#F-Fare-RegExpSyntaxOptions-Empty 'Fare.RegExpSyntaxOptions.Empty')
  - [Intersection](#F-Fare-RegExpSyntaxOptions-Intersection 'Fare.RegExpSyntaxOptions.Intersection')
  - [Interval](#F-Fare-RegExpSyntaxOptions-Interval 'Fare.RegExpSyntaxOptions.Interval')
- [SpecialOperations](#T-Fare-SpecialOperations 'Fare.SpecialOperations')
  - [Compress(a,set,c)](#M-Fare-SpecialOperations-Compress-Fare-Automaton,System-String,System-Char- 'Fare.SpecialOperations.Compress(Fare.Automaton,System.String,System.Char)')
  - [FindIndex(c,points)](#M-Fare-SpecialOperations-FindIndex-System-Char,System-Char[]- 'Fare.SpecialOperations.FindIndex(System.Char,System.Char[])')
  - [GetCommonPrefix(a)](#M-Fare-SpecialOperations-GetCommonPrefix-Fare-Automaton- 'Fare.SpecialOperations.GetCommonPrefix(Fare.Automaton)')
  - [GetFiniteStrings(a)](#M-Fare-SpecialOperations-GetFiniteStrings-Fare-Automaton- 'Fare.SpecialOperations.GetFiniteStrings(Fare.Automaton)')
  - [GetFiniteStrings(a,limit)](#M-Fare-SpecialOperations-GetFiniteStrings-Fare-Automaton,System-Int32- 'Fare.SpecialOperations.GetFiniteStrings(Fare.Automaton,System.Int32)')
  - [GetFiniteStrings(s,pathStates,strings,path,limit)](#M-Fare-SpecialOperations-GetFiniteStrings-Fare-State,System-Collections-Generic-HashSet{Fare-State},System-Collections-Generic-HashSet{System-String},System-Text-StringBuilder,System-Int32- 'Fare.SpecialOperations.GetFiniteStrings(Fare.State,System.Collections.Generic.HashSet{Fare.State},System.Collections.Generic.HashSet{System.String},System.Text.StringBuilder,System.Int32)')
  - [GetStrings(a,length)](#M-Fare-SpecialOperations-GetStrings-Fare-Automaton,System-Int32- 'Fare.SpecialOperations.GetStrings(Fare.Automaton,System.Int32)')
  - [HexCases(a)](#M-Fare-SpecialOperations-HexCases-Fare-Automaton- 'Fare.SpecialOperations.HexCases(Fare.Automaton)')
  - [Homomorph(a,source,dest)](#M-Fare-SpecialOperations-Homomorph-Fare-Automaton,System-Char[],System-Char[]- 'Fare.SpecialOperations.Homomorph(Fare.Automaton,System.Char[],System.Char[])')
  - [IsFinite(a)](#M-Fare-SpecialOperations-IsFinite-Fare-Automaton- 'Fare.SpecialOperations.IsFinite(Fare.Automaton)')
  - [IsFinite(s,path,visited)](#M-Fare-SpecialOperations-IsFinite-Fare-State,System-Collections-Generic-HashSet{Fare-State},System-Collections-Generic-HashSet{Fare-State}- 'Fare.SpecialOperations.IsFinite(Fare.State,System.Collections.Generic.HashSet{Fare.State},System.Collections.Generic.HashSet{Fare.State})')
  - [Overlap(a1,a2)](#M-Fare-SpecialOperations-Overlap-Fare-Automaton,Fare-Automaton- 'Fare.SpecialOperations.Overlap(Fare.Automaton,Fare.Automaton)')
  - [PrefixClose(a)](#M-Fare-SpecialOperations-PrefixClose-Fare-Automaton- 'Fare.SpecialOperations.PrefixClose(Fare.Automaton)')
  - [ProjectChars(a,chars)](#M-Fare-SpecialOperations-ProjectChars-Fare-Automaton,System-Collections-Generic-HashSet{System-Char}- 'Fare.SpecialOperations.ProjectChars(Fare.Automaton,System.Collections.Generic.HashSet{System.Char})')
  - [ReplaceWhitespace(a)](#M-Fare-SpecialOperations-ReplaceWhitespace-Fare-Automaton- 'Fare.SpecialOperations.ReplaceWhitespace(Fare.Automaton)')
  - [Reverse(a)](#M-Fare-SpecialOperations-Reverse-Fare-Automaton- 'Fare.SpecialOperations.Reverse(Fare.Automaton)')
  - [SingleChars(a)](#M-Fare-SpecialOperations-SingleChars-Fare-Automaton- 'Fare.SpecialOperations.SingleChars(Fare.Automaton)')
  - [Subst(a,dictionary)](#M-Fare-SpecialOperations-Subst-Fare-Automaton,System-Collections-Generic-IDictionary{System-Char,System-Collections-Generic-HashSet{System-Char}}- 'Fare.SpecialOperations.Subst(Fare.Automaton,System.Collections.Generic.IDictionary{System.Char,System.Collections.Generic.HashSet{System.Char}})')
  - [Subst(a,c,s)](#M-Fare-SpecialOperations-Subst-Fare-Automaton,System-Char,System-String- 'Fare.SpecialOperations.Subst(Fare.Automaton,System.Char,System.String)')
  - [Trim(a,set,c)](#M-Fare-SpecialOperations-Trim-Fare-Automaton,System-String,System-Char- 'Fare.SpecialOperations.Trim(Fare.Automaton,System.String,System.Char)')
- [State](#T-Fare-State 'Fare.State')
  - [#ctor()](#M-Fare-State-#ctor 'Fare.State.#ctor')
  - [Accept](#P-Fare-State-Accept 'Fare.State.Accept')
  - [Id](#P-Fare-State-Id 'Fare.State.Id')
  - [Number](#P-Fare-State-Number 'Fare.State.Number')
  - [Transitions](#P-Fare-State-Transitions 'Fare.State.Transitions')
  - [AddTransition(t)](#M-Fare-State-AddTransition-Fare-Transition- 'Fare.State.AddTransition(Fare.Transition)')
  - [CompareTo()](#M-Fare-State-CompareTo-System-Object- 'Fare.State.CompareTo(System.Object)')
  - [CompareTo()](#M-Fare-State-CompareTo-Fare-State- 'Fare.State.CompareTo(Fare.State)')
  - [Equals()](#M-Fare-State-Equals-System-Object- 'Fare.State.Equals(System.Object)')
  - [Equals()](#M-Fare-State-Equals-Fare-State- 'Fare.State.Equals(Fare.State)')
  - [GetHashCode()](#M-Fare-State-GetHashCode 'Fare.State.GetHashCode')
  - [GetSortedTransitions(toFirst)](#M-Fare-State-GetSortedTransitions-System-Boolean- 'Fare.State.GetSortedTransitions(System.Boolean)')
  - [Step(c)](#M-Fare-State-Step-System-Char- 'Fare.State.Step(System.Char)')
  - [Step(c,dest)](#M-Fare-State-Step-System-Char,System-Collections-Generic-List{Fare-State}- 'Fare.State.Step(System.Char,System.Collections.Generic.List{Fare.State})')
  - [ToString()](#M-Fare-State-ToString 'Fare.State.ToString')
  - [op_Equality(left,right)](#M-Fare-State-op_Equality-Fare-State,Fare-State- 'Fare.State.op_Equality(Fare.State,Fare.State)')
  - [op_Inequality(left,right)](#M-Fare-State-op_Inequality-Fare-State,Fare-State- 'Fare.State.op_Inequality(Fare.State,Fare.State)')
- [StateEqualityComparer](#T-Fare-StateEqualityComparer 'Fare.StateEqualityComparer')
  - [Equals(x,y)](#M-Fare-StateEqualityComparer-Equals-Fare-State,Fare-State- 'Fare.StateEqualityComparer.Equals(Fare.State,Fare.State)')
  - [GetHashCode(obj)](#M-Fare-StateEqualityComparer-GetHashCode-Fare-State- 'Fare.StateEqualityComparer.GetHashCode(Fare.State)')
- [StatePair](#T-Fare-StatePair 'Fare.StatePair')
  - [#ctor(s,s1,s2)](#M-Fare-StatePair-#ctor-Fare-State,Fare-State,Fare-State- 'Fare.StatePair.#ctor(Fare.State,Fare.State,Fare.State)')
  - [#ctor(s1,s2)](#M-Fare-StatePair-#ctor-Fare-State,Fare-State- 'Fare.StatePair.#ctor(Fare.State,Fare.State)')
  - [FirstState](#P-Fare-StatePair-FirstState 'Fare.StatePair.FirstState')
  - [S](#P-Fare-StatePair-S 'Fare.StatePair.S')
  - [SecondState](#P-Fare-StatePair-SecondState 'Fare.StatePair.SecondState')
  - [Equals()](#M-Fare-StatePair-Equals-Fare-StatePair- 'Fare.StatePair.Equals(Fare.StatePair)')
  - [Equals()](#M-Fare-StatePair-Equals-System-Object- 'Fare.StatePair.Equals(System.Object)')
  - [GetHashCode()](#M-Fare-StatePair-GetHashCode 'Fare.StatePair.GetHashCode')
  - [op_Equality(left,right)](#M-Fare-StatePair-op_Equality-Fare-StatePair,Fare-StatePair- 'Fare.StatePair.op_Equality(Fare.StatePair,Fare.StatePair)')
  - [op_Inequality(left,right)](#M-Fare-StatePair-op_Inequality-Fare-StatePair,Fare-StatePair- 'Fare.StatePair.op_Inequality(Fare.StatePair,Fare.StatePair)')
- [StringUnionOperations](#T-Fare-StringUnionOperations 'Fare.StringUnionOperations')
  - [LexicographicOrderComparer](#P-Fare-StringUnionOperations-LexicographicOrderComparer 'Fare.StringUnionOperations.LexicographicOrderComparer')
  - [Add(current)](#M-Fare-StringUnionOperations-Add-System-Char[]- 'Fare.StringUnionOperations.Add(System.Char[])')
  - [Build(input)](#M-Fare-StringUnionOperations-Build-System-Collections-Generic-IEnumerable{System-Char[]}- 'Fare.StringUnionOperations.Build(System.Collections.Generic.IEnumerable{System.Char[]})')
- [SubFieldType](#T-RandomDataGenerator-Enums-SubFieldType 'RandomDataGenerator.Enums.SubFieldType')
  - [Boolean](#F-RandomDataGenerator-Enums-SubFieldType-Boolean 'RandomDataGenerator.Enums.SubFieldType.Boolean')
  - [CCN](#F-RandomDataGenerator-Enums-SubFieldType-CCN 'RandomDataGenerator.Enums.SubFieldType.CCN')
  - [City](#F-RandomDataGenerator-Enums-SubFieldType-City 'RandomDataGenerator.Enums.SubFieldType.City')
  - [Country](#F-RandomDataGenerator-Enums-SubFieldType-Country 'RandomDataGenerator.Enums.SubFieldType.Country')
  - [DateTime](#F-RandomDataGenerator-Enums-SubFieldType-DateTime 'RandomDataGenerator.Enums.SubFieldType.DateTime')
  - [Double](#F-RandomDataGenerator-Enums-SubFieldType-Double 'RandomDataGenerator.Enums.SubFieldType.Double')
  - [EmailAddress](#F-RandomDataGenerator-Enums-SubFieldType-EmailAddress 'RandomDataGenerator.Enums.SubFieldType.EmailAddress')
  - [FirstName](#F-RandomDataGenerator-Enums-SubFieldType-FirstName 'RandomDataGenerator.Enums.SubFieldType.FirstName')
  - [Float](#F-RandomDataGenerator-Enums-SubFieldType-Float 'RandomDataGenerator.Enums.SubFieldType.Float')
  - [FullName](#F-RandomDataGenerator-Enums-SubFieldType-FullName 'RandomDataGenerator.Enums.SubFieldType.FullName')
  - [Guid](#F-RandomDataGenerator-Enums-SubFieldType-Guid 'RandomDataGenerator.Enums.SubFieldType.Guid')
  - [IPv4Address](#F-RandomDataGenerator-Enums-SubFieldType-IPv4Address 'RandomDataGenerator.Enums.SubFieldType.IPv4Address')
  - [IPv6Address](#F-RandomDataGenerator-Enums-SubFieldType-IPv6Address 'RandomDataGenerator.Enums.SubFieldType.IPv6Address')
  - [Integer](#F-RandomDataGenerator-Enums-SubFieldType-Integer 'RandomDataGenerator.Enums.SubFieldType.Integer')
  - [LastName](#F-RandomDataGenerator-Enums-SubFieldType-LastName 'RandomDataGenerator.Enums.SubFieldType.LastName')
  - [Long](#F-RandomDataGenerator-Enums-SubFieldType-Long 'RandomDataGenerator.Enums.SubFieldType.Long')
  - [MACAddress](#F-RandomDataGenerator-Enums-SubFieldType-MACAddress 'RandomDataGenerator.Enums.SubFieldType.MACAddress')
  - [None](#F-RandomDataGenerator-Enums-SubFieldType-None 'RandomDataGenerator.Enums.SubFieldType.None')
  - [Short](#F-RandomDataGenerator-Enums-SubFieldType-Short 'RandomDataGenerator.Enums.SubFieldType.Short')
  - [StringList](#F-RandomDataGenerator-Enums-SubFieldType-StringList 'RandomDataGenerator.Enums.SubFieldType.StringList')
  - [Text](#F-RandomDataGenerator-Enums-SubFieldType-Text 'RandomDataGenerator.Enums.SubFieldType.Text')
  - [TextLipsum](#F-RandomDataGenerator-Enums-SubFieldType-TextLipsum 'RandomDataGenerator.Enums.SubFieldType.TextLipsum')
  - [TextNaughtyStrings](#F-RandomDataGenerator-Enums-SubFieldType-TextNaughtyStrings 'RandomDataGenerator.Enums.SubFieldType.TextNaughtyStrings')
  - [TextPattern](#F-RandomDataGenerator-Enums-SubFieldType-TextPattern 'RandomDataGenerator.Enums.SubFieldType.TextPattern')
  - [TextRegex](#F-RandomDataGenerator-Enums-SubFieldType-TextRegex 'RandomDataGenerator.Enums.SubFieldType.TextRegex')
  - [TextWords](#F-RandomDataGenerator-Enums-SubFieldType-TextWords 'RandomDataGenerator.Enums.SubFieldType.TextWords')
- [TextRandomizeContextEnum](#T-RandomDataGenerator-FieldOptions-TextRandomizeContextEnum 'RandomDataGenerator.FieldOptions.TextRandomizeContextEnum')
  - [All](#F-RandomDataGenerator-FieldOptions-TextRandomizeContextEnum-All 'RandomDataGenerator.FieldOptions.TextRandomizeContextEnum.All')
  - [UseLetter](#F-RandomDataGenerator-FieldOptions-TextRandomizeContextEnum-UseLetter 'RandomDataGenerator.FieldOptions.TextRandomizeContextEnum.UseLetter')
  - [UseLowercase](#F-RandomDataGenerator-FieldOptions-TextRandomizeContextEnum-UseLowercase 'RandomDataGenerator.FieldOptions.TextRandomizeContextEnum.UseLowercase')
  - [UseNumber](#F-RandomDataGenerator-FieldOptions-TextRandomizeContextEnum-UseNumber 'RandomDataGenerator.FieldOptions.TextRandomizeContextEnum.UseNumber')
  - [UseSpace](#F-RandomDataGenerator-FieldOptions-TextRandomizeContextEnum-UseSpace 'RandomDataGenerator.FieldOptions.TextRandomizeContextEnum.UseSpace')
  - [UseSpecial](#F-RandomDataGenerator-FieldOptions-TextRandomizeContextEnum-UseSpecial 'RandomDataGenerator.FieldOptions.TextRandomizeContextEnum.UseSpecial')
  - [UseUppercase](#F-RandomDataGenerator-FieldOptions-TextRandomizeContextEnum-UseUppercase 'RandomDataGenerator.FieldOptions.TextRandomizeContextEnum.UseUppercase')
- [TheNaughtyStrings](#T-RandomDataGenerator-Data-TheNaughtyStrings 'RandomDataGenerator.Data.TheNaughtyStrings')
  - [All](#F-RandomDataGenerator-Data-TheNaughtyStrings-All 'RandomDataGenerator.Data.TheNaughtyStrings.All')
  - [Changinglengthwhenlowercased](#F-RandomDataGenerator-Data-TheNaughtyStrings-Changinglengthwhenlowercased 'RandomDataGenerator.Data.TheNaughtyStrings.Changinglengthwhenlowercased')
  - [CommandInjectionRuby](#F-RandomDataGenerator-Data-TheNaughtyStrings-CommandInjectionRuby 'RandomDataGenerator.Data.TheNaughtyStrings.CommandInjectionRuby')
  - [Emoji](#F-RandomDataGenerator-Data-TheNaughtyStrings-Emoji 'RandomDataGenerator.Data.TheNaughtyStrings.Emoji')
  - [FileInclusion](#F-RandomDataGenerator-Data-TheNaughtyStrings-FileInclusion 'RandomDataGenerator.Data.TheNaughtyStrings.FileInclusion')
  - [Humaninjection](#F-RandomDataGenerator-Data-TheNaughtyStrings-Humaninjection 'RandomDataGenerator.Data.TheNaughtyStrings.Humaninjection')
  - [JapaneseEmoticons](#F-RandomDataGenerator-Data-TheNaughtyStrings-JapaneseEmoticons 'RandomDataGenerator.Data.TheNaughtyStrings.JapaneseEmoticons')
  - [KnownCVEsandVulnerabilities](#F-RandomDataGenerator-Data-TheNaughtyStrings-KnownCVEsandVulnerabilities 'RandomDataGenerator.Data.TheNaughtyStrings.KnownCVEsandVulnerabilities')
  - [MSDOSWindowsSpecialFilenames](#F-RandomDataGenerator-Data-TheNaughtyStrings-MSDOSWindowsSpecialFilenames 'RandomDataGenerator.Data.TheNaughtyStrings.MSDOSWindowsSpecialFilenames')
  - [NumericStrings](#F-RandomDataGenerator-Data-TheNaughtyStrings-NumericStrings 'RandomDataGenerator.Data.TheNaughtyStrings.NumericStrings')
  - [OghamText](#F-RandomDataGenerator-Data-TheNaughtyStrings-OghamText 'RandomDataGenerator.Data.TheNaughtyStrings.OghamText')
  - [QuotationMarks](#F-RandomDataGenerator-Data-TheNaughtyStrings-QuotationMarks 'RandomDataGenerator.Data.TheNaughtyStrings.QuotationMarks')
  - [ReservedStrings](#F-RandomDataGenerator-Data-TheNaughtyStrings-ReservedStrings 'RandomDataGenerator.Data.TheNaughtyStrings.ReservedStrings')
  - [RightToLeftStrings](#F-RandomDataGenerator-Data-TheNaughtyStrings-RightToLeftStrings 'RandomDataGenerator.Data.TheNaughtyStrings.RightToLeftStrings')
  - [SQLInjection](#F-RandomDataGenerator-Data-TheNaughtyStrings-SQLInjection 'RandomDataGenerator.Data.TheNaughtyStrings.SQLInjection')
  - [ScriptInjection](#F-RandomDataGenerator-Data-TheNaughtyStrings-ScriptInjection 'RandomDataGenerator.Data.TheNaughtyStrings.ScriptInjection')
  - [ScunthorpeProblem](#F-RandomDataGenerator-Data-TheNaughtyStrings-ScunthorpeProblem 'RandomDataGenerator.Data.TheNaughtyStrings.ScunthorpeProblem')
  - [ServerCodeInjection](#F-RandomDataGenerator-Data-TheNaughtyStrings-ServerCodeInjection 'RandomDataGenerator.Data.TheNaughtyStrings.ServerCodeInjection')
  - [SpecialCharacters](#F-RandomDataGenerator-Data-TheNaughtyStrings-SpecialCharacters 'RandomDataGenerator.Data.TheNaughtyStrings.SpecialCharacters')
  - [SpecialUnicodeCharactersUnion](#F-RandomDataGenerator-Data-TheNaughtyStrings-SpecialUnicodeCharactersUnion 'RandomDataGenerator.Data.TheNaughtyStrings.SpecialUnicodeCharactersUnion')
  - [Stringswhichcontaintwobyteletters](#F-RandomDataGenerator-Data-TheNaughtyStrings-Stringswhichcontaintwobyteletters 'RandomDataGenerator.Data.TheNaughtyStrings.Stringswhichcontaintwobyteletters')
  - [Terminalescapecodes](#F-RandomDataGenerator-Data-TheNaughtyStrings-Terminalescapecodes 'RandomDataGenerator.Data.TheNaughtyStrings.Terminalescapecodes')
  - [TrickUnicode](#F-RandomDataGenerator-Data-TheNaughtyStrings-TrickUnicode 'RandomDataGenerator.Data.TheNaughtyStrings.TrickUnicode')
  - [TwoByteCharacters](#F-RandomDataGenerator-Data-TheNaughtyStrings-TwoByteCharacters 'RandomDataGenerator.Data.TheNaughtyStrings.TwoByteCharacters')
  - [UnicodeNumbers](#F-RandomDataGenerator-Data-TheNaughtyStrings-UnicodeNumbers 'RandomDataGenerator.Data.TheNaughtyStrings.UnicodeNumbers')
  - [UnicodeSubscriptSuperscriptAccents](#F-RandomDataGenerator-Data-TheNaughtyStrings-UnicodeSubscriptSuperscriptAccents 'RandomDataGenerator.Data.TheNaughtyStrings.UnicodeSubscriptSuperscriptAccents')
  - [UnicodeSymbols](#F-RandomDataGenerator-Data-TheNaughtyStrings-UnicodeSymbols 'RandomDataGenerator.Data.TheNaughtyStrings.UnicodeSymbols')
  - [UnicodeUpsidedown](#F-RandomDataGenerator-Data-TheNaughtyStrings-UnicodeUpsidedown 'RandomDataGenerator.Data.TheNaughtyStrings.UnicodeUpsidedown')
  - [Unicodefont](#F-RandomDataGenerator-Data-TheNaughtyStrings-Unicodefont 'RandomDataGenerator.Data.TheNaughtyStrings.Unicodefont')
  - [UnwantedInterpolation](#F-RandomDataGenerator-Data-TheNaughtyStrings-UnwantedInterpolation 'RandomDataGenerator.Data.TheNaughtyStrings.UnwantedInterpolation')
  - [ZalgoText](#F-RandomDataGenerator-Data-TheNaughtyStrings-ZalgoText 'RandomDataGenerator.Data.TheNaughtyStrings.ZalgoText')
  - [iOSVulnerabilities](#F-RandomDataGenerator-Data-TheNaughtyStrings-iOSVulnerabilities 'RandomDataGenerator.Data.TheNaughtyStrings.iOSVulnerabilities')
- [Transition](#T-Fare-Transition 'Fare.Transition')
  - [#ctor(c,to)](#M-Fare-Transition-#ctor-System-Char,Fare-State- 'Fare.Transition.#ctor(System.Char,Fare.State)')
  - [#ctor(min,max,to)](#M-Fare-Transition-#ctor-System-Char,System-Char,Fare-State- 'Fare.Transition.#ctor(System.Char,System.Char,Fare.State)')
  - [Max](#P-Fare-Transition-Max 'Fare.Transition.Max')
  - [Min](#P-Fare-Transition-Min 'Fare.Transition.Min')
  - [To](#P-Fare-Transition-To 'Fare.Transition.To')
  - [Equals()](#M-Fare-Transition-Equals-System-Object- 'Fare.Transition.Equals(System.Object)')
  - [Equals()](#M-Fare-Transition-Equals-Fare-Transition- 'Fare.Transition.Equals(Fare.Transition)')
  - [GetHashCode()](#M-Fare-Transition-GetHashCode 'Fare.Transition.GetHashCode')
  - [ToString()](#M-Fare-Transition-ToString 'Fare.Transition.ToString')
  - [op_Equality(left,right)](#M-Fare-Transition-op_Equality-Fare-Transition,Fare-Transition- 'Fare.Transition.op_Equality(Fare.Transition,Fare.Transition)')
  - [op_Inequality(left,right)](#M-Fare-Transition-op_Inequality-Fare-Transition,Fare-Transition- 'Fare.Transition.op_Inequality(Fare.Transition,Fare.Transition)')
- [TransitionComparer](#T-Fare-TransitionComparer 'Fare.TransitionComparer')
  - [#ctor(toFirst)](#M-Fare-TransitionComparer-#ctor-System-Boolean- 'Fare.TransitionComparer.#ctor(System.Boolean)')
  - [Compare(t1,t2)](#M-Fare-TransitionComparer-Compare-Fare-Transition,Fare-Transition- 'Fare.TransitionComparer.Compare(Fare.Transition,Fare.Transition)')
- [Xeger](#T-Fare-Xeger 'Fare.Xeger')
  - [#ctor(regex,random)](#M-Fare-Xeger-#ctor-System-String,System-Random- 'Fare.Xeger.#ctor(System.String,System.Random)')
  - [#ctor(regex)](#M-Fare-Xeger-#ctor-System-String- 'Fare.Xeger.#ctor(System.String)')
  - [Generate()](#M-Fare-Xeger-Generate 'Fare.Xeger.Generate')
  - [GetRandomInt(min,max,random)](#M-Fare-Xeger-GetRandomInt-System-Int32,System-Int32,System-Random- 'Fare.Xeger.GetRandomInt(System.Int32,System.Int32,System.Random)')

<a name='T-Fare-Automaton'></a>
## Automaton `type`

##### Namespace

Fare

##### Summary

Finite-state automaton with regular expression operations.

If the states or transitions are manipulated manually, the RestoreInvariant() method and
SetDeterministic(bool) methods should be used afterwards to restore representation invariants
that are assumed by the built-in automata operations.

<a name='M-Fare-Automaton-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [Automaton](#T-Fare-Automaton 'Fare.Automaton') class that accepts the empty 
  language. Using this constructor, automata can be constructed manually from 
  [State](#T-Fare-State 'Fare.State') and [Transition](#T-Fare-Transition 'Fare.Transition') objects.

##### Parameters

This constructor has no parameters.

<a name='F-Fare-Automaton-MinimizeBrzozowski'></a>
### MinimizeBrzozowski `constants`

##### Summary

Minimize using Brzozowski's O(2) algorithm. 
  This algorithm uses the reverse-determinize-reverse-determinize trick, which has a bad
  worst-case behavior but often works very well in practice even better than Hopcroft's!).

<a name='F-Fare-Automaton-MinimizeHopcroft'></a>
### MinimizeHopcroft `constants`

##### Summary

Minimize using Hopcroft's O(n log n) algorithm.
  This is regarded as one of the most generally efficient algorithms that exist.

<a name='F-Fare-Automaton-MinimizeHuffman'></a>
### MinimizeHuffman `constants`

##### Summary

Minimize using Huffman's O(n) algorithm.
  This is the standard text-book algorithm.

<a name='F-Fare-Automaton-allowMutation'></a>
### allowMutation `constants`

##### Summary

Selects whether operations may modify the input automata (default:

```
false
```

).

<a name='F-Fare-Automaton-hashCode'></a>
### hashCode `constants`

##### Summary

The hash code.

<a name='F-Fare-Automaton-initial'></a>
### initial `constants`

##### Summary

The initial.

<a name='F-Fare-Automaton-minimizeAlways'></a>
### minimizeAlways `constants`

##### Summary

Minimize always flag.

<a name='P-Fare-Automaton-AllowMutation'></a>
### AllowMutation `property`

##### Summary

Gets or sets a value indicating whether operations may modify the input automata (default:

```
false
```

).

<a name='P-Fare-Automaton-Initial'></a>
### Initial `property`

##### Summary

Gets or sets the initial state of this automaton.

<a name='P-Fare-Automaton-IsDebug'></a>
### IsDebug `property`

##### Summary

Gets or sets a value indicating whether this instance is debug.

<a name='P-Fare-Automaton-IsDeterministic'></a>
### IsDeterministic `property`

##### Summary

Gets or sets a value indicating whether this automaton is definitely deterministic (i.e.,
  there are no choices for any run, but a run may crash).

<a name='P-Fare-Automaton-IsEmpty'></a>
### IsEmpty `property`

##### Summary

Gets or sets a value indicating whether IsEmpty.

<a name='P-Fare-Automaton-IsSingleton'></a>
### IsSingleton `property`

##### Summary

Gets or sets a value indicating whether this instance is singleton.

<a name='P-Fare-Automaton-Minimization'></a>
### Minimization `property`

##### Summary

Gets the minimization algorithm (default:

```
MINIMIZE_HOPCROFT
```

).

<a name='P-Fare-Automaton-NumberOfStates'></a>
### NumberOfStates `property`

##### Summary

Gets the number of states in this automaton.

<a name='P-Fare-Automaton-NumberOfTransitions'></a>
### NumberOfTransitions `property`

##### Summary

Gets the number of transitions in this automaton. This number is counted
  as the total number of edges, where one edge may be a character interval.

<a name='P-Fare-Automaton-Singleton'></a>
### Singleton `property`

##### Summary

Gets or sets the singleton string for this automaton. An automaton that accepts exactly one
 string be represented in singleton mode. In that case, this method may be 
used to obtain the string.

<a name='M-Fare-Automaton-AddEpsilons-System-Collections-Generic-ICollection{Fare-StatePair}-'></a>
### AddEpsilons(pairs) `method`

##### Summary

Adds the epsilons.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pairs | [System.Collections.Generic.ICollection{Fare.StatePair}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{Fare.StatePair}') | The pairs. |

<a name='M-Fare-Automaton-CheckMinimizeAlways'></a>
### CheckMinimizeAlways() `method`

##### Summary

The check minimize always.

##### Parameters

This method has no parameters.

<a name='M-Fare-Automaton-ClearHashCode'></a>
### ClearHashCode() `method`

##### Summary

The clear hash code.

##### Parameters

This method has no parameters.

<a name='M-Fare-Automaton-Clone'></a>
### Clone() `method`

##### Summary

Creates a shallow copy of the current Automaton.

##### Returns

A shallow copy of the current Automaton.

##### Parameters

This method has no parameters.

<a name='M-Fare-Automaton-CloneExpanded'></a>
### CloneExpanded() `method`

##### Summary

A clone of this automaton, expands if singleton.

##### Returns

Returns a clone of this automaton, expands if singleton.

##### Parameters

This method has no parameters.

<a name='M-Fare-Automaton-CloneExpandedIfRequired'></a>
### CloneExpandedIfRequired() `method`

##### Summary

A clone of this automaton unless

```
allowMutation
```

is set, expands if singleton.

##### Returns

Returns a clone of this automaton unless

```
allowMutation
```

is set, expands if singleton.

##### Parameters

This method has no parameters.

<a name='M-Fare-Automaton-CloneIfRequired'></a>
### CloneIfRequired() `method`

##### Summary

Returns a clone of this automaton, or this automaton itself if

```
allow_mutation
```

flag is set.

##### Returns

A clone of this automaton, or this automaton itself if

```
allow_mutation
```

flag is set.

##### Parameters

This method has no parameters.

<a name='M-Fare-Automaton-Complement'></a>
### Complement() `method`

##### Summary

Complements this instance.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Fare-Automaton-Concatenate-Fare-Automaton-'></a>
### Concatenate(a) `method`

##### Summary

Concatenates the specified a.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | a. |

<a name='M-Fare-Automaton-Determinize'></a>
### Determinize() `method`

##### Summary

Determinizes this instance.

##### Parameters

This method has no parameters.

<a name='M-Fare-Automaton-ExpandSingleton'></a>
### ExpandSingleton() `method`

##### Summary

Expands singleton representation to normal representation.
Does nothing if not in singleton representation.

##### Parameters

This method has no parameters.

<a name='M-Fare-Automaton-GetAcceptStates'></a>
### GetAcceptStates() `method`

##### Summary

The set of reachable accept states.

##### Returns

Returns the set of reachable accept states.

##### Parameters

This method has no parameters.

<a name='M-Fare-Automaton-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Fare-Automaton-GetLiveStates'></a>
### GetLiveStates() `method`

##### Summary

Returns the set of live states. A state is "live" if an accept state is reachable from it.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Fare-Automaton-GetSortedTransitions-System-Collections-Generic-HashSet{Fare-State}-'></a>
### GetSortedTransitions(states) `method`

##### Summary

Gets the sorted transitions.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| states | [System.Collections.Generic.HashSet{Fare.State}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.HashSet 'System.Collections.Generic.HashSet{Fare.State}') | The states. |

<a name='M-Fare-Automaton-GetStartPoints'></a>
### GetStartPoints() `method`

##### Summary

The sorted array of all interval start points.

##### Returns

Returns sorted array of all interval start points.

##### Parameters

This method has no parameters.

<a name='M-Fare-Automaton-GetStates'></a>
### GetStates() `method`

##### Summary

Gets the set of states that are reachable from the initial state.

##### Returns

The set of states that are reachable from the initial state.

##### Parameters

This method has no parameters.

<a name='M-Fare-Automaton-Intersection-Fare-Automaton-'></a>
### Intersection(a) `method`

##### Summary

Intersections the specified a.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | a. |

<a name='M-Fare-Automaton-IsEmptyString'></a>
### IsEmptyString() `method`

##### Summary

Determines whether [is empty string].

##### Returns

`true` if [is empty string]; otherwise, `false`.

##### Parameters

This method has no parameters.

<a name='M-Fare-Automaton-MakeChar-System-Char-'></a>
### MakeChar(c) `method`

##### Summary

Makes the character.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The c. |

<a name='M-Fare-Automaton-MakeCharSet-System-String-'></a>
### MakeCharSet(set) `method`

##### Summary

Makes the character set.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| set | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The set. |

<a name='M-Fare-Automaton-MakeString-System-String-'></a>
### MakeString(s) `method`

##### Summary

Makes the string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The s. |

<a name='M-Fare-Automaton-Minimize-Fare-Automaton-'></a>
### Minimize(a) `method`

##### Summary

Minimizes the specified a.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | a. |

<a name='M-Fare-Automaton-Minimize'></a>
### Minimize() `method`

##### Summary

The minimize.

##### Parameters

This method has no parameters.

<a name='M-Fare-Automaton-Optional'></a>
### Optional() `method`

##### Summary

Optionals this instance.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Fare-Automaton-RecomputeHashCode'></a>
### RecomputeHashCode() `method`

##### Summary

Recomputes the hash code.
  The automaton must be minimal when this operation is performed.

##### Parameters

This method has no parameters.

<a name='M-Fare-Automaton-Reduce'></a>
### Reduce() `method`

##### Summary

Reduces this automaton.
An automaton is "reduced" by combining overlapping and adjacent edge intervals with same 
destination.

##### Parameters

This method has no parameters.

<a name='M-Fare-Automaton-RemoveDeadTransitions'></a>
### RemoveDeadTransitions() `method`

##### Summary

Removes transitions to dead states and calls Reduce() and ClearHashCode().
(A state is "dead" if no accept state is reachable from it).

##### Parameters

This method has no parameters.

<a name='M-Fare-Automaton-Repeat-System-Int32,System-Int32-'></a>
### Repeat(min,max) `method`

##### Summary

Repeats the specified minimum.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The minimum. |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The maximum. |

<a name='M-Fare-Automaton-Repeat'></a>
### Repeat() `method`

##### Summary

Repeats this instance.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Fare-Automaton-Repeat-System-Int32-'></a>
### Repeat(min) `method`

##### Summary

Repeats the specified minimum.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The minimum. |

<a name='M-Fare-Automaton-Run-System-String-'></a>
### Run(s) `method`

##### Summary

Runs the specified s.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The s. |

<a name='M-Fare-Automaton-SetAllowMutate-System-Boolean-'></a>
### SetAllowMutate(flag) `method`

##### Summary

Sets or resets allow mutate flag. If this flag is set, then all automata operations
may modify automata given as input; otherwise, operations will always leave input
automata languages unmodified. By default, the flag is not set.

##### Returns

The previous value of the flag.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| flag | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` then all automata operations may modify 
automata given as input; otherwise, operations will always leave input automata 
languages unmodified.. |

<a name='M-Fare-Automaton-SetMinimizeAlways-System-Boolean-'></a>
### SetMinimizeAlways(flag) `method`

##### Summary

Sets or resets minimize always flag. If this flag is set, then {@link #minimize()} 
will automatically be invoked after all operations that otherwise may produce 
non-minimal automata. By default, the flag is not set.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| flag | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The flag if true, the flag is set. |

<a name='M-Fare-Automaton-SetStateNumbers-System-Collections-Generic-IEnumerable{Fare-State}-'></a>
### SetStateNumbers(states) `method`

##### Summary

Assigns consecutive numbers to the given states.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| states | [System.Collections.Generic.IEnumerable{Fare.State}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Fare.State}') | The states. |

<a name='M-Fare-Automaton-Totalize'></a>
### Totalize() `method`

##### Summary

Adds transitions to explicit crash state to ensure that transition function is total.

##### Parameters

This method has no parameters.

<a name='T-Fare-BasicAutomata'></a>
## BasicAutomata `type`

##### Namespace

Fare

<a name='M-Fare-BasicAutomata-AnyOfRightLength-System-String,System-Int32-'></a>
### AnyOfRightLength(x,n) `method`

##### Summary

Constructs sub-automaton corresponding to decimal numbers of length x.Substring(n).Length.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| x | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The x. |
| n | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The n. |

<a name='M-Fare-BasicAutomata-AtLeast-System-String,System-Int32,System-Collections-Generic-ICollection{Fare-State},System-Boolean-'></a>
### AtLeast(x,n,initials,zeros) `method`

##### Summary

Constructs sub-automaton corresponding to decimal numbers of value at least x.Substring(n)
and length x.Substring(n).Length.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| x | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The x. |
| n | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The n. |
| initials | [System.Collections.Generic.ICollection{Fare.State}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{Fare.State}') | The initials. |
| zeros | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [zeros]. |

<a name='M-Fare-BasicAutomata-AtMost-System-String,System-Int32-'></a>
### AtMost(x,n) `method`

##### Summary

Constructs sub-automaton corresponding to decimal numbers of value at most x.Substring(n)
and length x.Substring(n).Length.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| x | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The x. |
| n | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The n. |

<a name='M-Fare-BasicAutomata-Between-System-String,System-String,System-Int32,System-Collections-Generic-ICollection{Fare-State},System-Boolean-'></a>
### Between(x,y,n,initials,zeros) `method`

##### Summary

Constructs sub-automaton corresponding to decimal numbers of value between x.Substring(n)
and y.Substring(n) and of length x.Substring(n).Length (which must be equal to 
y.Substring(n).Length).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| x | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The x. |
| y | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The y. |
| n | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The n. |
| initials | [System.Collections.Generic.ICollection{Fare.State}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{Fare.State}') | The initials. |
| zeros | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [zeros]. |

<a name='M-Fare-BasicAutomata-MakeAnyChar'></a>
### MakeAnyChar() `method`

##### Summary

Returns a new (deterministic) automaton that accepts any single character.

##### Returns

A new (deterministic) automaton that accepts any single character.

##### Parameters

This method has no parameters.

<a name='M-Fare-BasicAutomata-MakeAnyString'></a>
### MakeAnyString() `method`

##### Summary

Returns a new (deterministic) automaton that accepts all strings.

##### Returns

A new (deterministic) automaton that accepts all strings.

##### Parameters

This method has no parameters.

<a name='M-Fare-BasicAutomata-MakeChar-System-Char-'></a>
### MakeChar(c) `method`

##### Summary

Returns a new (deterministic) automaton that accepts a single character of the given value.

##### Returns

A new (deterministic) automaton that accepts a single character of the given value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The c. |

<a name='M-Fare-BasicAutomata-MakeCharRange-System-Char,System-Char-'></a>
### MakeCharRange(min,max) `method`

##### Summary

Returns a new (deterministic) automaton that accepts a single char whose value is in the
given interval (including both end points).

##### Returns

A new (deterministic) automaton that accepts a single char whose value is in the
given interval (including both end points).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The min. |
| max | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The max. |

<a name='M-Fare-BasicAutomata-MakeCharSet-System-String-'></a>
### MakeCharSet(set) `method`

##### Summary

Returns a new (deterministic) automaton that accepts a single character in the given set.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| set | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The set. |

<a name='M-Fare-BasicAutomata-MakeDecimalValue-System-String-'></a>
### MakeDecimalValue(value) `method`

##### Summary

Constructs automaton that accept strings representing the given decimal number.
Surrounding whitespace is permitted.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value string representation of decimal number. |

<a name='M-Fare-BasicAutomata-MakeEmpty'></a>
### MakeEmpty() `method`

##### Summary

Returns a new (deterministic) automaton with the empty language.

##### Returns

A new (deterministic) automaton with the empty language.

##### Parameters

This method has no parameters.

<a name='M-Fare-BasicAutomata-MakeEmptyString'></a>
### MakeEmptyString() `method`

##### Summary

Returns a new (deterministic) automaton that accepts only the empty string.

##### Returns

A new (deterministic) automaton that accepts only the empty string.

##### Parameters

This method has no parameters.

<a name='M-Fare-BasicAutomata-MakeFractionDigits-System-Int32-'></a>
### MakeFractionDigits(i) `method`

##### Summary

Constructs automaton that accept strings representing decimal numbers that can be 
written with at most the given number of digits in the fraction part. Surrounding
whitespace is permitted.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| i | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The i max number of necessary fraction digits. |

<a name='M-Fare-BasicAutomata-MakeIntegerValue-System-String-'></a>
### MakeIntegerValue(value) `method`

##### Summary

Constructs automaton that accept strings representing the given integer. Surrounding 
whitespace is permitted.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value string representation of integer. |

<a name='M-Fare-BasicAutomata-MakeInterval-System-Int32,System-Int32,System-Int32-'></a>
### MakeInterval(min,max,digits) `method`

##### Summary

Returns a new automaton that accepts strings representing decimal non-negative integers in
the given interval.

##### Returns

A new automaton that accepts strings representing decimal non-negative integers 
in the given interval.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The minimum value of interval. |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The maximum value of inverval (both end points are included in the 
interval). |
| digits | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | If f >0, use fixed number of digits (strings must be prefixed by 0's 
to obtain the right length) otherwise, the number of digits is not fixed. |

<a name='M-Fare-BasicAutomata-MakeMaxInteger-System-String-'></a>
### MakeMaxInteger(n) `method`

##### Summary

Constructs automaton that accept strings representing nonnegative integer that are not 
larger than the given value.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| n | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The n string representation of maximum value. |

<a name='M-Fare-BasicAutomata-MakeMinInteger-System-String-'></a>
### MakeMinInteger(n) `method`

##### Summary

Constructs automaton that accept strings representing nonnegative integers that are not
less that the given value.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| n | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The n string representation of minimum value. |

<a name='M-Fare-BasicAutomata-MakeString-System-String-'></a>
### MakeString(s) `method`

##### Summary

Returns a new (deterministic) automaton that accepts the single given string.

##### Returns

A new (deterministic) automaton that accepts the single given string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string. |

<a name='M-Fare-BasicAutomata-MakeStringMatcher-System-String-'></a>
### MakeStringMatcher(s) `method`

##### Summary

Constructs deterministic automaton that matches strings that contain the given substring.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The s. |

<a name='M-Fare-BasicAutomata-MakeStringUnion-System-Char[][]-'></a>
### MakeStringUnion(strings) `method`

##### Summary

Returns a new (deterministic and minimal) automaton that accepts the union of the given
set of strings. The input character sequences are internally sorted in-place, so the 
input array is modified. @see StringUnionOperations.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| strings | [System.Char[][]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char[][] 'System.Char[][]') | The strings. |

<a name='M-Fare-BasicAutomata-MakeTotalDigits-System-Int32-'></a>
### MakeTotalDigits(i) `method`

##### Summary

Constructs automaton that accept strings representing decimal numbers that can be 
written with at most the given number of digits. Surrounding whitespace is permitted.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| i | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The i max number of necessary digits. |

<a name='T-Fare-BasicOperations'></a>
## BasicOperations `type`

##### Namespace

Fare

<a name='M-Fare-BasicOperations-AddEpsilons-Fare-Automaton,System-Collections-Generic-ICollection{Fare-StatePair}-'></a>
### AddEpsilons(a,pairs) `method`

##### Summary

Adds epsilon transitions to the given automaton. This method adds extra character interval
transitions that are equivalent to the given set of epsilon transitions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |
| pairs | [System.Collections.Generic.ICollection{Fare.StatePair}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{Fare.StatePair}') | A collection of [StatePair](#T-Fare-StatePair 'Fare.StatePair') objects representing pairs of
source/destination states where epsilon transitions should be added. |

<a name='M-Fare-BasicOperations-Complement-Fare-Automaton-'></a>
### Complement(a) `method`

##### Summary

Returns a (deterministic) automaton that accepts the complement of the language of the 
given automaton.

##### Returns

A (deterministic) automaton that accepts the complement of the language of the 
given automaton.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |

##### Remarks

Complexity: linear in number of states (if already deterministic).

<a name='M-Fare-BasicOperations-Concatenate-Fare-Automaton,Fare-Automaton-'></a>
### Concatenate(a1,a2) `method`

##### Summary

Concatenates the specified a1.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a1 | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The a1. |
| a2 | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The a2. |

<a name='M-Fare-BasicOperations-Concatenate-System-Collections-Generic-IList{Fare-Automaton}-'></a>
### Concatenate(l) `method`

##### Summary

Concatenates the specified l.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| l | [System.Collections.Generic.IList{Fare.Automaton}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{Fare.Automaton}') | The l. |

<a name='M-Fare-BasicOperations-Determinize-Fare-Automaton-'></a>
### Determinize(a) `method`

##### Summary

Determinizes the specified automaton.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |

##### Remarks

Complexity: exponential in number of states.

<a name='M-Fare-BasicOperations-Determinize-Fare-Automaton,System-Collections-Generic-List{Fare-State}-'></a>
### Determinize(a,initialset) `method`

##### Summary

Determinizes the given automaton using the given set of initial states.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |
| initialset | [System.Collections.Generic.List{Fare.State}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{Fare.State}') | The initial states. |

<a name='M-Fare-BasicOperations-Intersection-Fare-Automaton,Fare-Automaton-'></a>
### Intersection(a1,a2) `method`

##### Summary

Returns an automaton that accepts the intersection of the languages of the given automata.
Never modifies the input automata languages.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a1 | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The a1. |
| a2 | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The a2. |

<a name='M-Fare-BasicOperations-IsEmpty-Fare-Automaton-'></a>
### IsEmpty(a) `method`

##### Summary

Determines whether the given automaton accepts no strings.

##### Returns

`true` if the given automaton accepts no strings; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |

<a name='M-Fare-BasicOperations-IsEmptyString-Fare-Automaton-'></a>
### IsEmptyString(a) `method`

##### Summary

Determines whether the given automaton accepts the empty string and nothing else.

##### Returns

`true` if the given automaton accepts the empty string and nothing else; otherwise,
`false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |

<a name='M-Fare-BasicOperations-Optional-Fare-Automaton-'></a>
### Optional(a) `method`

##### Summary

Returns an automaton that accepts the union of the empty string and the language of the 
given automaton.

##### Returns

An automaton that accepts the union of the empty string and the language of the 
given automaton.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |

##### Remarks

Complexity: linear in number of states.

<a name='M-Fare-BasicOperations-Repeat-Fare-Automaton-'></a>
### Repeat(a) `method`

##### Summary

Accepts the Kleene star (zero or more concatenated repetitions) of the language of the
given automaton. Never modifies the input automaton language.

##### Returns

An automaton that accepts the Kleene star (zero or more concatenated repetitions)
of the language of the given automaton. Never modifies the input automaton language.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |

##### Remarks

Complexity: linear in number of states.

<a name='M-Fare-BasicOperations-Repeat-Fare-Automaton,System-Int32-'></a>
### Repeat(a,min) `method`

##### Summary

Accepts

```
min
```

or more concatenated repetitions of the language of the given 
automaton.

##### Returns

Returns an automaton that accepts

```
min
```

or more concatenated 
repetitions of the language of the given automaton.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |
| min | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The minimum concatenated repetitions of the language of the given 
automaton. |

##### Remarks

Complexity: linear in number of states and in

```
min
```

.

<a name='M-Fare-BasicOperations-Repeat-Fare-Automaton,System-Int32,System-Int32-'></a>
### Repeat(a,min,max) `method`

##### Summary

Accepts between

```
min
```

and

```
max
```

(including both) concatenated
repetitions of the language of the given automaton.

##### Returns

Returns an automaton that accepts between

```
min
```

and

```
max
```

(including both) concatenated repetitions of the language of the given automaton.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |
| min | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The minimum concatenated repetitions of the language of the given
automaton. |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The maximum concatenated repetitions of the language of the given
automaton. |

##### Remarks

Complexity: linear in number of states and in

```
min
```

and

```
max
```

.

<a name='M-Fare-BasicOperations-Run-Fare-Automaton,System-String-'></a>
### Run(a,s) `method`

##### Summary

Returns true if the given string is accepted by the automaton.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string. |

##### Remarks

Complexity: linear in the length of the string.
For full performance, use the RunAutomaton class.

<a name='M-Fare-BasicOperations-Union-System-Collections-Generic-IList{Fare-Automaton}-'></a>
### Union(automatons) `method`

##### Summary

Returns an automaton that accepts the union of the languages of the given automata.

##### Returns

An automaton that accepts the union of the languages of the given automata.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| automatons | [System.Collections.Generic.IList{Fare.Automaton}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{Fare.Automaton}') | The l. |

##### Remarks

Complexity: linear in number of states.

<a name='T-RandomDataGenerator-CreditCardValidator-CardIssuer'></a>
## CardIssuer `type`

##### Namespace

RandomDataGenerator.CreditCardValidator

##### Summary

Accepted Card Issuers Institutes.

<a name='F-RandomDataGenerator-CreditCardValidator-CardIssuer-AmericanExpress'></a>
### AmericanExpress `constants`

##### Summary

The american express card

<a name='F-RandomDataGenerator-CreditCardValidator-CardIssuer-Any'></a>
### Any `constants`

##### Summary

Choose any card from below

<a name='F-RandomDataGenerator-CreditCardValidator-CardIssuer-ChinaUnionPay'></a>
### ChinaUnionPay `constants`

##### Summary

The china union pay card

<a name='F-RandomDataGenerator-CreditCardValidator-CardIssuer-Dankort'></a>
### Dankort `constants`

##### Summary

The dankort card

<a name='F-RandomDataGenerator-CreditCardValidator-CardIssuer-DinersClub'></a>
### DinersClub `constants`

##### Summary

The diners club card

<a name='F-RandomDataGenerator-CreditCardValidator-CardIssuer-Discover'></a>
### Discover `constants`

##### Summary

The discover card

<a name='F-RandomDataGenerator-CreditCardValidator-CardIssuer-Hipercard'></a>
### Hipercard `constants`

##### Summary

The hiper card

<a name='F-RandomDataGenerator-CreditCardValidator-CardIssuer-JCB'></a>
### JCB `constants`

##### Summary

The JCB card

<a name='F-RandomDataGenerator-CreditCardValidator-CardIssuer-Laser'></a>
### Laser `constants`

##### Summary

The laser card

<a name='F-RandomDataGenerator-CreditCardValidator-CardIssuer-Maestro'></a>
### Maestro `constants`

##### Summary

The maestro card

<a name='F-RandomDataGenerator-CreditCardValidator-CardIssuer-MasterCard'></a>
### MasterCard `constants`

##### Summary

The master card

<a name='F-RandomDataGenerator-CreditCardValidator-CardIssuer-RuPay'></a>
### RuPay `constants`

##### Summary

The rupay card

<a name='F-RandomDataGenerator-CreditCardValidator-CardIssuer-Switch'></a>
### Switch `constants`

##### Summary

The switch card

<a name='F-RandomDataGenerator-CreditCardValidator-CardIssuer-Visa'></a>
### Visa `constants`

##### Summary

The visa card

<a name='T-RandomDataGenerator-CreditCardValidator-CreditCardData'></a>
## CreditCardData `type`

##### Namespace

RandomDataGenerator.CreditCardValidator

<a name='M-RandomDataGenerator-CreditCardValidator-CreditCardData-GenerateRange-System-Int32,System-Int32-'></a>
### GenerateRange(start,end) `method`

##### Summary

Includes start and end values in the result.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| end | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='T-System-Reflection-CustomIntrospectionExtensions'></a>
## CustomIntrospectionExtensions `type`

##### Namespace

System.Reflection

##### Summary

https://github.com/castleproject/Core/blob/netcore/src/Castle.Core/Compatibility/IntrospectionExtensions.cs

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract'></a>
## FieldOptionsAbstract `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

Abstract class for field options

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsAbstract-Seed'></a>
### Seed `property`

##### Summary

Gets or sets the seed.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsAbstract-UseNullValues'></a>
### UseNullValues `property`

##### Summary

Gets or sets a value indicating whether [use null values].

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsAbstract-ValueAsString'></a>
### ValueAsString `property`

##### Summary

Gets or sets a value indicating whether [value as string].

<a name='M-RandomDataGenerator-FieldOptions-FieldOptionsAbstract-Clone'></a>
### Clone() `method`

##### Summary

Clones this instance.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsBoolean'></a>
## FieldOptionsBoolean `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

Boolean Field Options

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsNumber<System.Boolean>](#!-RandomDataGenerator-FieldOptions-FieldOptionsNumber<System-Boolean> 'RandomDataGenerator.FieldOptions.FieldOptionsNumber<System.Boolean>')

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsByte'></a>
## FieldOptionsByte `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

byte field options.

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsNumber<System.Byte>](#!-RandomDataGenerator-FieldOptions-FieldOptionsNumber<System-Byte> 'RandomDataGenerator.FieldOptions.FieldOptionsNumber<System.Byte>')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsByte-Max'></a>
### Max `property`

##### Summary

Determines the maximum value to generate.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsByte-Min'></a>
### Min `property`

##### Summary

Determines the minimum value to generate.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsBytes'></a>
## FieldOptionsBytes `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

Bytes field options.

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsBytes](#T-RandomDataGenerator-FieldOptions-IFieldOptionsBytes 'RandomDataGenerator.FieldOptions.IFieldOptionsBytes')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsBytes-Max'></a>
### Max `property`

##### Summary

Determines the maximum  value to generate.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsBytes-Min'></a>
### Min `property`

##### Summary

Determines the minimum value to generate.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsCCN'></a>
## FieldOptionsCCN `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

CCN Field Options

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsString](#T-RandomDataGenerator-FieldOptions-IFieldOptionsString 'RandomDataGenerator.FieldOptions.IFieldOptionsString')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsCCN-CardIssuer'></a>
### CardIssuer `property`

##### Summary

Gets or sets the card issuer.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsCCN-Length'></a>
### Length `property`

##### Summary

Gets or sets the length.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsCity'></a>
## FieldOptionsCity `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary



##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsString](#T-RandomDataGenerator-FieldOptions-IFieldOptionsString 'RandomDataGenerator.FieldOptions.IFieldOptionsString')

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsCountry'></a>
## FieldOptionsCountry `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

Country Options

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsString](#T-RandomDataGenerator-FieldOptions-IFieldOptionsString 'RandomDataGenerator.FieldOptions.IFieldOptionsString')

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsDateTime'></a>
## FieldOptionsDateTime `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

DateTime field options

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsDateTime](#T-RandomDataGenerator-FieldOptions-IFieldOptionsDateTime 'RandomDataGenerator.FieldOptions.IFieldOptionsDateTime')

<a name='F-RandomDataGenerator-FieldOptions-FieldOptionsDateTime-DefaultFormat'></a>
### DefaultFormat `constants`

##### Summary

The default format

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsDateTime-Format'></a>
### Format `property`

##### Summary

Gets or sets the format.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsDateTime-From'></a>
### From `property`

##### Summary

Gets or sets from.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsDateTime-IncludeTime'></a>
### IncludeTime `property`

##### Summary

Gets or sets a value indicating whether [include time].

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsDateTime-To'></a>
### To `property`

##### Summary

Gets or sets to.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsDouble'></a>
## FieldOptionsDouble `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

Double Field Options

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsNumber<System.Double>](#!-RandomDataGenerator-FieldOptions-FieldOptionsNumber<System-Double> 'RandomDataGenerator.FieldOptions.FieldOptionsNumber<System.Double>')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsDouble-Max'></a>
### Max `property`

##### Summary

Determines the maximum value to generate.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsDouble-Min'></a>
### Min `property`

##### Summary

Determines the minimum value to generate.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsEmailAddress'></a>
## FieldOptionsEmailAddress `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

Email Address Field Options

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsString](#T-RandomDataGenerator-FieldOptions-IFieldOptionsString 'RandomDataGenerator.FieldOptions.IFieldOptionsString')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsEmailAddress-Female'></a>
### Female `property`

##### Summary

Gets or sets a value indicating whether this [FieldOptionsEmailAddress](#T-RandomDataGenerator-FieldOptions-FieldOptionsEmailAddress 'RandomDataGenerator.FieldOptions.FieldOptionsEmailAddress') can be female.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsEmailAddress-Left2Right'></a>
### Left2Right `property`

##### Summary

Gets or sets a value indicating whether [left2 right].

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsEmailAddress-Male'></a>
### Male `property`

##### Summary

Gets or sets a value indicating whether this [FieldOptionsEmailAddress](#T-RandomDataGenerator-FieldOptions-FieldOptionsEmailAddress 'RandomDataGenerator.FieldOptions.FieldOptionsEmailAddress') can be male.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsFactory'></a>
## FieldOptionsFactory `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

Factory for creating field options

<a name='M-RandomDataGenerator-FieldOptions-FieldOptionsFactory-GetFieldOptions-RandomDataGenerator-Enums-SubFieldType-'></a>
### GetFieldOptions(subFieldType) `method`

##### Summary

Gets the field options.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| subFieldType | [RandomDataGenerator.Enums.SubFieldType](#T-RandomDataGenerator-Enums-SubFieldType 'RandomDataGenerator.Enums.SubFieldType') | Type of the sub field. |

<a name='M-RandomDataGenerator-FieldOptions-FieldOptionsFactory-GetFieldOptions-System-String,System-Collections-Generic-Dictionary{System-String,System-Object}-'></a>
### GetFieldOptions(name,properties) `method`

##### Summary

Gets the field options.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name. |
| properties | [System.Collections.Generic.Dictionary{System.String,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.Object}') | The properties. |

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsFirstName'></a>
## FieldOptionsFirstName `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

First name options

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsString](#T-RandomDataGenerator-FieldOptions-IFieldOptionsString 'RandomDataGenerator.FieldOptions.IFieldOptionsString')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsFirstName-Female'></a>
### Female `property`

##### Summary

Gets or sets a value indicating whether this [FieldOptionsFirstName](#T-RandomDataGenerator-FieldOptions-FieldOptionsFirstName 'RandomDataGenerator.FieldOptions.FieldOptionsFirstName') is female.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsFirstName-Male'></a>
### Male `property`

##### Summary

Gets or sets a value indicating whether this [FieldOptionsFirstName](#T-RandomDataGenerator-FieldOptions-FieldOptionsFirstName 'RandomDataGenerator.FieldOptions.FieldOptionsFirstName') is male.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsFloat'></a>
## FieldOptionsFloat `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

Float Field Options

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsNumber<System.Single>](#!-RandomDataGenerator-FieldOptions-FieldOptionsNumber<System-Single> 'RandomDataGenerator.FieldOptions.FieldOptionsNumber<System.Single>')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsFloat-Max'></a>
### Max `property`

##### Summary

Determines the maximum value to generate.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsFloat-Min'></a>
### Min `property`

##### Summary

Determines the minimum value to generate.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsFullName'></a>
## FieldOptionsFullName `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

Full name options

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsString](#T-RandomDataGenerator-FieldOptions-IFieldOptionsString 'RandomDataGenerator.FieldOptions.IFieldOptionsString')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsFullName-Female'></a>
### Female `property`

##### Summary

Gets or sets a value indicating whether this [FieldOptionsFullName](#T-RandomDataGenerator-FieldOptions-FieldOptionsFullName 'RandomDataGenerator.FieldOptions.FieldOptionsFullName') is female.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsFullName-Left2Right'></a>
### Left2Right `property`

##### Summary

Gets or sets a value indicating whether [left2 right].

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsFullName-Male'></a>
### Male `property`

##### Summary

Gets or sets a value indicating whether this [FieldOptionsFullName](#T-RandomDataGenerator-FieldOptions-FieldOptionsFullName 'RandomDataGenerator.FieldOptions.FieldOptionsFullName') is male.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsGuid'></a>
## FieldOptionsGuid `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

Guid Field Options

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsGuid](#T-RandomDataGenerator-FieldOptions-IFieldOptionsGuid 'RandomDataGenerator.FieldOptions.IFieldOptionsGuid')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsGuid-Format'></a>
### Format `property`

##### Summary

Gets or sets the format.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsGuid-Uppercase'></a>
### Uppercase `property`

##### Summary

Gets or sets a value indicating whether this [FieldOptionsGuid](#T-RandomDataGenerator-FieldOptions-FieldOptionsGuid 'RandomDataGenerator.FieldOptions.FieldOptionsGuid') is uppercase.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsIBAN'></a>
## FieldOptionsIBAN `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

Ibans are used to identify individual bank accounts for both incoming and outgoing international money transfer.

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsString](#T-RandomDataGenerator-FieldOptions-IFieldOptionsString 'RandomDataGenerator.FieldOptions.IFieldOptionsString')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsIBAN-CountryCode'></a>
### CountryCode `property`

##### Summary

Gets or sets the country code.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsIBAN-Type'></a>
### Type `property`

##### Summary

The type can be IBAN (default), BBAN or BOTH. In case the value is null, IBAN is used as default.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsIPv4Address'></a>
## FieldOptionsIPv4Address `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

Ip v4 address field options.

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsString](#T-RandomDataGenerator-FieldOptions-IFieldOptionsString 'RandomDataGenerator.FieldOptions.IFieldOptionsString')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsIPv4Address-Max'></a>
### Max `property`

##### Summary

Determines the maximum value to generate.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsIPv4Address-Min'></a>
### Min `property`

##### Summary

Determines the minimum value to generate.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsIPv6Address'></a>
## FieldOptionsIPv6Address `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

IPv6 Address Field Options

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsString](#T-RandomDataGenerator-FieldOptions-IFieldOptionsString 'RandomDataGenerator.FieldOptions.IFieldOptionsString')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsIPv6Address-Max'></a>
### Max `property`

##### Summary

Determines the maximum value to generate.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsIPv6Address-Min'></a>
### Min `property`

##### Summary

Determines the minimum value to generate.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsIPv6Address-Uppercase'></a>
### Uppercase `property`

##### Summary

Gets or sets a value indicating whether this [FieldOptionsIPv6Address](#T-RandomDataGenerator-FieldOptions-FieldOptionsIPv6Address 'RandomDataGenerator.FieldOptions.FieldOptionsIPv6Address') is uppercase.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsInteger'></a>
## FieldOptionsInteger `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

Integer field options.

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsNumber<System.Int32>](#!-RandomDataGenerator-FieldOptions-FieldOptionsNumber<System-Int32> 'RandomDataGenerator.FieldOptions.FieldOptionsNumber<System.Int32>')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsInteger-Max'></a>
### Max `property`

##### Summary

Determines the maximum value to generate.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsInteger-Min'></a>
### Min `property`

##### Summary

Determines the minimum value to generate.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsLastName'></a>
## FieldOptionsLastName `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

LastName field options.

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsString](#T-RandomDataGenerator-FieldOptions-IFieldOptionsString 'RandomDataGenerator.FieldOptions.IFieldOptionsString')

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsLong'></a>
## FieldOptionsLong `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

Long field options.

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsNumber<System.Int64>](#!-RandomDataGenerator-FieldOptions-FieldOptionsNumber<System-Int64> 'RandomDataGenerator.FieldOptions.FieldOptionsNumber<System.Int64>')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsLong-Max'></a>
### Max `property`

##### Summary

Determines the maximum value to generate.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsLong-Min'></a>
### Min `property`

##### Summary

Determines the minimum value to generate.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsMACAddress'></a>
## FieldOptionsMACAddress `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

Mac Address Field Options

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsString](#T-RandomDataGenerator-FieldOptions-IFieldOptionsString 'RandomDataGenerator.FieldOptions.IFieldOptionsString')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsMACAddress-Max'></a>
### Max `property`

##### Summary

Determines the maximum value to generate.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsMACAddress-Min'></a>
### Min `property`

##### Summary

Determines the minimum value to generate.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsMACAddress-Separator'></a>
### Separator `property`

##### Summary

Gets or sets the separator.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsMACAddress-Uppercase'></a>
### Uppercase `property`

##### Summary

Gets or sets a value indicating whether this [FieldOptionsMACAddress](#T-RandomDataGenerator-FieldOptions-FieldOptionsMACAddress 'RandomDataGenerator.FieldOptions.FieldOptionsMACAddress') is uppercase.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsNumber`1'></a>
## FieldOptionsNumber\`1 `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

abstract class for number options

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsNumber\`1](#T-RandomDataGenerator-FieldOptions-IFieldOptionsNumber`1 'RandomDataGenerator.FieldOptions.IFieldOptionsNumber`1')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsNumber`1-Max'></a>
### Max `property`

##### Summary

Determines the maximum value to generate.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsNumber`1-Min'></a>
### Min `property`

##### Summary

Determines the minimum value to generate.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsShort'></a>
## FieldOptionsShort `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

Short Field Options

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsNumber<System.Int16>](#!-RandomDataGenerator-FieldOptions-FieldOptionsNumber<System-Int16> 'RandomDataGenerator.FieldOptions.FieldOptionsNumber<System.Int16>')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsShort-Max'></a>
### Max `property`

##### Summary

Determines the maximum value to generate.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsShort-Min'></a>
### Min `property`

##### Summary

Determines the minimum value to generate.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsStringList'></a>
## FieldOptionsStringList `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

String List Field options class

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsString](#T-RandomDataGenerator-FieldOptions-IFieldOptionsString 'RandomDataGenerator.FieldOptions.IFieldOptionsString')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsStringList-Values'></a>
### Values `property`

##### Summary

Gets or sets the values.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsText'></a>
## FieldOptionsText `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

Text randomizer options

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsString](#T-RandomDataGenerator-FieldOptions-IFieldOptionsString 'RandomDataGenerator.FieldOptions.IFieldOptionsString')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsText-Max'></a>
### Max `property`

##### Summary

Determines the maximum value to generate.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsText-Min'></a>
### Min `property`

##### Summary

Determines the minimum value to generate.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsText-UseLetter'></a>
### UseLetter `property`

##### Summary

Gets or sets a value indicating whether [use letter].

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsText-UseLowercase'></a>
### UseLowercase `property`

##### Summary

Gets or sets a value indicating whether [use lowercase].

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsText-UseNumber'></a>
### UseNumber `property`

##### Summary

Gets or sets a value indicating whether [use number].

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsText-UseSpace'></a>
### UseSpace `property`

##### Summary

Gets or sets a value indicating whether [use space].

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsText-UseSpecial'></a>
### UseSpecial `property`

##### Summary

Gets or sets a value indicating whether [use special].

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsText-UseUppercase'></a>
### UseUppercase `property`

##### Summary

Gets or sets a value indicating whether [use uppercase].

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsTextLipsum'></a>
## FieldOptionsTextLipsum `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

TextLipsum field options

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsString](#T-RandomDataGenerator-FieldOptions-IFieldOptionsString 'RandomDataGenerator.FieldOptions.IFieldOptionsString')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsTextLipsum-Paragraphs'></a>
### Paragraphs `property`

##### Summary

Gets or sets the paragraphs count

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsTextNaughtyStrings'></a>
## FieldOptionsTextNaughtyStrings `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

Text naughty strings options

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsString](#T-RandomDataGenerator-FieldOptions-IFieldOptionsString 'RandomDataGenerator.FieldOptions.IFieldOptionsString')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsTextNaughtyStrings-Categories'></a>
### Categories `property`

##### Summary

A comma separated string from one or more from these categories:

 All
 Changinglengthwhenlowercased
 CommandInjectionRuby
 Emoji
 FileInclusion
 Humaninjection
 JapaneseEmoticons
 KnownCVEsandVulnerabilities
 MSDOSWindowsSpecialFilenames
 NumericStrings
 OghamText
 QuotationMarks
 ReservedStrings
 RightToLeftStrings
 SQLInjection
 ScriptInjection
 ScunthorpeProblem
 ServerCodeInjection
 SpecialCharacters
 SpecialUnicodeCharactersUnion
 Stringswhichcontaintwobyteletters
 Terminalescapecodes
 TrickUnicode
 TwoByteCharacters
 UnicodeNumbers
 UnicodeSubscriptSuperscriptAccents
 UnicodeSymbols
 UnicodeUpsidedown
 Unicodefont
 UnwantedInterpolation
 ZalgoText
 iOSVulnerabilities

 When null, the 'All' category is used.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsTextRegex'></a>
## FieldOptionsTextRegex `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

TextRegex Field Options

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsString](#T-RandomDataGenerator-FieldOptions-IFieldOptionsString 'RandomDataGenerator.FieldOptions.IFieldOptionsString')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsTextRegex-Pattern'></a>
### Pattern `property`

##### Summary

Use any valid Regex pattern to generate a string.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsTextWords'></a>
## FieldOptionsTextWords `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

TextWords field options.

##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsString](#T-RandomDataGenerator-FieldOptions-IFieldOptionsString 'RandomDataGenerator.FieldOptions.IFieldOptionsString')

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsTextWords-Max'></a>
### Max `property`

##### Summary

Determines the maximum value to generate.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsTextWords-Min'></a>
### Min `property`

##### Summary

Determines the minimum value to generate.

<a name='T-RandomDataGenerator-FieldOptions-FieldOptionsTimeSpan'></a>
## FieldOptionsTimeSpan `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary



##### See Also

- [RandomDataGenerator.FieldOptions.FieldOptionsAbstract](#T-RandomDataGenerator-FieldOptions-FieldOptionsAbstract 'RandomDataGenerator.FieldOptions.FieldOptionsAbstract')
- [RandomDataGenerator.FieldOptions.IFieldOptionsTimeSpan](#T-RandomDataGenerator-FieldOptions-IFieldOptionsTimeSpan 'RandomDataGenerator.FieldOptions.IFieldOptionsTimeSpan')

<a name='F-RandomDataGenerator-FieldOptions-FieldOptionsTimeSpan-DefaultFormat'></a>
### DefaultFormat `constants`

##### Summary

The default format

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsTimeSpan-Format'></a>
### Format `property`

##### Summary

Allowed values are "c", "g" and "G".
See https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-timespan-format-strings

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsTimeSpan-From'></a>
### From `property`

##### Summary

Gets or sets from.

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsTimeSpan-IncludeMilliseconds'></a>
### IncludeMilliseconds `property`

##### Summary

Gets or sets a value indicating whether [include milliseconds].

<a name='P-RandomDataGenerator-FieldOptions-FieldOptionsTimeSpan-To'></a>
### To `property`

##### Summary

Gets or sets to.

<a name='T-RandomDataGenerator-Enums-FieldType'></a>
## FieldType `type`

##### Namespace

RandomDataGenerator.Enums

##### Summary

Type of field

<a name='F-RandomDataGenerator-Enums-FieldType-Human'></a>
### Human `constants`

##### Summary

Human

<a name='F-RandomDataGenerator-Enums-FieldType-IT'></a>
### IT `constants`

##### Summary

IT

<a name='F-RandomDataGenerator-Enums-FieldType-Location'></a>
### Location `constants`

##### Summary

Location

<a name='F-RandomDataGenerator-Enums-FieldType-None'></a>
### None `constants`

##### Summary

The none

<a name='F-RandomDataGenerator-Enums-FieldType-Numbers'></a>
### Numbers `constants`

##### Summary

Numbers

<a name='F-RandomDataGenerator-Enums-FieldType-Set'></a>
### Set `constants`

##### Summary

Set

<a name='F-RandomDataGenerator-Enums-FieldType-Text'></a>
### Text `constants`

##### Summary

Text

<a name='F-RandomDataGenerator-Enums-FieldType-Time'></a>
### Time `constants`

##### Summary

Time

<a name='T-RandomDataGenerator-FieldOptions-IFieldOptionsBytes'></a>
## IFieldOptionsBytes `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary



<a name='P-RandomDataGenerator-FieldOptions-IFieldOptionsBytes-Max'></a>
### Max `property`

##### Summary

Determines the maximum value to generate.

<a name='P-RandomDataGenerator-FieldOptions-IFieldOptionsBytes-Min'></a>
### Min `property`

##### Summary

Determines the minimum value to generate.

<a name='T-RandomDataGenerator-FieldOptions-IFieldOptionsDateTime'></a>
## IFieldOptionsDateTime `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary



<a name='P-RandomDataGenerator-FieldOptions-IFieldOptionsDateTime-From'></a>
### From `property`

##### Summary

Gets or sets from.

<a name='P-RandomDataGenerator-FieldOptions-IFieldOptionsDateTime-IncludeTime'></a>
### IncludeTime `property`

##### Summary

Gets or sets a value indicating whether [include time].

<a name='P-RandomDataGenerator-FieldOptions-IFieldOptionsDateTime-To'></a>
### To `property`

##### Summary

Gets or sets to.

<a name='T-RandomDataGenerator-FieldOptions-IFieldOptionsGuid'></a>
## IFieldOptionsGuid `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary



<a name='P-RandomDataGenerator-FieldOptions-IFieldOptionsGuid-Uppercase'></a>
### Uppercase `property`

##### Summary

Gets or sets a value indicating whether this [IFieldOptionsGuid](#T-RandomDataGenerator-FieldOptions-IFieldOptionsGuid 'RandomDataGenerator.FieldOptions.IFieldOptionsGuid') is uppercase.

<a name='T-RandomDataGenerator-FieldOptions-IFieldOptionsNumber`1'></a>
## IFieldOptionsNumber\`1 `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

Number field options interface

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='T-RandomDataGenerator-FieldOptions-IFieldOptionsString'></a>
## IFieldOptionsString `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

String option interface

<a name='T-RandomDataGenerator-FieldOptions-IFieldOptionsTimeSpan'></a>
## IFieldOptionsTimeSpan `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

Timespan field options interface

<a name='P-RandomDataGenerator-FieldOptions-IFieldOptionsTimeSpan-Format'></a>
### Format `property`

##### Summary

Allowed values are "c", "g" and "G".
See https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-timespan-format-strings

<a name='P-RandomDataGenerator-FieldOptions-IFieldOptionsTimeSpan-From'></a>
### From `property`

##### Summary

Gets or sets from.

<a name='P-RandomDataGenerator-FieldOptions-IFieldOptionsTimeSpan-To'></a>
### To `property`

##### Summary

Gets or sets to.

<a name='T-RandomDataGenerator-Randomizers-IRandomizerBytes'></a>
## IRandomizerBytes `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

Bytes randomizer interface

<a name='M-RandomDataGenerator-Randomizers-IRandomizerBytes-Generate'></a>
### Generate() `method`

##### Summary

Generates this instance.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-IRandomizerBytes-GenerateAsASCIIString'></a>
### GenerateAsASCIIString() `method`

##### Summary

Generates as ASCII string.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-IRandomizerBytes-GenerateAsBase64String'></a>
### GenerateAsBase64String() `method`

##### Summary

Generates as base64 string.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-IRandomizerBytes-GenerateAsString-System-Text-Encoding-'></a>
### GenerateAsString(encoding) `method`

##### Summary

Generates as string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | The encoding. |

<a name='M-RandomDataGenerator-Randomizers-IRandomizerBytes-GenerateAsUTF8String'></a>
### GenerateAsUTF8String() `method`

##### Summary

Generates as ut f8 string.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-RandomDataGenerator-Randomizers-IRandomizerDateTime'></a>
## IRandomizerDateTime `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

DateTime randomizer interface

<a name='M-RandomDataGenerator-Randomizers-IRandomizerDateTime-Generate'></a>
### Generate() `method`

##### Summary

Generates this instance.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-IRandomizerDateTime-GenerateAsString'></a>
### GenerateAsString() `method`

##### Summary

Generates as string.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-RandomDataGenerator-Randomizers-IRandomizerGuid'></a>
## IRandomizerGuid `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

Guid randomizer interface

<a name='M-RandomDataGenerator-Randomizers-IRandomizerGuid-Generate'></a>
### Generate() `method`

##### Summary

Generates this instance.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-IRandomizerGuid-GenerateAsString'></a>
### GenerateAsString() `method`

##### Summary

Generates as string.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-RandomDataGenerator-Randomizers-IRandomizerNumber`1'></a>
## IRandomizerNumber\`1 `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

number randomizer interface

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-RandomDataGenerator-Randomizers-IRandomizerNumber`1-Generate'></a>
### Generate() `method`

##### Summary

Generates this instance.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-RandomDataGenerator-Randomizers-IRandomizerString'></a>
## IRandomizerString `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

string randomizer interface

<a name='M-RandomDataGenerator-Randomizers-IRandomizerString-Generate'></a>
### Generate() `method`

##### Summary

Generates the value string.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-IRandomizerString-Generate-System-Boolean-'></a>
### Generate(upperCase) `method`

##### Summary

Generates the value string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| upperCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [upper case]. |

<a name='T-RandomDataGenerator-Randomizers-IRandomizerTimeSpan'></a>
## IRandomizerTimeSpan `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

Timespan randomizer interface

<a name='M-RandomDataGenerator-Randomizers-IRandomizerTimeSpan-Generate'></a>
### Generate() `method`

##### Summary

Generates this instance.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-IRandomizerTimeSpan-GenerateAsString'></a>
### GenerateAsString() `method`

##### Summary

Generates as string.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Fare-ListEqualityComparer`1'></a>
## ListEqualityComparer\`1 `type`

##### Namespace

Fare

<a name='M-Fare-ListEqualityComparer`1-Equals-System-Collections-Generic-List{`0},System-Collections-Generic-List{`0}-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Fare-ListEqualityComparer`1-Equals-Fare-ListEqualityComparer{`0}-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Fare-ListEqualityComparer`1-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Fare-ListEqualityComparer`1-GetHashCode-System-Collections-Generic-List{`0}-'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Fare-ListEqualityComparer`1-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Fare-ListEqualityComparer`1-op_Equality-Fare-ListEqualityComparer{`0},Fare-ListEqualityComparer{`0}-'></a>
### op_Equality(left,right) `method`

##### Summary

Implements the operator ==.

##### Returns

The result of the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Fare.ListEqualityComparer{\`0}](#T-Fare-ListEqualityComparer{`0} 'Fare.ListEqualityComparer{`0}') | The left. |
| right | [Fare.ListEqualityComparer{\`0}](#T-Fare-ListEqualityComparer{`0} 'Fare.ListEqualityComparer{`0}') | The right. |

<a name='M-Fare-ListEqualityComparer`1-op_Inequality-Fare-ListEqualityComparer{`0},Fare-ListEqualityComparer{`0}-'></a>
### op_Inequality(left,right) `method`

##### Summary

Implements the operator !=.

##### Returns

The result of the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Fare.ListEqualityComparer{\`0}](#T-Fare-ListEqualityComparer{`0} 'Fare.ListEqualityComparer{`0}') | The left. |
| right | [Fare.ListEqualityComparer{\`0}](#T-Fare-ListEqualityComparer{`0} 'Fare.ListEqualityComparer{`0}') | The right. |

<a name='T-Fare-MinimizationOperations'></a>
## MinimizationOperations `type`

##### Namespace

Fare

##### Summary



<a name='M-Fare-MinimizationOperations-Minimize-Fare-Automaton-'></a>
### Minimize(a) `method`

##### Summary

Minimizes (and determinizes if not already deterministic) the given automaton.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |

<a name='M-Fare-MinimizationOperations-MinimizeBrzozowski-Fare-Automaton-'></a>
### MinimizeBrzozowski(a) `method`

##### Summary

Minimizes the given automaton using Brzozowski's algorithm.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |

<a name='M-Fare-MinimizationOperations-MinimizeHopcroft-Fare-Automaton-'></a>
### MinimizeHopcroft(a) `method`

##### Summary

Minimizes the hopcroft.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | a. |

<a name='M-Fare-MinimizationOperations-MinimizeHuffman-Fare-Automaton-'></a>
### MinimizeHuffman(a) `method`

##### Summary

Minimizes the given automaton using Huffman's algorithm.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |

<a name='T-RandomDataGenerator-Generators-RandomStringGenerator'></a>
## RandomStringGenerator `type`

##### Namespace

RandomDataGenerator.Generators

##### Summary

Copyright http://www.codeproject.com/Articles/423229/CsharpRandomStringGenerator
 
 This class can generate random strings and supports following settings:
 1) 6 character sets (UpperCase, LowerCase, Numeric, Space and Special characters)
 2) Variable number of the character sets in use
 3) Minimal number of each type of the characters
 4) Pattern driven string generation
 5) Unique string generation
 6) Using each character only once
 It can be easily used for generation of a password or an identificator.

 Stef: Replaced RNGCryptoServiceProvider by Random for netstandard1.3

<a name='F-RandomDataGenerator-Generators-RandomStringGenerator-RepeatCharacters'></a>
### RepeatCharacters `constants`

##### Summary

True if characters can be repeated.

<a name='F-RandomDataGenerator-Generators-RandomStringGenerator-UniqueStrings'></a>
### UniqueStrings `constants`

##### Summary

True if it's not possible to create similar strings.

<a name='P-RandomDataGenerator-Generators-RandomStringGenerator-LowerCaseCharacters'></a>
### LowerCaseCharacters `property`

##### Summary

Sets or gets lower case character set.

<a name='P-RandomDataGenerator-Generators-RandomStringGenerator-MinLowerCaseCharacters'></a>
### MinLowerCaseCharacters `property`

##### Summary

Sets or gets minimal number of the lower case characters in generated strings.

<a name='P-RandomDataGenerator-Generators-RandomStringGenerator-MinNumericCharacters'></a>
### MinNumericCharacters `property`

##### Summary

Sets or gets minimal number of the numeric characters in generated strings.

<a name='P-RandomDataGenerator-Generators-RandomStringGenerator-MinSpaceCharacters'></a>
### MinSpaceCharacters `property`

##### Summary

Sets or gets minimal number of the special characters in generated strings.

<a name='P-RandomDataGenerator-Generators-RandomStringGenerator-MinSpecialCharacters'></a>
### MinSpecialCharacters `property`

##### Summary

Sets or gets minimal number of the special characters in generated strings.

<a name='P-RandomDataGenerator-Generators-RandomStringGenerator-MinUpperCaseCharacters'></a>
### MinUpperCaseCharacters `property`

##### Summary

Sets or gets minimal number of the upper case characters in generated strings.

<a name='P-RandomDataGenerator-Generators-RandomStringGenerator-NumericCharacters'></a>
### NumericCharacters `property`

##### Summary

Sets or gets numeric character set.

<a name='P-RandomDataGenerator-Generators-RandomStringGenerator-Pattern'></a>
### Pattern `property`

##### Summary

Defines the pattern to be followed to generate a string.
This value is ignored if it equals empty string.
Patterns are:
L - for upper case letter
l - for lower case letter
n - for number
s - for special character
_ - for space character
* - for any character
\ - for character as-is

<a name='P-RandomDataGenerator-Generators-RandomStringGenerator-SpaceCharacters'></a>
### SpaceCharacters `property`

##### Summary

Sets or gets spaces character set.

<a name='P-RandomDataGenerator-Generators-RandomStringGenerator-SpecialCharacters'></a>
### SpecialCharacters `property`

##### Summary

Sets or gets special character set.

<a name='P-RandomDataGenerator-Generators-RandomStringGenerator-UpperCaseCharacters'></a>
### UpperCaseCharacters `property`

##### Summary

Sets or gets upper case character set.

<a name='P-RandomDataGenerator-Generators-RandomStringGenerator-UseLowerCaseCharacters'></a>
### UseLowerCaseCharacters `property`

##### Summary

True if we need to use lower case characters

<a name='P-RandomDataGenerator-Generators-RandomStringGenerator-UseNumericCharacters'></a>
### UseNumericCharacters `property`

##### Summary

True if we need to use numeric characters

<a name='P-RandomDataGenerator-Generators-RandomStringGenerator-UseSpaces'></a>
### UseSpaces `property`

##### Summary

True if we need to use numeric characters

<a name='P-RandomDataGenerator-Generators-RandomStringGenerator-UseSpecialCharacters'></a>
### UseSpecialCharacters `property`

##### Summary

True if we need to use special characters

<a name='P-RandomDataGenerator-Generators-RandomStringGenerator-UseUpperCaseCharacters'></a>
### UseUpperCaseCharacters `property`

##### Summary

True if we need to use upper case characters

<a name='M-RandomDataGenerator-Generators-RandomStringGenerator-AddExistingString-System-String-'></a>
### AddExistingString() `method`

##### Summary

Adding the string to the history array to support unique string generation.

##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Generators-RandomStringGenerator-Generate-System-String-'></a>
### Generate(pattern) `method`

##### Summary

Generate a string which follows the pattern.
Possible characters are:
L - for upper case letter
l - for lower case letter
n - for number
s - for special character
* - for any character
\ - for character as-is

##### Returns

A random string which follows the pattern

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The pattern to follow while generation |

<a name='M-RandomDataGenerator-Generators-RandomStringGenerator-Generate-System-Int32,System-Int32-'></a>
### Generate(minLength,maxLength) `method`

##### Summary

Generate a string of a variable length from MinLength to MaxLength. The possible 
character sets should be defined before calling this function.

##### Returns

A random string from the selected range of length

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| minLength | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Minimal length of a string |
| maxLength | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Maximal length of a string |

<a name='M-RandomDataGenerator-Generators-RandomStringGenerator-Generate-System-Int32-'></a>
### Generate(fixedLength) `method`

##### Summary

Generate a string of a fixed length. The possible 
character sets should be defined before calling this function.

##### Returns

A random string of the desirable length

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fixedLength | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length of a string |

<a name='M-RandomDataGenerator-Generators-RandomStringGenerator-GenerateAlgoWithLimits-System-Int32-'></a>
### GenerateAlgoWithLimits() `method`

##### Summary

Generate a random string with specified number of minimal characters of each character set.

##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Generators-RandomStringGenerator-GenerateString-System-Int32-'></a>
### GenerateString() `method`

##### Summary

Main generation method which chooses the algorithm to use for the generation.
It checks some exceptional situations as well.

##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Generators-RandomStringGenerator-GetRandomCharFromArray-System-Char[],System-Collections-Generic-List{System-Char}-'></a>
### GetRandomCharFromArray(array,existentItems) `method`

##### Summary

Get a random char from the selected array of chars. It pays attention to
the RepeatCharacters flag.

##### Returns

A random character from the array

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Char[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char[] 'System.Char[]') | Source of symbols |
| existentItems | [System.Collections.Generic.List{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Char}') | Existing symbols. Can be null if RepeatCharacters flag is false |

<a name='M-RandomDataGenerator-Generators-RandomStringGenerator-GetRandomInt'></a>
### GetRandomInt() `method`

##### Summary

A 16bit integer number generator.

##### Returns

A random integer value from 0 to 65576

##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Generators-RandomStringGenerator-PatternDrivenAlgo-System-String-'></a>
### PatternDrivenAlgo() `method`

##### Summary

Generate a random string following the pattern

##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Generators-RandomStringGenerator-SimpleGenerateAlgo-System-Int32-'></a>
### SimpleGenerateAlgo() `method`

##### Summary

The simpliest algorithm of the random string generation. It doesn't pay attention to
limits and patterns.

##### Parameters

This method has no parameters.

<a name='T-RandomDataGenerator-Generators-RandomValueGenerator'></a>
## RandomValueGenerator `type`

##### Namespace

RandomDataGenerator.Generators

##### Summary

Copyright : http://www.cambiaresearch.com/articles/13/csharp-randomprovider-class

RandomProvider.  Provides random numbers of all data types
in specified ranges. It also contains a couple of methods
from Normally (Gaussian) distributed random numbers and 
Exponentially distributed random numbers.

<a name='M-RandomDataGenerator-Generators-RandomValueGenerator-Next'></a>
### Next() `method`

##### Summary

Returns double in the range [0, 1)

##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Generators-RandomValueGenerator-Next-System-Byte,System-Byte-'></a>
### Next() `method`

##### Summary

Returns byte in the range [min, max)

##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Generators-RandomValueGenerator-Next-System-Int16,System-Int16-'></a>
### Next() `method`

##### Summary

Returns Int16 in the range [min, max)

##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Generators-RandomValueGenerator-Next-System-Int32,System-Int32-'></a>
### Next() `method`

##### Summary

Returns Int32 in the range [min, max)

##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Generators-RandomValueGenerator-Next-System-Int64,System-Int64-'></a>
### Next() `method`

##### Summary

Returns Int64 in the range [min, max)

##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Generators-RandomValueGenerator-Next-System-Single,System-Single-'></a>
### Next() `method`

##### Summary

Returns float (Single) in the range [min, max)

##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Generators-RandomValueGenerator-Next-System-Double,System-Double-'></a>
### Next() `method`

##### Summary

Returns double in the range [min, max)

##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Generators-RandomValueGenerator-Next-System-DateTime,System-DateTime-'></a>
### Next() `method`

##### Summary

Returns DateTime in the range [min, max)

##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Generators-RandomValueGenerator-Next-System-TimeSpan,System-TimeSpan-'></a>
### Next() `method`

##### Summary

Returns TimeSpan in the range [min, max)

##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Generators-RandomValueGenerator-NextBoolean'></a>
### NextBoolean() `method`

##### Summary

Returns true or false randomly.

##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Generators-RandomValueGenerator-NextBytes-System-Int32,System-Int32-'></a>
### NextBytes(min,max) `method`

##### Summary

Generates an array of bytes with random numbers.

##### Returns

Random byte array

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The minimum number of bytes |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The maximum number of bytes |

<a name='M-RandomDataGenerator-Generators-RandomValueGenerator-NextDouble'></a>
### NextDouble() `method`

##### Summary

Returns double in the range [0, 1)

##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Generators-RandomValueGenerator-NextEnum-System-Type-'></a>
### NextEnum() `method`

##### Summary

Returns a uniformly random integer representing one of the values 
in the enum.

##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Generators-RandomValueGenerator-NextExponential'></a>
### NextExponential() `method`

##### Summary

Returns an exponentially distributed, positive, random deviate of unit mean.

##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Generators-RandomValueGenerator-NextNormal'></a>
### NextNormal() `method`

##### Summary

Returns a normally distributed deviate with zero mean and unit 
variance.

##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Generators-RandomValueGenerator-NextUniform'></a>
### NextUniform() `method`

##### Summary

Returns double in the range [min, max)

##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Generators-RandomValueGenerator-Next``1-``0,``0-'></a>
### Next\`\`1(min,max) `method`

##### Summary

Return a random T in the range [min, max]

##### Returns

Random T

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [\`\`0](#T-``0 '``0') | The minimum value |
| max | [\`\`0](#T-``0 '``0') | The maximum value |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Generic type |

<a name='T-Bb-Randomizer'></a>
## Randomizer `type`

##### Namespace

Bb

##### Summary

Randoms helper

<a name='M-Bb-Randomizer-GenerateBinary-System-Int32,System-Int32-'></a>
### GenerateBinary(min,max) `method`

##### Summary

Generates the binary.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The minimum. |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The maximum. |

<a name='M-Bb-Randomizer-GenerateBoolean'></a>
### GenerateBoolean() `method`

##### Summary

Generates boolean.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Bb-Randomizer-GenerateByte-System-Byte,System-Byte-'></a>
### GenerateByte(min,max,useNullValues) `method`

##### Summary

Generates the byte.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The minimum value. |
| max | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The maximum value. |

<a name='M-Bb-Randomizer-GenerateCard-RandomDataGenerator-CreditCardValidator-CardIssuer,System-Int32-'></a>
### GenerateCard(cardIssuer,length) `method`

##### Summary

Generates the card.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cardIssuer | [RandomDataGenerator.CreditCardValidator.CardIssuer](#T-RandomDataGenerator-CreditCardValidator-CardIssuer 'RandomDataGenerator.CreditCardValidator.CardIssuer') | The card issuer. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length. |

<a name='M-Bb-Randomizer-GenerateCity'></a>
### GenerateCity() `method`

##### Summary

Generates the city.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Bb-Randomizer-GenerateCountry'></a>
### GenerateCountry(options) `method`

##### Summary

Generates the country.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [M:Bb.Randomizer.GenerateCountry](#T-M-Bb-Randomizer-GenerateCountry 'M:Bb.Randomizer.GenerateCountry') | The options. |

<a name='M-Bb-Randomizer-GenerateDateTime-System-Boolean,System-Nullable{System-DateTime},System-Nullable{System-DateTime}-'></a>
### GenerateDateTime(includeTime,from,to) `method`

##### Summary

Generates the date time.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| includeTime | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [include time]. |
| from | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | From. |
| to | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | To. |

<a name='M-Bb-Randomizer-GenerateDouble-System-Double,System-Double-'></a>
### GenerateDouble(min,max) `method`

##### Summary

Generates the double.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | The minimum. |
| max | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | The maximum. |

<a name='M-Bb-Randomizer-GenerateEmailAddress-System-Boolean,System-Boolean,System-Boolean-'></a>
### GenerateEmailAddress(female,male,left2Right) `method`

##### Summary

Generates the email address.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| female | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [female]. |
| male | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [male]. |
| left2Right | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [left2 right]. |

<a name='M-Bb-Randomizer-GenerateFirstName'></a>
### GenerateFirstName(options) `method`

##### Summary

Generates the first name.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [M:Bb.Randomizer.GenerateFirstName](#T-M-Bb-Randomizer-GenerateFirstName 'M:Bb.Randomizer.GenerateFirstName') | The options. |

<a name='M-Bb-Randomizer-GenerateFloat-System-Single,System-Single-'></a>
### GenerateFloat(min,max) `method`

##### Summary

Generates the float.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The minimum. |
| max | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The maximum. |

<a name='M-Bb-Randomizer-GenerateFullName'></a>
### GenerateFullName(options) `method`

##### Summary

Generates the full name.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [M:Bb.Randomizer.GenerateFullName](#T-M-Bb-Randomizer-GenerateFullName 'M:Bb.Randomizer.GenerateFullName') | The options. |

<a name='M-Bb-Randomizer-GenerateIbanBban-System-String-'></a>
### GenerateIbanBban(countryCode) `method`

##### Summary

Generates the iban bban.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| countryCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The country code. |

<a name='M-Bb-Randomizer-GenerateIbanBoth-System-String-'></a>
### GenerateIbanBoth(countryCode) `method`

##### Summary

Generates the iban both.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| countryCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The country code. |

<a name='M-Bb-Randomizer-GenerateInteger-System-Int32,System-Int32-'></a>
### GenerateInteger(min,max) `method`

##### Summary

Generates the integer.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The minimum value. |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The maximum value. |

<a name='M-Bb-Randomizer-GenerateIpV4-System-String,System-String-'></a>
### GenerateIpV4(min,max) `method`

##### Summary

Generates the ip v4.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The minimum. |
| max | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The maximum. |

<a name='M-Bb-Randomizer-GenerateIpV6-System-String,System-String,System-Boolean-'></a>
### GenerateIpV6(min,max,upperCase) `method`

##### Summary

Generates the ip v6.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The minimum. |
| max | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The maximum. |
| upperCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [upper case]. |

<a name='M-Bb-Randomizer-GenerateLastName'></a>
### GenerateLastName() `method`

##### Summary

Generates the last name.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Bb-Randomizer-GenerateLong-System-Int64,System-Int64-'></a>
### GenerateLong(min,max) `method`

##### Summary

Generates the long.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The minimum. |
| max | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The maximum. |

<a name='M-Bb-Randomizer-GenerateNaughtyStrings-System-String-'></a>
### GenerateNaughtyStrings(categories) `method`

##### Summary

Generates the naughty strings.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| categories | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The category. |

<a name='M-Bb-Randomizer-GeneratePassword-System-Int32,System-String-'></a>
### GeneratePassword(length,charsetAvailables) `method`

##### Summary

Generate a new random password.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length. |
| charsetAvailables | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The charset availables. |

<a name='M-Bb-Randomizer-GenerateShort-System-Int16,System-Int16-'></a>
### GenerateShort(min,max) `method`

##### Summary

Generates the short.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') | The minimum. |
| max | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') | The maximum. |

<a name='M-Bb-Randomizer-GenerateStringList-System-Collections-Generic-IEnumerable{System-String}-'></a>
### GenerateStringList(list) `method`

##### Summary

Generates the string list.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | The list. |

<a name='M-Bb-Randomizer-GenerateText-System-Int32,System-Int32,RandomDataGenerator-FieldOptions-TextRandomizeContextEnum-'></a>
### GenerateText(min,max,context) `method`

##### Summary

Generates the text.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The minimum. |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The maximum. |
| context | [RandomDataGenerator.FieldOptions.TextRandomizeContextEnum](#T-RandomDataGenerator-FieldOptions-TextRandomizeContextEnum 'RandomDataGenerator.FieldOptions.TextRandomizeContextEnum') | The context. |

<a name='M-Bb-Randomizer-GenerateTextByRegex-System-String-'></a>
### GenerateTextByRegex(pattern) `method`

##### Summary

Generates the text by regex.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The pattern. |

<a name='M-Bb-Randomizer-GenerateTextWords-System-Int32,System-Int32-'></a>
### GenerateTextWords(min,max) `method`

##### Summary

Generates the text words.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The minimum. |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The maximum. |

<a name='M-Bb-Randomizer-GenerateTimeSpan-System-Boolean,System-Nullable{System-TimeSpan},System-Nullable{System-TimeSpan},System-String-'></a>
### GenerateTimeSpan(includeMilliseconds,from,to) `method`

##### Summary

Generates the time span.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| includeMilliseconds | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [include milliseconds]. |
| from | [System.Nullable{System.TimeSpan}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.TimeSpan}') | From. |
| to | [System.Nullable{System.TimeSpan}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.TimeSpan}') | To. |

<a name='T-RandomDataGenerator-Randomizers-RandomizerDateTime'></a>
## RandomizerDateTime `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

DateTime randomizer

##### See Also

- [RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsDateTime>](#!-RandomDataGenerator-Randomizers-RandomizerAbstract<RandomDataGenerator-FieldOptions-FieldOptionsDateTime> 'RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsDateTime>')
- [RandomDataGenerator.Randomizers.IRandomizerDateTime](#T-RandomDataGenerator-Randomizers-IRandomizerDateTime 'RandomDataGenerator.Randomizers.IRandomizerDateTime')

<a name='M-RandomDataGenerator-Randomizers-RandomizerDateTime-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsDateTime-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [RandomizerDateTime](#T-RandomDataGenerator-Randomizers-RandomizerDateTime 'RandomDataGenerator.Randomizers.RandomizerDateTime') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [RandomDataGenerator.FieldOptions.FieldOptionsDateTime](#T-RandomDataGenerator-FieldOptions-FieldOptionsDateTime 'RandomDataGenerator.FieldOptions.FieldOptionsDateTime') | The options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerDateTime-Generate'></a>
### Generate() `method`

##### Summary

Generates the dateTime.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-RandomizerDateTime-GenerateAsString'></a>
### GenerateAsString() `method`

##### Summary

Generates as string.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-RandomDataGenerator-Randomizers-RandomizerEmailAddress'></a>
## RandomizerEmailAddress `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

Email address randomizer

##### See Also

- [RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsEmailAddress>](#!-RandomDataGenerator-Randomizers-RandomizerAbstract<RandomDataGenerator-FieldOptions-FieldOptionsEmailAddress> 'RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsEmailAddress>')
- [RandomDataGenerator.Randomizers.IRandomizerString](#T-RandomDataGenerator-Randomizers-IRandomizerString 'RandomDataGenerator.Randomizers.IRandomizerString')

<a name='M-RandomDataGenerator-Randomizers-RandomizerEmailAddress-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsEmailAddress-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [RandomizerEmailAddress](#T-RandomDataGenerator-Randomizers-RandomizerEmailAddress 'RandomDataGenerator.Randomizers.RandomizerEmailAddress') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [RandomDataGenerator.FieldOptions.FieldOptionsEmailAddress](#T-RandomDataGenerator-FieldOptions-FieldOptionsEmailAddress 'RandomDataGenerator.FieldOptions.FieldOptionsEmailAddress') | The options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerEmailAddress-Generate'></a>
### Generate() `method`

##### Summary

Generates string

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-RandomizerEmailAddress-Generate-System-Boolean-'></a>
### Generate(upperCase) `method`

##### Summary

Generates the string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| upperCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [upper case]. |

<a name='T-RandomDataGenerator-Randomizers-RandomizerFactory'></a>
## RandomizerFactory `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

Randomizer factory

<a name='M-RandomDataGenerator-Randomizers-RandomizerFactory-GetRandomizer-RandomDataGenerator-FieldOptions-IFieldOptionsBytes-'></a>
### GetRandomizer(fieldOptions) `method`

##### Summary

Gets the randomizer.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fieldOptions | [RandomDataGenerator.FieldOptions.IFieldOptionsBytes](#T-RandomDataGenerator-FieldOptions-IFieldOptionsBytes 'RandomDataGenerator.FieldOptions.IFieldOptionsBytes') | The field options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerFactory-GetRandomizer-RandomDataGenerator-FieldOptions-IFieldOptionsString-'></a>
### GetRandomizer(fieldOptions) `method`

##### Summary

Gets the randomizer.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fieldOptions | [RandomDataGenerator.FieldOptions.IFieldOptionsString](#T-RandomDataGenerator-FieldOptions-IFieldOptionsString 'RandomDataGenerator.FieldOptions.IFieldOptionsString') | The field options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerFactory-GetRandomizer-RandomDataGenerator-FieldOptions-IFieldOptionsGuid-'></a>
### GetRandomizer(fieldOptions) `method`

##### Summary

Gets the randomizer.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fieldOptions | [RandomDataGenerator.FieldOptions.IFieldOptionsGuid](#T-RandomDataGenerator-FieldOptions-IFieldOptionsGuid 'RandomDataGenerator.FieldOptions.IFieldOptionsGuid') | The field options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerFactory-GetRandomizer-RandomDataGenerator-FieldOptions-IFieldOptionsDateTime-'></a>
### GetRandomizer(fieldOptions) `method`

##### Summary

Gets the randomizer.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fieldOptions | [RandomDataGenerator.FieldOptions.IFieldOptionsDateTime](#T-RandomDataGenerator-FieldOptions-IFieldOptionsDateTime 'RandomDataGenerator.FieldOptions.IFieldOptionsDateTime') | The field options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerFactory-GetRandomizer-RandomDataGenerator-FieldOptions-IFieldOptionsTimeSpan-'></a>
### GetRandomizer(fieldOptions) `method`

##### Summary

Gets the randomizer.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fieldOptions | [RandomDataGenerator.FieldOptions.IFieldOptionsTimeSpan](#T-RandomDataGenerator-FieldOptions-IFieldOptionsTimeSpan 'RandomDataGenerator.FieldOptions.IFieldOptionsTimeSpan') | The field options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerFactory-GetRandomizerAsDynamic-System-Object-'></a>
### GetRandomizerAsDynamic(fieldOptions) `method`

##### Summary

Gets the randomizer as dynamic.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fieldOptions | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The field options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerFactory-GetRandomizer``1-RandomDataGenerator-FieldOptions-IFieldOptionsNumber{``0}-'></a>
### GetRandomizer\`\`1(fieldOptions) `method`

##### Summary

Gets the randomizer.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fieldOptions | [RandomDataGenerator.FieldOptions.IFieldOptionsNumber{\`\`0}](#T-RandomDataGenerator-FieldOptions-IFieldOptionsNumber{``0} 'RandomDataGenerator.FieldOptions.IFieldOptionsNumber{``0}') | The field options. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='T-RandomDataGenerator-Randomizers-RandomizerFirstName'></a>
## RandomizerFirstName `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

First name randomizer

##### See Also

- [RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsFirstName>](#!-RandomDataGenerator-Randomizers-RandomizerAbstract<RandomDataGenerator-FieldOptions-FieldOptionsFirstName> 'RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsFirstName>')
- [RandomDataGenerator.Randomizers.IRandomizerString](#T-RandomDataGenerator-Randomizers-IRandomizerString 'RandomDataGenerator.Randomizers.IRandomizerString')

<a name='M-RandomDataGenerator-Randomizers-RandomizerFirstName-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsFirstName-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [RandomizerFirstName](#T-RandomDataGenerator-Randomizers-RandomizerFirstName 'RandomDataGenerator.Randomizers.RandomizerFirstName') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [RandomDataGenerator.FieldOptions.FieldOptionsFirstName](#T-RandomDataGenerator-FieldOptions-FieldOptionsFirstName 'RandomDataGenerator.FieldOptions.FieldOptionsFirstName') | The options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerFirstName-Generate'></a>
### Generate() `method`

##### Summary

Generates the string.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-RandomizerFirstName-Generate-System-Boolean-'></a>
### Generate(upperCase) `method`

##### Summary

Generates the string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| upperCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [upper case]. |

<a name='T-RandomDataGenerator-Randomizers-RandomizerFullName'></a>
## RandomizerFullName `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

Full name randomizer

##### See Also

- [RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsFullName>](#!-RandomDataGenerator-Randomizers-RandomizerAbstract<RandomDataGenerator-FieldOptions-FieldOptionsFullName> 'RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsFullName>')
- [RandomDataGenerator.Randomizers.IRandomizerString](#T-RandomDataGenerator-Randomizers-IRandomizerString 'RandomDataGenerator.Randomizers.IRandomizerString')

<a name='M-RandomDataGenerator-Randomizers-RandomizerFullName-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsFullName-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [RandomizerFullName](#T-RandomDataGenerator-Randomizers-RandomizerFullName 'RandomDataGenerator.Randomizers.RandomizerFullName') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [RandomDataGenerator.FieldOptions.FieldOptionsFullName](#T-RandomDataGenerator-FieldOptions-FieldOptionsFullName 'RandomDataGenerator.FieldOptions.FieldOptionsFullName') | The options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerFullName-Generate'></a>
### Generate() `method`

##### Summary

Generates strings.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-RandomizerFullName-Generate-System-Boolean-'></a>
### Generate(upperCase) `method`

##### Summary

Generates the strings

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| upperCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [upper case]. |

<a name='T-RandomDataGenerator-Randomizers-RandomizerGuid'></a>
## RandomizerGuid `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

Guid randomizer

##### See Also

- [RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsGuid>](#!-RandomDataGenerator-Randomizers-RandomizerAbstract<RandomDataGenerator-FieldOptions-FieldOptionsGuid> 'RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsGuid>')
- [RandomDataGenerator.Randomizers.IRandomizerGuid](#T-RandomDataGenerator-Randomizers-IRandomizerGuid 'RandomDataGenerator.Randomizers.IRandomizerGuid')

<a name='M-RandomDataGenerator-Randomizers-RandomizerGuid-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsGuid-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [RandomizerGuid](#T-RandomDataGenerator-Randomizers-RandomizerGuid 'RandomDataGenerator.Randomizers.RandomizerGuid') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [RandomDataGenerator.FieldOptions.FieldOptionsGuid](#T-RandomDataGenerator-FieldOptions-FieldOptionsGuid 'RandomDataGenerator.FieldOptions.FieldOptionsGuid') | The options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerGuid-Generate'></a>
### Generate() `method`

##### Summary

Generates the guid.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-RandomizerGuid-GenerateAsString'></a>
### GenerateAsString() `method`

##### Summary

Generates the guid as string.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-RandomDataGenerator-Randomizers-RandomizerIBAN'></a>
## RandomizerIBAN `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

Ibans randomizer

##### See Also

- [RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsIBAN>](#!-RandomDataGenerator-Randomizers-RandomizerAbstract<RandomDataGenerator-FieldOptions-FieldOptionsIBAN> 'RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsIBAN>')
- [RandomDataGenerator.Randomizers.IRandomizerString](#T-RandomDataGenerator-Randomizers-IRandomizerString 'RandomDataGenerator.Randomizers.IRandomizerString')

<a name='M-RandomDataGenerator-Randomizers-RandomizerIBAN-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsIBAN-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [RandomizerIBAN](#T-RandomDataGenerator-Randomizers-RandomizerIBAN 'RandomDataGenerator.Randomizers.RandomizerIBAN') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [RandomDataGenerator.FieldOptions.FieldOptionsIBAN](#T-RandomDataGenerator-FieldOptions-FieldOptionsIBAN 'RandomDataGenerator.FieldOptions.FieldOptionsIBAN') | The options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerIBAN-Generate'></a>
### Generate() `method`

##### Summary

Generates strings.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-RandomizerIBAN-Generate-System-Boolean-'></a>
### Generate(upperCase) `method`

##### Summary

Generates the specified upper case.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| upperCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [upper case]. |

<a name='T-RandomDataGenerator-Randomizers-RandomizerIPv4Address'></a>
## RandomizerIPv4Address `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

IP v4 address randomizer

##### See Also

- [RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsIPv4Address>](#!-RandomDataGenerator-Randomizers-RandomizerAbstract<RandomDataGenerator-FieldOptions-FieldOptionsIPv4Address> 'RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsIPv4Address>')
- [RandomDataGenerator.Randomizers.IRandomizerString](#T-RandomDataGenerator-Randomizers-IRandomizerString 'RandomDataGenerator.Randomizers.IRandomizerString')

<a name='M-RandomDataGenerator-Randomizers-RandomizerIPv4Address-Generate'></a>
### Generate() `method`

##### Summary

Generates IP v4 address as string.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-RandomizerIPv4Address-Generate-System-Boolean-'></a>
### Generate(upperCase) `method`

##### Summary

Generates IP v4 address as strings.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| upperCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [upper case]. |

<a name='T-RandomDataGenerator-Randomizers-RandomizerIPv6Address'></a>
## RandomizerIPv6Address `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

IP v6 address randomizer

##### See Also

- [RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsIPv6Address>](#!-RandomDataGenerator-Randomizers-RandomizerAbstract<RandomDataGenerator-FieldOptions-FieldOptionsIPv6Address> 'RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsIPv6Address>')
- [RandomDataGenerator.Randomizers.IRandomizerString](#T-RandomDataGenerator-Randomizers-IRandomizerString 'RandomDataGenerator.Randomizers.IRandomizerString')

<a name='M-RandomDataGenerator-Randomizers-RandomizerIPv6Address-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsIPv6Address-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [RandomizerIPv6Address](#T-RandomDataGenerator-Randomizers-RandomizerIPv6Address 'RandomDataGenerator.Randomizers.RandomizerIPv6Address') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [RandomDataGenerator.FieldOptions.FieldOptionsIPv6Address](#T-RandomDataGenerator-FieldOptions-FieldOptionsIPv6Address 'RandomDataGenerator.FieldOptions.FieldOptionsIPv6Address') | The options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerIPv6Address-Generate'></a>
### Generate() `method`

##### Summary

Generates ip v6 address as string

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-RandomizerIPv6Address-Generate-System-Boolean-'></a>
### Generate(upperCase) `method`

##### Summary

Generates ip v6 address as string

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| upperCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [upper case]. |

<a name='T-RandomDataGenerator-Randomizers-RandomizerLastName'></a>
## RandomizerLastName `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

Last name randomizer

##### See Also

- [RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsLastName>](#!-RandomDataGenerator-Randomizers-RandomizerAbstract<RandomDataGenerator-FieldOptions-FieldOptionsLastName> 'RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsLastName>')
- [RandomDataGenerator.Randomizers.IRandomizerString](#T-RandomDataGenerator-Randomizers-IRandomizerString 'RandomDataGenerator.Randomizers.IRandomizerString')

<a name='M-RandomDataGenerator-Randomizers-RandomizerLastName-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsLastName-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [RandomizerLastName](#T-RandomDataGenerator-Randomizers-RandomizerLastName 'RandomDataGenerator.Randomizers.RandomizerLastName') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [RandomDataGenerator.FieldOptions.FieldOptionsLastName](#T-RandomDataGenerator-FieldOptions-FieldOptionsLastName 'RandomDataGenerator.FieldOptions.FieldOptionsLastName') | The options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerLastName-Generate'></a>
### Generate() `method`

##### Summary

Generates the last name as string.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-RandomizerLastName-Generate-System-Boolean-'></a>
### Generate(upperCase) `method`

##### Summary

Generates the last name as string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| upperCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [upper case]. |

<a name='T-RandomDataGenerator-Randomizers-RandomizerMACAddress'></a>
## RandomizerMACAddress `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

Mac address randomizer

##### See Also

- [RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsMACAddress>](#!-RandomDataGenerator-Randomizers-RandomizerAbstract<RandomDataGenerator-FieldOptions-FieldOptionsMACAddress> 'RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsMACAddress>')
- [RandomDataGenerator.Randomizers.IRandomizerString](#T-RandomDataGenerator-Randomizers-IRandomizerString 'RandomDataGenerator.Randomizers.IRandomizerString')

<a name='M-RandomDataGenerator-Randomizers-RandomizerMACAddress-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsMACAddress-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [RandomizerMACAddress](#T-RandomDataGenerator-Randomizers-RandomizerMACAddress 'RandomDataGenerator.Randomizers.RandomizerMACAddress') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [RandomDataGenerator.FieldOptions.FieldOptionsMACAddress](#T-RandomDataGenerator-FieldOptions-FieldOptionsMACAddress 'RandomDataGenerator.FieldOptions.FieldOptionsMACAddress') | The options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerMACAddress-Generate'></a>
### Generate() `method`

##### Summary

Generates the mac address.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-RandomizerMACAddress-Generate-System-Boolean-'></a>
### Generate(upperCase) `method`

##### Summary

Generates the mac address

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| upperCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [upper case]. |

<a name='T-RandomDataGenerator-Randomizers-RandomizerNumber`1'></a>
## RandomizerNumber\`1 `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

Number randomizer

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

##### See Also

- [RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsNumber<T>>](#!-RandomDataGenerator-Randomizers-RandomizerAbstract<RandomDataGenerator-FieldOptions-FieldOptionsNumber<T>> 'RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsNumber<T>>')
- [RandomDataGenerator.Randomizers.IRandomizerNumber\`1](#T-RandomDataGenerator-Randomizers-IRandomizerNumber`1 'RandomDataGenerator.Randomizers.IRandomizerNumber`1')

<a name='M-RandomDataGenerator-Randomizers-RandomizerNumber`1-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsNumber{`0}-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [RandomizerNumber\`1](#T-RandomDataGenerator-Randomizers-RandomizerNumber`1 'RandomDataGenerator.Randomizers.RandomizerNumber`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [RandomDataGenerator.FieldOptions.FieldOptionsNumber{\`0}](#T-RandomDataGenerator-FieldOptions-FieldOptionsNumber{`0} 'RandomDataGenerator.FieldOptions.FieldOptionsNumber{`0}') | The options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerNumber`1-Generate'></a>
### Generate() `method`

##### Summary

Generates value.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-RandomDataGenerator-Randomizers-RandomizerStringList'></a>
## RandomizerStringList `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

string list randomizer

##### See Also

- [RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsStringList>](#!-RandomDataGenerator-Randomizers-RandomizerAbstract<RandomDataGenerator-FieldOptions-FieldOptionsStringList> 'RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsStringList>')
- [RandomDataGenerator.Randomizers.IRandomizerString](#T-RandomDataGenerator-Randomizers-IRandomizerString 'RandomDataGenerator.Randomizers.IRandomizerString')

<a name='M-RandomDataGenerator-Randomizers-RandomizerStringList-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsStringList-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [RandomizerStringList](#T-RandomDataGenerator-Randomizers-RandomizerStringList 'RandomDataGenerator.Randomizers.RandomizerStringList') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [RandomDataGenerator.FieldOptions.FieldOptionsStringList](#T-RandomDataGenerator-FieldOptions-FieldOptionsStringList 'RandomDataGenerator.FieldOptions.FieldOptionsStringList') | The options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerStringList-Generate'></a>
### Generate() `method`

##### Summary

select an item in the source list

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-RandomizerStringList-Generate-System-Boolean-'></a>
### Generate(upperCase) `method`

##### Summary

select an item in the source list

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| upperCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [upper case]. |

<a name='T-RandomDataGenerator-Randomizers-RandomizerText'></a>
## RandomizerText `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

Text randomizer

##### See Also

- [RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsText>](#!-RandomDataGenerator-Randomizers-RandomizerAbstract<RandomDataGenerator-FieldOptions-FieldOptionsText> 'RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsText>')
- [RandomDataGenerator.Randomizers.IRandomizerString](#T-RandomDataGenerator-Randomizers-IRandomizerString 'RandomDataGenerator.Randomizers.IRandomizerString')

<a name='M-RandomDataGenerator-Randomizers-RandomizerText-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsText-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [RandomizerText](#T-RandomDataGenerator-Randomizers-RandomizerText 'RandomDataGenerator.Randomizers.RandomizerText') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [RandomDataGenerator.FieldOptions.FieldOptionsText](#T-RandomDataGenerator-FieldOptions-FieldOptionsText 'RandomDataGenerator.FieldOptions.FieldOptionsText') | The options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerText-Generate'></a>
### Generate() `method`

##### Summary

Generates the text.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-RandomizerText-Generate-System-Boolean-'></a>
### Generate(upperCase) `method`

##### Summary

Generates the text in upper case.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| upperCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [upper case]. |

<a name='T-RandomDataGenerator-Randomizers-RandomizerTextLipsum'></a>
## RandomizerTextLipsum `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

Lipsum text randomizer

##### See Also

- [RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsTextLipsum>](#!-RandomDataGenerator-Randomizers-RandomizerAbstract<RandomDataGenerator-FieldOptions-FieldOptionsTextLipsum> 'RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsTextLipsum>')
- [RandomDataGenerator.Randomizers.IRandomizerString](#T-RandomDataGenerator-Randomizers-IRandomizerString 'RandomDataGenerator.Randomizers.IRandomizerString')

<a name='M-RandomDataGenerator-Randomizers-RandomizerTextLipsum-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsTextLipsum-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [RandomizerTextLipsum](#T-RandomDataGenerator-Randomizers-RandomizerTextLipsum 'RandomDataGenerator.Randomizers.RandomizerTextLipsum') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [RandomDataGenerator.FieldOptions.FieldOptionsTextLipsum](#T-RandomDataGenerator-FieldOptions-FieldOptionsTextLipsum 'RandomDataGenerator.FieldOptions.FieldOptionsTextLipsum') | The options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerTextLipsum-Generate'></a>
### Generate() `method`

##### Summary

Generates the value string.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-RandomizerTextLipsum-Generate-System-Boolean-'></a>
### Generate(upperCase) `method`

##### Summary

Generates the value string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| upperCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [upper case]. |

<a name='T-RandomDataGenerator-Randomizers-RandomizerTextNaughtyStrings'></a>
## RandomizerTextNaughtyStrings `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

Naughty strings randomizer

##### See Also

- [RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsTextNaughtyStrings>](#!-RandomDataGenerator-Randomizers-RandomizerAbstract<RandomDataGenerator-FieldOptions-FieldOptionsTextNaughtyStrings> 'RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsTextNaughtyStrings>')
- [RandomDataGenerator.Randomizers.IRandomizerString](#T-RandomDataGenerator-Randomizers-IRandomizerString 'RandomDataGenerator.Randomizers.IRandomizerString')

<a name='M-RandomDataGenerator-Randomizers-RandomizerTextNaughtyStrings-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsTextNaughtyStrings-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [RandomizerTextNaughtyStrings](#T-RandomDataGenerator-Randomizers-RandomizerTextNaughtyStrings 'RandomDataGenerator.Randomizers.RandomizerTextNaughtyStrings') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [RandomDataGenerator.FieldOptions.FieldOptionsTextNaughtyStrings](#T-RandomDataGenerator-FieldOptions-FieldOptionsTextNaughtyStrings 'RandomDataGenerator.FieldOptions.FieldOptionsTextNaughtyStrings') | The options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerTextNaughtyStrings-Generate'></a>
### Generate() `method`

##### Summary

Generates the value string.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-RandomizerTextNaughtyStrings-Generate-System-Boolean-'></a>
### Generate(upperCase) `method`

##### Summary

Generates the value string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| upperCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [upper case]. |

<a name='T-RandomDataGenerator-Randomizers-RandomizerTextRegex'></a>
## RandomizerTextRegex `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

Regex text randomizer

##### See Also

- [RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsTextRegex>](#!-RandomDataGenerator-Randomizers-RandomizerAbstract<RandomDataGenerator-FieldOptions-FieldOptionsTextRegex> 'RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsTextRegex>')
- [RandomDataGenerator.Randomizers.IRandomizerString](#T-RandomDataGenerator-Randomizers-IRandomizerString 'RandomDataGenerator.Randomizers.IRandomizerString')

<a name='M-RandomDataGenerator-Randomizers-RandomizerTextRegex-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsTextRegex-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [RandomizerTextRegex](#T-RandomDataGenerator-Randomizers-RandomizerTextRegex 'RandomDataGenerator.Randomizers.RandomizerTextRegex') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [RandomDataGenerator.FieldOptions.FieldOptionsTextRegex](#T-RandomDataGenerator-FieldOptions-FieldOptionsTextRegex 'RandomDataGenerator.FieldOptions.FieldOptionsTextRegex') | The options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerTextRegex-Generate'></a>
### Generate() `method`

##### Summary

Generates the value string.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-RandomizerTextRegex-Generate-System-Boolean-'></a>
### Generate(upperCase) `method`

##### Summary

Generates the value string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| upperCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [upper case]. |

<a name='T-RandomDataGenerator-Randomizers-RandomizerTextWords'></a>
## RandomizerTextWords `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

Text word

##### See Also

- [RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsTextWords>](#!-RandomDataGenerator-Randomizers-RandomizerAbstract<RandomDataGenerator-FieldOptions-FieldOptionsTextWords> 'RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsTextWords>')
- [RandomDataGenerator.Randomizers.IRandomizerString](#T-RandomDataGenerator-Randomizers-IRandomizerString 'RandomDataGenerator.Randomizers.IRandomizerString')

<a name='M-RandomDataGenerator-Randomizers-RandomizerTextWords-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsTextWords-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [RandomizerTextWords](#T-RandomDataGenerator-Randomizers-RandomizerTextWords 'RandomDataGenerator.Randomizers.RandomizerTextWords') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [RandomDataGenerator.FieldOptions.FieldOptionsTextWords](#T-RandomDataGenerator-FieldOptions-FieldOptionsTextWords 'RandomDataGenerator.FieldOptions.FieldOptionsTextWords') | The options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerTextWords-Generate'></a>
### Generate() `method`

##### Summary

Generates the value string.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-RandomizerTextWords-Generate-System-Boolean-'></a>
### Generate(upperCase) `method`

##### Summary

Generates the value string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| upperCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [upper case]. |

<a name='T-RandomDataGenerator-Randomizers-RandomizerTimeSpan'></a>
## RandomizerTimeSpan `type`

##### Namespace

RandomDataGenerator.Randomizers

##### Summary

Randomizer that generates TimeSpan

##### See Also

- [RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsTimeSpan>](#!-RandomDataGenerator-Randomizers-RandomizerAbstract<RandomDataGenerator-FieldOptions-FieldOptionsTimeSpan> 'RandomDataGenerator.Randomizers.RandomizerAbstract<RandomDataGenerator.FieldOptions.FieldOptionsTimeSpan>')
- [RandomDataGenerator.Randomizers.IRandomizerTimeSpan](#T-RandomDataGenerator-Randomizers-IRandomizerTimeSpan 'RandomDataGenerator.Randomizers.IRandomizerTimeSpan')

<a name='M-RandomDataGenerator-Randomizers-RandomizerTimeSpan-#ctor-RandomDataGenerator-FieldOptions-FieldOptionsTimeSpan-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [RandomizerTimeSpan](#T-RandomDataGenerator-Randomizers-RandomizerTimeSpan 'RandomDataGenerator.Randomizers.RandomizerTimeSpan') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [RandomDataGenerator.FieldOptions.FieldOptionsTimeSpan](#T-RandomDataGenerator-FieldOptions-FieldOptionsTimeSpan 'RandomDataGenerator.FieldOptions.FieldOptionsTimeSpan') | The options. |

<a name='M-RandomDataGenerator-Randomizers-RandomizerTimeSpan-Generate'></a>
### Generate() `method`

##### Summary

Generates this instance.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-RandomDataGenerator-Randomizers-RandomizerTimeSpan-GenerateAsString'></a>
### GenerateAsString() `method`

##### Summary

Generates as string.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Fare-RegExp'></a>
## RegExp `type`

##### Namespace

Fare

##### Summary

Regular Expression extension to Automaton.

<a name='M-Fare-RegExp-#ctor'></a>
### #ctor() `constructor`

##### Summary

Prevents a default instance of the [RegExp](#T-Fare-RegExp 'Fare.RegExp') class from being created.

##### Parameters

This constructor has no parameters.

<a name='M-Fare-RegExp-#ctor-System-String-'></a>
### #ctor(s) `constructor`

##### Summary

Initializes a new instance of the [RegExp](#T-Fare-RegExp 'Fare.RegExp') class from a string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A string with the regular expression. |

<a name='M-Fare-RegExp-#ctor-System-String,Fare-RegExpSyntaxOptions-'></a>
### #ctor(s,syntaxFlags) `constructor`

##### Summary

Initializes a new instance of the [RegExp](#T-Fare-RegExp 'Fare.RegExp') class from a string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A string with the regular expression. |
| syntaxFlags | [Fare.RegExpSyntaxOptions](#T-Fare-RegExpSyntaxOptions 'Fare.RegExpSyntaxOptions') | Boolean 'or' of optional syntax constructs to be enabled. |

<a name='M-Fare-RegExp-GetIdentifiers'></a>
### GetIdentifiers() `method`

##### Summary

Returns the set of automaton identifiers that occur in this regular expression.

##### Returns

The set of automaton identifiers that occur in this regular expression.

##### Parameters

This method has no parameters.

<a name='M-Fare-RegExp-SetAllowMutate-System-Boolean-'></a>
### SetAllowMutate(flag) `method`

##### Summary

Sets or resets allow mutate flag.
  If this flag is set, then automata construction uses mutable automata,
  which is slightly faster but not thread safe.

##### Returns

The previous value of the flag.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| flag | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` the flag is set. |

<a name='M-Fare-RegExp-ToAutomaton'></a>
### ToAutomaton() `method`

##### Summary

Constructs new

```
Automaton
```

from this

```
RegExp
```

. 
  Same as

```
toAutomaton(null)
```

(empty automaton map).

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Fare-RegExp-ToAutomaton-System-Boolean-'></a>
### ToAutomaton(minimize) `method`

##### Summary

Constructs new

```
Automaton
```

from this

```
RegExp
```

.
Same as

```
toAutomaton(null,minimize)
```

(empty automaton map).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| minimize | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [minimize]. |

<a name='M-Fare-RegExp-ToAutomaton-Fare-IAutomatonProvider-'></a>
### ToAutomaton(automatonProvider) `method`

##### Summary

Constructs new

```
Automaton
```

from this

```
RegExp
```

. 
  The constructed automaton is minimal and deterministic and has no 
  transitions to dead states.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| automatonProvider | [Fare.IAutomatonProvider](#T-Fare-IAutomatonProvider 'Fare.IAutomatonProvider') | The provider of automata for named identifiers. |

<a name='M-Fare-RegExp-ToAutomaton-Fare-IAutomatonProvider,System-Boolean-'></a>
### ToAutomaton(automatonProvider,minimize) `method`

##### Summary

Constructs new

```
Automaton
```

from this

```
RegExp
```

. 
  The constructed automaton has no transitions to dead states.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| automatonProvider | [Fare.IAutomatonProvider](#T-Fare-IAutomatonProvider 'Fare.IAutomatonProvider') | The provider of automata for named identifiers. |
| minimize | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` the automaton is minimized and determinized. |

<a name='M-Fare-RegExp-ToAutomaton-System-Collections-Generic-IDictionary{System-String,Fare-Automaton}-'></a>
### ToAutomaton(automata) `method`

##### Summary

Constructs new

```
Automaton
```

from this

```
RegExp
```

. 
  The constructed automaton is minimal and deterministic and has no 
  transitions to dead states.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| automata | [System.Collections.Generic.IDictionary{System.String,Fare.Automaton}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{System.String,Fare.Automaton}') | The a map from automaton identifiers to automata. |

<a name='M-Fare-RegExp-ToAutomaton-System-Collections-Generic-IDictionary{System-String,Fare-Automaton},System-Boolean-'></a>
### ToAutomaton(automata,minimize) `method`

##### Summary

Constructs new

```
Automaton
```

from this

```
RegExp
```

. 
  The constructed automaton has no transitions to dead states.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| automata | [System.Collections.Generic.IDictionary{System.String,Fare.Automaton}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{System.String,Fare.Automaton}') | The map from automaton identifiers to automata. |
| minimize | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` the automaton is minimized and determinized. |

<a name='M-Fare-RegExp-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Fare-RegExpMatchingOptions'></a>
## RegExpMatchingOptions `type`

##### Namespace

Fare

##### Summary

regex matching options

<a name='F-Fare-RegExpMatchingOptions-ExplicitCapture'></a>
### ExplicitCapture `constants`

##### Summary

Do not capture unnamed groups.

<a name='F-Fare-RegExpMatchingOptions-IgnoreCase'></a>
### IgnoreCase `constants`

##### Summary

Uses case-insensitive matching.

<a name='F-Fare-RegExpMatchingOptions-IgnorePatternWhitespace'></a>
### IgnorePatternWhitespace `constants`

##### Summary

Exclude escaped white space from the pattern
and enable comments after a hash sign

```
#
```

.

<a name='F-Fare-RegExpMatchingOptions-Multiline'></a>
### Multiline `constants`

##### Summary

Use multi line mode, where

```
^
```

and

```
$
```

match
the beginning and end of each line, instead of the beginning and end of the input string.

<a name='F-Fare-RegExpMatchingOptions-Singleline'></a>
### Singleline `constants`

##### Summary

Use single-line mode, where the period matches every character,
instead of every character except

```
\n
```

.

<a name='M-Fare-RegExpMatchingOptions-All'></a>
### All() `method`

##### Summary

Alls this instance.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Fare-RegExpSyntaxOptions'></a>
## RegExpSyntaxOptions `type`

##### Namespace

Fare

##### Summary



<a name='F-Fare-RegExpSyntaxOptions-All'></a>
### All `constants`

##### Summary

Enables all optional regexp syntax.

<a name='F-Fare-RegExpSyntaxOptions-Anystring'></a>
### Anystring `constants`

##### Summary

Enables any string.

<a name='F-Fare-RegExpSyntaxOptions-Automaton'></a>
### Automaton `constants`

##### Summary

Enables named automaton.

<a name='F-Fare-RegExpSyntaxOptions-Complement'></a>
### Complement `constants`

##### Summary

Enables complement.

<a name='F-Fare-RegExpSyntaxOptions-Empty'></a>
### Empty `constants`

##### Summary

Enables empty language.

<a name='F-Fare-RegExpSyntaxOptions-Intersection'></a>
### Intersection `constants`

##### Summary

Enables intersection.

<a name='F-Fare-RegExpSyntaxOptions-Interval'></a>
### Interval `constants`

##### Summary

Enables numerical intervals.

<a name='T-Fare-SpecialOperations'></a>
## SpecialOperations `type`

##### Namespace

Fare

##### Summary

Special automata operations.

<a name='M-Fare-SpecialOperations-Compress-Fare-Automaton,System-String,System-Char-'></a>
### Compress(a,set,c) `method`

##### Summary

Returns an automaton that accepts the compressed language of the given automaton. 
Whenever a

```
c
```

character is allowed in the original automaton, one or more

```
set
```

characters are allowed in the new automaton.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |
| set | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The set of characters to be compressed. |
| c | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The canonical compress character (assumed to be in

```
set
```

). |

<a name='M-Fare-SpecialOperations-FindIndex-System-Char,System-Char[]-'></a>
### FindIndex(c,points) `method`

##### Summary

Rinds the largest entry whose value is less than or equal to c, or 0 if there is no
such entry.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The c. |
| points | [System.Char[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char[] 'System.Char[]') | The points. |

<a name='M-Fare-SpecialOperations-GetCommonPrefix-Fare-Automaton-'></a>
### GetCommonPrefix(a) `method`

##### Summary

Returns the longest string that is a prefix of all accepted strings and visits each state
at most once.

##### Returns

A common prefix.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |

<a name='M-Fare-SpecialOperations-GetFiniteStrings-Fare-Automaton-'></a>
### GetFiniteStrings(a) `method`

##### Summary

Returns the set of accepted strings, assuming this automaton has a finite language. If the
language is not finite, null is returned.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |

<a name='M-Fare-SpecialOperations-GetFiniteStrings-Fare-Automaton,System-Int32-'></a>
### GetFiniteStrings(a,limit) `method`

##### Summary

Returns the set of accepted strings, assuming that at most

```
limit
```

strings are
accepted. If more than

```
limit
```

strings are accepted, null is returned. If

```
limit
```

<0, then this methods works like {@link #getFiniteStrings(Automaton)}.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |
| limit | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The limit. |

<a name='M-Fare-SpecialOperations-GetFiniteStrings-Fare-State,System-Collections-Generic-HashSet{Fare-State},System-Collections-Generic-HashSet{System-String},System-Text-StringBuilder,System-Int32-'></a>
### GetFiniteStrings(s,pathStates,strings,path,limit) `method`

##### Summary

Returns the strings that can be produced from the given state, or false if more than

```
limit
```

strings are found.

```
limit
```

<0 means "infinite".

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [Fare.State](#T-Fare-State 'Fare.State') | The s. |
| pathStates | [System.Collections.Generic.HashSet{Fare.State}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.HashSet 'System.Collections.Generic.HashSet{Fare.State}') | The path states. |
| strings | [System.Collections.Generic.HashSet{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.HashSet 'System.Collections.Generic.HashSet{System.String}') | The strings. |
| path | [System.Text.StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') | The path. |
| limit | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The limit. |

<a name='M-Fare-SpecialOperations-GetStrings-Fare-Automaton,System-Int32-'></a>
### GetStrings(a,length) `method`

##### Summary

Returns the set of accepted strings of the given length.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length. |

<a name='M-Fare-SpecialOperations-HexCases-Fare-Automaton-'></a>
### HexCases(a) `method`

##### Summary

Constructs automaton that accepts the same strings as the given automaton but ignores upper/lower 
case of A-F.

##### Returns

An automaton.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |

<a name='M-Fare-SpecialOperations-Homomorph-Fare-Automaton,System-Char[],System-Char[]-'></a>
### Homomorph(a,source,dest) `method`

##### Summary

Returns an automaton accepting the homomorphic image of the given automaton using the
given function.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |
| source | [System.Char[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char[] 'System.Char[]') | The source. |
| dest | [System.Char[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char[] 'System.Char[]') | The dest. |

<a name='M-Fare-SpecialOperations-IsFinite-Fare-Automaton-'></a>
### IsFinite(a) `method`

##### Summary

Returns true if the language of this automaton is finite.

##### Returns

`true` if the specified a is finite; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |

<a name='M-Fare-SpecialOperations-IsFinite-Fare-State,System-Collections-Generic-HashSet{Fare-State},System-Collections-Generic-HashSet{Fare-State}-'></a>
### IsFinite(s,path,visited) `method`

##### Summary

Checks whether there is a loop containing s. (This is sufficient since there are never
transitions to dead states).

##### Returns

`true` if the specified s is finite; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [Fare.State](#T-Fare-State 'Fare.State') | The s. |
| path | [System.Collections.Generic.HashSet{Fare.State}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.HashSet 'System.Collections.Generic.HashSet{Fare.State}') | The path. |
| visited | [System.Collections.Generic.HashSet{Fare.State}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.HashSet 'System.Collections.Generic.HashSet{Fare.State}') | The visited. |

<a name='M-Fare-SpecialOperations-Overlap-Fare-Automaton,Fare-Automaton-'></a>
### Overlap(a1,a2) `method`

##### Summary

Returns an automaton that accepts the overlap of strings that in more than one way can be 
split into a left part being accepted by

```
a1
```

and a right part being accepted 
by

```
a2
```

.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a1 | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The a1. |
| a2 | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The a2. |

<a name='M-Fare-SpecialOperations-PrefixClose-Fare-Automaton-'></a>
### PrefixClose(a) `method`

##### Summary

Prefix closes the given automaton.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |

<a name='M-Fare-SpecialOperations-ProjectChars-Fare-Automaton,System-Collections-Generic-HashSet{System-Char}-'></a>
### ProjectChars(a,chars) `method`

##### Summary

Returns an automaton with projected alphabet. The new automaton accepts all strings that
are projections of strings accepted by the given automaton onto the given characters
(represented by

```
Character
```

). If

```
null
```

is in the set, it abbreviates
the intervals u0000-uDFFF and uF900-uFFFF (i.e., the non-private code points). It is assumed
that all other characters from

```
chars
```

are in the interval uE000-uF8FF.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |
| chars | [System.Collections.Generic.HashSet{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.HashSet 'System.Collections.Generic.HashSet{System.Char}') | The chars. |

<a name='M-Fare-SpecialOperations-ReplaceWhitespace-Fare-Automaton-'></a>
### ReplaceWhitespace(a) `method`

##### Summary

Constructs automaton that accepts 0x20, 0x9, 0xa, and 0xd in place of each 0x20 transition
in the given automaton.

##### Returns

An automaton.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |

<a name='M-Fare-SpecialOperations-Reverse-Fare-Automaton-'></a>
### Reverse(a) `method`

##### Summary

Reverses the language of the given (non-singleton) automaton while returning the set of 
new initial states.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |

<a name='M-Fare-SpecialOperations-SingleChars-Fare-Automaton-'></a>
### SingleChars(a) `method`

##### Summary

Returns an automaton that accepts the single chars that occur in strings that are accepted
by the given automaton. Never modifies the input automaton.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |

<a name='M-Fare-SpecialOperations-Subst-Fare-Automaton,System-Collections-Generic-IDictionary{System-Char,System-Collections-Generic-HashSet{System-Char}}-'></a>
### Subst(a,dictionary) `method`

##### Summary

Returns an automaton where all transition labels have been substituted.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |
| dictionary | [System.Collections.Generic.IDictionary{System.Char,System.Collections.Generic.HashSet{System.Char}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{System.Char,System.Collections.Generic.HashSet{System.Char}}') | The dictionary from characters to sets of characters (where 
characters are

```
char
```

objects). |

<a name='M-Fare-SpecialOperations-Subst-Fare-Automaton,System-Char,System-String-'></a>
### Subst(a,c,s) `method`

##### Summary

Returns an automaton where all transitions of the given char are replaced by a string.

##### Returns

A new automaton.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |
| c | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The c. |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The s. |

<a name='M-Fare-SpecialOperations-Trim-Fare-Automaton,System-String,System-Char-'></a>
### Trim(a,set,c) `method`

##### Summary

Returns an automaton that accepts the trimmed language of the given automaton. The 
resulting automaton is constructed as follows: 1) Whenever a

```
c
```

character is
allowed in the original automaton, one or more

```
set
```

characters are allowed in
the new automaton. 2) The automaton is prefixed and postfixed with any number of

```
set
```

characters.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Fare.Automaton](#T-Fare-Automaton 'Fare.Automaton') | The automaton. |
| set | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The set of characters to be trimmed. |
| c | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The canonical trim character (assumed to be in

```
set
```

). |

<a name='T-Fare-State'></a>
## State `type`

##### Namespace

Fare

##### Summary

state.

<a name='M-Fare-State-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [State](#T-Fare-State 'Fare.State') class. Initially, the new state is a 
  reject state.

##### Parameters

This constructor has no parameters.

<a name='P-Fare-State-Accept'></a>
### Accept `property`

##### Summary

Gets or sets a value indicating whether this State is Accept.

<a name='P-Fare-State-Id'></a>
### Id `property`

##### Summary

Gets the id.

<a name='P-Fare-State-Number'></a>
### Number `property`

##### Summary

Gets or sets this State Number.

<a name='P-Fare-State-Transitions'></a>
### Transitions `property`

##### Summary

Gets or sets this State Transitions.

<a name='M-Fare-State-AddTransition-Fare-Transition-'></a>
### AddTransition(t) `method`

##### Summary

Adds an outgoing transition.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t | [Fare.Transition](#T-Fare-Transition 'Fare.Transition') | The transition. |

<a name='M-Fare-State-CompareTo-System-Object-'></a>
### CompareTo() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Fare-State-CompareTo-Fare-State-'></a>
### CompareTo() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Fare-State-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Fare-State-Equals-Fare-State-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Fare-State-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Fare-State-GetSortedTransitions-System-Boolean-'></a>
### GetSortedTransitions(toFirst) `method`

##### Summary

Gets the transitions sorted by (min, reverse max, to) or (to, min, reverse max).

##### Returns

The transitions sorted by (min, reverse max, to) or (to, min, reverse max).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| toFirst | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [to first]. |

<a name='M-Fare-State-Step-System-Char-'></a>
### Step(c) `method`

##### Summary

Performs lookup in transitions, assuming determinism.

##### Returns

The destination state, null if no matching outgoing transition.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The character to look up. |

<a name='M-Fare-State-Step-System-Char,System-Collections-Generic-List{Fare-State}-'></a>
### Step(c,dest) `method`

##### Summary

Performs lookup in transitions, allowing nondeterminism.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The character to look up. |
| dest | [System.Collections.Generic.List{Fare.State}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{Fare.State}') | The collection where destination states are stored. |

<a name='M-Fare-State-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Fare-State-op_Equality-Fare-State,Fare-State-'></a>
### op_Equality(left,right) `method`

##### Summary

Implements the operator ==.

##### Returns

The result of the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Fare.State](#T-Fare-State 'Fare.State') | The left. |
| right | [Fare.State](#T-Fare-State 'Fare.State') | The right. |

<a name='M-Fare-State-op_Inequality-Fare-State,Fare-State-'></a>
### op_Inequality(left,right) `method`

##### Summary

Implements the operator !=.

##### Returns

The result of the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Fare.State](#T-Fare-State 'Fare.State') | The left. |
| right | [Fare.State](#T-Fare-State 'Fare.State') | The right. |

<a name='T-Fare-StateEqualityComparer'></a>
## StateEqualityComparer `type`

##### Namespace

Fare

<a name='M-Fare-StateEqualityComparer-Equals-Fare-State,Fare-State-'></a>
### Equals(x,y) `method`

##### Summary

Determines whether the specified objects are equal.

##### Returns

true if the specified objects are equal; otherwise, false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| x | [Fare.State](#T-Fare-State 'Fare.State') | The first object of type `x` to compare. |
| y | [Fare.State](#T-Fare-State 'Fare.State') | The second object of type `y` to compare. |

<a name='M-Fare-StateEqualityComparer-GetHashCode-Fare-State-'></a>
### GetHashCode(obj) `method`

##### Summary

Returns a hash code for this instance.

##### Returns

A hash code for this instance, suitable for use in hashing algorithms and data structures
like a hash table.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [Fare.State](#T-Fare-State 'Fare.State') | The obj. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | The type of `obj` is a reference type and `obj` is null. |

<a name='T-Fare-StatePair'></a>
## StatePair `type`

##### Namespace

Fare

##### Summary

Pair of states.

<a name='M-Fare-StatePair-#ctor-Fare-State,Fare-State,Fare-State-'></a>
### #ctor(s,s1,s2) `constructor`

##### Summary

Initializes a new instance of the [StatePair](#T-Fare-StatePair 'Fare.StatePair') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [Fare.State](#T-Fare-State 'Fare.State') | The s. |
| s1 | [Fare.State](#T-Fare-State 'Fare.State') | The s1. |
| s2 | [Fare.State](#T-Fare-State 'Fare.State') | The s2. |

<a name='M-Fare-StatePair-#ctor-Fare-State,Fare-State-'></a>
### #ctor(s1,s2) `constructor`

##### Summary

Initializes a new instance of the [StatePair](#T-Fare-StatePair 'Fare.StatePair') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s1 | [Fare.State](#T-Fare-State 'Fare.State') | The first state. |
| s2 | [Fare.State](#T-Fare-State 'Fare.State') | The second state. |

<a name='P-Fare-StatePair-FirstState'></a>
### FirstState `property`

##### Summary

Gets or sets the first component of this pair.

<a name='P-Fare-StatePair-S'></a>
### S `property`

##### Summary

Gets or sets the s.

<a name='P-Fare-StatePair-SecondState'></a>
### SecondState `property`

##### Summary

Gets or sets the second component of this pair.

<a name='M-Fare-StatePair-Equals-Fare-StatePair-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Fare-StatePair-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Fare-StatePair-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Fare-StatePair-op_Equality-Fare-StatePair,Fare-StatePair-'></a>
### op_Equality(left,right) `method`

##### Summary

Implements the operator ==.

##### Returns

The result of the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Fare.StatePair](#T-Fare-StatePair 'Fare.StatePair') | The left. |
| right | [Fare.StatePair](#T-Fare-StatePair 'Fare.StatePair') | The right. |

<a name='M-Fare-StatePair-op_Inequality-Fare-StatePair,Fare-StatePair-'></a>
### op_Inequality(left,right) `method`

##### Summary

Implements the operator !=.

##### Returns

The result of the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Fare.StatePair](#T-Fare-StatePair 'Fare.StatePair') | The left. |
| right | [Fare.StatePair](#T-Fare-StatePair 'Fare.StatePair') | The right. |

<a name='T-Fare-StringUnionOperations'></a>
## StringUnionOperations `type`

##### Namespace

Fare

##### Summary

string union operations

<a name='P-Fare-StringUnionOperations-LexicographicOrderComparer'></a>
### LexicographicOrderComparer `property`

##### Summary

Gets the lexicographic order comparer.

<a name='M-Fare-StringUnionOperations-Add-System-Char[]-'></a>
### Add(current) `method`

##### Summary

Adds the specified current.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| current | [System.Char[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char[] 'System.Char[]') | The current. |

<a name='M-Fare-StringUnionOperations-Build-System-Collections-Generic-IEnumerable{System-Char[]}-'></a>
### Build(input) `method`

##### Summary

Builds the specified input.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.Collections.Generic.IEnumerable{System.Char[]}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Char[]}') | The input. |

<a name='T-RandomDataGenerator-Enums-SubFieldType'></a>
## SubFieldType `type`

##### Namespace

RandomDataGenerator.Enums

##### Summary



<a name='F-RandomDataGenerator-Enums-SubFieldType-Boolean'></a>
### Boolean `constants`

##### Summary

Boolean

<a name='F-RandomDataGenerator-Enums-SubFieldType-CCN'></a>
### CCN `constants`

##### Summary

CCN payment card

<a name='F-RandomDataGenerator-Enums-SubFieldType-City'></a>
### City `constants`

##### Summary

City

<a name='F-RandomDataGenerator-Enums-SubFieldType-Country'></a>
### Country `constants`

##### Summary

Country

<a name='F-RandomDataGenerator-Enums-SubFieldType-DateTime'></a>
### DateTime `constants`

##### Summary

Date / Time

<a name='F-RandomDataGenerator-Enums-SubFieldType-Double'></a>
### Double `constants`

##### Summary

Double

<a name='F-RandomDataGenerator-Enums-SubFieldType-EmailAddress'></a>
### EmailAddress `constants`

##### Summary

Email Address

<a name='F-RandomDataGenerator-Enums-SubFieldType-FirstName'></a>
### FirstName `constants`

##### Summary

First Name

<a name='F-RandomDataGenerator-Enums-SubFieldType-Float'></a>
### Float `constants`

##### Summary

Float

<a name='F-RandomDataGenerator-Enums-SubFieldType-FullName'></a>
### FullName `constants`

##### Summary

Full Name

<a name='F-RandomDataGenerator-Enums-SubFieldType-Guid'></a>
### Guid `constants`

##### Summary

Guid

<a name='F-RandomDataGenerator-Enums-SubFieldType-IPv4Address'></a>
### IPv4Address `constants`

##### Summary

IPv4 Address

<a name='F-RandomDataGenerator-Enums-SubFieldType-IPv6Address'></a>
### IPv6Address `constants`

##### Summary

IPV6 Address

<a name='F-RandomDataGenerator-Enums-SubFieldType-Integer'></a>
### Integer `constants`

##### Summary

Integer

<a name='F-RandomDataGenerator-Enums-SubFieldType-LastName'></a>
### LastName `constants`

##### Summary

Last Name

<a name='F-RandomDataGenerator-Enums-SubFieldType-Long'></a>
### Long `constants`

##### Summary

Long

<a name='F-RandomDataGenerator-Enums-SubFieldType-MACAddress'></a>
### MACAddress `constants`

##### Summary

Mac Address

<a name='F-RandomDataGenerator-Enums-SubFieldType-None'></a>
### None `constants`

##### Summary

The none option

<a name='F-RandomDataGenerator-Enums-SubFieldType-Short'></a>
### Short `constants`

##### Summary

Short

<a name='F-RandomDataGenerator-Enums-SubFieldType-StringList'></a>
### StringList `constants`

##### Summary

string list

<a name='F-RandomDataGenerator-Enums-SubFieldType-Text'></a>
### Text `constants`

##### Summary

Text

<a name='F-RandomDataGenerator-Enums-SubFieldType-TextLipsum'></a>
### TextLipsum `constants`

##### Summary

Lipsum

<a name='F-RandomDataGenerator-Enums-SubFieldType-TextNaughtyStrings'></a>
### TextNaughtyStrings `constants`

##### Summary

Naughty Strings

<a name='F-RandomDataGenerator-Enums-SubFieldType-TextPattern'></a>
### TextPattern `constants`

##### Summary

Text pattern

<a name='F-RandomDataGenerator-Enums-SubFieldType-TextRegex'></a>
### TextRegex `constants`

##### Summary

Regex

<a name='F-RandomDataGenerator-Enums-SubFieldType-TextWords'></a>
### TextWords `constants`

##### Summary

Text words

<a name='T-RandomDataGenerator-FieldOptions-TextRandomizeContextEnum'></a>
## TextRandomizeContextEnum `type`

##### Namespace

RandomDataGenerator.FieldOptions

##### Summary

Text randomize context Enumeration

<a name='F-RandomDataGenerator-FieldOptions-TextRandomizeContextEnum-All'></a>
### All `constants`

##### Summary

Use All

<a name='F-RandomDataGenerator-FieldOptions-TextRandomizeContextEnum-UseLetter'></a>
### UseLetter `constants`

##### Summary

Use letter

<a name='F-RandomDataGenerator-FieldOptions-TextRandomizeContextEnum-UseLowercase'></a>
### UseLowercase `constants`

##### Summary

Use lowercase

<a name='F-RandomDataGenerator-FieldOptions-TextRandomizeContextEnum-UseNumber'></a>
### UseNumber `constants`

##### Summary

Use number

<a name='F-RandomDataGenerator-FieldOptions-TextRandomizeContextEnum-UseSpace'></a>
### UseSpace `constants`

##### Summary

Use space

<a name='F-RandomDataGenerator-FieldOptions-TextRandomizeContextEnum-UseSpecial'></a>
### UseSpecial `constants`

##### Summary

Use special

<a name='F-RandomDataGenerator-FieldOptions-TextRandomizeContextEnum-UseUppercase'></a>
### UseUppercase `constants`

##### Summary

Use uppercase

<a name='T-RandomDataGenerator-Data-TheNaughtyStrings'></a>
## TheNaughtyStrings `type`

##### Namespace

RandomDataGenerator.Data

##### Summary

Naughty strings.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-All'></a>
### All `constants`

##### Summary

All naughty strings.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-Changinglengthwhenlowercased'></a>
### Changinglengthwhenlowercased `constants`

##### Summary

Characters which increase in length (2 to 3 bytes) when lowercased Credit: https://twitter.com/jifa/status/625776454479970304.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-CommandInjectionRuby'></a>
### CommandInjectionRuby `constants`

##### Summary

Strings which can call system commands within Ruby/Rails applications.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-Emoji'></a>
### Emoji `constants`

##### Summary

Strings which contain Emoji; should be the same behavior as two-byte characters, but not always.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-FileInclusion'></a>
### FileInclusion `constants`

##### Summary

Strings which can cause user to pull in files that should not be a part of a web server.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-Humaninjection'></a>
### Humaninjection `constants`

##### Summary

Strings which may cause human to reinterpret worldview.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-JapaneseEmoticons'></a>
### JapaneseEmoticons `constants`

##### Summary

Strings which consists of Japanese-style emoticons which are popular on the web.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-KnownCVEsandVulnerabilities'></a>
### KnownCVEsandVulnerabilities `constants`

##### Summary

Strings that test for known vulnerabilities.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-MSDOSWindowsSpecialFilenames'></a>
### MSDOSWindowsSpecialFilenames `constants`

##### Summary

Strings which are reserved characters in MSDOS/Windows.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-NumericStrings'></a>
### NumericStrings `constants`

##### Summary

Strings which can be interpreted as numeric.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-OghamText'></a>
### OghamText `constants`

##### Summary

The only unicode alphabet to use a space which isn't empty but should still act like a space.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-QuotationMarks'></a>
### QuotationMarks `constants`

##### Summary

Strings which contain misplaced quotation marks; can cause encoding errors.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-ReservedStrings'></a>
### ReservedStrings `constants`

##### Summary

Strings which may be used elsewhere in code.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-RightToLeftStrings'></a>
### RightToLeftStrings `constants`

##### Summary

Strings which contain text that should be rendered RTL if possible (e.g. Arabic, Hebrew).

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-SQLInjection'></a>
### SQLInjection `constants`

##### Summary

Strings which can cause a SQL injection if inputs are not sanitized.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-ScriptInjection'></a>
### ScriptInjection `constants`

##### Summary

Strings which attempt to invoke a benign script injection; shows vulnerability to XSS.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-ScunthorpeProblem'></a>
### ScunthorpeProblem `constants`

##### Summary

Innocuous strings which may be blocked by profanity filters (https://en.wikipedia.org/wiki/Scunthorpe_problem).

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-ServerCodeInjection'></a>
### ServerCodeInjection `constants`

##### Summary

Strings which can cause user to run code on server as a privileged user (c.f. https://news.ycombinator.com/item?id=7665153).

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-SpecialCharacters'></a>
### SpecialCharacters `constants`

##### Summary

ASCII punctuation.  All of these characters may need to be escaped in some contexts.  Divided into three groups based on (US-layout) keyboard position.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-SpecialUnicodeCharactersUnion'></a>
### SpecialUnicodeCharactersUnion `constants`

##### Summary

A super string recommended by VMware Inc. Globalization Team: can effectively cause rendering issues or character-length issues to validate product globalization readiness.  表          CJK_UNIFIED_IDEOGRAPHS (U+8868) ポ          KATAKANA LETTER PO (U+30DD) あ          HIRAGANA LETTER A (U+3042) A           LATIN CAPITAL LETTER A (U+0041) 鷗          CJK_UNIFIED_IDEOGRAPHS (U+9DD7) Œ           LATIN SMALL LIGATURE OE (U+0153) é           LATIN SMALL LETTER E WITH ACUTE (U+00E9) Ｂ           FULLWIDTH LATIN CAPITAL LETTER B (U+FF22) 逍          CJK_UNIFIED_IDEOGRAPHS (U+900D) Ü           LATIN SMALL LETTER U WITH DIAERESIS (U+00FC) ß           LATIN SMALL LETTER SHARP S (U+00DF) ª           FEMININE ORDINAL INDICATOR (U+00AA) ą           LATIN SMALL LETTER A WITH OGONEK (U+0105) ñ           LATIN SMALL LETTER N WITH TILDE (U+00F1) 丂          CJK_UNIFIED_IDEOGRAPHS (U+4E02) 㐀          CJK Ideograph Extension A, First (U+3400) 𠀀          CJK Ideograph Extension B, First (U+20000).

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-Stringswhichcontaintwobyteletters'></a>
### Stringswhichcontaintwobyteletters `constants`

##### Summary

.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-Terminalescapecodes'></a>
### Terminalescapecodes `constants`

##### Summary

Strings which punish the fools who use cat/type on this file.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-TrickUnicode'></a>
### TrickUnicode `constants`

##### Summary

Strings which contain unicode with unusual properties (e.g. Right-to-left override) (c.f. http://www.unicode.org/charts/PDF/U2000.pdf).

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-TwoByteCharacters'></a>
### TwoByteCharacters `constants`

##### Summary

Strings which contain two-byte characters: can cause rendering issues or character-length issues.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-UnicodeNumbers'></a>
### UnicodeNumbers `constants`

##### Summary

Strings which contain unicode numbers; if the code is localized, it should see the input as numeric.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-UnicodeSubscriptSuperscriptAccents'></a>
### UnicodeSubscriptSuperscriptAccents `constants`

##### Summary

Strings which contain unicode subscripts/superscripts; can cause rendering issues.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-UnicodeSymbols'></a>
### UnicodeSymbols `constants`

##### Summary

Strings which contain common unicode symbols (e.g. smart quotes).

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-UnicodeUpsidedown'></a>
### UnicodeUpsidedown `constants`

##### Summary

Strings which contain unicode with an "upsidedown" effect (via http://www.upsidedowntext.com).

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-Unicodefont'></a>
### Unicodefont `constants`

##### Summary

Strings which contain bold/italic/etc. versions of normal characters.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-UnwantedInterpolation'></a>
### UnwantedInterpolation `constants`

##### Summary

Strings which can be accidentally expanded into different strings if evaluated in the wrong context, e.g. used as a printf format string or via Perl or shell eval. Might expose sensitive data from the program doing the interpolation, or might just represent the wrong string.

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-ZalgoText'></a>
### ZalgoText `constants`

##### Summary

Strings which contain "corrupted" text. The corruption will not appear in non-HTML text, however. (via http://www.eeemo.net).

<a name='F-RandomDataGenerator-Data-TheNaughtyStrings-iOSVulnerabilities'></a>
### iOSVulnerabilities `constants`

##### Summary

Strings which crashed iMessage in various versions of iOS.

<a name='T-Fare-Transition'></a>
## Transition `type`

##### Namespace

Fare

##### Summary

transition.

<a name='M-Fare-Transition-#ctor-System-Char,Fare-State-'></a>
### #ctor(c,to) `constructor`

##### Summary

Initializes a new instance of the [Transition](#T-Fare-Transition 'Fare.Transition') class.
(Constructs a new singleton interval transition).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The transition character. |
| to | [Fare.State](#T-Fare-State 'Fare.State') | The destination state. |

<a name='M-Fare-Transition-#ctor-System-Char,System-Char,Fare-State-'></a>
### #ctor(min,max,to) `constructor`

##### Summary

Initializes a new instance of the [Transition](#T-Fare-Transition 'Fare.Transition') class.
(Both end points are included in the interval).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The transition interval minimum. |
| max | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The transition interval maximum. |
| to | [Fare.State](#T-Fare-State 'Fare.State') | The destination state. |

<a name='P-Fare-Transition-Max'></a>
### Max `property`

##### Summary

Gets the maximum of this transition interval.

<a name='P-Fare-Transition-Min'></a>
### Min `property`

##### Summary

Gets the minimum of this transition interval.

<a name='P-Fare-Transition-To'></a>
### To `property`

##### Summary

Gets the destination of this transition.

<a name='M-Fare-Transition-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Fare-Transition-Equals-Fare-Transition-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Fare-Transition-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Fare-Transition-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Fare-Transition-op_Equality-Fare-Transition,Fare-Transition-'></a>
### op_Equality(left,right) `method`

##### Summary

Implements the operator ==.

##### Returns

The result of the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Fare.Transition](#T-Fare-Transition 'Fare.Transition') | The left. |
| right | [Fare.Transition](#T-Fare-Transition 'Fare.Transition') | The right. |

<a name='M-Fare-Transition-op_Inequality-Fare-Transition,Fare-Transition-'></a>
### op_Inequality(left,right) `method`

##### Summary

Implements the operator !=.

##### Returns

The result of the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Fare.Transition](#T-Fare-Transition 'Fare.Transition') | The left. |
| right | [Fare.Transition](#T-Fare-Transition 'Fare.Transition') | The right. |

<a name='T-Fare-TransitionComparer'></a>
## TransitionComparer `type`

##### Namespace

Fare

<a name='M-Fare-TransitionComparer-#ctor-System-Boolean-'></a>
### #ctor(toFirst) `constructor`

##### Summary

Initializes a new instance of the [TransitionComparer](#T-Fare-TransitionComparer 'Fare.TransitionComparer') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| toFirst | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [to first]. |

<a name='M-Fare-TransitionComparer-Compare-Fare-Transition,Fare-Transition-'></a>
### Compare(t1,t2) `method`

##### Summary

Compares by (min, reverse max, to) or (to, min, reverse max).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t1 | [Fare.Transition](#T-Fare-Transition 'Fare.Transition') | The first Transition. |
| t2 | [Fare.Transition](#T-Fare-Transition 'Fare.Transition') | The second Transition. |

<a name='T-Fare-Xeger'></a>
## Xeger `type`

##### Namespace

Fare

##### Summary

An object that will generate text from a regular expression. In a way, 
it's the opposite of a regular expression matcher: an instance of this class
will produce text that is guaranteed to match the regular expression passed in.

<a name='M-Fare-Xeger-#ctor-System-String,System-Random-'></a>
### #ctor(regex,random) `constructor`

##### Summary

Initializes a new instance of the [Xeger](#T-Fare-Xeger 'Fare.Xeger') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| regex | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The regex. |
| random | [System.Random](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Random 'System.Random') | The random. |

<a name='M-Fare-Xeger-#ctor-System-String-'></a>
### #ctor(regex) `constructor`

##### Summary

Initializes a new instance of the [Xeger](#T-Fare-Xeger 'Fare.Xeger') class.
Note that if multiple instances are created within short time using this overload,
the instances might generate identical random strings.
To avoid this, use the constructor overload that accepts an argument of type Random.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| regex | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The regex. |

<a name='M-Fare-Xeger-Generate'></a>
### Generate() `method`

##### Summary

Generates a random String that is guaranteed to match the regular expression passed to the constructor.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Fare-Xeger-GetRandomInt-System-Int32,System-Int32,System-Random-'></a>
### GetRandomInt(min,max,random) `method`

##### Summary

Generates a random number within the given bounds.

##### Returns

A random number in the given range.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The minimum number (inclusive). |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The maximum number (inclusive). |
| random | [System.Random](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Random 'System.Random') | The object used as the randomizer. |
