using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValidRecord
public class RESTRC_a224d98ed725f0a01e029de10d28bcba : AbstractRESTStructure<RC_a224d98ed725f0a01e029de10d28bcba> {
[JsonProperty("Valid")]
public ssConectaProveedores.RestRecords.RESTST_b453bea0930035904f55a74692afd3a8Structure AttrValid;

public RESTRC_a224d98ed725f0a01e029de10d28bcba() { }

public RESTRC_a224d98ed725f0a01e029de10d28bcba (RC_a224d98ed725f0a01e029de10d28bcba s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValid = ConvertToRestWithoutDefaults(s.ssSTValid, new ST_b453bea0930035904f55a74692afd3a8Structure(), ssConectaProveedores.RestRecords.RESTST_b453bea0930035904f55a74692afd3a8Structure.FromStructure, config);
  } else {
AttrValid = ssConectaProveedores.RestRecords.RESTST_b453bea0930035904f55a74692afd3a8Structure.FromStructure(s.ssSTValid, config);
  }
}

public static RC_a224d98ed725f0a01e029de10d28bcba ToStructure(ssConectaProveedores.RestRecords.RESTRC_a224d98ed725f0a01e029de10d28bcba obj) { 
  RC_a224d98ed725f0a01e029de10d28bcba s = new RC_a224d98ed725f0a01e029de10d28bcba();
  if(obj != null) {
  s.ssSTValid = ssConectaProveedores.RestRecords.RESTST_b453bea0930035904f55a74692afd3a8Structure.ToStructure(obj.AttrValid);
  }
  return s;
}

public static Func<RC_a224d98ed725f0a01e029de10d28bcba, ssConectaProveedores.RestRecords.RESTRC_a224d98ed725f0a01e029de10d28bcba> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a224d98ed725f0a01e029de10d28bcba s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a224d98ed725f0a01e029de10d28bcba FromStructure(RC_a224d98ed725f0a01e029de10d28bcba s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a224d98ed725f0a01e029de10d28bcba(s, config);
}

}


