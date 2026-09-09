using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalTempData
public class JSONST_ba28fce29317fb1a65969ecb0fce5c4bStructure : AbstractRESTStructure<ST_ba28fce29317fb1a65969ecb0fce5c4bStructure> {
[JsonProperty("ProposalTypeId")]
[JsonPropertyName("ProposalTypeId")]
public int? AttrProposalTypeId;

[JsonProperty("ProposalType")]
[JsonPropertyName("ProposalType")]
public string AttrProposalType;

[JsonProperty("PaymentDate")]
[JsonPropertyName("PaymentDate")]
public String AttrPaymentDate;

[JsonProperty("ProposalDate")]
[JsonPropertyName("ProposalDate")]
public String AttrProposalDate;

[JsonProperty("PaymentDateText")]
[JsonPropertyName("PaymentDateText")]
public string AttrPaymentDateText;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("BankCode")]
[JsonPropertyName("BankCode")]
public string AttrBankCode;

[JsonProperty("BankId")]
[JsonPropertyName("BankId")]
public long? AttrBankId;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public string AttrRegion;

[JsonProperty("RegionId")]
[JsonPropertyName("RegionId")]
public long? AttrRegionId;

[JsonProperty("DivisionFI")]
[JsonPropertyName("DivisionFI")]
public string AttrDivisionFI;

[JsonProperty("TotalProposalLines")]
[JsonPropertyName("TotalProposalLines")]
public int? AttrTotalProposalLines;

[JsonProperty("TotalValueML")]
[JsonPropertyName("TotalValueML")]
public decimal? AttrTotalValueML;

[JsonProperty("TotalValueMD")]
[JsonPropertyName("TotalValueMD")]
public decimal? AttrTotalValueMD;

[JsonProperty("CurrencyId")]
[JsonPropertyName("CurrencyId")]
public string AttrCurrencyId;

[JsonProperty("CurrencyCode")]
[JsonPropertyName("CurrencyCode")]
public string AttrCurrencyCode;

[JsonProperty("CommissionsAndLeasesFileStructList")]
[JsonPropertyName("CommissionsAndLeasesFileStructList")]
public ssConectaProveedores.RestRecords.JSONST_0a2958ff44247d7464fd88ba7a80597cStructure[] AttrCommissionsAndLeasesFileStructList;

public JSONST_ba28fce29317fb1a65969ecb0fce5c4bStructure() { }

public JSONST_ba28fce29317fb1a65969ecb0fce5c4bStructure (ST_ba28fce29317fb1a65969ecb0fce5c4bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalTypeId = ConvertToRestWithoutDefaults(s.ssProposalTypeId, 0);
AttrProposalType = ConvertToRestWithoutDefaults(s.ssProposalType, "");
AttrPaymentDate = ConvertDateToRestWithoutDefaults(s.ssPaymentDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrProposalDate = ConvertDateToRestWithoutDefaults(s.ssProposalDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrPaymentDateText = ConvertToRestWithoutDefaults(s.ssPaymentDateText, "");
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrBankCode = ConvertToRestWithoutDefaults(s.ssBankCode, "");
AttrBankId = ConvertToRestWithoutDefaults(s.ssBankId, 0L);
AttrRegion = ConvertToRestWithoutDefaults(s.ssRegion, "");
AttrRegionId = ConvertToRestWithoutDefaults(s.ssRegionId, 0L);
AttrDivisionFI = ConvertToRestWithoutDefaults(s.ssDivisionFI, "");
AttrTotalProposalLines = ConvertToRestWithoutDefaults(s.ssTotalProposalLines, 0);
AttrTotalValueML = ConvertToRestWithoutDefaults(s.ssTotalValueML, 0.0M);
AttrTotalValueMD = ConvertToRestWithoutDefaults(s.ssTotalValueMD, 0.0M);
AttrCurrencyId = ConvertToRestWithoutDefaults(s.ssCurrencyId, "");
AttrCurrencyCode = ConvertToRestWithoutDefaults(s.ssCurrencyCode, "");
AttrCommissionsAndLeasesFileStructList = s.ssCommissionsAndLeasesFileStructList.Length == 0 ? null : s.ssCommissionsAndLeasesFileStructList.ToArray<ssConectaProveedores.RestRecords.JSONST_0a2958ff44247d7464fd88ba7a80597cStructure>(ssConectaProveedores.RestRecords.JSONST_0a2958ff44247d7464fd88ba7a80597cStructure.FromStructureDelegate(config));
  } else {
AttrProposalTypeId = (int?) s.ssProposalTypeId;
AttrProposalType = s.ssProposalType;
AttrPaymentDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssPaymentDate);
AttrProposalDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssProposalDate);
AttrPaymentDateText = s.ssPaymentDateText;
AttrName = s.ssName;
AttrBankCode = s.ssBankCode;
AttrBankId = (long?) s.ssBankId;
AttrRegion = s.ssRegion;
AttrRegionId = (long?) s.ssRegionId;
AttrDivisionFI = s.ssDivisionFI;
AttrTotalProposalLines = (int?) s.ssTotalProposalLines;
AttrTotalValueML = (decimal?) s.ssTotalValueML;
AttrTotalValueMD = (decimal?) s.ssTotalValueMD;
AttrCurrencyId = s.ssCurrencyId;
AttrCurrencyCode = s.ssCurrencyCode;
AttrCommissionsAndLeasesFileStructList = s.ssCommissionsAndLeasesFileStructList.ToArray<ssConectaProveedores.RestRecords.JSONST_0a2958ff44247d7464fd88ba7a80597cStructure>(ssConectaProveedores.RestRecords.JSONST_0a2958ff44247d7464fd88ba7a80597cStructure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_ba28fce29317fb1a65969ecb0fce5c4bStructure, ST_ba28fce29317fb1a65969ecb0fce5c4bStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_ba28fce29317fb1a65969ecb0fce5c4bStructure s) => ToStructure(s, config);
}
public static ST_ba28fce29317fb1a65969ecb0fce5c4bStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_ba28fce29317fb1a65969ecb0fce5c4bStructure obj, IBehaviorsConfiguration config) { 
  ST_ba28fce29317fb1a65969ecb0fce5c4bStructure s = new ST_ba28fce29317fb1a65969ecb0fce5c4bStructure();
  if(obj != null) {
  s.ssProposalTypeId = obj.AttrProposalTypeId == null ? 0 : obj.AttrProposalTypeId.Value;
  s.ssProposalType = obj.AttrProposalType == null ? "" : obj.AttrProposalType;
  s.ssPaymentDate = obj.AttrPaymentDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrPaymentDate);
  s.ssProposalDate = obj.AttrProposalDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrProposalDate);
  s.ssPaymentDateText = obj.AttrPaymentDateText == null ? "" : obj.AttrPaymentDateText;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssBankCode = obj.AttrBankCode == null ? "" : obj.AttrBankCode;
  s.ssBankId = obj.AttrBankId == null ? 0L : obj.AttrBankId.Value;
  s.ssRegion = obj.AttrRegion == null ? "" : obj.AttrRegion;
  s.ssRegionId = obj.AttrRegionId == null ? 0L : obj.AttrRegionId.Value;
  s.ssDivisionFI = obj.AttrDivisionFI == null ? "" : obj.AttrDivisionFI;
  s.ssTotalProposalLines = obj.AttrTotalProposalLines == null ? 0 : obj.AttrTotalProposalLines.Value;
  s.ssTotalValueML = obj.AttrTotalValueML == null ? 0.0M : obj.AttrTotalValueML.Value;
  s.ssTotalValueMD = obj.AttrTotalValueMD == null ? 0.0M : obj.AttrTotalValueMD.Value;
  s.ssCurrencyId = obj.AttrCurrencyId == null ? "" : obj.AttrCurrencyId;
  s.ssCurrencyCode = obj.AttrCurrencyCode == null ? "" : obj.AttrCurrencyCode;
  s.ssCommissionsAndLeasesFileStructList = RL_238f83286c67570510312c00ff7c1c1b.ToList(obj.AttrCommissionsAndLeasesFileStructList, ssConectaProveedores.RestRecords.JSONST_0a2958ff44247d7464fd88ba7a80597cStructure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_ba28fce29317fb1a65969ecb0fce5c4bStructure, ssConectaProveedores.RestRecords.JSONST_ba28fce29317fb1a65969ecb0fce5c4bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_ba28fce29317fb1a65969ecb0fce5c4bStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_ba28fce29317fb1a65969ecb0fce5c4bStructure FromStructure(ST_ba28fce29317fb1a65969ecb0fce5c4bStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_ba28fce29317fb1a65969ecb0fce5c4bStructure(s, config);
}

}


