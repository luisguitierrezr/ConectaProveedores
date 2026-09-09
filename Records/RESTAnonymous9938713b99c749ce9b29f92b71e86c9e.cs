using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionSupplierRecord
public class RESTRC_78028cb3076672e5dc4e3606fbea5d54 : AbstractRESTStructure<RC_78028cb3076672e5dc4e3606fbea5d54> {
[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("Supplier")]
public ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

public RESTRC_78028cb3076672e5dc4e3606fbea5d54() { }

public RESTRC_78028cb3076672e5dc4e3606fbea5d54 (RC_78028cb3076672e5dc4e3606fbea5d54 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
  }
}

public static RC_78028cb3076672e5dc4e3606fbea5d54 ToStructure(ssConectaProveedores.RestRecords.RESTRC_78028cb3076672e5dc4e3606fbea5d54 obj) { 
  RC_78028cb3076672e5dc4e3606fbea5d54 s = new RC_78028cb3076672e5dc4e3606fbea5d54();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  s.ssENSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier);
  }
  return s;
}

public static Func<RC_78028cb3076672e5dc4e3606fbea5d54, ssConectaProveedores.RestRecords.RESTRC_78028cb3076672e5dc4e3606fbea5d54> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_78028cb3076672e5dc4e3606fbea5d54 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_78028cb3076672e5dc4e3606fbea5d54 FromStructure(RC_78028cb3076672e5dc4e3606fbea5d54 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_78028cb3076672e5dc4e3606fbea5d54(s, config);
}

}


