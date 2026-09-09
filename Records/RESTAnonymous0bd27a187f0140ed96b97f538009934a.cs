using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DirectionRecord
public class RESTRC_070998dc6b3dc951b52d8108550fe380 : AbstractRESTStructure<RC_070998dc6b3dc951b52d8108550fe380> {
[JsonProperty("Direction")]
public ssConectaProveedores.RestRecords.RESTEN_50814454e481dd1773c2250bc248da5eEntityRecord AttrDirection;

public RESTRC_070998dc6b3dc951b52d8108550fe380() { }

public RESTRC_070998dc6b3dc951b52d8108550fe380 (RC_070998dc6b3dc951b52d8108550fe380 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDirection = ConvertToRestWithoutDefaults(s.ssENDirection, new EN_50814454e481dd1773c2250bc248da5eEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_50814454e481dd1773c2250bc248da5eEntityRecord.FromStructure, config);
  } else {
AttrDirection = ssConectaProveedores.RestRecords.RESTEN_50814454e481dd1773c2250bc248da5eEntityRecord.FromStructure(s.ssENDirection, config);
  }
}

public static RC_070998dc6b3dc951b52d8108550fe380 ToStructure(ssConectaProveedores.RestRecords.RESTRC_070998dc6b3dc951b52d8108550fe380 obj) { 
  RC_070998dc6b3dc951b52d8108550fe380 s = new RC_070998dc6b3dc951b52d8108550fe380();
  if(obj != null) {
  s.ssENDirection = ssConectaProveedores.RestRecords.RESTEN_50814454e481dd1773c2250bc248da5eEntityRecord.ToStructure(obj.AttrDirection);
  }
  return s;
}

public static Func<RC_070998dc6b3dc951b52d8108550fe380, ssConectaProveedores.RestRecords.RESTRC_070998dc6b3dc951b52d8108550fe380> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_070998dc6b3dc951b52d8108550fe380 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_070998dc6b3dc951b52d8108550fe380 FromStructure(RC_070998dc6b3dc951b52d8108550fe380 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_070998dc6b3dc951b52d8108550fe380(s, config);
}

}


