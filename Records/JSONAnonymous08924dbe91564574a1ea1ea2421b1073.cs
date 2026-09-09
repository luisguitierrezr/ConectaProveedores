using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ServiceFormatRecord
public class JSONRC_1356565a59d37b0a56b61edcf3cae9df : AbstractRESTStructure<RC_1356565a59d37b0a56b61edcf3cae9df> {
[JsonProperty("ServiceFormat")]
[JsonPropertyName("ServiceFormat")]
public ssConectaProveedores.RestRecords.JSONEN_90b73a13d9271bc660c79c0da31f8dbbEntityRecord AttrServiceFormat;

public JSONRC_1356565a59d37b0a56b61edcf3cae9df() { }

public JSONRC_1356565a59d37b0a56b61edcf3cae9df (RC_1356565a59d37b0a56b61edcf3cae9df s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrServiceFormat = ConvertToRestWithoutDefaults(s.ssENServiceFormat, new EN_90b73a13d9271bc660c79c0da31f8dbbEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_90b73a13d9271bc660c79c0da31f8dbbEntityRecord.FromStructure, config);
  } else {
AttrServiceFormat = ssConectaProveedores.RestRecords.JSONEN_90b73a13d9271bc660c79c0da31f8dbbEntityRecord.FromStructure(s.ssENServiceFormat, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1356565a59d37b0a56b61edcf3cae9df, RC_1356565a59d37b0a56b61edcf3cae9df> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1356565a59d37b0a56b61edcf3cae9df s) => ToStructure(s, config);
}
public static RC_1356565a59d37b0a56b61edcf3cae9df ToStructure(ssConectaProveedores.RestRecords.JSONRC_1356565a59d37b0a56b61edcf3cae9df obj, IBehaviorsConfiguration config) { 
  RC_1356565a59d37b0a56b61edcf3cae9df s = new RC_1356565a59d37b0a56b61edcf3cae9df();
  if(obj != null) {
  s.ssENServiceFormat = ssConectaProveedores.RestRecords.JSONEN_90b73a13d9271bc660c79c0da31f8dbbEntityRecord.ToStructure(obj.AttrServiceFormat, config);
  }
  return s;
}

public static Func<RC_1356565a59d37b0a56b61edcf3cae9df, ssConectaProveedores.RestRecords.JSONRC_1356565a59d37b0a56b61edcf3cae9df> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1356565a59d37b0a56b61edcf3cae9df s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1356565a59d37b0a56b61edcf3cae9df FromStructure(RC_1356565a59d37b0a56b61edcf3cae9df s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1356565a59d37b0a56b61edcf3cae9df(s, config);
}

}


