using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DropdownOptionalConfigs
public class RESTST_4e53cb8815b86020ced1d2f2652c9b1dStructure : AbstractRESTStructure<ST_4e53cb8815b86020ced1d2f2652c9b1dStructure> {
[JsonProperty("AllowMultipleSelection")]
public bool? AttrAllowMultipleSelection;

[JsonProperty("IsDisabled")]
public bool? AttrIsDisabled;

[JsonProperty("NoResultsText")]
public string AttrNoResultsText;

[JsonProperty("SearchPrompt")]
public string AttrSearchPrompt;

[JsonProperty("NoOptionsText")]
public string AttrNoOptionsText;

[JsonProperty("SanitizeDropdownValues")]
public bool? AttrSanitizeDropdownValues;

public RESTST_4e53cb8815b86020ced1d2f2652c9b1dStructure() { }

public RESTST_4e53cb8815b86020ced1d2f2652c9b1dStructure (ST_4e53cb8815b86020ced1d2f2652c9b1dStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAllowMultipleSelection = ConvertToRestWithoutDefaults(s.ssAllowMultipleSelection, false);
AttrIsDisabled = ConvertToRestWithoutDefaults(s.ssIsDisabled, false);
AttrNoResultsText = ConvertToRestWithoutDefaults(s.ssNoResultsText, RsseSpaceOutSystemsUI.DefaultValues.ReferenceStructure_DropdownOptionalConfigs_ReferenceStructureAttribute_NoResultsText);
AttrSearchPrompt = ConvertToRestWithoutDefaults(s.ssSearchPrompt, RsseSpaceOutSystemsUI.DefaultValues.ReferenceStructure_DropdownOptionalConfigs_ReferenceStructureAttribute_SearchPrompt);
AttrNoOptionsText = ConvertToRestWithoutDefaults(s.ssNoOptionsText, RsseSpaceOutSystemsUI.DefaultValues.ReferenceStructure_DropdownOptionalConfigs_ReferenceStructureAttribute_NoOptionsText);
AttrSanitizeDropdownValues = ConvertToRestWithoutDefaults(s.ssSanitizeDropdownValues, false);
  } else {
AttrAllowMultipleSelection = (bool?) s.ssAllowMultipleSelection;
AttrIsDisabled = (bool?) s.ssIsDisabled;
AttrNoResultsText = s.ssNoResultsText;
AttrSearchPrompt = s.ssSearchPrompt;
AttrNoOptionsText = s.ssNoOptionsText;
AttrSanitizeDropdownValues = (bool?) s.ssSanitizeDropdownValues;
  }
}

public static ST_4e53cb8815b86020ced1d2f2652c9b1dStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_4e53cb8815b86020ced1d2f2652c9b1dStructure obj) { 
  ST_4e53cb8815b86020ced1d2f2652c9b1dStructure s = new ST_4e53cb8815b86020ced1d2f2652c9b1dStructure();
  if(obj != null) {
  s.ssAllowMultipleSelection = obj.AttrAllowMultipleSelection == null ? false : obj.AttrAllowMultipleSelection.Value;
  s.ssIsDisabled = obj.AttrIsDisabled == null ? false : obj.AttrIsDisabled.Value;
  s.ssNoResultsText = obj.AttrNoResultsText == null ? RsseSpaceOutSystemsUI.DefaultValues.ReferenceStructure_DropdownOptionalConfigs_ReferenceStructureAttribute_NoResultsText : obj.AttrNoResultsText;
  s.ssSearchPrompt = obj.AttrSearchPrompt == null ? RsseSpaceOutSystemsUI.DefaultValues.ReferenceStructure_DropdownOptionalConfigs_ReferenceStructureAttribute_SearchPrompt : obj.AttrSearchPrompt;
  s.ssNoOptionsText = obj.AttrNoOptionsText == null ? RsseSpaceOutSystemsUI.DefaultValues.ReferenceStructure_DropdownOptionalConfigs_ReferenceStructureAttribute_NoOptionsText : obj.AttrNoOptionsText;
  s.ssSanitizeDropdownValues = obj.AttrSanitizeDropdownValues == null ? false : obj.AttrSanitizeDropdownValues.Value;
  }
  return s;
}

public static Func<ST_4e53cb8815b86020ced1d2f2652c9b1dStructure, ssConectaProveedores.RestRecords.RESTST_4e53cb8815b86020ced1d2f2652c9b1dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_4e53cb8815b86020ced1d2f2652c9b1dStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_4e53cb8815b86020ced1d2f2652c9b1dStructure FromStructure(ST_4e53cb8815b86020ced1d2f2652c9b1dStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_4e53cb8815b86020ced1d2f2652c9b1dStructure(s, config);
}

}


