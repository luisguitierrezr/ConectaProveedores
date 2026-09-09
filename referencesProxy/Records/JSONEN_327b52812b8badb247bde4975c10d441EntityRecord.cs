using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Currency
public class JSONEN_327b52812b8badb247bde4975c10d441EntityRecord : AbstractRESTStructure<EN_327b52812b8badb247bde4975c10d441EntityRecord> {
[JsonProperty("Code")]
[JsonPropertyName("Code")]
public string AttrCode;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("Symbol")]
[JsonPropertyName("Symbol")]
public string AttrSymbol;

[JsonProperty("MinorUnitDecimals")]
[JsonPropertyName("MinorUnitDecimals")]
public int? AttrMinorUnitDecimals;

[JsonProperty("IsActive")]
[JsonPropertyName("IsActive")]
public bool? AttrIsActive;

public JSONEN_327b52812b8badb247bde4975c10d441EntityRecord() { }

public JSONEN_327b52812b8badb247bde4975c10d441EntityRecord (EN_327b52812b8badb247bde4975c10d441EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCode = s.ssCode;
AttrName = s.ssName;
AttrSymbol = s.ssSymbol;
AttrMinorUnitDecimals = ConvertToRestWithoutDefaults(s.ssMinorUnitDecimals, 0);
AttrIsActive = (bool?) s.ssIsActive;
  } else {
AttrCode = s.ssCode;
AttrName = s.ssName;
AttrSymbol = s.ssSymbol;
AttrMinorUnitDecimals = (int?) s.ssMinorUnitDecimals;
AttrIsActive = (bool?) s.ssIsActive;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord, EN_327b52812b8badb247bde4975c10d441EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord s) => ToStructure(s, config);
}
public static EN_327b52812b8badb247bde4975c10d441EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_327b52812b8badb247bde4975c10d441EntityRecord s = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
  if(obj != null) {
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssSymbol = obj.AttrSymbol == null ? "" : obj.AttrSymbol;
  s.ssMinorUnitDecimals = obj.AttrMinorUnitDecimals == null ? 0 : obj.AttrMinorUnitDecimals.Value;
  s.ssIsActive = obj.AttrIsActive == null ? false : obj.AttrIsActive.Value;
  }
  return s;
}

public static Func<EN_327b52812b8badb247bde4975c10d441EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_327b52812b8badb247bde4975c10d441EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord FromStructure(EN_327b52812b8badb247bde4975c10d441EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord(s, config);
}

}


