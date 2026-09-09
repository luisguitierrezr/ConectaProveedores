using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// IsSelectedSupplierRecord
public class JSONRC_c0133441667bf39f1c8403118864a3c3 : AbstractRESTStructure<RC_c0133441667bf39f1c8403118864a3c3> {
[JsonProperty("IsSelected")]
[JsonPropertyName("IsSelected")]
public bool? AttrIsSelected;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

public JSONRC_c0133441667bf39f1c8403118864a3c3() { }

public JSONRC_c0133441667bf39f1c8403118864a3c3 (RC_c0133441667bf39f1c8403118864a3c3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIsSelected = ConvertToRestWithoutDefaults(s.ssIsSelected, false);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
  } else {
AttrIsSelected = (bool?) s.ssIsSelected;
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_c0133441667bf39f1c8403118864a3c3, RC_c0133441667bf39f1c8403118864a3c3> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_c0133441667bf39f1c8403118864a3c3 s) => ToStructure(s, config);
}
public static RC_c0133441667bf39f1c8403118864a3c3 ToStructure(ssConectaProveedores.RestRecords.JSONRC_c0133441667bf39f1c8403118864a3c3 obj, IBehaviorsConfiguration config) { 
  RC_c0133441667bf39f1c8403118864a3c3 s = new RC_c0133441667bf39f1c8403118864a3c3();
  if(obj != null) {
  s.ssIsSelected = obj.AttrIsSelected == null ? false : obj.AttrIsSelected.Value;
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  }
  return s;
}

public static Func<RC_c0133441667bf39f1c8403118864a3c3, ssConectaProveedores.RestRecords.JSONRC_c0133441667bf39f1c8403118864a3c3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c0133441667bf39f1c8403118864a3c3 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_c0133441667bf39f1c8403118864a3c3 FromStructure(RC_c0133441667bf39f1c8403118864a3c3 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_c0133441667bf39f1c8403118864a3c3(s, config);
}

}


