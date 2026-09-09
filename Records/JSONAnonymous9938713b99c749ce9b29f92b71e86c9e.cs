using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionSupplierRecord
public class JSONRC_78028cb3076672e5dc4e3606fbea5d54 : AbstractRESTStructure<RC_78028cb3076672e5dc4e3606fbea5d54> {
[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

public JSONRC_78028cb3076672e5dc4e3606fbea5d54() { }

public JSONRC_78028cb3076672e5dc4e3606fbea5d54 (RC_78028cb3076672e5dc4e3606fbea5d54 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_78028cb3076672e5dc4e3606fbea5d54, RC_78028cb3076672e5dc4e3606fbea5d54> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_78028cb3076672e5dc4e3606fbea5d54 s) => ToStructure(s, config);
}
public static RC_78028cb3076672e5dc4e3606fbea5d54 ToStructure(ssConectaProveedores.RestRecords.JSONRC_78028cb3076672e5dc4e3606fbea5d54 obj, IBehaviorsConfiguration config) { 
  RC_78028cb3076672e5dc4e3606fbea5d54 s = new RC_78028cb3076672e5dc4e3606fbea5d54();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  }
  return s;
}

public static Func<RC_78028cb3076672e5dc4e3606fbea5d54, ssConectaProveedores.RestRecords.JSONRC_78028cb3076672e5dc4e3606fbea5d54> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_78028cb3076672e5dc4e3606fbea5d54 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_78028cb3076672e5dc4e3606fbea5d54 FromStructure(RC_78028cb3076672e5dc4e3606fbea5d54 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_78028cb3076672e5dc4e3606fbea5d54(s, config);
}

}


