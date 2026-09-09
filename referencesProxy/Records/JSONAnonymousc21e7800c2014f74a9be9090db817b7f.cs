using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// UserAreaRecord
public class JSONRC_908593a03afc462f5e9a47938601f707 : AbstractRESTStructure<RC_908593a03afc462f5e9a47938601f707> {
[JsonProperty("UserArea")]
[JsonPropertyName("UserArea")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_91436b6b897297e560f42a1f2d0c865cEntityRecord AttrUserArea;

public JSONRC_908593a03afc462f5e9a47938601f707() { }

public JSONRC_908593a03afc462f5e9a47938601f707 (RC_908593a03afc462f5e9a47938601f707 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserArea = ConvertToRestWithoutDefaults(s.ssENUserArea, new EN_91436b6b897297e560f42a1f2d0c865cEntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_91436b6b897297e560f42a1f2d0c865cEntityRecord.FromStructure, config);
  } else {
AttrUserArea = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_91436b6b897297e560f42a1f2d0c865cEntityRecord.FromStructure(s.ssENUserArea, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_908593a03afc462f5e9a47938601f707, RC_908593a03afc462f5e9a47938601f707> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_908593a03afc462f5e9a47938601f707 s) => ToStructure(s, config);
}
public static RC_908593a03afc462f5e9a47938601f707 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_908593a03afc462f5e9a47938601f707 obj, IBehaviorsConfiguration config) { 
  RC_908593a03afc462f5e9a47938601f707 s = new RC_908593a03afc462f5e9a47938601f707();
  if(obj != null) {
  s.ssENUserArea = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_91436b6b897297e560f42a1f2d0c865cEntityRecord.ToStructure(obj.AttrUserArea, config);
  }
  return s;
}

public static Func<RC_908593a03afc462f5e9a47938601f707, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_908593a03afc462f5e9a47938601f707> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_908593a03afc462f5e9a47938601f707 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_908593a03afc462f5e9a47938601f707 FromStructure(RC_908593a03afc462f5e9a47938601f707 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_908593a03afc462f5e9a47938601f707(s, config);
}

}


