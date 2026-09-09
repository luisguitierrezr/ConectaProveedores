using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SupplierUserSupplierRecord
public class RESTRC_187912d0df64c67be181be3d4f7af5f3 : AbstractRESTStructure<RC_187912d0df64c67be181be3d4f7af5f3> {
[JsonProperty("SupplierUser")]
public ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord AttrSupplierUser;

[JsonProperty("Supplier")]
public ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

public RESTRC_187912d0df64c67be181be3d4f7af5f3() { }

public RESTRC_187912d0df64c67be181be3d4f7af5f3 (RC_187912d0df64c67be181be3d4f7af5f3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSupplierUser = ConvertToRestWithoutDefaults(s.ssENSupplierUser, new EN_360367a38fba8439556dd1e5826e0428EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
  } else {
AttrSupplierUser = ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord.FromStructure(s.ssENSupplierUser, config);
AttrSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
  }
}

public static RC_187912d0df64c67be181be3d4f7af5f3 ToStructure(ssConectaProveedores.RestRecords.RESTRC_187912d0df64c67be181be3d4f7af5f3 obj) { 
  RC_187912d0df64c67be181be3d4f7af5f3 s = new RC_187912d0df64c67be181be3d4f7af5f3();
  if(obj != null) {
  s.ssENSupplierUser = ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord.ToStructure(obj.AttrSupplierUser);
  s.ssENSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier);
  }
  return s;
}

public static Func<RC_187912d0df64c67be181be3d4f7af5f3, ssConectaProveedores.RestRecords.RESTRC_187912d0df64c67be181be3d4f7af5f3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_187912d0df64c67be181be3d4f7af5f3 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_187912d0df64c67be181be3d4f7af5f3 FromStructure(RC_187912d0df64c67be181be3d4f7af5f3 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_187912d0df64c67be181be3d4f7af5f3(s, config);
}

}


