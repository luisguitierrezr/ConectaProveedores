using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CostCenterSAPRecord
public class JSONRC_515e950fe4b29206769e5475135e301d : AbstractRESTStructure<RC_515e950fe4b29206769e5475135e301d> {
[JsonProperty("CostCenterSAP")]
[JsonPropertyName("CostCenterSAP")]
public ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord AttrCostCenterSAP;

public JSONRC_515e950fe4b29206769e5475135e301d() { }

public JSONRC_515e950fe4b29206769e5475135e301d (RC_515e950fe4b29206769e5475135e301d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCostCenterSAP = ConvertToRestWithoutDefaults(s.ssENCostCenterSAP, new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure, config);
  } else {
AttrCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure(s.ssENCostCenterSAP, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_515e950fe4b29206769e5475135e301d, RC_515e950fe4b29206769e5475135e301d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_515e950fe4b29206769e5475135e301d s) => ToStructure(s, config);
}
public static RC_515e950fe4b29206769e5475135e301d ToStructure(ssConectaProveedores.RestRecords.JSONRC_515e950fe4b29206769e5475135e301d obj, IBehaviorsConfiguration config) { 
  RC_515e950fe4b29206769e5475135e301d s = new RC_515e950fe4b29206769e5475135e301d();
  if(obj != null) {
  s.ssENCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.ToStructure(obj.AttrCostCenterSAP, config);
  }
  return s;
}

public static Func<RC_515e950fe4b29206769e5475135e301d, ssConectaProveedores.RestRecords.JSONRC_515e950fe4b29206769e5475135e301d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_515e950fe4b29206769e5475135e301d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_515e950fe4b29206769e5475135e301d FromStructure(RC_515e950fe4b29206769e5475135e301d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_515e950fe4b29206769e5475135e301d(s, config);
}

}


