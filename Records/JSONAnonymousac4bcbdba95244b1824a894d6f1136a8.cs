using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioSAPDataFolioOrderMainOrderDetailCompanySupplierFrequencyProject_Asset_ServiceBusinessValueCategoryBusinessValueSubcategoryRecord
public class JSONRC_a0ca9572f9e7d998d312de7b2a0a8fa0 : AbstractRESTStructure<RC_a0ca9572f9e7d998d312de7b2a0a8fa0> {
[JsonProperty("FolioSAPData")]
[JsonPropertyName("FolioSAPData")]
public ssConectaProveedores.RestRecords.JSONEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord AttrFolioSAPData;

[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderDetail")]
[JsonPropertyName("OrderDetail")]
public ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord AttrOrderDetail;

[JsonProperty("Company")]
[JsonPropertyName("Company")]
public ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrCompany;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

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

public JSONRC_a0ca9572f9e7d998d312de7b2a0a8fa0() { }

public JSONRC_a0ca9572f9e7d998d312de7b2a0a8fa0 (RC_a0ca9572f9e7d998d312de7b2a0a8fa0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioSAPData = ConvertToRestWithoutDefaults(s.ssENFolioSAPData, new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderDetail = ConvertToRestWithoutDefaults(s.ssENOrderDetail, new EN_26f696e758428762fc617e811634d15dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure, config);
AttrCompany = ConvertToRestWithoutDefaults(s.ssENCompany, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrFrequency = ConvertToRestWithoutDefaults(s.ssENFrequency, new EN_a6239c65aa61ed4530d18a92034301bbEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.FromStructure, config);
AttrProject_Asset_Service = ConvertToRestWithoutDefaults(s.ssENProject_Asset_Service, new EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.FromStructure, config);
AttrBusinessValueCategory = ConvertToRestWithoutDefaults(s.ssENBusinessValueCategory, new EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord.FromStructure, config);
AttrBusinessValueSubcategory = ConvertToRestWithoutDefaults(s.ssENBusinessValueSubcategory, new EN_f296fc330d9916f9de4aae18321e8388EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f296fc330d9916f9de4aae18321e8388EntityRecord.FromStructure, config);
  } else {
AttrFolioSAPData = ssConectaProveedores.RestRecords.JSONEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.FromStructure(s.ssENFolioSAPData, config);
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderDetail = ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure(s.ssENOrderDetail, config);
AttrCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENCompany, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrFrequency = ssConectaProveedores.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.FromStructure(s.ssENFrequency, config);
AttrProject_Asset_Service = ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.FromStructure(s.ssENProject_Asset_Service, config);
AttrBusinessValueCategory = ssConectaProveedores.RestRecords.JSONEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord.FromStructure(s.ssENBusinessValueCategory, config);
AttrBusinessValueSubcategory = ssConectaProveedores.RestRecords.JSONEN_f296fc330d9916f9de4aae18321e8388EntityRecord.FromStructure(s.ssENBusinessValueSubcategory, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a0ca9572f9e7d998d312de7b2a0a8fa0, RC_a0ca9572f9e7d998d312de7b2a0a8fa0> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a0ca9572f9e7d998d312de7b2a0a8fa0 s) => ToStructure(s, config);
}
public static RC_a0ca9572f9e7d998d312de7b2a0a8fa0 ToStructure(ssConectaProveedores.RestRecords.JSONRC_a0ca9572f9e7d998d312de7b2a0a8fa0 obj, IBehaviorsConfiguration config) { 
  RC_a0ca9572f9e7d998d312de7b2a0a8fa0 s = new RC_a0ca9572f9e7d998d312de7b2a0a8fa0();
  if(obj != null) {
  s.ssENFolioSAPData = ssConectaProveedores.RestRecords.JSONEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.ToStructure(obj.AttrFolioSAPData, config);
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENOrderDetail = ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord.ToStructure(obj.AttrOrderDetail, config);
  s.ssENCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrCompany, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  s.ssENFrequency = ssConectaProveedores.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.ToStructure(obj.AttrFrequency, config);
  s.ssENProject_Asset_Service = ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.ToStructure(obj.AttrProject_Asset_Service, config);
  s.ssENBusinessValueCategory = ssConectaProveedores.RestRecords.JSONEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord.ToStructure(obj.AttrBusinessValueCategory, config);
  s.ssENBusinessValueSubcategory = ssConectaProveedores.RestRecords.JSONEN_f296fc330d9916f9de4aae18321e8388EntityRecord.ToStructure(obj.AttrBusinessValueSubcategory, config);
  }
  return s;
}

public static Func<RC_a0ca9572f9e7d998d312de7b2a0a8fa0, ssConectaProveedores.RestRecords.JSONRC_a0ca9572f9e7d998d312de7b2a0a8fa0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a0ca9572f9e7d998d312de7b2a0a8fa0 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a0ca9572f9e7d998d312de7b2a0a8fa0 FromStructure(RC_a0ca9572f9e7d998d312de7b2a0a8fa0 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a0ca9572f9e7d998d312de7b2a0a8fa0(s, config);
}

}


