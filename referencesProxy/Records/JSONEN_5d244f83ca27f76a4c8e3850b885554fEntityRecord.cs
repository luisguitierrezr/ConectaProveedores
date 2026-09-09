using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// RetentionTypes
public class JSONEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord : AbstractRESTStructure<EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Indicator")]
[JsonPropertyName("Indicator")]
public string AttrIndicator;

[JsonProperty("Description")]
[JsonPropertyName("Description")]
public string AttrDescription;

public JSONEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord() { }

public JSONEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord (EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrIndicator = s.ssIndicator;
AttrDescription = s.ssDescription;
  } else {
AttrId = (long?) s.ssId;
AttrIndicator = s.ssIndicator;
AttrDescription = s.ssDescription;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord, EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord s) => ToStructure(s, config);
}
public static EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord s = new EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssIndicator = obj.AttrIndicator == null ? "" : obj.AttrIndicator;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  }
  return s;
}

public static Func<EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord FromStructure(EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord(s, config);
}

}


