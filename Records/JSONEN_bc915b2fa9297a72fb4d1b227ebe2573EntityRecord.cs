using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Space
public class JSONEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord : AbstractRESTStructure<EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord> {
[JsonProperty("Space")]
[JsonPropertyName("Space")]
public string AttrSpace;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

public JSONEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord() { }

public JSONEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord (EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSpace = s.ssSpace;
AttrOrder = (int?) s.ssOrder;
  } else {
AttrSpace = s.ssSpace;
AttrOrder = (int?) s.ssOrder;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord, EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord s) => ToStructure(s, config);
}
public static EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord s = new EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord();
  if(obj != null) {
  s.ssSpace = obj.AttrSpace == null ? "" : obj.AttrSpace;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  }
  return s;
}

public static Func<EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord, ssConectaProveedores.RestRecords.JSONEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord FromStructure(EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord(s, config);
}

}


