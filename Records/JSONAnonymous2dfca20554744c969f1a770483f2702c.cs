using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionRequisitionApprovalLevelRequisitionApprovalRequisitionStatusShowCancelButtonCompanySupplierTelcelDirectionSegmentAccGroupPaymentTermsSegmentAccGroupTelcelDirRecord
public class JSONRC_db730a379abf48e3725f395a2176e12f : AbstractRESTStructure<RC_db730a379abf48e3725f395a2176e12f> {
[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionApprovalLevel")]
[JsonPropertyName("RequisitionApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord AttrRequisitionApprovalLevel;

[JsonProperty("RequisitionApproval")]
[JsonPropertyName("RequisitionApproval")]
public ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord AttrRequisitionApproval;

[JsonProperty("RequisitionStatus")]
[JsonPropertyName("RequisitionStatus")]
public ssConectaProveedores.RestRecords.JSONEN_0554a1252840ba4a5c4e6af5899608adEntityRecord AttrRequisitionStatus;

[JsonProperty("ShowCancelButton")]
[JsonPropertyName("ShowCancelButton")]
public bool? AttrShowCancelButton;

[JsonProperty("Company")]
[JsonPropertyName("Company")]
public ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrCompany;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("TelcelDirection")]
[JsonPropertyName("TelcelDirection")]
public ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord AttrTelcelDirection;

[JsonProperty("SegmentAccGroup")]
[JsonPropertyName("SegmentAccGroup")]
public ssConectaProveedores.RestRecords.JSONEN_029f0fb77a2785e324319f171edbc2c0EntityRecord AttrSegmentAccGroup;

[JsonProperty("PaymentTerms")]
[JsonPropertyName("PaymentTerms")]
public ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord AttrPaymentTerms;

[JsonProperty("SegmentAccGroupTelcelDir")]
[JsonPropertyName("SegmentAccGroupTelcelDir")]
public ssConectaProveedores.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord AttrSegmentAccGroupTelcelDir;

public JSONRC_db730a379abf48e3725f395a2176e12f() { }

public JSONRC_db730a379abf48e3725f395a2176e12f (RC_db730a379abf48e3725f395a2176e12f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionApprovalLevel = ConvertToRestWithoutDefaults(s.ssENRequisitionApprovalLevel, new EN_27b1469f497d364a764a1359956ef9adEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure, config);
AttrRequisitionApproval = ConvertToRestWithoutDefaults(s.ssENRequisitionApproval, new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure, config);
AttrRequisitionStatus = ConvertToRestWithoutDefaults(s.ssENRequisitionStatus, new EN_0554a1252840ba4a5c4e6af5899608adEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_0554a1252840ba4a5c4e6af5899608adEntityRecord.FromStructure, config);
AttrShowCancelButton = ConvertToRestWithoutDefaults(s.ssShowCancelButton, false);
AttrCompany = ConvertToRestWithoutDefaults(s.ssENCompany, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrTelcelDirection = ConvertToRestWithoutDefaults(s.ssENTelcelDirection, new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure, config);
AttrSegmentAccGroup = ConvertToRestWithoutDefaults(s.ssENSegmentAccGroup, new EN_029f0fb77a2785e324319f171edbc2c0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_029f0fb77a2785e324319f171edbc2c0EntityRecord.FromStructure, config);
AttrPaymentTerms = ConvertToRestWithoutDefaults(s.ssENPaymentTerms, new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure, config);
AttrSegmentAccGroupTelcelDir = ConvertToRestWithoutDefaults(s.ssENSegmentAccGroupTelcelDir, new EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord.FromStructure, config);
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure(s.ssENRequisitionApprovalLevel, config);
AttrRequisitionApproval = ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure(s.ssENRequisitionApproval, config);
AttrRequisitionStatus = ssConectaProveedores.RestRecords.JSONEN_0554a1252840ba4a5c4e6af5899608adEntityRecord.FromStructure(s.ssENRequisitionStatus, config);
AttrShowCancelButton = (bool?) s.ssShowCancelButton;
AttrCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENCompany, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrTelcelDirection = ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure(s.ssENTelcelDirection, config);
AttrSegmentAccGroup = ssConectaProveedores.RestRecords.JSONEN_029f0fb77a2785e324319f171edbc2c0EntityRecord.FromStructure(s.ssENSegmentAccGroup, config);
AttrPaymentTerms = ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure(s.ssENPaymentTerms, config);
AttrSegmentAccGroupTelcelDir = ssConectaProveedores.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord.FromStructure(s.ssENSegmentAccGroupTelcelDir, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_db730a379abf48e3725f395a2176e12f, RC_db730a379abf48e3725f395a2176e12f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_db730a379abf48e3725f395a2176e12f s) => ToStructure(s, config);
}
public static RC_db730a379abf48e3725f395a2176e12f ToStructure(ssConectaProveedores.RestRecords.JSONRC_db730a379abf48e3725f395a2176e12f obj, IBehaviorsConfiguration config) { 
  RC_db730a379abf48e3725f395a2176e12f s = new RC_db730a379abf48e3725f395a2176e12f();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENRequisitionApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord.ToStructure(obj.AttrRequisitionApprovalLevel, config);
  s.ssENRequisitionApproval = ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.ToStructure(obj.AttrRequisitionApproval, config);
  s.ssENRequisitionStatus = ssConectaProveedores.RestRecords.JSONEN_0554a1252840ba4a5c4e6af5899608adEntityRecord.ToStructure(obj.AttrRequisitionStatus, config);
  s.ssShowCancelButton = obj.AttrShowCancelButton == null ? false : obj.AttrShowCancelButton.Value;
  s.ssENCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrCompany, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  s.ssENTelcelDirection = ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.ToStructure(obj.AttrTelcelDirection, config);
  s.ssENSegmentAccGroup = ssConectaProveedores.RestRecords.JSONEN_029f0fb77a2785e324319f171edbc2c0EntityRecord.ToStructure(obj.AttrSegmentAccGroup, config);
  s.ssENPaymentTerms = ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.ToStructure(obj.AttrPaymentTerms, config);
  s.ssENSegmentAccGroupTelcelDir = ssConectaProveedores.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord.ToStructure(obj.AttrSegmentAccGroupTelcelDir, config);
  }
  return s;
}

public static Func<RC_db730a379abf48e3725f395a2176e12f, ssConectaProveedores.RestRecords.JSONRC_db730a379abf48e3725f395a2176e12f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_db730a379abf48e3725f395a2176e12f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_db730a379abf48e3725f395a2176e12f FromStructure(RC_db730a379abf48e3725f395a2176e12f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_db730a379abf48e3725f395a2176e12f(s, config);
}

}


