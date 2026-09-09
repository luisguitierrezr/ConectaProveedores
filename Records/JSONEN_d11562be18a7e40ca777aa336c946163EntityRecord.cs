using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Shape
public class JSONEN_d11562be18a7e40ca777aa336c946163EntityRecord : AbstractRESTStructure<EN_d11562be18a7e40ca777aa336c946163EntityRecord> {
[JsonProperty("Shape")]
[JsonPropertyName("Shape")]
public string AttrShape;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

public JSONEN_d11562be18a7e40ca777aa336c946163EntityRecord() { }

public JSONEN_d11562be18a7e40ca777aa336c946163EntityRecord (EN_d11562be18a7e40ca777aa336c946163EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrShape = s.ssShape;
AttrOrder = ConvertToRestWithoutDefaults(s.ssOrder, 0);
  } else {
AttrShape = s.ssShape;
AttrOrder = (int?) s.ssOrder;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_d11562be18a7e40ca777aa336c946163EntityRecord, EN_d11562be18a7e40ca777aa336c946163EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_d11562be18a7e40ca777aa336c946163EntityRecord s) => ToStructure(s, config);
}
public static EN_d11562be18a7e40ca777aa336c946163EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_d11562be18a7e40ca777aa336c946163EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_d11562be18a7e40ca777aa336c946163EntityRecord s = new EN_d11562be18a7e40ca777aa336c946163EntityRecord();
  if(obj != null) {
  s.ssShape = obj.AttrShape == null ? "" : obj.AttrShape;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  }
  return s;
}

public static Func<EN_d11562be18a7e40ca777aa336c946163EntityRecord, ssConectaProveedores.RestRecords.JSONEN_d11562be18a7e40ca777aa336c946163EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_d11562be18a7e40ca777aa336c946163EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_d11562be18a7e40ca777aa336c946163EntityRecord FromStructure(EN_d11562be18a7e40ca777aa336c946163EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_d11562be18a7e40ca777aa336c946163EntityRecord(s, config);
}

}


