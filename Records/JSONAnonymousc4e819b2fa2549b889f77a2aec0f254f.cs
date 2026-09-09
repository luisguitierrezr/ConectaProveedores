using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ErroImportRecord
public class JSONRC_a3650876f3c0ce24e984510abde7b989 : AbstractRESTStructure<RC_a3650876f3c0ce24e984510abde7b989> {
[JsonProperty("ErroImport")]
[JsonPropertyName("ErroImport")]
public ssConectaProveedores.RestRecords.JSONST_37eba272293c59d7cf1400fbd0fb4b40Structure AttrErroImport;

public JSONRC_a3650876f3c0ce24e984510abde7b989() { }

public JSONRC_a3650876f3c0ce24e984510abde7b989 (RC_a3650876f3c0ce24e984510abde7b989 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrErroImport = ConvertToRestWithoutDefaults(s.ssSTErroImport, new ST_37eba272293c59d7cf1400fbd0fb4b40Structure(), ssConectaProveedores.RestRecords.JSONST_37eba272293c59d7cf1400fbd0fb4b40Structure.FromStructure, config);
  } else {
AttrErroImport = ssConectaProveedores.RestRecords.JSONST_37eba272293c59d7cf1400fbd0fb4b40Structure.FromStructure(s.ssSTErroImport, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a3650876f3c0ce24e984510abde7b989, RC_a3650876f3c0ce24e984510abde7b989> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a3650876f3c0ce24e984510abde7b989 s) => ToStructure(s, config);
}
public static RC_a3650876f3c0ce24e984510abde7b989 ToStructure(ssConectaProveedores.RestRecords.JSONRC_a3650876f3c0ce24e984510abde7b989 obj, IBehaviorsConfiguration config) { 
  RC_a3650876f3c0ce24e984510abde7b989 s = new RC_a3650876f3c0ce24e984510abde7b989();
  if(obj != null) {
  s.ssSTErroImport = ssConectaProveedores.RestRecords.JSONST_37eba272293c59d7cf1400fbd0fb4b40Structure.ToStructure(obj.AttrErroImport, config);
  }
  return s;
}

public static Func<RC_a3650876f3c0ce24e984510abde7b989, ssConectaProveedores.RestRecords.JSONRC_a3650876f3c0ce24e984510abde7b989> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a3650876f3c0ce24e984510abde7b989 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a3650876f3c0ce24e984510abde7b989 FromStructure(RC_a3650876f3c0ce24e984510abde7b989 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a3650876f3c0ce24e984510abde7b989(s, config);
}

}


