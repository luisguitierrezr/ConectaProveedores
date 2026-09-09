using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionStatusRecord
public class JSONRC_b0a85cd983a4f43fec20a9e94774104b : AbstractRESTStructure<RC_b0a85cd983a4f43fec20a9e94774104b> {
[JsonProperty("RequisitionStatus")]
[JsonPropertyName("RequisitionStatus")]
public ssConectaProveedores.RestRecords.JSONEN_0554a1252840ba4a5c4e6af5899608adEntityRecord AttrRequisitionStatus;

public JSONRC_b0a85cd983a4f43fec20a9e94774104b() { }

public JSONRC_b0a85cd983a4f43fec20a9e94774104b (RC_b0a85cd983a4f43fec20a9e94774104b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionStatus = ConvertToRestWithoutDefaults(s.ssENRequisitionStatus, new EN_0554a1252840ba4a5c4e6af5899608adEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_0554a1252840ba4a5c4e6af5899608adEntityRecord.FromStructure, config);
  } else {
AttrRequisitionStatus = ssConectaProveedores.RestRecords.JSONEN_0554a1252840ba4a5c4e6af5899608adEntityRecord.FromStructure(s.ssENRequisitionStatus, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b0a85cd983a4f43fec20a9e94774104b, RC_b0a85cd983a4f43fec20a9e94774104b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b0a85cd983a4f43fec20a9e94774104b s) => ToStructure(s, config);
}
public static RC_b0a85cd983a4f43fec20a9e94774104b ToStructure(ssConectaProveedores.RestRecords.JSONRC_b0a85cd983a4f43fec20a9e94774104b obj, IBehaviorsConfiguration config) { 
  RC_b0a85cd983a4f43fec20a9e94774104b s = new RC_b0a85cd983a4f43fec20a9e94774104b();
  if(obj != null) {
  s.ssENRequisitionStatus = ssConectaProveedores.RestRecords.JSONEN_0554a1252840ba4a5c4e6af5899608adEntityRecord.ToStructure(obj.AttrRequisitionStatus, config);
  }
  return s;
}

public static Func<RC_b0a85cd983a4f43fec20a9e94774104b, ssConectaProveedores.RestRecords.JSONRC_b0a85cd983a4f43fec20a9e94774104b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b0a85cd983a4f43fec20a9e94774104b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b0a85cd983a4f43fec20a9e94774104b FromStructure(RC_b0a85cd983a4f43fec20a9e94774104b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b0a85cd983a4f43fec20a9e94774104b(s, config);
}

}


