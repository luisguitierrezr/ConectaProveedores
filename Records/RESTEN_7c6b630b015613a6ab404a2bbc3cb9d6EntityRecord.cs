using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalLine
public class RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord : AbstractRESTStructure<EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("ProposalId")]
public long? AttrProposalId;

[JsonProperty("ApprovalStatusId")]
public int? AttrApprovalStatusId;

[JsonProperty("CompanyId")]
public long? AttrCompanyId;

[JsonProperty("SupplierId")]
public long? AttrSupplierId;

[JsonProperty("Fe_contab_")]
public String AttrFe_contab_;

[JsonProperty("Ej__mes")]
public string AttrEj__mes;

[JsonProperty("Cuenta")]
public string AttrCuenta;

[JsonProperty("Referencia")]
public string AttrReferencia;

[JsonProperty("Nombre1")]
public string AttrNombre1;

[JsonProperty("Nombre2")]
public string AttrNombre2;

[JsonProperty("N_doc_")]
public string AttrN_doc_;

[JsonProperty("N_DocType")]
public string AttrN_DocType;

[JsonProperty("ImporteenML")]
public decimal? AttrImporteenML;

[JsonProperty("ML")]
public string AttrML;

[JsonProperty("ImporteenMD")]
public decimal? AttrImporteenMD;

[JsonProperty("Mon_")]
public string AttrMon_;

[JsonProperty("Soc_")]
public string AttrSoc_;

[JsonProperty("Div_")]
public string AttrDiv_;

[JsonProperty("Lib_mayor")]
public string AttrLib_mayor;

[JsonProperty("Textocab_documento")]
public string AttrTextocab_documento;

[JsonProperty("Doc_comp_")]
public string AttrDoc_comp_;

[JsonProperty("PaidBy")]
public string AttrPaidBy;

[JsonProperty("PaidOn")]
public String AttrPaidOn;

[JsonProperty("UnpaidBy")]
public string AttrUnpaidBy;

[JsonProperty("UnpaidOn")]
public String AttrUnpaidOn;

[JsonProperty("HasErrors")]
public bool? AttrHasErrors;

[JsonProperty("ErrorMessage")]
public string AttrErrorMessage;

public RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord() { }

public RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord (EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrProposalId = ConvertToRestWithoutDefaults(s.ssProposalId, 0L);
AttrApprovalStatusId = ConvertToRestWithoutDefaults(s.ssApprovalStatusId, 0);
AttrCompanyId = ConvertToRestWithoutDefaults(s.ssCompanyId, 0L);
AttrSupplierId = ConvertToRestWithoutDefaults(s.ssSupplierId, 0L);
AttrFe_contab_ = ConvertDateToRestWithoutDefaults(s.ssFe_contab_, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrEj__mes = ConvertToRestWithoutDefaults(s.ssEj__mes, "");
AttrCuenta = ConvertToRestWithoutDefaults(s.ssCuenta, "");
AttrReferencia = ConvertToRestWithoutDefaults(s.ssReferencia, "");
AttrNombre1 = ConvertToRestWithoutDefaults(s.ssNombre1, "");
AttrNombre2 = ConvertToRestWithoutDefaults(s.ssNombre2, "");
AttrN_doc_ = ConvertToRestWithoutDefaults(s.ssN_doc_, "");
AttrN_DocType = ConvertToRestWithoutDefaults(s.ssN_DocType, "");
AttrImporteenML = ConvertToRestWithoutDefaults(s.ssImporteenML, 0.0M);
AttrML = ConvertToRestWithoutDefaults(s.ssML, "");
AttrImporteenMD = ConvertToRestWithoutDefaults(s.ssImporteenMD, 0.0M);
AttrMon_ = ConvertToRestWithoutDefaults(s.ssMon_, "");
AttrSoc_ = ConvertToRestWithoutDefaults(s.ssSoc_, "");
AttrDiv_ = ConvertToRestWithoutDefaults(s.ssDiv_, "");
AttrLib_mayor = ConvertToRestWithoutDefaults(s.ssLib_mayor, "");
AttrTextocab_documento = ConvertToRestWithoutDefaults(s.ssTextocab_documento, "");
AttrDoc_comp_ = ConvertToRestWithoutDefaults(s.ssDoc_comp_, "");
AttrPaidBy = ConvertToRestWithoutDefaults(s.ssPaidBy, "");
AttrPaidOn = ConvertDateTimeToRestWithoutDefaults(s.ssPaidOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUnpaidBy = ConvertToRestWithoutDefaults(s.ssUnpaidBy, "");
AttrUnpaidOn = ConvertDateTimeToRestWithoutDefaults(s.ssUnpaidOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrHasErrors = ConvertToRestWithoutDefaults(s.ssHasErrors, false);
AttrErrorMessage = ConvertToRestWithoutDefaults(s.ssErrorMessage, "");
  } else {
AttrId = (long?) s.ssId;
AttrProposalId = (long?) s.ssProposalId;
AttrApprovalStatusId = (int?) s.ssApprovalStatusId;
AttrCompanyId = (long?) s.ssCompanyId;
AttrSupplierId = (long?) s.ssSupplierId;
AttrFe_contab_ = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssFe_contab_);
AttrEj__mes = s.ssEj__mes;
AttrCuenta = s.ssCuenta;
AttrReferencia = s.ssReferencia;
AttrNombre1 = s.ssNombre1;
AttrNombre2 = s.ssNombre2;
AttrN_doc_ = s.ssN_doc_;
AttrN_DocType = s.ssN_DocType;
AttrImporteenML = (decimal?) s.ssImporteenML;
AttrML = s.ssML;
AttrImporteenMD = (decimal?) s.ssImporteenMD;
AttrMon_ = s.ssMon_;
AttrSoc_ = s.ssSoc_;
AttrDiv_ = s.ssDiv_;
AttrLib_mayor = s.ssLib_mayor;
AttrTextocab_documento = s.ssTextocab_documento;
AttrDoc_comp_ = s.ssDoc_comp_;
AttrPaidBy = s.ssPaidBy;
AttrPaidOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssPaidOn, config.DateTimeFormat);
AttrUnpaidBy = s.ssUnpaidBy;
AttrUnpaidOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUnpaidOn, config.DateTimeFormat);
AttrHasErrors = (bool?) s.ssHasErrors;
AttrErrorMessage = s.ssErrorMessage;
  }
}

public static EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord obj) { 
  EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord s = new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssProposalId = obj.AttrProposalId == null ? 0L : obj.AttrProposalId.Value;
  s.ssApprovalStatusId = obj.AttrApprovalStatusId == null ? 0 : obj.AttrApprovalStatusId.Value;
  s.ssCompanyId = obj.AttrCompanyId == null ? 0L : obj.AttrCompanyId.Value;
  s.ssSupplierId = obj.AttrSupplierId == null ? 0L : obj.AttrSupplierId.Value;
  s.ssFe_contab_ = obj.AttrFe_contab_ == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrFe_contab_);
  s.ssEj__mes = obj.AttrEj__mes == null ? "" : obj.AttrEj__mes;
  s.ssCuenta = obj.AttrCuenta == null ? "" : obj.AttrCuenta;
  s.ssReferencia = obj.AttrReferencia == null ? "" : obj.AttrReferencia;
  s.ssNombre1 = obj.AttrNombre1 == null ? "" : obj.AttrNombre1;
  s.ssNombre2 = obj.AttrNombre2 == null ? "" : obj.AttrNombre2;
  s.ssN_doc_ = obj.AttrN_doc_ == null ? "" : obj.AttrN_doc_;
  s.ssN_DocType = obj.AttrN_DocType == null ? "" : obj.AttrN_DocType;
  s.ssImporteenML = obj.AttrImporteenML == null ? 0.0M : obj.AttrImporteenML.Value;
  s.ssML = obj.AttrML == null ? "" : obj.AttrML;
  s.ssImporteenMD = obj.AttrImporteenMD == null ? 0.0M : obj.AttrImporteenMD.Value;
  s.ssMon_ = obj.AttrMon_ == null ? "" : obj.AttrMon_;
  s.ssSoc_ = obj.AttrSoc_ == null ? "" : obj.AttrSoc_;
  s.ssDiv_ = obj.AttrDiv_ == null ? "" : obj.AttrDiv_;
  s.ssLib_mayor = obj.AttrLib_mayor == null ? "" : obj.AttrLib_mayor;
  s.ssTextocab_documento = obj.AttrTextocab_documento == null ? "" : obj.AttrTextocab_documento;
  s.ssDoc_comp_ = obj.AttrDoc_comp_ == null ? "" : obj.AttrDoc_comp_;
  s.ssPaidBy = obj.AttrPaidBy == null ? "" : obj.AttrPaidBy;
  s.ssPaidOn = obj.AttrPaidOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrPaidOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUnpaidBy = obj.AttrUnpaidBy == null ? "" : obj.AttrUnpaidBy;
  s.ssUnpaidOn = obj.AttrUnpaidOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUnpaidOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssHasErrors = obj.AttrHasErrors == null ? false : obj.AttrHasErrors.Value;
  s.ssErrorMessage = obj.AttrErrorMessage == null ? "" : obj.AttrErrorMessage;
  }
  return s;
}

public static Func<EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord, ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord FromStructure(EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord(s, config);
}

}


