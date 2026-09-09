using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionSupplierFrequencyProject_Asset_ServiceBusinessValueCategoryBusinessValueSubcategoryRecord
public class JSONRC_8f1f5794477fd248ce426e958892e780 : AbstractRESTStructure<RC_8f1f5794477fd248ce426e958892e780> {
[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

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

public JSONRC_8f1f5794477fd248ce426e958892e780() { }

public JSONRC_8f1f5794477fd248ce426e958892e780 (RC_8f1f5794477fd248ce426e958892e780 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrFrequency = ConvertToRestWithoutDefaults(s.ssENFrequency, new EN_a6239c65aa61ed4530d18a92034301bbEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.FromStructure, config);
AttrProject_Asset_Service = ConvertToRestWithoutDefaults(s.ssENProject_Asset_Service, new EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.FromStructure, config);
AttrBusinessValueCategory = ConvertToRestWithoutDefaults(s.ssENBusinessValueCategory, new EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord.FromStructure, config);
AttrBusinessValueSubcategory = ConvertToRestWithoutDefaults(s.ssENBusinessValueSubcategory, new EN_f296fc330d9916f9de4aae18321e8388EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f296fc330d9916f9de4aae18321e8388EntityRecord.FromStructure, config);
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrFrequency = ssConectaProveedores.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.FromStructure(s.ssENFrequency, config);
AttrProject_Asset_Service = ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.FromStructure(s.ssENProject_Asset_Service, config);
AttrBusinessValueCategory = ssConectaProveedores.RestRecords.JSONEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord.FromStructure(s.ssENBusinessValueCategory, config);
AttrBusinessValueSubcategory = ssConectaProveedores.RestRecords.JSONEN_f296fc330d9916f9de4aae18321e8388EntityRecord.FromStructure(s.ssENBusinessValueSubcategory, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8f1f5794477fd248ce426e958892e780, RC_8f1f5794477fd248ce426e958892e780> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8f1f5794477fd248ce426e958892e780 s) => ToStructure(s, config);
}
public static RC_8f1f5794477fd248ce426e958892e780 ToStructure(ssConectaProveedores.RestRecords.JSONRC_8f1f5794477fd248ce426e958892e780 obj, IBehaviorsConfiguration config) { 
  RC_8f1f5794477fd248ce426e958892e780 s = new RC_8f1f5794477fd248ce426e958892e780();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  s.ssENFrequency = ssConectaProveedores.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.ToStructure(obj.AttrFrequency, config);
  s.ssENProject_Asset_Service = ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.ToStructure(obj.AttrProject_Asset_Service, config);
  s.ssENBusinessValueCategory = ssConectaProveedores.RestRecords.JSONEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord.ToStructure(obj.AttrBusinessValueCategory, config);
  s.ssENBusinessValueSubcategory = ssConectaProveedores.RestRecords.JSONEN_f296fc330d9916f9de4aae18321e8388EntityRecord.ToStructure(obj.AttrBusinessValueSubcategory, config);
  }
  return s;
}

public static Func<RC_8f1f5794477fd248ce426e958892e780, ssConectaProveedores.RestRecords.JSONRC_8f1f5794477fd248ce426e958892e780> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8f1f5794477fd248ce426e958892e780 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8f1f5794477fd248ce426e958892e780 FromStructure(RC_8f1f5794477fd248ce426e958892e780 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8f1f5794477fd248ce426e958892e780(s, config);
}

}


