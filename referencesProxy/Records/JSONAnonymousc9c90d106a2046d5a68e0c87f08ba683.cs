using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// SpaceRecord
public class JSONRC_9589ecc0629788c2aca6b47bcbae782c : AbstractRESTStructure<RC_9589ecc0629788c2aca6b47bcbae782c> {
[JsonProperty("Space")]
[JsonPropertyName("Space")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord AttrSpace;

public JSONRC_9589ecc0629788c2aca6b47bcbae782c() { }

public JSONRC_9589ecc0629788c2aca6b47bcbae782c (RC_9589ecc0629788c2aca6b47bcbae782c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSpace = ConvertToRestWithoutDefaults(s.ssENSpace, new EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord.FromStructure, config);
  } else {
AttrSpace = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord.FromStructure(s.ssENSpace, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_9589ecc0629788c2aca6b47bcbae782c, RC_9589ecc0629788c2aca6b47bcbae782c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_9589ecc0629788c2aca6b47bcbae782c s) => ToStructure(s, config);
}
public static RC_9589ecc0629788c2aca6b47bcbae782c ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_9589ecc0629788c2aca6b47bcbae782c obj, IBehaviorsConfiguration config) { 
  RC_9589ecc0629788c2aca6b47bcbae782c s = new RC_9589ecc0629788c2aca6b47bcbae782c();
  if(obj != null) {
  s.ssENSpace = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord.ToStructure(obj.AttrSpace, config);
  }
  return s;
}

public static Func<RC_9589ecc0629788c2aca6b47bcbae782c, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_9589ecc0629788c2aca6b47bcbae782c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9589ecc0629788c2aca6b47bcbae782c s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_9589ecc0629788c2aca6b47bcbae782c FromStructure(RC_9589ecc0629788c2aca6b47bcbae782c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_9589ecc0629788c2aca6b47bcbae782c(s, config);
}

}


