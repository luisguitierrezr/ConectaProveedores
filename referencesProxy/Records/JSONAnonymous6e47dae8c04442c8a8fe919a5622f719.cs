using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// EntraDomainRecord
public class JSONRC_46822aff680dcd6a1139ef31b620e73d : AbstractRESTStructure<RC_46822aff680dcd6a1139ef31b620e73d> {
[JsonProperty("EntraDomain")]
[JsonPropertyName("EntraDomain")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_635849dd879ffe94511aeebfcff26dbcEntityRecord AttrEntraDomain;

public JSONRC_46822aff680dcd6a1139ef31b620e73d() { }

public JSONRC_46822aff680dcd6a1139ef31b620e73d (RC_46822aff680dcd6a1139ef31b620e73d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEntraDomain = ConvertToRestWithoutDefaults(s.ssENEntraDomain, new EN_635849dd879ffe94511aeebfcff26dbcEntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_635849dd879ffe94511aeebfcff26dbcEntityRecord.FromStructure, config);
  } else {
AttrEntraDomain = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_635849dd879ffe94511aeebfcff26dbcEntityRecord.FromStructure(s.ssENEntraDomain, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_46822aff680dcd6a1139ef31b620e73d, RC_46822aff680dcd6a1139ef31b620e73d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_46822aff680dcd6a1139ef31b620e73d s) => ToStructure(s, config);
}
public static RC_46822aff680dcd6a1139ef31b620e73d ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_46822aff680dcd6a1139ef31b620e73d obj, IBehaviorsConfiguration config) { 
  RC_46822aff680dcd6a1139ef31b620e73d s = new RC_46822aff680dcd6a1139ef31b620e73d();
  if(obj != null) {
  s.ssENEntraDomain = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_635849dd879ffe94511aeebfcff26dbcEntityRecord.ToStructure(obj.AttrEntraDomain, config);
  }
  return s;
}

public static Func<RC_46822aff680dcd6a1139ef31b620e73d, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_46822aff680dcd6a1139ef31b620e73d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_46822aff680dcd6a1139ef31b620e73d s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_46822aff680dcd6a1139ef31b620e73d FromStructure(RC_46822aff680dcd6a1139ef31b620e73d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_46822aff680dcd6a1139ef31b620e73d(s, config);
}

}


