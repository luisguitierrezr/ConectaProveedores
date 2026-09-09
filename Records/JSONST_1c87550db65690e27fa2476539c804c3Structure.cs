using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExportDisplayedProposalsStruct
public class JSONST_1c87550db65690e27fa2476539c804c3Structure : AbstractRESTStructure<ST_1c87550db65690e27fa2476539c804c3Structure> {
[JsonProperty("ProposalName")]
[JsonPropertyName("ProposalName")]
public string AttrProposalName;

[JsonProperty("ProposalType")]
[JsonPropertyName("ProposalType")]
public string AttrProposalType;

[JsonProperty("UploadedDate")]
[JsonPropertyName("UploadedDate")]
public String AttrUploadedDate;

[JsonProperty("Uploadedby")]
[JsonPropertyName("Uploadedby")]
public string AttrUploadedby;

[JsonProperty("PaymentDate")]
[JsonPropertyName("PaymentDate")]
public String AttrPaymentDate;

[JsonProperty("Bank")]
[JsonPropertyName("Bank")]
public string AttrBank;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public string AttrRegion;

[JsonProperty("AmountML")]
[JsonPropertyName("AmountML")]
public decimal? AttrAmountML;

[JsonProperty("AmountMD")]
[JsonPropertyName("AmountMD")]
public decimal? AttrAmountMD;

[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public string AttrCurrency;

[JsonProperty("Status")]
[JsonPropertyName("Status")]
public string AttrStatus;

[JsonProperty("UploadType")]
[JsonPropertyName("UploadType")]
public string AttrUploadType;

public JSONST_1c87550db65690e27fa2476539c804c3Structure() { }

public JSONST_1c87550db65690e27fa2476539c804c3Structure (ST_1c87550db65690e27fa2476539c804c3Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalName = ConvertToRestWithoutDefaults(s.ssProposalName, "");
AttrProposalType = ConvertToRestWithoutDefaults(s.ssProposalType, "");
AttrUploadedDate = ConvertDateToRestWithoutDefaults(s.ssUploadedDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrUploadedby = ConvertToRestWithoutDefaults(s.ssUploadedby, "");
AttrPaymentDate = ConvertDateToRestWithoutDefaults(s.ssPaymentDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrBank = ConvertToRestWithoutDefaults(s.ssBank, "");
AttrRegion = ConvertToRestWithoutDefaults(s.ssRegion, "");
AttrAmountML = ConvertToRestWithoutDefaults(s.ssAmountML, 0.0M);
AttrAmountMD = ConvertToRestWithoutDefaults(s.ssAmountMD, 0.0M);
AttrCurrency = ConvertToRestWithoutDefaults(s.ssCurrency, "");
AttrStatus = ConvertToRestWithoutDefaults(s.ssStatus, "");
AttrUploadType = ConvertToRestWithoutDefaults(s.ssUploadType, "");
  } else {
AttrProposalName = s.ssProposalName;
AttrProposalType = s.ssProposalType;
AttrUploadedDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssUploadedDate);
AttrUploadedby = s.ssUploadedby;
AttrPaymentDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssPaymentDate);
AttrBank = s.ssBank;
AttrRegion = s.ssRegion;
AttrAmountML = (decimal?) s.ssAmountML;
AttrAmountMD = (decimal?) s.ssAmountMD;
AttrCurrency = s.ssCurrency;
AttrStatus = s.ssStatus;
AttrUploadType = s.ssUploadType;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_1c87550db65690e27fa2476539c804c3Structure, ST_1c87550db65690e27fa2476539c804c3Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_1c87550db65690e27fa2476539c804c3Structure s) => ToStructure(s, config);
}
public static ST_1c87550db65690e27fa2476539c804c3Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_1c87550db65690e27fa2476539c804c3Structure obj, IBehaviorsConfiguration config) { 
  ST_1c87550db65690e27fa2476539c804c3Structure s = new ST_1c87550db65690e27fa2476539c804c3Structure();
  if(obj != null) {
  s.ssProposalName = obj.AttrProposalName == null ? "" : obj.AttrProposalName;
  s.ssProposalType = obj.AttrProposalType == null ? "" : obj.AttrProposalType;
  s.ssUploadedDate = obj.AttrUploadedDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrUploadedDate);
  s.ssUploadedby = obj.AttrUploadedby == null ? "" : obj.AttrUploadedby;
  s.ssPaymentDate = obj.AttrPaymentDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrPaymentDate);
  s.ssBank = obj.AttrBank == null ? "" : obj.AttrBank;
  s.ssRegion = obj.AttrRegion == null ? "" : obj.AttrRegion;
  s.ssAmountML = obj.AttrAmountML == null ? 0.0M : obj.AttrAmountML.Value;
  s.ssAmountMD = obj.AttrAmountMD == null ? 0.0M : obj.AttrAmountMD.Value;
  s.ssCurrency = obj.AttrCurrency == null ? "" : obj.AttrCurrency;
  s.ssStatus = obj.AttrStatus == null ? "" : obj.AttrStatus;
  s.ssUploadType = obj.AttrUploadType == null ? "" : obj.AttrUploadType;
  }
  return s;
}

public static Func<ST_1c87550db65690e27fa2476539c804c3Structure, ssConectaProveedores.RestRecords.JSONST_1c87550db65690e27fa2476539c804c3Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1c87550db65690e27fa2476539c804c3Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_1c87550db65690e27fa2476539c804c3Structure FromStructure(ST_1c87550db65690e27fa2476539c804c3Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_1c87550db65690e27fa2476539c804c3Structure(s, config);
}

}


