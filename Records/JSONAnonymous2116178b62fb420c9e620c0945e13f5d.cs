using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRequestFileApprovalLevelRecord
public class JSONRC_daa6040aa65b55c2574e6a4e976766ce : AbstractRESTStructure<RC_daa6040aa65b55c2574e6a4e976766ce> {
[JsonProperty("OrderRequestFileApprovalLevel")]
[JsonPropertyName("OrderRequestFileApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_80af67ecab8f43d464cc57955285a024EntityRecord AttrOrderRequestFileApprovalLevel;

public JSONRC_daa6040aa65b55c2574e6a4e976766ce() { }

public JSONRC_daa6040aa65b55c2574e6a4e976766ce (RC_daa6040aa65b55c2574e6a4e976766ce s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderRequestFileApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderRequestFileApprovalLevel, new EN_80af67ecab8f43d464cc57955285a024EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_80af67ecab8f43d464cc57955285a024EntityRecord.FromStructure, config);
  } else {
AttrOrderRequestFileApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_80af67ecab8f43d464cc57955285a024EntityRecord.FromStructure(s.ssENOrderRequestFileApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_daa6040aa65b55c2574e6a4e976766ce, RC_daa6040aa65b55c2574e6a4e976766ce> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_daa6040aa65b55c2574e6a4e976766ce s) => ToStructure(s, config);
}
public static RC_daa6040aa65b55c2574e6a4e976766ce ToStructure(ssConectaProveedores.RestRecords.JSONRC_daa6040aa65b55c2574e6a4e976766ce obj, IBehaviorsConfiguration config) { 
  RC_daa6040aa65b55c2574e6a4e976766ce s = new RC_daa6040aa65b55c2574e6a4e976766ce();
  if(obj != null) {
  s.ssENOrderRequestFileApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_80af67ecab8f43d464cc57955285a024EntityRecord.ToStructure(obj.AttrOrderRequestFileApprovalLevel, config);
  }
  return s;
}

public static Func<RC_daa6040aa65b55c2574e6a4e976766ce, ssConectaProveedores.RestRecords.JSONRC_daa6040aa65b55c2574e6a4e976766ce> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_daa6040aa65b55c2574e6a4e976766ce s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_daa6040aa65b55c2574e6a4e976766ce FromStructure(RC_daa6040aa65b55c2574e6a4e976766ce s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_daa6040aa65b55c2574e6a4e976766ce(s, config);
}

}


