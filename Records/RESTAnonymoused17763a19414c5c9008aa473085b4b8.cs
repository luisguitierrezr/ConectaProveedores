using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// IsSelectedSupplierRecord
public class RESTRC_c0133441667bf39f1c8403118864a3c3 : AbstractRESTStructure<RC_c0133441667bf39f1c8403118864a3c3> {
[JsonProperty("IsSelected")]
public bool? AttrIsSelected;

[JsonProperty("Supplier")]
public ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

public RESTRC_c0133441667bf39f1c8403118864a3c3() { }

public RESTRC_c0133441667bf39f1c8403118864a3c3 (RC_c0133441667bf39f1c8403118864a3c3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIsSelected = ConvertToRestWithoutDefaults(s.ssIsSelected, false);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
  } else {
AttrIsSelected = (bool?) s.ssIsSelected;
AttrSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
  }
}

public static RC_c0133441667bf39f1c8403118864a3c3 ToStructure(ssConectaProveedores.RestRecords.RESTRC_c0133441667bf39f1c8403118864a3c3 obj) { 
  RC_c0133441667bf39f1c8403118864a3c3 s = new RC_c0133441667bf39f1c8403118864a3c3();
  if(obj != null) {
  s.ssIsSelected = obj.AttrIsSelected == null ? false : obj.AttrIsSelected.Value;
  s.ssENSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier);
  }
  return s;
}

public static Func<RC_c0133441667bf39f1c8403118864a3c3, ssConectaProveedores.RestRecords.RESTRC_c0133441667bf39f1c8403118864a3c3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c0133441667bf39f1c8403118864a3c3 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_c0133441667bf39f1c8403118864a3c3 FromStructure(RC_c0133441667bf39f1c8403118864a3c3 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_c0133441667bf39f1c8403118864a3c3(s, config);
}

}


