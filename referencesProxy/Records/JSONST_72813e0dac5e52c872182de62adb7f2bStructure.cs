using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ZMXFFIMF_OBT_TIP_CAMResp
public class JSONST_72813e0dac5e52c872182de62adb7f2bStructure : AbstractRESTStructure<ST_72813e0dac5e52c872182de62adb7f2bStructure> {
[JsonProperty("PE_FCURR")]
[JsonPropertyName("PE_FCURR")]
public string AttrPE_FCURR;

[JsonProperty("PE_GDATU")]
[JsonPropertyName("PE_GDATU")]
public string AttrPE_GDATU;

[JsonProperty("PE_KURST")]
[JsonPropertyName("PE_KURST")]
public string AttrPE_KURST;

[JsonProperty("PE_MSG")]
[JsonPropertyName("PE_MSG")]
public string AttrPE_MSG;

[JsonProperty("PE_TCURR")]
[JsonPropertyName("PE_TCURR")]
public string AttrPE_TCURR;

[JsonProperty("PE_UKURS")]
[JsonPropertyName("PE_UKURS")]
public decimal? AttrPE_UKURS;

public JSONST_72813e0dac5e52c872182de62adb7f2bStructure() { }

public JSONST_72813e0dac5e52c872182de62adb7f2bStructure (ST_72813e0dac5e52c872182de62adb7f2bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPE_FCURR = ConvertToRestWithoutDefaults(s.ssPE_FCURR, "");
AttrPE_GDATU = ConvertToRestWithoutDefaults(s.ssPE_GDATU, "");
AttrPE_KURST = ConvertToRestWithoutDefaults(s.ssPE_KURST, "");
AttrPE_MSG = ConvertToRestWithoutDefaults(s.ssPE_MSG, "");
AttrPE_TCURR = ConvertToRestWithoutDefaults(s.ssPE_TCURR, "");
AttrPE_UKURS = ConvertToRestWithoutDefaults(s.ssPE_UKURS, 0.0M);
  } else {
AttrPE_FCURR = s.ssPE_FCURR;
AttrPE_GDATU = s.ssPE_GDATU;
AttrPE_KURST = s.ssPE_KURST;
AttrPE_MSG = s.ssPE_MSG;
AttrPE_TCURR = s.ssPE_TCURR;
AttrPE_UKURS = (decimal?) s.ssPE_UKURS;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_72813e0dac5e52c872182de62adb7f2bStructure, ST_72813e0dac5e52c872182de62adb7f2bStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_72813e0dac5e52c872182de62adb7f2bStructure s) => ToStructure(s, config);
}
public static ST_72813e0dac5e52c872182de62adb7f2bStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_72813e0dac5e52c872182de62adb7f2bStructure obj, IBehaviorsConfiguration config) { 
  ST_72813e0dac5e52c872182de62adb7f2bStructure s = new ST_72813e0dac5e52c872182de62adb7f2bStructure();
  if(obj != null) {
  s.ssPE_FCURR = obj.AttrPE_FCURR == null ? "" : obj.AttrPE_FCURR;
  s.ssPE_GDATU = obj.AttrPE_GDATU == null ? "" : obj.AttrPE_GDATU;
  s.ssPE_KURST = obj.AttrPE_KURST == null ? "" : obj.AttrPE_KURST;
  s.ssPE_MSG = obj.AttrPE_MSG == null ? "" : obj.AttrPE_MSG;
  s.ssPE_TCURR = obj.AttrPE_TCURR == null ? "" : obj.AttrPE_TCURR;
  s.ssPE_UKURS = obj.AttrPE_UKURS == null ? 0.0M : obj.AttrPE_UKURS.Value;
  }
  return s;
}

public static Func<ST_72813e0dac5e52c872182de62adb7f2bStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_72813e0dac5e52c872182de62adb7f2bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_72813e0dac5e52c872182de62adb7f2bStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_72813e0dac5e52c872182de62adb7f2bStructure FromStructure(ST_72813e0dac5e52c872182de62adb7f2bStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_72813e0dac5e52c872182de62adb7f2bStructure(s, config);
}

}


