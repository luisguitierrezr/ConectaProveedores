using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionRequisitionAccountingAllFilesRequisitionAccConceptsi_RequisitionAccConcept_EstimEqualAgRecord
public class JSONRC_cc86cc41f7a6d52842bfa86c15f13d61 : AbstractRESTStructure<RC_cc86cc41f7a6d52842bfa86c15f13d61> {
[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionAccounting")]
[JsonPropertyName("RequisitionAccounting")]
public ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord AttrRequisitionAccounting;

[JsonProperty("AllFiles")]
[JsonPropertyName("AllFiles")]
public ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure[] AttrAllFiles;

[JsonProperty("RequisitionAccConcepts")]
[JsonPropertyName("RequisitionAccConcepts")]
public ssConectaProveedores.RestRecords.JSONRC_f80fde4acf9a7dc465a1d535c05dfb8e[] AttrRequisitionAccConcepts;

[JsonProperty("i_RequisitionAccConcept_EstimEqualAg")]
[JsonPropertyName("i_RequisitionAccConcept_EstimEqualAg")]
public ssConectaProveedores.RestRecords.JSONRC_cdb29de40f41bea5403aac7edb2d6159 Attri_RequisitionAccConcept_EstimEqualAg;

public JSONRC_cc86cc41f7a6d52842bfa86c15f13d61() { }

public JSONRC_cc86cc41f7a6d52842bfa86c15f13d61 (RC_cc86cc41f7a6d52842bfa86c15f13d61 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionAccounting = ConvertToRestWithoutDefaults(s.ssENRequisitionAccounting, new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.FromStructure, config);
AttrAllFiles = s.ssRLAllFiles.Length == 0 ? null : s.ssRLAllFiles.ToArray<ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure>(ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure.FromStructureDelegate(config));
AttrRequisitionAccConcepts = s.ssRLRequisitionAccConcepts.Length == 0 ? null : s.ssRLRequisitionAccConcepts.ToArray<ssConectaProveedores.RestRecords.JSONRC_f80fde4acf9a7dc465a1d535c05dfb8e>(ssConectaProveedores.RestRecords.JSONRC_f80fde4acf9a7dc465a1d535c05dfb8e.FromStructureDelegate(config));
Attri_RequisitionAccConcept_EstimEqualAg = ConvertToRestWithoutDefaults(s.ssRCi_RequisitionAccConcept_EstimEqualAg, new RC_cdb29de40f41bea5403aac7edb2d6159(), ssConectaProveedores.RestRecords.JSONRC_cdb29de40f41bea5403aac7edb2d6159.FromStructure, config);
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionAccounting = ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.FromStructure(s.ssENRequisitionAccounting, config);
AttrAllFiles = s.ssRLAllFiles.ToArray<ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure>(ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure.FromStructureDelegate(config));
AttrRequisitionAccConcepts = s.ssRLRequisitionAccConcepts.ToArray<ssConectaProveedores.RestRecords.JSONRC_f80fde4acf9a7dc465a1d535c05dfb8e>(ssConectaProveedores.RestRecords.JSONRC_f80fde4acf9a7dc465a1d535c05dfb8e.FromStructureDelegate(config));
Attri_RequisitionAccConcept_EstimEqualAg = ssConectaProveedores.RestRecords.JSONRC_cdb29de40f41bea5403aac7edb2d6159.FromStructure(s.ssRCi_RequisitionAccConcept_EstimEqualAg, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_cc86cc41f7a6d52842bfa86c15f13d61, RC_cc86cc41f7a6d52842bfa86c15f13d61> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_cc86cc41f7a6d52842bfa86c15f13d61 s) => ToStructure(s, config);
}
public static RC_cc86cc41f7a6d52842bfa86c15f13d61 ToStructure(ssConectaProveedores.RestRecords.JSONRC_cc86cc41f7a6d52842bfa86c15f13d61 obj, IBehaviorsConfiguration config) { 
  RC_cc86cc41f7a6d52842bfa86c15f13d61 s = new RC_cc86cc41f7a6d52842bfa86c15f13d61();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENRequisitionAccounting = ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.ToStructure(obj.AttrRequisitionAccounting, config);
  s.ssRLAllFiles = RL_7a479a555821b093171c5d3cd3382006.ToList(obj.AttrAllFiles, ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure.ToStructureDelegate(config));
  s.ssRLRequisitionAccConcepts = RL_7c236018492d50b3625a5b0d981eb4eb.ToList(obj.AttrRequisitionAccConcepts, ssConectaProveedores.RestRecords.JSONRC_f80fde4acf9a7dc465a1d535c05dfb8e.ToStructureDelegate(config));
  s.ssRCi_RequisitionAccConcept_EstimEqualAg = ssConectaProveedores.RestRecords.JSONRC_cdb29de40f41bea5403aac7edb2d6159.ToStructure(obj.Attri_RequisitionAccConcept_EstimEqualAg, config);
  }
  return s;
}

public static Func<RC_cc86cc41f7a6d52842bfa86c15f13d61, ssConectaProveedores.RestRecords.JSONRC_cc86cc41f7a6d52842bfa86c15f13d61> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cc86cc41f7a6d52842bfa86c15f13d61 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_cc86cc41f7a6d52842bfa86c15f13d61 FromStructure(RC_cc86cc41f7a6d52842bfa86c15f13d61 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_cc86cc41f7a6d52842bfa86c15f13d61(s, config);
}

}


