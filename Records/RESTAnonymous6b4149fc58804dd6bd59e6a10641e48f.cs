using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LongIntegerIdentifierRecord
public class RESTRC_9a90bc2051b4738eb963dcb1fec11850 : AbstractRESTStructure<RC_9a90bc2051b4738eb963dcb1fec11850> {
[JsonProperty("LongIntegerIdentifier")]
public ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrLongIntegerIdentifier;

public RESTRC_9a90bc2051b4738eb963dcb1fec11850() { }

public RESTRC_9a90bc2051b4738eb963dcb1fec11850 (RC_9a90bc2051b4738eb963dcb1fec11850 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLongIntegerIdentifier = ConvertToRestWithoutDefaults(s.ssSTLongIntegerIdentifier, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
  } else {
AttrLongIntegerIdentifier = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTLongIntegerIdentifier, config);
  }
}

public static RC_9a90bc2051b4738eb963dcb1fec11850 ToStructure(ssConectaProveedores.RestRecords.RESTRC_9a90bc2051b4738eb963dcb1fec11850 obj) { 
  RC_9a90bc2051b4738eb963dcb1fec11850 s = new RC_9a90bc2051b4738eb963dcb1fec11850();
  if(obj != null) {
  s.ssSTLongIntegerIdentifier = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrLongIntegerIdentifier);
  }
  return s;
}

public static Func<RC_9a90bc2051b4738eb963dcb1fec11850, ssConectaProveedores.RestRecords.RESTRC_9a90bc2051b4738eb963dcb1fec11850> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9a90bc2051b4738eb963dcb1fec11850 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_9a90bc2051b4738eb963dcb1fec11850 FromStructure(RC_9a90bc2051b4738eb963dcb1fec11850 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_9a90bc2051b4738eb963dcb1fec11850(s, config);
}

}


