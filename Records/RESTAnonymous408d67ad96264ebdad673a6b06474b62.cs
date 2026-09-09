using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioSupplierRecord
public class RESTRC_d1d085a826d7afd1d542eed60c39554c : AbstractRESTStructure<RC_d1d085a826d7afd1d542eed60c39554c> {
[JsonProperty("Folio")]
public ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("Supplier")]
public ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

public RESTRC_d1d085a826d7afd1d542eed60c39554c() { }

public RESTRC_d1d085a826d7afd1d542eed60c39554c (RC_d1d085a826d7afd1d542eed60c39554c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
  } else {
AttrFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
  }
}

public static RC_d1d085a826d7afd1d542eed60c39554c ToStructure(ssConectaProveedores.RestRecords.RESTRC_d1d085a826d7afd1d542eed60c39554c obj) { 
  RC_d1d085a826d7afd1d542eed60c39554c s = new RC_d1d085a826d7afd1d542eed60c39554c();
  if(obj != null) {
  s.ssENFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio);
  s.ssENSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier);
  }
  return s;
}

public static Func<RC_d1d085a826d7afd1d542eed60c39554c, ssConectaProveedores.RestRecords.RESTRC_d1d085a826d7afd1d542eed60c39554c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d1d085a826d7afd1d542eed60c39554c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d1d085a826d7afd1d542eed60c39554c FromStructure(RC_d1d085a826d7afd1d542eed60c39554c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d1d085a826d7afd1d542eed60c39554c(s, config);
}

}


