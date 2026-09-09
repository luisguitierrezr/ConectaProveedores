using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RetentionTypes
public class RESTEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord : AbstractRESTStructure<EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Indicator")]
public string AttrIndicator;

[JsonProperty("Description")]
public string AttrDescription;

public RESTEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord() { }

public RESTEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord (EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord obj) { 
  EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord s = new EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssIndicator = obj.AttrIndicator == null ? "" : obj.AttrIndicator;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  }
  return s;
}

public static Func<EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord, ssConectaProveedores.RestRecords.RESTEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord FromStructure(EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord(s, config);
}

}


