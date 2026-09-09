using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// BooleanTypes
public class RESTEN_1e2af88601c0491260411e1369eb104cEntityRecord : AbstractRESTStructure<EN_1e2af88601c0491260411e1369eb104cEntityRecord> {
[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

public RESTEN_1e2af88601c0491260411e1369eb104cEntityRecord() { }

public RESTEN_1e2af88601c0491260411e1369eb104cEntityRecord (EN_1e2af88601c0491260411e1369eb104cEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
  } else {
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
  }
}

public static EN_1e2af88601c0491260411e1369eb104cEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_1e2af88601c0491260411e1369eb104cEntityRecord obj) { 
  EN_1e2af88601c0491260411e1369eb104cEntityRecord s = new EN_1e2af88601c0491260411e1369eb104cEntityRecord();
  if(obj != null) {
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  }
  return s;
}

public static Func<EN_1e2af88601c0491260411e1369eb104cEntityRecord, ssConectaProveedores.RestRecords.RESTEN_1e2af88601c0491260411e1369eb104cEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_1e2af88601c0491260411e1369eb104cEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_1e2af88601c0491260411e1369eb104cEntityRecord FromStructure(EN_1e2af88601c0491260411e1369eb104cEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_1e2af88601c0491260411e1369eb104cEntityRecord(s, config);
}

}


