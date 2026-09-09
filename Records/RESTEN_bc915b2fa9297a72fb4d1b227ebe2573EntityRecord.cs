using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Space
public class RESTEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord : AbstractRESTStructure<EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord> {
[JsonProperty("Space")]
public string AttrSpace;

[JsonProperty("Order")]
public int? AttrOrder;

public RESTEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord() { }

public RESTEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord (EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSpace = s.ssSpace;
AttrOrder = (int?) s.ssOrder;
  } else {
AttrSpace = s.ssSpace;
AttrOrder = (int?) s.ssOrder;
  }
}

public static EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord obj) { 
  EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord s = new EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord();
  if(obj != null) {
  s.ssSpace = obj.AttrSpace == null ? "" : obj.AttrSpace;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  }
  return s;
}

public static Func<EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord, ssConectaProveedores.RestRecords.RESTEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord FromStructure(EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord(s, config);
}

}


