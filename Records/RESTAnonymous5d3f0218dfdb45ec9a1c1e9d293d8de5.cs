using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionStatusRecord
public class RESTRC_b0a85cd983a4f43fec20a9e94774104b : AbstractRESTStructure<RC_b0a85cd983a4f43fec20a9e94774104b> {
[JsonProperty("RequisitionStatus")]
public ssConectaProveedores.RestRecords.RESTEN_0554a1252840ba4a5c4e6af5899608adEntityRecord AttrRequisitionStatus;

public RESTRC_b0a85cd983a4f43fec20a9e94774104b() { }

public RESTRC_b0a85cd983a4f43fec20a9e94774104b (RC_b0a85cd983a4f43fec20a9e94774104b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionStatus = ConvertToRestWithoutDefaults(s.ssENRequisitionStatus, new EN_0554a1252840ba4a5c4e6af5899608adEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_0554a1252840ba4a5c4e6af5899608adEntityRecord.FromStructure, config);
  } else {
AttrRequisitionStatus = ssConectaProveedores.RestRecords.RESTEN_0554a1252840ba4a5c4e6af5899608adEntityRecord.FromStructure(s.ssENRequisitionStatus, config);
  }
}

public static RC_b0a85cd983a4f43fec20a9e94774104b ToStructure(ssConectaProveedores.RestRecords.RESTRC_b0a85cd983a4f43fec20a9e94774104b obj) { 
  RC_b0a85cd983a4f43fec20a9e94774104b s = new RC_b0a85cd983a4f43fec20a9e94774104b();
  if(obj != null) {
  s.ssENRequisitionStatus = ssConectaProveedores.RestRecords.RESTEN_0554a1252840ba4a5c4e6af5899608adEntityRecord.ToStructure(obj.AttrRequisitionStatus);
  }
  return s;
}

public static Func<RC_b0a85cd983a4f43fec20a9e94774104b, ssConectaProveedores.RestRecords.RESTRC_b0a85cd983a4f43fec20a9e94774104b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b0a85cd983a4f43fec20a9e94774104b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_b0a85cd983a4f43fec20a9e94774104b FromStructure(RC_b0a85cd983a4f43fec20a9e94774104b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_b0a85cd983a4f43fec20a9e94774104b(s, config);
}

}


