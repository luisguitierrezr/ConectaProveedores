using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserAreaRecord
public class RESTRC_908593a03afc462f5e9a47938601f707 : AbstractRESTStructure<RC_908593a03afc462f5e9a47938601f707> {
[JsonProperty("UserArea")]
public ssConectaProveedores.RestRecords.RESTEN_91436b6b897297e560f42a1f2d0c865cEntityRecord AttrUserArea;

public RESTRC_908593a03afc462f5e9a47938601f707() { }

public RESTRC_908593a03afc462f5e9a47938601f707 (RC_908593a03afc462f5e9a47938601f707 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserArea = ConvertToRestWithoutDefaults(s.ssENUserArea, new EN_91436b6b897297e560f42a1f2d0c865cEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_91436b6b897297e560f42a1f2d0c865cEntityRecord.FromStructure, config);
  } else {
AttrUserArea = ssConectaProveedores.RestRecords.RESTEN_91436b6b897297e560f42a1f2d0c865cEntityRecord.FromStructure(s.ssENUserArea, config);
  }
}

public static RC_908593a03afc462f5e9a47938601f707 ToStructure(ssConectaProveedores.RestRecords.RESTRC_908593a03afc462f5e9a47938601f707 obj) { 
  RC_908593a03afc462f5e9a47938601f707 s = new RC_908593a03afc462f5e9a47938601f707();
  if(obj != null) {
  s.ssENUserArea = ssConectaProveedores.RestRecords.RESTEN_91436b6b897297e560f42a1f2d0c865cEntityRecord.ToStructure(obj.AttrUserArea);
  }
  return s;
}

public static Func<RC_908593a03afc462f5e9a47938601f707, ssConectaProveedores.RestRecords.RESTRC_908593a03afc462f5e9a47938601f707> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_908593a03afc462f5e9a47938601f707 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_908593a03afc462f5e9a47938601f707 FromStructure(RC_908593a03afc462f5e9a47938601f707 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_908593a03afc462f5e9a47938601f707(s, config);
}

}


