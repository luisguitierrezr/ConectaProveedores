using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRequestFileApprovalLevelRecord
public class RESTRC_daa6040aa65b55c2574e6a4e976766ce : AbstractRESTStructure<RC_daa6040aa65b55c2574e6a4e976766ce> {
[JsonProperty("OrderRequestFileApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord AttrOrderRequestFileApprovalLevel;

public RESTRC_daa6040aa65b55c2574e6a4e976766ce() { }

public RESTRC_daa6040aa65b55c2574e6a4e976766ce (RC_daa6040aa65b55c2574e6a4e976766ce s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderRequestFileApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderRequestFileApprovalLevel, new EN_80af67ecab8f43d464cc57955285a024EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord.FromStructure, config);
  } else {
AttrOrderRequestFileApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord.FromStructure(s.ssENOrderRequestFileApprovalLevel, config);
  }
}

public static RC_daa6040aa65b55c2574e6a4e976766ce ToStructure(ssConectaProveedores.RestRecords.RESTRC_daa6040aa65b55c2574e6a4e976766ce obj) { 
  RC_daa6040aa65b55c2574e6a4e976766ce s = new RC_daa6040aa65b55c2574e6a4e976766ce();
  if(obj != null) {
  s.ssENOrderRequestFileApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord.ToStructure(obj.AttrOrderRequestFileApprovalLevel);
  }
  return s;
}

public static Func<RC_daa6040aa65b55c2574e6a4e976766ce, ssConectaProveedores.RestRecords.RESTRC_daa6040aa65b55c2574e6a4e976766ce> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_daa6040aa65b55c2574e6a4e976766ce s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_daa6040aa65b55c2574e6a4e976766ce FromStructure(RC_daa6040aa65b55c2574e6a4e976766ce s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_daa6040aa65b55c2574e6a4e976766ce(s, config);
}

}


