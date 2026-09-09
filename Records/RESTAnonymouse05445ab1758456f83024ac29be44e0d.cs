using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CostCenterSAPRecord
public class RESTRC_515e950fe4b29206769e5475135e301d : AbstractRESTStructure<RC_515e950fe4b29206769e5475135e301d> {
[JsonProperty("CostCenterSAP")]
public ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord AttrCostCenterSAP;

public RESTRC_515e950fe4b29206769e5475135e301d() { }

public RESTRC_515e950fe4b29206769e5475135e301d (RC_515e950fe4b29206769e5475135e301d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCostCenterSAP = ConvertToRestWithoutDefaults(s.ssENCostCenterSAP, new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure, config);
  } else {
AttrCostCenterSAP = ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure(s.ssENCostCenterSAP, config);
  }
}

public static RC_515e950fe4b29206769e5475135e301d ToStructure(ssConectaProveedores.RestRecords.RESTRC_515e950fe4b29206769e5475135e301d obj) { 
  RC_515e950fe4b29206769e5475135e301d s = new RC_515e950fe4b29206769e5475135e301d();
  if(obj != null) {
  s.ssENCostCenterSAP = ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.ToStructure(obj.AttrCostCenterSAP);
  }
  return s;
}

public static Func<RC_515e950fe4b29206769e5475135e301d, ssConectaProveedores.RestRecords.RESTRC_515e950fe4b29206769e5475135e301d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_515e950fe4b29206769e5475135e301d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_515e950fe4b29206769e5475135e301d FromStructure(RC_515e950fe4b29206769e5475135e301d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_515e950fe4b29206769e5475135e301d(s, config);
}

}


