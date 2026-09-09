using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SupplierUserRecord
public class RESTRC_33e6e9ec201f65e0eb7bd5d251178def : AbstractRESTStructure<RC_33e6e9ec201f65e0eb7bd5d251178def> {
[JsonProperty("SupplierUser")]
public ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord AttrSupplierUser;

public RESTRC_33e6e9ec201f65e0eb7bd5d251178def() { }

public RESTRC_33e6e9ec201f65e0eb7bd5d251178def (RC_33e6e9ec201f65e0eb7bd5d251178def s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSupplierUser = ConvertToRestWithoutDefaults(s.ssENSupplierUser, new EN_360367a38fba8439556dd1e5826e0428EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord.FromStructure, config);
  } else {
AttrSupplierUser = ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord.FromStructure(s.ssENSupplierUser, config);
  }
}

public static RC_33e6e9ec201f65e0eb7bd5d251178def ToStructure(ssConectaProveedores.RestRecords.RESTRC_33e6e9ec201f65e0eb7bd5d251178def obj) { 
  RC_33e6e9ec201f65e0eb7bd5d251178def s = new RC_33e6e9ec201f65e0eb7bd5d251178def();
  if(obj != null) {
  s.ssENSupplierUser = ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord.ToStructure(obj.AttrSupplierUser);
  }
  return s;
}

public static Func<RC_33e6e9ec201f65e0eb7bd5d251178def, ssConectaProveedores.RestRecords.RESTRC_33e6e9ec201f65e0eb7bd5d251178def> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_33e6e9ec201f65e0eb7bd5d251178def s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_33e6e9ec201f65e0eb7bd5d251178def FromStructure(RC_33e6e9ec201f65e0eb7bd5d251178def s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_33e6e9ec201f65e0eb7bd5d251178def(s, config);
}

}


