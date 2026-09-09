using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EntraRoleUser_Extended_InternalRecord
public class RESTRC_2d026dc77741fad17a11f0df63aa3b4b : AbstractRESTStructure<RC_2d026dc77741fad17a11f0df63aa3b4b> {
[JsonProperty("EntraRole")]
public ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrEntraRole;

[JsonProperty("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

public RESTRC_2d026dc77741fad17a11f0df63aa3b4b() { }

public RESTRC_2d026dc77741fad17a11f0df63aa3b4b (RC_2d026dc77741fad17a11f0df63aa3b4b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEntraRole = ConvertToRestWithoutDefaults(s.ssENEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
  } else {
AttrEntraRole = ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENEntraRole, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
  }
}

public static RC_2d026dc77741fad17a11f0df63aa3b4b ToStructure(ssConectaProveedores.RestRecords.RESTRC_2d026dc77741fad17a11f0df63aa3b4b obj) { 
  RC_2d026dc77741fad17a11f0df63aa3b4b s = new RC_2d026dc77741fad17a11f0df63aa3b4b();
  if(obj != null) {
  s.ssENEntraRole = ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrEntraRole);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal);
  }
  return s;
}

public static Func<RC_2d026dc77741fad17a11f0df63aa3b4b, ssConectaProveedores.RestRecords.RESTRC_2d026dc77741fad17a11f0df63aa3b4b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2d026dc77741fad17a11f0df63aa3b4b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_2d026dc77741fad17a11f0df63aa3b4b FromStructure(RC_2d026dc77741fad17a11f0df63aa3b4b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_2d026dc77741fad17a11f0df63aa3b4b(s, config);
}

}


