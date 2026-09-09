using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUser_Extended_InternalRecord
public class RESTRC_34272dae45b4de5e1332f46c6e8700b9 : AbstractRESTStructure<RC_34272dae45b4de5e1332f46c6e8700b9> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

public RESTRC_34272dae45b4de5e1332f46c6e8700b9() { }

public RESTRC_34272dae45b4de5e1332f46c6e8700b9 (RC_34272dae45b4de5e1332f46c6e8700b9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
  }
}

public static RC_34272dae45b4de5e1332f46c6e8700b9 ToStructure(ssConectaProveedores.RestRecords.RESTRC_34272dae45b4de5e1332f46c6e8700b9 obj) { 
  RC_34272dae45b4de5e1332f46c6e8700b9 s = new RC_34272dae45b4de5e1332f46c6e8700b9();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal);
  }
  return s;
}

public static Func<RC_34272dae45b4de5e1332f46c6e8700b9, ssConectaProveedores.RestRecords.RESTRC_34272dae45b4de5e1332f46c6e8700b9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_34272dae45b4de5e1332f46c6e8700b9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_34272dae45b4de5e1332f46c6e8700b9 FromStructure(RC_34272dae45b4de5e1332f46c6e8700b9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_34272dae45b4de5e1332f46c6e8700b9(s, config);
}

}


