using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionListExport_StructRecord
public class JSONRC_065973fb437991de65b823e42c10f6b8 : AbstractRESTStructure<RC_065973fb437991de65b823e42c10f6b8> {
[JsonProperty("RequisitionListExport_Struct")]
[JsonPropertyName("RequisitionListExport_Struct")]
public ssConectaProveedores.RestRecords.JSONST_4b0669d4e8a5d503dc5477cdc7b3957dStructure AttrRequisitionListExport_Struct;

public JSONRC_065973fb437991de65b823e42c10f6b8() { }

public JSONRC_065973fb437991de65b823e42c10f6b8 (RC_065973fb437991de65b823e42c10f6b8 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionListExport_Struct = ConvertToRestWithoutDefaults(s.ssSTRequisitionListExport_Struct, new ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure(), ssConectaProveedores.RestRecords.JSONST_4b0669d4e8a5d503dc5477cdc7b3957dStructure.FromStructure, config);
  } else {
AttrRequisitionListExport_Struct = ssConectaProveedores.RestRecords.JSONST_4b0669d4e8a5d503dc5477cdc7b3957dStructure.FromStructure(s.ssSTRequisitionListExport_Struct, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_065973fb437991de65b823e42c10f6b8, RC_065973fb437991de65b823e42c10f6b8> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_065973fb437991de65b823e42c10f6b8 s) => ToStructure(s, config);
}
public static RC_065973fb437991de65b823e42c10f6b8 ToStructure(ssConectaProveedores.RestRecords.JSONRC_065973fb437991de65b823e42c10f6b8 obj, IBehaviorsConfiguration config) { 
  RC_065973fb437991de65b823e42c10f6b8 s = new RC_065973fb437991de65b823e42c10f6b8();
  if(obj != null) {
  s.ssSTRequisitionListExport_Struct = ssConectaProveedores.RestRecords.JSONST_4b0669d4e8a5d503dc5477cdc7b3957dStructure.ToStructure(obj.AttrRequisitionListExport_Struct, config);
  }
  return s;
}

public static Func<RC_065973fb437991de65b823e42c10f6b8, ssConectaProveedores.RestRecords.JSONRC_065973fb437991de65b823e42c10f6b8> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_065973fb437991de65b823e42c10f6b8 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_065973fb437991de65b823e42c10f6b8 FromStructure(RC_065973fb437991de65b823e42c10f6b8 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_065973fb437991de65b823e42c10f6b8(s, config);
}

}


