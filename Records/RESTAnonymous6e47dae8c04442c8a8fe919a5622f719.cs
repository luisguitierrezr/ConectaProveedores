using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EntraDomainRecord
public class RESTRC_46822aff680dcd6a1139ef31b620e73d : AbstractRESTStructure<RC_46822aff680dcd6a1139ef31b620e73d> {
[JsonProperty("EntraDomain")]
public ssConectaProveedores.RestRecords.RESTEN_635849dd879ffe94511aeebfcff26dbcEntityRecord AttrEntraDomain;

public RESTRC_46822aff680dcd6a1139ef31b620e73d() { }

public RESTRC_46822aff680dcd6a1139ef31b620e73d (RC_46822aff680dcd6a1139ef31b620e73d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEntraDomain = ConvertToRestWithoutDefaults(s.ssENEntraDomain, new EN_635849dd879ffe94511aeebfcff26dbcEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_635849dd879ffe94511aeebfcff26dbcEntityRecord.FromStructure, config);
  } else {
AttrEntraDomain = ssConectaProveedores.RestRecords.RESTEN_635849dd879ffe94511aeebfcff26dbcEntityRecord.FromStructure(s.ssENEntraDomain, config);
  }
}

public static RC_46822aff680dcd6a1139ef31b620e73d ToStructure(ssConectaProveedores.RestRecords.RESTRC_46822aff680dcd6a1139ef31b620e73d obj) { 
  RC_46822aff680dcd6a1139ef31b620e73d s = new RC_46822aff680dcd6a1139ef31b620e73d();
  if(obj != null) {
  s.ssENEntraDomain = ssConectaProveedores.RestRecords.RESTEN_635849dd879ffe94511aeebfcff26dbcEntityRecord.ToStructure(obj.AttrEntraDomain);
  }
  return s;
}

public static Func<RC_46822aff680dcd6a1139ef31b620e73d, ssConectaProveedores.RestRecords.RESTRC_46822aff680dcd6a1139ef31b620e73d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_46822aff680dcd6a1139ef31b620e73d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_46822aff680dcd6a1139ef31b620e73d FromStructure(RC_46822aff680dcd6a1139ef31b620e73d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_46822aff680dcd6a1139ef31b620e73d(s, config);
}

}


