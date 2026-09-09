using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// MarginSize
public class JSONEN_bc12735cadf5fd97cab6601d74d436e8EntityRecord : AbstractRESTStructure<EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord> {
[JsonProperty("Size")]
[JsonPropertyName("Size")]
public string AttrSize;

[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

[JsonProperty("MarginTop")]
[JsonPropertyName("MarginTop")]
public decimal? AttrMarginTop;

[JsonProperty("MarginRight")]
[JsonPropertyName("MarginRight")]
public decimal? AttrMarginRight;

[JsonProperty("MarginBottom")]
[JsonPropertyName("MarginBottom")]
public decimal? AttrMarginBottom;

[JsonProperty("MarginLeft")]
[JsonPropertyName("MarginLeft")]
public decimal? AttrMarginLeft;

[JsonProperty("IsInternational")]
[JsonPropertyName("IsInternational")]
public bool? AttrIsInternational;

public JSONEN_bc12735cadf5fd97cab6601d74d436e8EntityRecord() { }

public JSONEN_bc12735cadf5fd97cab6601d74d436e8EntityRecord (EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSize = s.ssSize;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrMarginTop = (decimal?) s.ssMarginTop;
AttrMarginRight = (decimal?) s.ssMarginRight;
AttrMarginBottom = (decimal?) s.ssMarginBottom;
AttrMarginLeft = (decimal?) s.ssMarginLeft;
AttrIsInternational = (bool?) s.ssIsInternational;
  } else {
AttrSize = s.ssSize;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrMarginTop = (decimal?) s.ssMarginTop;
AttrMarginRight = (decimal?) s.ssMarginRight;
AttrMarginBottom = (decimal?) s.ssMarginBottom;
AttrMarginLeft = (decimal?) s.ssMarginLeft;
AttrIsInternational = (bool?) s.ssIsInternational;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_bc12735cadf5fd97cab6601d74d436e8EntityRecord, EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_bc12735cadf5fd97cab6601d74d436e8EntityRecord s) => ToStructure(s, config);
}
public static EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_bc12735cadf5fd97cab6601d74d436e8EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord s = new EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord();
  if(obj != null) {
  s.ssSize = obj.AttrSize == null ? "" : obj.AttrSize;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssMarginTop = obj.AttrMarginTop == null ? 0.0M : obj.AttrMarginTop.Value;
  s.ssMarginRight = obj.AttrMarginRight == null ? 0.0M : obj.AttrMarginRight.Value;
  s.ssMarginBottom = obj.AttrMarginBottom == null ? 0.0M : obj.AttrMarginBottom.Value;
  s.ssMarginLeft = obj.AttrMarginLeft == null ? 0.0M : obj.AttrMarginLeft.Value;
  s.ssIsInternational = obj.AttrIsInternational == null ? false : obj.AttrIsInternational.Value;
  }
  return s;
}

public static Func<EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_bc12735cadf5fd97cab6601d74d436e8EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_bc12735cadf5fd97cab6601d74d436e8EntityRecord FromStructure(EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_bc12735cadf5fd97cab6601d74d436e8EntityRecord(s, config);
}

}


