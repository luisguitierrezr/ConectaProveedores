using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionSupplierFrequencyProject_Asset_ServiceBusinessValueCategoryBusinessValueSubcategoryRecord
public class RESTRC_8f1f5794477fd248ce426e958892e780 : AbstractRESTStructure<RC_8f1f5794477fd248ce426e958892e780> {
[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("Supplier")]
public ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("Frequency")]
public ssConectaProveedores.RestRecords.RESTEN_a6239c65aa61ed4530d18a92034301bbEntityRecord AttrFrequency;

[JsonProperty("Project_Asset_Service")]
public ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord AttrProject_Asset_Service;

[JsonProperty("BusinessValueCategory")]
public ssConectaProveedores.RestRecords.RESTEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord AttrBusinessValueCategory;

[JsonProperty("BusinessValueSubcategory")]
public ssConectaProveedores.RestRecords.RESTEN_f296fc330d9916f9de4aae18321e8388EntityRecord AttrBusinessValueSubcategory;

public RESTRC_8f1f5794477fd248ce426e958892e780() { }

public RESTRC_8f1f5794477fd248ce426e958892e780 (RC_8f1f5794477fd248ce426e958892e780 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrFrequency = ConvertToRestWithoutDefaults(s.ssENFrequency, new EN_a6239c65aa61ed4530d18a92034301bbEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.FromStructure, config);
AttrProject_Asset_Service = ConvertToRestWithoutDefaults(s.ssENProject_Asset_Service, new EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.FromStructure, config);
AttrBusinessValueCategory = ConvertToRestWithoutDefaults(s.ssENBusinessValueCategory, new EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord.FromStructure, config);
AttrBusinessValueSubcategory = ConvertToRestWithoutDefaults(s.ssENBusinessValueSubcategory, new EN_f296fc330d9916f9de4aae18321e8388EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_f296fc330d9916f9de4aae18321e8388EntityRecord.FromStructure, config);
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrFrequency = ssConectaProveedores.RestRecords.RESTEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.FromStructure(s.ssENFrequency, config);
AttrProject_Asset_Service = ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.FromStructure(s.ssENProject_Asset_Service, config);
AttrBusinessValueCategory = ssConectaProveedores.RestRecords.RESTEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord.FromStructure(s.ssENBusinessValueCategory, config);
AttrBusinessValueSubcategory = ssConectaProveedores.RestRecords.RESTEN_f296fc330d9916f9de4aae18321e8388EntityRecord.FromStructure(s.ssENBusinessValueSubcategory, config);
  }
}

public static RC_8f1f5794477fd248ce426e958892e780 ToStructure(ssConectaProveedores.RestRecords.RESTRC_8f1f5794477fd248ce426e958892e780 obj) { 
  RC_8f1f5794477fd248ce426e958892e780 s = new RC_8f1f5794477fd248ce426e958892e780();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  s.ssENSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier);
  s.ssENFrequency = ssConectaProveedores.RestRecords.RESTEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.ToStructure(obj.AttrFrequency);
  s.ssENProject_Asset_Service = ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.ToStructure(obj.AttrProject_Asset_Service);
  s.ssENBusinessValueCategory = ssConectaProveedores.RestRecords.RESTEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord.ToStructure(obj.AttrBusinessValueCategory);
  s.ssENBusinessValueSubcategory = ssConectaProveedores.RestRecords.RESTEN_f296fc330d9916f9de4aae18321e8388EntityRecord.ToStructure(obj.AttrBusinessValueSubcategory);
  }
  return s;
}

public static Func<RC_8f1f5794477fd248ce426e958892e780, ssConectaProveedores.RestRecords.RESTRC_8f1f5794477fd248ce426e958892e780> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8f1f5794477fd248ce426e958892e780 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_8f1f5794477fd248ce426e958892e780 FromStructure(RC_8f1f5794477fd248ce426e958892e780 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_8f1f5794477fd248ce426e958892e780(s, config);
}

}


