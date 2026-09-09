using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrdersImportRequestOrderApprovalOrderApprovalLevelRecord
public class JSONRC_89706669e1ea39d5a8170d632a3a45dc : AbstractRESTStructure<RC_89706669e1ea39d5a8170d632a3a45dc> {
[JsonProperty("OrdersImportRequest")]
[JsonPropertyName("OrdersImportRequest")]
public ssConectaProveedores.RestRecords.JSONEN_8c3668a93870461b8ea1216c2848f298EntityRecord AttrOrdersImportRequest;

[JsonProperty("OrderApproval")]
[JsonPropertyName("OrderApproval")]
public ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord AttrOrderApproval;

[JsonProperty("OrderApprovalLevel")]
[JsonPropertyName("OrderApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord AttrOrderApprovalLevel;

public JSONRC_89706669e1ea39d5a8170d632a3a45dc() { }

public JSONRC_89706669e1ea39d5a8170d632a3a45dc (RC_89706669e1ea39d5a8170d632a3a45dc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrdersImportRequest = ConvertToRestWithoutDefaults(s.ssENOrdersImportRequest, new EN_8c3668a93870461b8ea1216c2848f298EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_8c3668a93870461b8ea1216c2848f298EntityRecord.FromStructure, config);
AttrOrderApproval = ConvertToRestWithoutDefaults(s.ssENOrderApproval, new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure, config);
AttrOrderApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderApprovalLevel, new EN_6b660d05e4c0025dff47119642875ca2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure, config);
  } else {
AttrOrdersImportRequest = ssConectaProveedores.RestRecords.JSONEN_8c3668a93870461b8ea1216c2848f298EntityRecord.FromStructure(s.ssENOrdersImportRequest, config);
AttrOrderApproval = ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure(s.ssENOrderApproval, config);
AttrOrderApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure(s.ssENOrderApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_89706669e1ea39d5a8170d632a3a45dc, RC_89706669e1ea39d5a8170d632a3a45dc> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_89706669e1ea39d5a8170d632a3a45dc s) => ToStructure(s, config);
}
public static RC_89706669e1ea39d5a8170d632a3a45dc ToStructure(ssConectaProveedores.RestRecords.JSONRC_89706669e1ea39d5a8170d632a3a45dc obj, IBehaviorsConfiguration config) { 
  RC_89706669e1ea39d5a8170d632a3a45dc s = new RC_89706669e1ea39d5a8170d632a3a45dc();
  if(obj != null) {
  s.ssENOrdersImportRequest = ssConectaProveedores.RestRecords.JSONEN_8c3668a93870461b8ea1216c2848f298EntityRecord.ToStructure(obj.AttrOrdersImportRequest, config);
  s.ssENOrderApproval = ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.ToStructure(obj.AttrOrderApproval, config);
  s.ssENOrderApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.ToStructure(obj.AttrOrderApprovalLevel, config);
  }
  return s;
}

public static Func<RC_89706669e1ea39d5a8170d632a3a45dc, ssConectaProveedores.RestRecords.JSONRC_89706669e1ea39d5a8170d632a3a45dc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_89706669e1ea39d5a8170d632a3a45dc s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_89706669e1ea39d5a8170d632a3a45dc FromStructure(RC_89706669e1ea39d5a8170d632a3a45dc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_89706669e1ea39d5a8170d632a3a45dc(s, config);
}

}


