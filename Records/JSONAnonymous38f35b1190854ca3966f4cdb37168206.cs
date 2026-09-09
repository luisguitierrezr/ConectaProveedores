using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AuditProposalsReportExportStructRecord
public class JSONRC_1e039122eac73163e52e6371e4a4643a : AbstractRESTStructure<RC_1e039122eac73163e52e6371e4a4643a> {
[JsonProperty("AuditProposalsReportExportStruct")]
[JsonPropertyName("AuditProposalsReportExportStruct")]
public ssConectaProveedores.RestRecords.JSONST_003b164d236e27fa4a14d14a7514101cStructure AttrAuditProposalsReportExportStruct;

public JSONRC_1e039122eac73163e52e6371e4a4643a() { }

public JSONRC_1e039122eac73163e52e6371e4a4643a (RC_1e039122eac73163e52e6371e4a4643a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAuditProposalsReportExportStruct = ConvertToRestWithoutDefaults(s.ssSTAuditProposalsReportExportStruct, new ST_003b164d236e27fa4a14d14a7514101cStructure(), ssConectaProveedores.RestRecords.JSONST_003b164d236e27fa4a14d14a7514101cStructure.FromStructure, config);
  } else {
AttrAuditProposalsReportExportStruct = ssConectaProveedores.RestRecords.JSONST_003b164d236e27fa4a14d14a7514101cStructure.FromStructure(s.ssSTAuditProposalsReportExportStruct, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1e039122eac73163e52e6371e4a4643a, RC_1e039122eac73163e52e6371e4a4643a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1e039122eac73163e52e6371e4a4643a s) => ToStructure(s, config);
}
public static RC_1e039122eac73163e52e6371e4a4643a ToStructure(ssConectaProveedores.RestRecords.JSONRC_1e039122eac73163e52e6371e4a4643a obj, IBehaviorsConfiguration config) { 
  RC_1e039122eac73163e52e6371e4a4643a s = new RC_1e039122eac73163e52e6371e4a4643a();
  if(obj != null) {
  s.ssSTAuditProposalsReportExportStruct = ssConectaProveedores.RestRecords.JSONST_003b164d236e27fa4a14d14a7514101cStructure.ToStructure(obj.AttrAuditProposalsReportExportStruct, config);
  }
  return s;
}

public static Func<RC_1e039122eac73163e52e6371e4a4643a, ssConectaProveedores.RestRecords.JSONRC_1e039122eac73163e52e6371e4a4643a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1e039122eac73163e52e6371e4a4643a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1e039122eac73163e52e6371e4a4643a FromStructure(RC_1e039122eac73163e52e6371e4a4643a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1e039122eac73163e52e6371e4a4643a(s, config);
}

}


