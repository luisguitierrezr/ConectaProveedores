using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionRequisitionAccountingAllFilesRequisitionAccConceptsRecordListRequisitionCostCentersRequisitionServicesi_RequisitionAccConcept_EstimEqualAgRecord
public class JSONRC_44742d4360afdf16ff97b37b2eff1760 : AbstractRESTStructure<RC_44742d4360afdf16ff97b37b2eff1760> {
[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionAccounting")]
[JsonPropertyName("RequisitionAccounting")]
public ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord AttrRequisitionAccounting;

[JsonProperty("AllFiles")]
[JsonPropertyName("AllFiles")]
public ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure[] AttrAllFiles;

[JsonProperty("RequisitionAccConceptsRecordList")]
[JsonPropertyName("RequisitionAccConceptsRecordList")]
public ssConectaProveedores.RestRecords.JSONRC_f80fde4acf9a7dc465a1d535c05dfb8e[] AttrRequisitionAccConceptsRecordList;

[JsonProperty("RequisitionCostCenters")]
[JsonPropertyName("RequisitionCostCenters")]
public ssConectaProveedores.RestRecords.JSONEN_114fcf95674648310a3efb0d78529a37EntityRecord[] AttrRequisitionCostCenters;

[JsonProperty("RequisitionServices")]
[JsonPropertyName("RequisitionServices")]
public ssConectaProveedores.RestRecords.JSONRC_04e7247757060d4016b43102119b0dd6[] AttrRequisitionServices;

[JsonProperty("i_RequisitionAccConcept_EstimEqualAg")]
[JsonPropertyName("i_RequisitionAccConcept_EstimEqualAg")]
public ssConectaProveedores.RestRecords.JSONRC_cdb29de40f41bea5403aac7edb2d6159 Attri_RequisitionAccConcept_EstimEqualAg;

public JSONRC_44742d4360afdf16ff97b37b2eff1760() { }

public JSONRC_44742d4360afdf16ff97b37b2eff1760 (RC_44742d4360afdf16ff97b37b2eff1760 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionAccounting = ConvertToRestWithoutDefaults(s.ssENRequisitionAccounting, new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.FromStructure, config);
AttrAllFiles = s.ssRLAllFiles.Length == 0 ? null : s.ssRLAllFiles.ToArray<ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure>(ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure.FromStructureDelegate(config));
AttrRequisitionAccConceptsRecordList = s.ssRLRequisitionAccConceptsRecordList.Length == 0 ? null : s.ssRLRequisitionAccConceptsRecordList.ToArray<ssConectaProveedores.RestRecords.JSONRC_f80fde4acf9a7dc465a1d535c05dfb8e>(ssConectaProveedores.RestRecords.JSONRC_f80fde4acf9a7dc465a1d535c05dfb8e.FromStructureDelegate(config));
AttrRequisitionCostCenters = s.ssRLRequisitionCostCenters.Length == 0 ? null : s.ssRLRequisitionCostCenters.ToArray<ssConectaProveedores.RestRecords.JSONEN_114fcf95674648310a3efb0d78529a37EntityRecord>(ssConectaProveedores.RestRecords.JSONEN_114fcf95674648310a3efb0d78529a37EntityRecord.FromStructureDelegate(config));
AttrRequisitionServices = s.ssRLRequisitionServices.Length == 0 ? null : s.ssRLRequisitionServices.ToArray<ssConectaProveedores.RestRecords.JSONRC_04e7247757060d4016b43102119b0dd6>(ssConectaProveedores.RestRecords.JSONRC_04e7247757060d4016b43102119b0dd6.FromStructureDelegate(config));
Attri_RequisitionAccConcept_EstimEqualAg = ConvertToRestWithoutDefaults(s.ssRCi_RequisitionAccConcept_EstimEqualAg, new RC_cdb29de40f41bea5403aac7edb2d6159(), ssConectaProveedores.RestRecords.JSONRC_cdb29de40f41bea5403aac7edb2d6159.FromStructure, config);
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionAccounting = ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.FromStructure(s.ssENRequisitionAccounting, config);
AttrAllFiles = s.ssRLAllFiles.ToArray<ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure>(ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure.FromStructureDelegate(config));
AttrRequisitionAccConceptsRecordList = s.ssRLRequisitionAccConceptsRecordList.ToArray<ssConectaProveedores.RestRecords.JSONRC_f80fde4acf9a7dc465a1d535c05dfb8e>(ssConectaProveedores.RestRecords.JSONRC_f80fde4acf9a7dc465a1d535c05dfb8e.FromStructureDelegate(config));
AttrRequisitionCostCenters = s.ssRLRequisitionCostCenters.ToArray<ssConectaProveedores.RestRecords.JSONEN_114fcf95674648310a3efb0d78529a37EntityRecord>(ssConectaProveedores.RestRecords.JSONEN_114fcf95674648310a3efb0d78529a37EntityRecord.FromStructureDelegate(config));
AttrRequisitionServices = s.ssRLRequisitionServices.ToArray<ssConectaProveedores.RestRecords.JSONRC_04e7247757060d4016b43102119b0dd6>(ssConectaProveedores.RestRecords.JSONRC_04e7247757060d4016b43102119b0dd6.FromStructureDelegate(config));
Attri_RequisitionAccConcept_EstimEqualAg = ssConectaProveedores.RestRecords.JSONRC_cdb29de40f41bea5403aac7edb2d6159.FromStructure(s.ssRCi_RequisitionAccConcept_EstimEqualAg, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_44742d4360afdf16ff97b37b2eff1760, RC_44742d4360afdf16ff97b37b2eff1760> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_44742d4360afdf16ff97b37b2eff1760 s) => ToStructure(s, config);
}
public static RC_44742d4360afdf16ff97b37b2eff1760 ToStructure(ssConectaProveedores.RestRecords.JSONRC_44742d4360afdf16ff97b37b2eff1760 obj, IBehaviorsConfiguration config) { 
  RC_44742d4360afdf16ff97b37b2eff1760 s = new RC_44742d4360afdf16ff97b37b2eff1760();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENRequisitionAccounting = ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.ToStructure(obj.AttrRequisitionAccounting, config);
  s.ssRLAllFiles = RL_7a479a555821b093171c5d3cd3382006.ToList(obj.AttrAllFiles, ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure.ToStructureDelegate(config));
  s.ssRLRequisitionAccConceptsRecordList = RL_7c236018492d50b3625a5b0d981eb4eb.ToList(obj.AttrRequisitionAccConceptsRecordList, ssConectaProveedores.RestRecords.JSONRC_f80fde4acf9a7dc465a1d535c05dfb8e.ToStructureDelegate(config));
  s.ssRLRequisitionCostCenters = RL_943f36694cec370c0ce0c406bfa23715.ToList(obj.AttrRequisitionCostCenters, ssConectaProveedores.RestRecords.JSONEN_114fcf95674648310a3efb0d78529a37EntityRecord.ToStructureDelegate(config));
  s.ssRLRequisitionServices = RL_b47d9310671b1b627f451a333bb8980a.ToList(obj.AttrRequisitionServices, ssConectaProveedores.RestRecords.JSONRC_04e7247757060d4016b43102119b0dd6.ToStructureDelegate(config));
  s.ssRCi_RequisitionAccConcept_EstimEqualAg = ssConectaProveedores.RestRecords.JSONRC_cdb29de40f41bea5403aac7edb2d6159.ToStructure(obj.Attri_RequisitionAccConcept_EstimEqualAg, config);
  }
  return s;
}

public static Func<RC_44742d4360afdf16ff97b37b2eff1760, ssConectaProveedores.RestRecords.JSONRC_44742d4360afdf16ff97b37b2eff1760> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_44742d4360afdf16ff97b37b2eff1760 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_44742d4360afdf16ff97b37b2eff1760 FromStructure(RC_44742d4360afdf16ff97b37b2eff1760 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_44742d4360afdf16ff97b37b2eff1760(s, config);
}

}


