using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UploadValidationData
public class JSONST_452088c4ad7c6718df20290248661783Structure : AbstractRESTStructure<ST_452088c4ad7c6718df20290248661783Structure> {
[JsonProperty("CostCenterId")]
[JsonPropertyName("CostCenterId")]
public long? AttrCostCenterId;

[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public string AttrCurrency;

[JsonProperty("Project")]
[JsonPropertyName("Project")]
public string AttrProject;

[JsonProperty("PaymentMethodId")]
[JsonPropertyName("PaymentMethodId")]
public long? AttrPaymentMethodId;

[JsonProperty("PaymentTermsId")]
[JsonPropertyName("PaymentTermsId")]
public long? AttrPaymentTermsId;

[JsonProperty("RegionFI")]
[JsonPropertyName("RegionFI")]
public string AttrRegionFI;

[JsonProperty("TotalAmount")]
[JsonPropertyName("TotalAmount")]
public string AttrTotalAmount;

[JsonProperty("SupplierIsForeigner")]
[JsonPropertyName("SupplierIsForeigner")]
public bool? AttrSupplierIsForeigner;

[JsonProperty("SupplierLugarExpedicion")]
[JsonPropertyName("SupplierLugarExpedicion")]
public string AttrSupplierLugarExpedicion;

[JsonProperty("SupplierNr")]
[JsonPropertyName("SupplierNr")]
public string AttrSupplierNr;

[JsonProperty("SupplierRFC")]
[JsonPropertyName("SupplierRFC")]
public string AttrSupplierRFC;

[JsonProperty("SupplierSociety")]
[JsonPropertyName("SupplierSociety")]
public string AttrSupplierSociety;

[JsonProperty("IsAnticipoWithoutInv")]
[JsonPropertyName("IsAnticipoWithoutInv")]
public bool? AttrIsAnticipoWithoutInv;

[JsonProperty("IsAnticipoWithInv")]
[JsonPropertyName("IsAnticipoWithInv")]
public bool? AttrIsAnticipoWithInv;

[JsonProperty("InvoiceUsageKeyList")]
[JsonPropertyName("InvoiceUsageKeyList")]
public string[] AttrInvoiceUsageKeyList;

public JSONST_452088c4ad7c6718df20290248661783Structure() { }

public JSONST_452088c4ad7c6718df20290248661783Structure (ST_452088c4ad7c6718df20290248661783Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCostCenterId = ConvertToRestWithoutDefaults(s.ssCostCenterId, 0L);
AttrCurrency = ConvertToRestWithoutDefaults(s.ssCurrency, "");
AttrProject = ConvertToRestWithoutDefaults(s.ssProject, "");
AttrPaymentMethodId = ConvertToRestWithoutDefaults(s.ssPaymentMethodId, 0L);
AttrPaymentTermsId = ConvertToRestWithoutDefaults(s.ssPaymentTermsId, 0L);
AttrRegionFI = ConvertToRestWithoutDefaults(s.ssRegionFI, "");
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, "");
AttrSupplierIsForeigner = ConvertToRestWithoutDefaults(s.ssSupplierIsForeigner, false);
AttrSupplierLugarExpedicion = ConvertToRestWithoutDefaults(s.ssSupplierLugarExpedicion, "");
AttrSupplierNr = ConvertToRestWithoutDefaults(s.ssSupplierNr, "");
AttrSupplierRFC = ConvertToRestWithoutDefaults(s.ssSupplierRFC, "");
AttrSupplierSociety = ConvertToRestWithoutDefaults(s.ssSupplierSociety, "");
AttrIsAnticipoWithoutInv = ConvertToRestWithoutDefaults(s.ssIsAnticipoWithoutInv, false);
AttrIsAnticipoWithInv = ConvertToRestWithoutDefaults(s.ssIsAnticipoWithInv, false);
AttrInvoiceUsageKeyList = s.ssInvoiceUsageKeyList.Length == 0 ? null : s.ssInvoiceUsageKeyList.ToArray();
  } else {
AttrCostCenterId = (long?) s.ssCostCenterId;
AttrCurrency = s.ssCurrency;
AttrProject = s.ssProject;
AttrPaymentMethodId = (long?) s.ssPaymentMethodId;
AttrPaymentTermsId = (long?) s.ssPaymentTermsId;
AttrRegionFI = s.ssRegionFI;
AttrTotalAmount = s.ssTotalAmount;
AttrSupplierIsForeigner = (bool?) s.ssSupplierIsForeigner;
AttrSupplierLugarExpedicion = s.ssSupplierLugarExpedicion;
AttrSupplierNr = s.ssSupplierNr;
AttrSupplierRFC = s.ssSupplierRFC;
AttrSupplierSociety = s.ssSupplierSociety;
AttrIsAnticipoWithoutInv = (bool?) s.ssIsAnticipoWithoutInv;
AttrIsAnticipoWithInv = (bool?) s.ssIsAnticipoWithInv;
AttrInvoiceUsageKeyList = s.ssInvoiceUsageKeyList.ToArray();
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_452088c4ad7c6718df20290248661783Structure, ST_452088c4ad7c6718df20290248661783Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_452088c4ad7c6718df20290248661783Structure s) => ToStructure(s, config);
}
public static ST_452088c4ad7c6718df20290248661783Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_452088c4ad7c6718df20290248661783Structure obj, IBehaviorsConfiguration config) { 
  ST_452088c4ad7c6718df20290248661783Structure s = new ST_452088c4ad7c6718df20290248661783Structure();
  if(obj != null) {
  s.ssCostCenterId = obj.AttrCostCenterId == null ? 0L : obj.AttrCostCenterId.Value;
  s.ssCurrency = obj.AttrCurrency == null ? "" : obj.AttrCurrency;
  s.ssProject = obj.AttrProject == null ? "" : obj.AttrProject;
  s.ssPaymentMethodId = obj.AttrPaymentMethodId == null ? 0L : obj.AttrPaymentMethodId.Value;
  s.ssPaymentTermsId = obj.AttrPaymentTermsId == null ? 0L : obj.AttrPaymentTermsId.Value;
  s.ssRegionFI = obj.AttrRegionFI == null ? "" : obj.AttrRegionFI;
  s.ssTotalAmount = obj.AttrTotalAmount == null ? "" : obj.AttrTotalAmount;
  s.ssSupplierIsForeigner = obj.AttrSupplierIsForeigner == null ? false : obj.AttrSupplierIsForeigner.Value;
  s.ssSupplierLugarExpedicion = obj.AttrSupplierLugarExpedicion == null ? "" : obj.AttrSupplierLugarExpedicion;
  s.ssSupplierNr = obj.AttrSupplierNr == null ? "" : obj.AttrSupplierNr;
  s.ssSupplierRFC = obj.AttrSupplierRFC == null ? "" : obj.AttrSupplierRFC;
  s.ssSupplierSociety = obj.AttrSupplierSociety == null ? "" : obj.AttrSupplierSociety;
  s.ssIsAnticipoWithoutInv = obj.AttrIsAnticipoWithoutInv == null ? false : obj.AttrIsAnticipoWithoutInv.Value;
  s.ssIsAnticipoWithInv = obj.AttrIsAnticipoWithInv == null ? false : obj.AttrIsAnticipoWithInv.Value;
  s.ssInvoiceUsageKeyList = BasicTypeList<string>.ToList(obj.AttrInvoiceUsageKeyList);
  }
  return s;
}

public static Func<ST_452088c4ad7c6718df20290248661783Structure, ssConectaProveedores.RestRecords.JSONST_452088c4ad7c6718df20290248661783Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_452088c4ad7c6718df20290248661783Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_452088c4ad7c6718df20290248661783Structure FromStructure(ST_452088c4ad7c6718df20290248661783Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_452088c4ad7c6718df20290248661783Structure(s, config);
}

}


