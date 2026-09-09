using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SpaceRecord
public class RESTRC_9589ecc0629788c2aca6b47bcbae782c : AbstractRESTStructure<RC_9589ecc0629788c2aca6b47bcbae782c> {
[JsonProperty("Space")]
public ssConectaProveedores.RestRecords.RESTEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord AttrSpace;

public RESTRC_9589ecc0629788c2aca6b47bcbae782c() { }

public RESTRC_9589ecc0629788c2aca6b47bcbae782c (RC_9589ecc0629788c2aca6b47bcbae782c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSpace = ConvertToRestWithoutDefaults(s.ssENSpace, new EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord.FromStructure, config);
  } else {
AttrSpace = ssConectaProveedores.RestRecords.RESTEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord.FromStructure(s.ssENSpace, config);
  }
}

public static RC_9589ecc0629788c2aca6b47bcbae782c ToStructure(ssConectaProveedores.RestRecords.RESTRC_9589ecc0629788c2aca6b47bcbae782c obj) { 
  RC_9589ecc0629788c2aca6b47bcbae782c s = new RC_9589ecc0629788c2aca6b47bcbae782c();
  if(obj != null) {
  s.ssENSpace = ssConectaProveedores.RestRecords.RESTEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord.ToStructure(obj.AttrSpace);
  }
  return s;
}

public static Func<RC_9589ecc0629788c2aca6b47bcbae782c, ssConectaProveedores.RestRecords.RESTRC_9589ecc0629788c2aca6b47bcbae782c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9589ecc0629788c2aca6b47bcbae782c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_9589ecc0629788c2aca6b47bcbae782c FromStructure(RC_9589ecc0629788c2aca6b47bcbae782c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_9589ecc0629788c2aca6b47bcbae782c(s, config);
}

}


