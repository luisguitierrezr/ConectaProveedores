using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ServiceFormatRecord
public class RESTRC_1356565a59d37b0a56b61edcf3cae9df : AbstractRESTStructure<RC_1356565a59d37b0a56b61edcf3cae9df> {
[JsonProperty("ServiceFormat")]
public ssConectaProveedores.RestRecords.RESTEN_90b73a13d9271bc660c79c0da31f8dbbEntityRecord AttrServiceFormat;

public RESTRC_1356565a59d37b0a56b61edcf3cae9df() { }

public RESTRC_1356565a59d37b0a56b61edcf3cae9df (RC_1356565a59d37b0a56b61edcf3cae9df s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrServiceFormat = ConvertToRestWithoutDefaults(s.ssENServiceFormat, new EN_90b73a13d9271bc660c79c0da31f8dbbEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_90b73a13d9271bc660c79c0da31f8dbbEntityRecord.FromStructure, config);
  } else {
AttrServiceFormat = ssConectaProveedores.RestRecords.RESTEN_90b73a13d9271bc660c79c0da31f8dbbEntityRecord.FromStructure(s.ssENServiceFormat, config);
  }
}

public static RC_1356565a59d37b0a56b61edcf3cae9df ToStructure(ssConectaProveedores.RestRecords.RESTRC_1356565a59d37b0a56b61edcf3cae9df obj) { 
  RC_1356565a59d37b0a56b61edcf3cae9df s = new RC_1356565a59d37b0a56b61edcf3cae9df();
  if(obj != null) {
  s.ssENServiceFormat = ssConectaProveedores.RestRecords.RESTEN_90b73a13d9271bc660c79c0da31f8dbbEntityRecord.ToStructure(obj.AttrServiceFormat);
  }
  return s;
}

public static Func<RC_1356565a59d37b0a56b61edcf3cae9df, ssConectaProveedores.RestRecords.RESTRC_1356565a59d37b0a56b61edcf3cae9df> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1356565a59d37b0a56b61edcf3cae9df s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_1356565a59d37b0a56b61edcf3cae9df FromStructure(RC_1356565a59d37b0a56b61edcf3cae9df s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_1356565a59d37b0a56b61edcf3cae9df(s, config);
}

}


