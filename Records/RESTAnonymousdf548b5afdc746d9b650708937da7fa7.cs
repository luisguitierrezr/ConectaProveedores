using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ActivityKindRecord
public class RESTRC_99e7afb0bae555fcf70d1cd06f23ae14 : AbstractRESTStructure<RC_99e7afb0bae555fcf70d1cd06f23ae14> {
[JsonProperty("ActivityKind")]
public ssConectaProveedores.RestRecords.RESTENActivityKindEntityRecord AttrActivityKind;

public RESTRC_99e7afb0bae555fcf70d1cd06f23ae14() { }

public RESTRC_99e7afb0bae555fcf70d1cd06f23ae14 (RC_99e7afb0bae555fcf70d1cd06f23ae14 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActivityKind = ConvertToRestWithoutDefaults(s.ssENActivityKind, new ENActivityKindEntityRecord(), ssConectaProveedores.RestRecords.RESTENActivityKindEntityRecord.FromStructure, config);
  } else {
AttrActivityKind = ssConectaProveedores.RestRecords.RESTENActivityKindEntityRecord.FromStructure(s.ssENActivityKind, config);
  }
}

public static RC_99e7afb0bae555fcf70d1cd06f23ae14 ToStructure(ssConectaProveedores.RestRecords.RESTRC_99e7afb0bae555fcf70d1cd06f23ae14 obj) { 
  RC_99e7afb0bae555fcf70d1cd06f23ae14 s = new RC_99e7afb0bae555fcf70d1cd06f23ae14();
  if(obj != null) {
  s.ssENActivityKind = ssConectaProveedores.RestRecords.RESTENActivityKindEntityRecord.ToStructure(obj.AttrActivityKind);
  }
  return s;
}

public static Func<RC_99e7afb0bae555fcf70d1cd06f23ae14, ssConectaProveedores.RestRecords.RESTRC_99e7afb0bae555fcf70d1cd06f23ae14> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_99e7afb0bae555fcf70d1cd06f23ae14 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_99e7afb0bae555fcf70d1cd06f23ae14 FromStructure(RC_99e7afb0bae555fcf70d1cd06f23ae14 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_99e7afb0bae555fcf70d1cd06f23ae14(s, config);
}

}


