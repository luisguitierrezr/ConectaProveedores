using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LINESRecord
public class RESTRC_1a23e477b6ae940b541edd1112bf0a6b : AbstractRESTStructure<RC_1a23e477b6ae940b541edd1112bf0a6b> {
[JsonProperty("LINES")]
public ssConectaProveedores.RestRecords.RESTST_1ebe89bcb89e874288df8fa96ba9996fStructure AttrLINES;

public RESTRC_1a23e477b6ae940b541edd1112bf0a6b() { }

public RESTRC_1a23e477b6ae940b541edd1112bf0a6b (RC_1a23e477b6ae940b541edd1112bf0a6b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLINES = ConvertToRestWithoutDefaults(s.ssSTLINES, new ST_1ebe89bcb89e874288df8fa96ba9996fStructure(), ssConectaProveedores.RestRecords.RESTST_1ebe89bcb89e874288df8fa96ba9996fStructure.FromStructure, config);
  } else {
AttrLINES = ssConectaProveedores.RestRecords.RESTST_1ebe89bcb89e874288df8fa96ba9996fStructure.FromStructure(s.ssSTLINES, config);
  }
}

public static RC_1a23e477b6ae940b541edd1112bf0a6b ToStructure(ssConectaProveedores.RestRecords.RESTRC_1a23e477b6ae940b541edd1112bf0a6b obj) { 
  RC_1a23e477b6ae940b541edd1112bf0a6b s = new RC_1a23e477b6ae940b541edd1112bf0a6b();
  if(obj != null) {
  s.ssSTLINES = ssConectaProveedores.RestRecords.RESTST_1ebe89bcb89e874288df8fa96ba9996fStructure.ToStructure(obj.AttrLINES);
  }
  return s;
}

public static Func<RC_1a23e477b6ae940b541edd1112bf0a6b, ssConectaProveedores.RestRecords.RESTRC_1a23e477b6ae940b541edd1112bf0a6b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1a23e477b6ae940b541edd1112bf0a6b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_1a23e477b6ae940b541edd1112bf0a6b FromStructure(RC_1a23e477b6ae940b541edd1112bf0a6b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_1a23e477b6ae940b541edd1112bf0a6b(s, config);
}

}


