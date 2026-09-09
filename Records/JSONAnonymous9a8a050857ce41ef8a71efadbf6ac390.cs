using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SupplierUserSupplierRecord
public class JSONRC_187912d0df64c67be181be3d4f7af5f3 : AbstractRESTStructure<RC_187912d0df64c67be181be3d4f7af5f3> {
[JsonProperty("SupplierUser")]
[JsonPropertyName("SupplierUser")]
public ssConectaProveedores.RestRecords.JSONEN_360367a38fba8439556dd1e5826e0428EntityRecord AttrSupplierUser;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

public JSONRC_187912d0df64c67be181be3d4f7af5f3() { }

public JSONRC_187912d0df64c67be181be3d4f7af5f3 (RC_187912d0df64c67be181be3d4f7af5f3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSupplierUser = ConvertToRestWithoutDefaults(s.ssENSupplierUser, new EN_360367a38fba8439556dd1e5826e0428EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_360367a38fba8439556dd1e5826e0428EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
  } else {
AttrSupplierUser = ssConectaProveedores.RestRecords.JSONEN_360367a38fba8439556dd1e5826e0428EntityRecord.FromStructure(s.ssENSupplierUser, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_187912d0df64c67be181be3d4f7af5f3, RC_187912d0df64c67be181be3d4f7af5f3> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_187912d0df64c67be181be3d4f7af5f3 s) => ToStructure(s, config);
}
public static RC_187912d0df64c67be181be3d4f7af5f3 ToStructure(ssConectaProveedores.RestRecords.JSONRC_187912d0df64c67be181be3d4f7af5f3 obj, IBehaviorsConfiguration config) { 
  RC_187912d0df64c67be181be3d4f7af5f3 s = new RC_187912d0df64c67be181be3d4f7af5f3();
  if(obj != null) {
  s.ssENSupplierUser = ssConectaProveedores.RestRecords.JSONEN_360367a38fba8439556dd1e5826e0428EntityRecord.ToStructure(obj.AttrSupplierUser, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  }
  return s;
}

public static Func<RC_187912d0df64c67be181be3d4f7af5f3, ssConectaProveedores.RestRecords.JSONRC_187912d0df64c67be181be3d4f7af5f3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_187912d0df64c67be181be3d4f7af5f3 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_187912d0df64c67be181be3d4f7af5f3 FromStructure(RC_187912d0df64c67be181be3d4f7af5f3 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_187912d0df64c67be181be3d4f7af5f3(s, config);
}

}


