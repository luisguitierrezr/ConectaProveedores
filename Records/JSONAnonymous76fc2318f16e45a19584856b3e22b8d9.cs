using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionSupplierRegionRecord
public class JSONRC_9b8bde366f0fe61cf64fff2adf2f6e88 : AbstractRESTStructure<RC_9b8bde366f0fe61cf64fff2adf2f6e88> {
[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_9b8bde366f0fe61cf64fff2adf2f6e88() { }

public JSONRC_9b8bde366f0fe61cf64fff2adf2f6e88 (RC_9b8bde366f0fe61cf64fff2adf2f6e88 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_9b8bde366f0fe61cf64fff2adf2f6e88, RC_9b8bde366f0fe61cf64fff2adf2f6e88> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_9b8bde366f0fe61cf64fff2adf2f6e88 s) => ToStructure(s, config);
}
public static RC_9b8bde366f0fe61cf64fff2adf2f6e88 ToStructure(ssConectaProveedores.RestRecords.JSONRC_9b8bde366f0fe61cf64fff2adf2f6e88 obj, IBehaviorsConfiguration config) { 
  RC_9b8bde366f0fe61cf64fff2adf2f6e88 s = new RC_9b8bde366f0fe61cf64fff2adf2f6e88();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_9b8bde366f0fe61cf64fff2adf2f6e88, ssConectaProveedores.RestRecords.JSONRC_9b8bde366f0fe61cf64fff2adf2f6e88> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9b8bde366f0fe61cf64fff2adf2f6e88 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_9b8bde366f0fe61cf64fff2adf2f6e88 FromStructure(RC_9b8bde366f0fe61cf64fff2adf2f6e88 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_9b8bde366f0fe61cf64fff2adf2f6e88(s, config);
}

}


