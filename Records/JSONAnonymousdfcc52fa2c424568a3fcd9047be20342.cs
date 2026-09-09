using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUserExtensionUser_Extended_InternalRecord
public class JSONRC_184336c68155ad9e77005f91e8e8b363 : AbstractRESTStructure<RC_184336c68155ad9e77005f91e8e8b363> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("UserExtension")]
[JsonPropertyName("UserExtension")]
public ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord AttrUserExtension;

[JsonProperty("User_Extended_Internal")]
[JsonPropertyName("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

public JSONRC_184336c68155ad9e77005f91e8e8b363() { }

public JSONRC_184336c68155ad9e77005f91e8e8b363 (RC_184336c68155ad9e77005f91e8e8b363 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUserExtension = ConvertToRestWithoutDefaults(s.ssENUserExtension, new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUserExtension = ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure(s.ssENUserExtension, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_184336c68155ad9e77005f91e8e8b363, RC_184336c68155ad9e77005f91e8e8b363> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_184336c68155ad9e77005f91e8e8b363 s) => ToStructure(s, config);
}
public static RC_184336c68155ad9e77005f91e8e8b363 ToStructure(ssConectaProveedores.RestRecords.JSONRC_184336c68155ad9e77005f91e8e8b363 obj, IBehaviorsConfiguration config) { 
  RC_184336c68155ad9e77005f91e8e8b363 s = new RC_184336c68155ad9e77005f91e8e8b363();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENUserExtension = ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.ToStructure(obj.AttrUserExtension, config);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal, config);
  }
  return s;
}

public static Func<RC_184336c68155ad9e77005f91e8e8b363, ssConectaProveedores.RestRecords.JSONRC_184336c68155ad9e77005f91e8e8b363> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_184336c68155ad9e77005f91e8e8b363 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_184336c68155ad9e77005f91e8e8b363 FromStructure(RC_184336c68155ad9e77005f91e8e8b363 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_184336c68155ad9e77005f91e8e8b363(s, config);
}

}


