using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserAreaRecord
public class JSONRC_908593a03afc462f5e9a47938601f707 : AbstractRESTStructure<RC_908593a03afc462f5e9a47938601f707> {
[JsonProperty("UserArea")]
[JsonPropertyName("UserArea")]
public ssConectaProveedores.RestRecords.JSONEN_91436b6b897297e560f42a1f2d0c865cEntityRecord AttrUserArea;

public JSONRC_908593a03afc462f5e9a47938601f707() { }

public JSONRC_908593a03afc462f5e9a47938601f707 (RC_908593a03afc462f5e9a47938601f707 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserArea = ConvertToRestWithoutDefaults(s.ssENUserArea, new EN_91436b6b897297e560f42a1f2d0c865cEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_91436b6b897297e560f42a1f2d0c865cEntityRecord.FromStructure, config);
  } else {
AttrUserArea = ssConectaProveedores.RestRecords.JSONEN_91436b6b897297e560f42a1f2d0c865cEntityRecord.FromStructure(s.ssENUserArea, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_908593a03afc462f5e9a47938601f707, RC_908593a03afc462f5e9a47938601f707> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_908593a03afc462f5e9a47938601f707 s) => ToStructure(s, config);
}
public static RC_908593a03afc462f5e9a47938601f707 ToStructure(ssConectaProveedores.RestRecords.JSONRC_908593a03afc462f5e9a47938601f707 obj, IBehaviorsConfiguration config) { 
  RC_908593a03afc462f5e9a47938601f707 s = new RC_908593a03afc462f5e9a47938601f707();
  if(obj != null) {
  s.ssENUserArea = ssConectaProveedores.RestRecords.JSONEN_91436b6b897297e560f42a1f2d0c865cEntityRecord.ToStructure(obj.AttrUserArea, config);
  }
  return s;
}

public static Func<RC_908593a03afc462f5e9a47938601f707, ssConectaProveedores.RestRecords.JSONRC_908593a03afc462f5e9a47938601f707> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_908593a03afc462f5e9a47938601f707 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_908593a03afc462f5e9a47938601f707 FromStructure(RC_908593a03afc462f5e9a47938601f707 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_908593a03afc462f5e9a47938601f707(s, config);
}

}


