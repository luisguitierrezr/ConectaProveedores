using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionSupplierRegionRecord
public class RESTRC_9b8bde366f0fe61cf64fff2adf2f6e88 : AbstractRESTStructure<RC_9b8bde366f0fe61cf64fff2adf2f6e88> {
[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("Supplier")]
public ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_9b8bde366f0fe61cf64fff2adf2f6e88() { }

public RESTRC_9b8bde366f0fe61cf64fff2adf2f6e88 (RC_9b8bde366f0fe61cf64fff2adf2f6e88 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_9b8bde366f0fe61cf64fff2adf2f6e88 ToStructure(ssConectaProveedores.RestRecords.RESTRC_9b8bde366f0fe61cf64fff2adf2f6e88 obj) { 
  RC_9b8bde366f0fe61cf64fff2adf2f6e88 s = new RC_9b8bde366f0fe61cf64fff2adf2f6e88();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  s.ssENSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier);
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_9b8bde366f0fe61cf64fff2adf2f6e88, ssConectaProveedores.RestRecords.RESTRC_9b8bde366f0fe61cf64fff2adf2f6e88> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9b8bde366f0fe61cf64fff2adf2f6e88 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_9b8bde366f0fe61cf64fff2adf2f6e88 FromStructure(RC_9b8bde366f0fe61cf64fff2adf2f6e88 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_9b8bde366f0fe61cf64fff2adf2f6e88(s, config);
}

}


