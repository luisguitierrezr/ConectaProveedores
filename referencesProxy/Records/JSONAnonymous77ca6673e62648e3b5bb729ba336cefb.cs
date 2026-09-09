using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// SupplierUserRecord
public class JSONRC_33e6e9ec201f65e0eb7bd5d251178def : AbstractRESTStructure<RC_33e6e9ec201f65e0eb7bd5d251178def> {
[JsonProperty("SupplierUser")]
[JsonPropertyName("SupplierUser")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_360367a38fba8439556dd1e5826e0428EntityRecord AttrSupplierUser;

public JSONRC_33e6e9ec201f65e0eb7bd5d251178def() { }

public JSONRC_33e6e9ec201f65e0eb7bd5d251178def (RC_33e6e9ec201f65e0eb7bd5d251178def s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSupplierUser = ConvertToRestWithoutDefaults(s.ssENSupplierUser, new EN_360367a38fba8439556dd1e5826e0428EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_360367a38fba8439556dd1e5826e0428EntityRecord.FromStructure, config);
  } else {
AttrSupplierUser = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_360367a38fba8439556dd1e5826e0428EntityRecord.FromStructure(s.ssENSupplierUser, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_33e6e9ec201f65e0eb7bd5d251178def, RC_33e6e9ec201f65e0eb7bd5d251178def> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_33e6e9ec201f65e0eb7bd5d251178def s) => ToStructure(s, config);
}
public static RC_33e6e9ec201f65e0eb7bd5d251178def ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_33e6e9ec201f65e0eb7bd5d251178def obj, IBehaviorsConfiguration config) { 
  RC_33e6e9ec201f65e0eb7bd5d251178def s = new RC_33e6e9ec201f65e0eb7bd5d251178def();
  if(obj != null) {
  s.ssENSupplierUser = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_360367a38fba8439556dd1e5826e0428EntityRecord.ToStructure(obj.AttrSupplierUser, config);
  }
  return s;
}

public static Func<RC_33e6e9ec201f65e0eb7bd5d251178def, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_33e6e9ec201f65e0eb7bd5d251178def> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_33e6e9ec201f65e0eb7bd5d251178def s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_33e6e9ec201f65e0eb7bd5d251178def FromStructure(RC_33e6e9ec201f65e0eb7bd5d251178def s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_33e6e9ec201f65e0eb7bd5d251178def(s, config);
}

}


