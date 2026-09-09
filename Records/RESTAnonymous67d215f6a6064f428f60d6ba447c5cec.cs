using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrdersImportRequestOrderApprovalOrderApprovalLevelRecord
public class RESTRC_89706669e1ea39d5a8170d632a3a45dc : AbstractRESTStructure<RC_89706669e1ea39d5a8170d632a3a45dc> {
[JsonProperty("OrdersImportRequest")]
public ssConectaProveedores.RestRecords.RESTEN_8c3668a93870461b8ea1216c2848f298EntityRecord AttrOrdersImportRequest;

[JsonProperty("OrderApproval")]
public ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord AttrOrderApproval;

[JsonProperty("OrderApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord AttrOrderApprovalLevel;

public RESTRC_89706669e1ea39d5a8170d632a3a45dc() { }

public RESTRC_89706669e1ea39d5a8170d632a3a45dc (RC_89706669e1ea39d5a8170d632a3a45dc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrdersImportRequest = ConvertToRestWithoutDefaults(s.ssENOrdersImportRequest, new EN_8c3668a93870461b8ea1216c2848f298EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_8c3668a93870461b8ea1216c2848f298EntityRecord.FromStructure, config);
AttrOrderApproval = ConvertToRestWithoutDefaults(s.ssENOrderApproval, new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure, config);
AttrOrderApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderApprovalLevel, new EN_6b660d05e4c0025dff47119642875ca2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure, config);
  } else {
AttrOrdersImportRequest = ssConectaProveedores.RestRecords.RESTEN_8c3668a93870461b8ea1216c2848f298EntityRecord.FromStructure(s.ssENOrdersImportRequest, config);
AttrOrderApproval = ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure(s.ssENOrderApproval, config);
AttrOrderApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure(s.ssENOrderApprovalLevel, config);
  }
}

public static RC_89706669e1ea39d5a8170d632a3a45dc ToStructure(ssConectaProveedores.RestRecords.RESTRC_89706669e1ea39d5a8170d632a3a45dc obj) { 
  RC_89706669e1ea39d5a8170d632a3a45dc s = new RC_89706669e1ea39d5a8170d632a3a45dc();
  if(obj != null) {
  s.ssENOrdersImportRequest = ssConectaProveedores.RestRecords.RESTEN_8c3668a93870461b8ea1216c2848f298EntityRecord.ToStructure(obj.AttrOrdersImportRequest);
  s.ssENOrderApproval = ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.ToStructure(obj.AttrOrderApproval);
  s.ssENOrderApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.ToStructure(obj.AttrOrderApprovalLevel);
  }
  return s;
}

public static Func<RC_89706669e1ea39d5a8170d632a3a45dc, ssConectaProveedores.RestRecords.RESTRC_89706669e1ea39d5a8170d632a3a45dc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_89706669e1ea39d5a8170d632a3a45dc s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_89706669e1ea39d5a8170d632a3a45dc FromStructure(RC_89706669e1ea39d5a8170d632a3a45dc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_89706669e1ea39d5a8170d632a3a45dc(s, config);
}

}


