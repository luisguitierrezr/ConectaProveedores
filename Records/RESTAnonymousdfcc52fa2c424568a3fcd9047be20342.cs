using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUserExtensionUser_Extended_InternalRecord
public class RESTRC_184336c68155ad9e77005f91e8e8b363 : AbstractRESTStructure<RC_184336c68155ad9e77005f91e8e8b363> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("UserExtension")]
public ssConectaProveedores.RestRecords.RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord AttrUserExtension;

[JsonProperty("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

public RESTRC_184336c68155ad9e77005f91e8e8b363() { }

public RESTRC_184336c68155ad9e77005f91e8e8b363 (RC_184336c68155ad9e77005f91e8e8b363 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrUserExtension = ConvertToRestWithoutDefaults(s.ssENUserExtension, new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUserExtension = ssConectaProveedores.RestRecords.RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure(s.ssENUserExtension, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
  }
}

public static RC_184336c68155ad9e77005f91e8e8b363 ToStructure(ssConectaProveedores.RestRecords.RESTRC_184336c68155ad9e77005f91e8e8b363 obj) { 
  RC_184336c68155ad9e77005f91e8e8b363 s = new RC_184336c68155ad9e77005f91e8e8b363();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENUserExtension = ssConectaProveedores.RestRecords.RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.ToStructure(obj.AttrUserExtension);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal);
  }
  return s;
}

public static Func<RC_184336c68155ad9e77005f91e8e8b363, ssConectaProveedores.RestRecords.RESTRC_184336c68155ad9e77005f91e8e8b363> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_184336c68155ad9e77005f91e8e8b363 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_184336c68155ad9e77005f91e8e8b363 FromStructure(RC_184336c68155ad9e77005f91e8e8b363 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_184336c68155ad9e77005f91e8e8b363(s, config);
}

}


