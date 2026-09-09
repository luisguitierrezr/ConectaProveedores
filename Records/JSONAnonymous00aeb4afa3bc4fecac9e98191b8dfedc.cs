using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoiceExtendedTaxInvoiceTaxTypeRequisitionInvoiceExtendedDistributionFrequencyProject_Asset_ServiceBusinessValueCategoryBusinessValueSubcategoryRecord
public class JSONRC_b64650646295f01a3e7c46ac44009d3c : AbstractRESTStructure<RC_b64650646295f01a3e7c46ac44009d3c> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceExtendedTax")]
[JsonPropertyName("InvoiceExtendedTax")]
public ssConectaProveedores.RestRecords.JSONEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord AttrInvoiceExtendedTax;

[JsonProperty("InvoiceTaxType")]
[JsonPropertyName("InvoiceTaxType")]
public ssConectaProveedores.RestRecords.JSONEN_cff5cb02ac5fe11578884acf37327af3EntityRecord AttrInvoiceTaxType;

[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("InvoiceExtended")]
[JsonPropertyName("InvoiceExtended")]
public ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord AttrInvoiceExtended;

[JsonProperty("Distribution")]
[JsonPropertyName("Distribution")]
public ssConectaProveedores.RestRecords.JSONEN_88460e7eac2a65d244abb23fe44af0adEntityRecord AttrDistribution;

[JsonProperty("Frequency")]
[JsonPropertyName("Frequency")]
public ssConectaProveedores.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord AttrFrequency;

[JsonProperty("Project_Asset_Service")]
[JsonPropertyName("Project_Asset_Service")]
public ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord AttrProject_Asset_Service;

[JsonProperty("BusinessValueCategory")]
[JsonPropertyName("BusinessValueCategory")]
public ssConectaProveedores.RestRecords.JSONEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord AttrBusinessValueCategory;

[JsonProperty("BusinessValueSubcategory")]
[JsonPropertyName("BusinessValueSubcategory")]
public ssConectaProveedores.RestRecords.JSONEN_f296fc330d9916f9de4aae18321e8388EntityRecord AttrBusinessValueSubcategory;

public JSONRC_b64650646295f01a3e7c46ac44009d3c() { }

public JSONRC_b64650646295f01a3e7c46ac44009d3c (RC_b64650646295f01a3e7c46ac44009d3c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceExtendedTax = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedTax, new EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord.FromStructure, config);
AttrInvoiceTaxType = ConvertToRestWithoutDefaults(s.ssENInvoiceTaxType, new EN_cff5cb02ac5fe11578884acf37327af3EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_cff5cb02ac5fe11578884acf37327af3EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrInvoiceExtended = ConvertToRestWithoutDefaults(s.ssENInvoiceExtended, new EN_f81a3d226103fd013068b8763798067aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure, config);
AttrDistribution = ConvertToRestWithoutDefaults(s.ssENDistribution, new EN_88460e7eac2a65d244abb23fe44af0adEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_88460e7eac2a65d244abb23fe44af0adEntityRecord.FromStructure, config);
AttrFrequency = ConvertToRestWithoutDefaults(s.ssENFrequency, new EN_a6239c65aa61ed4530d18a92034301bbEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.FromStructure, config);
AttrProject_Asset_Service = ConvertToRestWithoutDefaults(s.ssENProject_Asset_Service, new EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.FromStructure, config);
AttrBusinessValueCategory = ConvertToRestWithoutDefaults(s.ssENBusinessValueCategory, new EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord.FromStructure, config);
AttrBusinessValueSubcategory = ConvertToRestWithoutDefaults(s.ssENBusinessValueSubcategory, new EN_f296fc330d9916f9de4aae18321e8388EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f296fc330d9916f9de4aae18321e8388EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceExtendedTax = ssConectaProveedores.RestRecords.JSONEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord.FromStructure(s.ssENInvoiceExtendedTax, config);
AttrInvoiceTaxType = ssConectaProveedores.RestRecords.JSONEN_cff5cb02ac5fe11578884acf37327af3EntityRecord.FromStructure(s.ssENInvoiceTaxType, config);
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrInvoiceExtended = ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure(s.ssENInvoiceExtended, config);
AttrDistribution = ssConectaProveedores.RestRecords.JSONEN_88460e7eac2a65d244abb23fe44af0adEntityRecord.FromStructure(s.ssENDistribution, config);
AttrFrequency = ssConectaProveedores.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.FromStructure(s.ssENFrequency, config);
AttrProject_Asset_Service = ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.FromStructure(s.ssENProject_Asset_Service, config);
AttrBusinessValueCategory = ssConectaProveedores.RestRecords.JSONEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord.FromStructure(s.ssENBusinessValueCategory, config);
AttrBusinessValueSubcategory = ssConectaProveedores.RestRecords.JSONEN_f296fc330d9916f9de4aae18321e8388EntityRecord.FromStructure(s.ssENBusinessValueSubcategory, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b64650646295f01a3e7c46ac44009d3c, RC_b64650646295f01a3e7c46ac44009d3c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b64650646295f01a3e7c46ac44009d3c s) => ToStructure(s, config);
}
public static RC_b64650646295f01a3e7c46ac44009d3c ToStructure(ssConectaProveedores.RestRecords.JSONRC_b64650646295f01a3e7c46ac44009d3c obj, IBehaviorsConfiguration config) { 
  RC_b64650646295f01a3e7c46ac44009d3c s = new RC_b64650646295f01a3e7c46ac44009d3c();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENInvoiceExtendedTax = ssConectaProveedores.RestRecords.JSONEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord.ToStructure(obj.AttrInvoiceExtendedTax, config);
  s.ssENInvoiceTaxType = ssConectaProveedores.RestRecords.JSONEN_cff5cb02ac5fe11578884acf37327af3EntityRecord.ToStructure(obj.AttrInvoiceTaxType, config);
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENInvoiceExtended = ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.ToStructure(obj.AttrInvoiceExtended, config);
  s.ssENDistribution = ssConectaProveedores.RestRecords.JSONEN_88460e7eac2a65d244abb23fe44af0adEntityRecord.ToStructure(obj.AttrDistribution, config);
  s.ssENFrequency = ssConectaProveedores.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.ToStructure(obj.AttrFrequency, config);
  s.ssENProject_Asset_Service = ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.ToStructure(obj.AttrProject_Asset_Service, config);
  s.ssENBusinessValueCategory = ssConectaProveedores.RestRecords.JSONEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord.ToStructure(obj.AttrBusinessValueCategory, config);
  s.ssENBusinessValueSubcategory = ssConectaProveedores.RestRecords.JSONEN_f296fc330d9916f9de4aae18321e8388EntityRecord.ToStructure(obj.AttrBusinessValueSubcategory, config);
  }
  return s;
}

public static Func<RC_b64650646295f01a3e7c46ac44009d3c, ssConectaProveedores.RestRecords.JSONRC_b64650646295f01a3e7c46ac44009d3c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b64650646295f01a3e7c46ac44009d3c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b64650646295f01a3e7c46ac44009d3c FromStructure(RC_b64650646295f01a3e7c46ac44009d3c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b64650646295f01a3e7c46ac44009d3c(s, config);
}

}


