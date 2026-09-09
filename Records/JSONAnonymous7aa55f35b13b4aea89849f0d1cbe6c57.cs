using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionRequisitionAccountingRecord
public class JSONRC_d44c83c6811c5993da31ecba331d9c39 : AbstractRESTStructure<RC_d44c83c6811c5993da31ecba331d9c39> {
[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionAccounting")]
[JsonPropertyName("RequisitionAccounting")]
public ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord AttrRequisitionAccounting;

public JSONRC_d44c83c6811c5993da31ecba331d9c39() { }

public JSONRC_d44c83c6811c5993da31ecba331d9c39 (RC_d44c83c6811c5993da31ecba331d9c39 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionAccounting = ConvertToRestWithoutDefaults(s.ssENRequisitionAccounting, new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.FromStructure, config);
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionAccounting = ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.FromStructure(s.ssENRequisitionAccounting, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_d44c83c6811c5993da31ecba331d9c39, RC_d44c83c6811c5993da31ecba331d9c39> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_d44c83c6811c5993da31ecba331d9c39 s) => ToStructure(s, config);
}
public static RC_d44c83c6811c5993da31ecba331d9c39 ToStructure(ssConectaProveedores.RestRecords.JSONRC_d44c83c6811c5993da31ecba331d9c39 obj, IBehaviorsConfiguration config) { 
  RC_d44c83c6811c5993da31ecba331d9c39 s = new RC_d44c83c6811c5993da31ecba331d9c39();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENRequisitionAccounting = ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.ToStructure(obj.AttrRequisitionAccounting, config);
  }
  return s;
}

public static Func<RC_d44c83c6811c5993da31ecba331d9c39, ssConectaProveedores.RestRecords.JSONRC_d44c83c6811c5993da31ecba331d9c39> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d44c83c6811c5993da31ecba331d9c39 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_d44c83c6811c5993da31ecba331d9c39 FromStructure(RC_d44c83c6811c5993da31ecba331d9c39 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_d44c83c6811c5993da31ecba331d9c39(s, config);
}

}


