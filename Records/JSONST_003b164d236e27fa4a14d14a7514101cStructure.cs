using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AuditProposalsReportExportStruct
public class JSONST_003b164d236e27fa4a14d14a7514101cStructure : AbstractRESTStructure<ST_003b164d236e27fa4a14d14a7514101cStructure> {
[JsonProperty("Soc_")]
[JsonPropertyName("Soc_")]
public string AttrSoc_;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public string AttrRegion;

[JsonProperty("Div_")]
[JsonPropertyName("Div_")]
public string AttrDiv_;

[JsonProperty("Ref")]
[JsonPropertyName("Ref")]
public string AttrRef;

[JsonProperty("ProposalName")]
[JsonPropertyName("ProposalName")]
public string AttrProposalName;

[JsonProperty("ProposalType")]
[JsonPropertyName("ProposalType")]
public string AttrProposalType;

[JsonProperty("ProposalStatus")]
[JsonPropertyName("ProposalStatus")]
public string AttrProposalStatus;

[JsonProperty("PaymentDate")]
[JsonPropertyName("PaymentDate")]
public String AttrPaymentDate;

[JsonProperty("Cuenta")]
[JsonPropertyName("Cuenta")]
public string AttrCuenta;

[JsonProperty("SupplierName")]
[JsonPropertyName("SupplierName")]
public string AttrSupplierName;

[JsonProperty("N_doc_")]
[JsonPropertyName("N_doc_")]
public string AttrN_doc_;

[JsonProperty("ImporteenML")]
[JsonPropertyName("ImporteenML")]
public string AttrImporteenML;

[JsonProperty("ML")]
[JsonPropertyName("ML")]
public string AttrML;

[JsonProperty("ImporteenMD")]
[JsonPropertyName("ImporteenMD")]
public string AttrImporteenMD;

[JsonProperty("MD")]
[JsonPropertyName("MD")]
public string AttrMD;

[JsonProperty("Upload")]
[JsonPropertyName("Upload")]
public string AttrUpload;

[JsonProperty("Status")]
[JsonPropertyName("Status")]
public string AttrStatus;

[JsonProperty("AppovedByUserLevel1")]
[JsonPropertyName("AppovedByUserLevel1")]
public string AttrAppovedByUserLevel1;

[JsonProperty("ApprovedOnLevel1")]
[JsonPropertyName("ApprovedOnLevel1")]
public string AttrApprovedOnLevel1;

[JsonProperty("AppovedByUserLevel2")]
[JsonPropertyName("AppovedByUserLevel2")]
public string AttrAppovedByUserLevel2;

[JsonProperty("ApprovedOnLevel2")]
[JsonPropertyName("ApprovedOnLevel2")]
public string AttrApprovedOnLevel2;

[JsonProperty("AppovedByUserLevel3")]
[JsonPropertyName("AppovedByUserLevel3")]
public string AttrAppovedByUserLevel3;

[JsonProperty("ApprovedOnLevel3")]
[JsonPropertyName("ApprovedOnLevel3")]
public string AttrApprovedOnLevel3;

[JsonProperty("TreasuryUser")]
[JsonPropertyName("TreasuryUser")]
public string AttrTreasuryUser;

[JsonProperty("PaidOn")]
[JsonPropertyName("PaidOn")]
public string AttrPaidOn;

public JSONST_003b164d236e27fa4a14d14a7514101cStructure() { }

public JSONST_003b164d236e27fa4a14d14a7514101cStructure (ST_003b164d236e27fa4a14d14a7514101cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSoc_ = ConvertToRestWithoutDefaults(s.ssSoc_, "");
AttrRegion = ConvertToRestWithoutDefaults(s.ssRegion, "");
AttrDiv_ = ConvertToRestWithoutDefaults(s.ssDiv_, "");
AttrRef = ConvertToRestWithoutDefaults(s.ssRef, "");
AttrProposalName = ConvertToRestWithoutDefaults(s.ssProposalName, "");
AttrProposalType = ConvertToRestWithoutDefaults(s.ssProposalType, "");
AttrProposalStatus = ConvertToRestWithoutDefaults(s.ssProposalStatus, "");
AttrPaymentDate = ConvertDateToRestWithoutDefaults(s.ssPaymentDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrCuenta = ConvertToRestWithoutDefaults(s.ssCuenta, "");
AttrSupplierName = ConvertToRestWithoutDefaults(s.ssSupplierName, "");
AttrN_doc_ = ConvertToRestWithoutDefaults(s.ssN_doc_, "");
AttrImporteenML = ConvertToRestWithoutDefaults(s.ssImporteenML, "");
AttrML = ConvertToRestWithoutDefaults(s.ssML, "");
AttrImporteenMD = ConvertToRestWithoutDefaults(s.ssImporteenMD, "");
AttrMD = ConvertToRestWithoutDefaults(s.ssMD, "");
AttrUpload = ConvertToRestWithoutDefaults(s.ssUpload, "");
AttrStatus = ConvertToRestWithoutDefaults(s.ssStatus, "");
AttrAppovedByUserLevel1 = ConvertToRestWithoutDefaults(s.ssAppovedByUserLevel1, "");
AttrApprovedOnLevel1 = ConvertToRestWithoutDefaults(s.ssApprovedOnLevel1, "");
AttrAppovedByUserLevel2 = ConvertToRestWithoutDefaults(s.ssAppovedByUserLevel2, "");
AttrApprovedOnLevel2 = ConvertToRestWithoutDefaults(s.ssApprovedOnLevel2, "");
AttrAppovedByUserLevel3 = ConvertToRestWithoutDefaults(s.ssAppovedByUserLevel3, "");
AttrApprovedOnLevel3 = ConvertToRestWithoutDefaults(s.ssApprovedOnLevel3, "");
AttrTreasuryUser = ConvertToRestWithoutDefaults(s.ssTreasuryUser, "");
AttrPaidOn = ConvertToRestWithoutDefaults(s.ssPaidOn, "");
  } else {
AttrSoc_ = s.ssSoc_;
AttrRegion = s.ssRegion;
AttrDiv_ = s.ssDiv_;
AttrRef = s.ssRef;
AttrProposalName = s.ssProposalName;
AttrProposalType = s.ssProposalType;
AttrProposalStatus = s.ssProposalStatus;
AttrPaymentDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssPaymentDate);
AttrCuenta = s.ssCuenta;
AttrSupplierName = s.ssSupplierName;
AttrN_doc_ = s.ssN_doc_;
AttrImporteenML = s.ssImporteenML;
AttrML = s.ssML;
AttrImporteenMD = s.ssImporteenMD;
AttrMD = s.ssMD;
AttrUpload = s.ssUpload;
AttrStatus = s.ssStatus;
AttrAppovedByUserLevel1 = s.ssAppovedByUserLevel1;
AttrApprovedOnLevel1 = s.ssApprovedOnLevel1;
AttrAppovedByUserLevel2 = s.ssAppovedByUserLevel2;
AttrApprovedOnLevel2 = s.ssApprovedOnLevel2;
AttrAppovedByUserLevel3 = s.ssAppovedByUserLevel3;
AttrApprovedOnLevel3 = s.ssApprovedOnLevel3;
AttrTreasuryUser = s.ssTreasuryUser;
AttrPaidOn = s.ssPaidOn;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_003b164d236e27fa4a14d14a7514101cStructure, ST_003b164d236e27fa4a14d14a7514101cStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_003b164d236e27fa4a14d14a7514101cStructure s) => ToStructure(s, config);
}
public static ST_003b164d236e27fa4a14d14a7514101cStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_003b164d236e27fa4a14d14a7514101cStructure obj, IBehaviorsConfiguration config) { 
  ST_003b164d236e27fa4a14d14a7514101cStructure s = new ST_003b164d236e27fa4a14d14a7514101cStructure();
  if(obj != null) {
  s.ssSoc_ = obj.AttrSoc_ == null ? "" : obj.AttrSoc_;
  s.ssRegion = obj.AttrRegion == null ? "" : obj.AttrRegion;
  s.ssDiv_ = obj.AttrDiv_ == null ? "" : obj.AttrDiv_;
  s.ssRef = obj.AttrRef == null ? "" : obj.AttrRef;
  s.ssProposalName = obj.AttrProposalName == null ? "" : obj.AttrProposalName;
  s.ssProposalType = obj.AttrProposalType == null ? "" : obj.AttrProposalType;
  s.ssProposalStatus = obj.AttrProposalStatus == null ? "" : obj.AttrProposalStatus;
  s.ssPaymentDate = obj.AttrPaymentDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrPaymentDate);
  s.ssCuenta = obj.AttrCuenta == null ? "" : obj.AttrCuenta;
  s.ssSupplierName = obj.AttrSupplierName == null ? "" : obj.AttrSupplierName;
  s.ssN_doc_ = obj.AttrN_doc_ == null ? "" : obj.AttrN_doc_;
  s.ssImporteenML = obj.AttrImporteenML == null ? "" : obj.AttrImporteenML;
  s.ssML = obj.AttrML == null ? "" : obj.AttrML;
  s.ssImporteenMD = obj.AttrImporteenMD == null ? "" : obj.AttrImporteenMD;
  s.ssMD = obj.AttrMD == null ? "" : obj.AttrMD;
  s.ssUpload = obj.AttrUpload == null ? "" : obj.AttrUpload;
  s.ssStatus = obj.AttrStatus == null ? "" : obj.AttrStatus;
  s.ssAppovedByUserLevel1 = obj.AttrAppovedByUserLevel1 == null ? "" : obj.AttrAppovedByUserLevel1;
  s.ssApprovedOnLevel1 = obj.AttrApprovedOnLevel1 == null ? "" : obj.AttrApprovedOnLevel1;
  s.ssAppovedByUserLevel2 = obj.AttrAppovedByUserLevel2 == null ? "" : obj.AttrAppovedByUserLevel2;
  s.ssApprovedOnLevel2 = obj.AttrApprovedOnLevel2 == null ? "" : obj.AttrApprovedOnLevel2;
  s.ssAppovedByUserLevel3 = obj.AttrAppovedByUserLevel3 == null ? "" : obj.AttrAppovedByUserLevel3;
  s.ssApprovedOnLevel3 = obj.AttrApprovedOnLevel3 == null ? "" : obj.AttrApprovedOnLevel3;
  s.ssTreasuryUser = obj.AttrTreasuryUser == null ? "" : obj.AttrTreasuryUser;
  s.ssPaidOn = obj.AttrPaidOn == null ? "" : obj.AttrPaidOn;
  }
  return s;
}

public static Func<ST_003b164d236e27fa4a14d14a7514101cStructure, ssConectaProveedores.RestRecords.JSONST_003b164d236e27fa4a14d14a7514101cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_003b164d236e27fa4a14d14a7514101cStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_003b164d236e27fa4a14d14a7514101cStructure FromStructure(ST_003b164d236e27fa4a14d14a7514101cStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_003b164d236e27fa4a14d14a7514101cStructure(s, config);
}

}


