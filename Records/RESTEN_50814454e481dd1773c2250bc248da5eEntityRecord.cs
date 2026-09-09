using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Direction
public class RESTEN_50814454e481dd1773c2250bc248da5eEntityRecord : AbstractRESTStructure<EN_50814454e481dd1773c2250bc248da5eEntityRecord> {
[JsonProperty("Direction")]
public string AttrDirection;

[JsonProperty("Order")]
public int? AttrOrder;

public RESTEN_50814454e481dd1773c2250bc248da5eEntityRecord() { }

public RESTEN_50814454e481dd1773c2250bc248da5eEntityRecord (EN_50814454e481dd1773c2250bc248da5eEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDirection = s.ssDirection;
AttrOrder = (int?) s.ssOrder;
  } else {
AttrDirection = s.ssDirection;
AttrOrder = (int?) s.ssOrder;
  }
}

public static EN_50814454e481dd1773c2250bc248da5eEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_50814454e481dd1773c2250bc248da5eEntityRecord obj) { 
  EN_50814454e481dd1773c2250bc248da5eEntityRecord s = new EN_50814454e481dd1773c2250bc248da5eEntityRecord();
  if(obj != null) {
  s.ssDirection = obj.AttrDirection == null ? "" : obj.AttrDirection;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  }
  return s;
}

public static Func<EN_50814454e481dd1773c2250bc248da5eEntityRecord, ssConectaProveedores.RestRecords.RESTEN_50814454e481dd1773c2250bc248da5eEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_50814454e481dd1773c2250bc248da5eEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_50814454e481dd1773c2250bc248da5eEntityRecord FromStructure(EN_50814454e481dd1773c2250bc248da5eEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_50814454e481dd1773c2250bc248da5eEntityRecord(s, config);
}

}


