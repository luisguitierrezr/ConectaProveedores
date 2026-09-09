using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FindUserByEmailRecord
public class RESTRC_3c3e6937665dab7fa6af3a41c38f6173 : AbstractRESTStructure<RC_3c3e6937665dab7fa6af3a41c38f6173> {
[JsonProperty("FindUserByEmail")]
public ssConectaProveedores.RestRecords.RESTST_f45a100349e05fd4d70690aea76ddd0aStructure AttrFindUserByEmail;

public RESTRC_3c3e6937665dab7fa6af3a41c38f6173() { }

public RESTRC_3c3e6937665dab7fa6af3a41c38f6173 (RC_3c3e6937665dab7fa6af3a41c38f6173 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFindUserByEmail = ConvertToRestWithoutDefaults(s.ssSTFindUserByEmail, new ST_f45a100349e05fd4d70690aea76ddd0aStructure(), ssConectaProveedores.RestRecords.RESTST_f45a100349e05fd4d70690aea76ddd0aStructure.FromStructure, config);
  } else {
AttrFindUserByEmail = ssConectaProveedores.RestRecords.RESTST_f45a100349e05fd4d70690aea76ddd0aStructure.FromStructure(s.ssSTFindUserByEmail, config);
  }
}

public static RC_3c3e6937665dab7fa6af3a41c38f6173 ToStructure(ssConectaProveedores.RestRecords.RESTRC_3c3e6937665dab7fa6af3a41c38f6173 obj) { 
  RC_3c3e6937665dab7fa6af3a41c38f6173 s = new RC_3c3e6937665dab7fa6af3a41c38f6173();
  if(obj != null) {
  s.ssSTFindUserByEmail = ssConectaProveedores.RestRecords.RESTST_f45a100349e05fd4d70690aea76ddd0aStructure.ToStructure(obj.AttrFindUserByEmail);
  }
  return s;
}

public static Func<RC_3c3e6937665dab7fa6af3a41c38f6173, ssConectaProveedores.RestRecords.RESTRC_3c3e6937665dab7fa6af3a41c38f6173> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3c3e6937665dab7fa6af3a41c38f6173 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_3c3e6937665dab7fa6af3a41c38f6173 FromStructure(RC_3c3e6937665dab7fa6af3a41c38f6173 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_3c3e6937665dab7fa6af3a41c38f6173(s, config);
}

}


