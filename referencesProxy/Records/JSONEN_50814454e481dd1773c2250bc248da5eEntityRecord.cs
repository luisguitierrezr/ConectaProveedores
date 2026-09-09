using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Direction
public class JSONEN_50814454e481dd1773c2250bc248da5eEntityRecord : AbstractRESTStructure<EN_50814454e481dd1773c2250bc248da5eEntityRecord> {
[JsonProperty("Direction")]
[JsonPropertyName("Direction")]
public string AttrDirection;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

public JSONEN_50814454e481dd1773c2250bc248da5eEntityRecord() { }

public JSONEN_50814454e481dd1773c2250bc248da5eEntityRecord (EN_50814454e481dd1773c2250bc248da5eEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDirection = s.ssDirection;
AttrOrder = (int?) s.ssOrder;
  } else {
AttrDirection = s.ssDirection;
AttrOrder = (int?) s.ssOrder;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_50814454e481dd1773c2250bc248da5eEntityRecord, EN_50814454e481dd1773c2250bc248da5eEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_50814454e481dd1773c2250bc248da5eEntityRecord s) => ToStructure(s, config);
}
public static EN_50814454e481dd1773c2250bc248da5eEntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_50814454e481dd1773c2250bc248da5eEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_50814454e481dd1773c2250bc248da5eEntityRecord s = new EN_50814454e481dd1773c2250bc248da5eEntityRecord();
  if(obj != null) {
  s.ssDirection = obj.AttrDirection == null ? "" : obj.AttrDirection;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  }
  return s;
}

public static Func<EN_50814454e481dd1773c2250bc248da5eEntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_50814454e481dd1773c2250bc248da5eEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_50814454e481dd1773c2250bc248da5eEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_50814454e481dd1773c2250bc248da5eEntityRecord FromStructure(EN_50814454e481dd1773c2250bc248da5eEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_50814454e481dd1773c2250bc248da5eEntityRecord(s, config);
}

}


