using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PaperSize
public class JSONEN_7f47ecde673669f1866fae1765d30761EntityRecord : AbstractRESTStructure<EN_7f47ecde673669f1866fae1765d30761EntityRecord> {
[JsonProperty("Size")]
[JsonPropertyName("Size")]
public string AttrSize;

[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

[JsonProperty("Width")]
[JsonPropertyName("Width")]
public decimal? AttrWidth;

[JsonProperty("Height")]
[JsonPropertyName("Height")]
public decimal? AttrHeight;

[JsonProperty("IsInternational")]
[JsonPropertyName("IsInternational")]
public bool? AttrIsInternational;

[JsonProperty("IsLandscape")]
[JsonPropertyName("IsLandscape")]
public bool? AttrIsLandscape;

public JSONEN_7f47ecde673669f1866fae1765d30761EntityRecord() { }

public JSONEN_7f47ecde673669f1866fae1765d30761EntityRecord (EN_7f47ecde673669f1866fae1765d30761EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSize = s.ssSize;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrWidth = (decimal?) s.ssWidth;
AttrHeight = (decimal?) s.ssHeight;
AttrIsInternational = (bool?) s.ssIsInternational;
AttrIsLandscape = (bool?) s.ssIsLandscape;
  } else {
AttrSize = s.ssSize;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrWidth = (decimal?) s.ssWidth;
AttrHeight = (decimal?) s.ssHeight;
AttrIsInternational = (bool?) s.ssIsInternational;
AttrIsLandscape = (bool?) s.ssIsLandscape;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7f47ecde673669f1866fae1765d30761EntityRecord, EN_7f47ecde673669f1866fae1765d30761EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7f47ecde673669f1866fae1765d30761EntityRecord s) => ToStructure(s, config);
}
public static EN_7f47ecde673669f1866fae1765d30761EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7f47ecde673669f1866fae1765d30761EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_7f47ecde673669f1866fae1765d30761EntityRecord s = new EN_7f47ecde673669f1866fae1765d30761EntityRecord();
  if(obj != null) {
  s.ssSize = obj.AttrSize == null ? "" : obj.AttrSize;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssWidth = obj.AttrWidth == null ? 0.0M : obj.AttrWidth.Value;
  s.ssHeight = obj.AttrHeight == null ? 0.0M : obj.AttrHeight.Value;
  s.ssIsInternational = obj.AttrIsInternational == null ? false : obj.AttrIsInternational.Value;
  s.ssIsLandscape = obj.AttrIsLandscape == null ? false : obj.AttrIsLandscape.Value;
  }
  return s;
}

public static Func<EN_7f47ecde673669f1866fae1765d30761EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7f47ecde673669f1866fae1765d30761EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_7f47ecde673669f1866fae1765d30761EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7f47ecde673669f1866fae1765d30761EntityRecord FromStructure(EN_7f47ecde673669f1866fae1765d30761EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7f47ecde673669f1866fae1765d30761EntityRecord(s, config);
}

}


