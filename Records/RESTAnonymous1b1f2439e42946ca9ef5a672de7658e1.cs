using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PositionRecord
public class RESTRC_5f28219a5e30fb90023fcbc295513e7c : AbstractRESTStructure<RC_5f28219a5e30fb90023fcbc295513e7c> {
[JsonProperty("Position")]
public ssConectaProveedores.RestRecords.RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord AttrPosition;

public RESTRC_5f28219a5e30fb90023fcbc295513e7c() { }

public RESTRC_5f28219a5e30fb90023fcbc295513e7c (RC_5f28219a5e30fb90023fcbc295513e7c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPosition = ConvertToRestWithoutDefaults(s.ssENPosition, new EN_5d1279724e719322292e34ef3c5500a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord.FromStructure, config);
  } else {
AttrPosition = ssConectaProveedores.RestRecords.RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord.FromStructure(s.ssENPosition, config);
  }
}

public static RC_5f28219a5e30fb90023fcbc295513e7c ToStructure(ssConectaProveedores.RestRecords.RESTRC_5f28219a5e30fb90023fcbc295513e7c obj) { 
  RC_5f28219a5e30fb90023fcbc295513e7c s = new RC_5f28219a5e30fb90023fcbc295513e7c();
  if(obj != null) {
  s.ssENPosition = ssConectaProveedores.RestRecords.RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord.ToStructure(obj.AttrPosition);
  }
  return s;
}

public static Func<RC_5f28219a5e30fb90023fcbc295513e7c, ssConectaProveedores.RestRecords.RESTRC_5f28219a5e30fb90023fcbc295513e7c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5f28219a5e30fb90023fcbc295513e7c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_5f28219a5e30fb90023fcbc295513e7c FromStructure(RC_5f28219a5e30fb90023fcbc295513e7c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_5f28219a5e30fb90023fcbc295513e7c(s, config);
}

}


