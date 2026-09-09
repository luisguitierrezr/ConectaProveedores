using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LINESRecord
public class JSONRC_1a23e477b6ae940b541edd1112bf0a6b : AbstractRESTStructure<RC_1a23e477b6ae940b541edd1112bf0a6b> {
[JsonProperty("LINES")]
[JsonPropertyName("LINES")]
public ssConectaProveedores.RestRecords.JSONST_1ebe89bcb89e874288df8fa96ba9996fStructure AttrLINES;

public JSONRC_1a23e477b6ae940b541edd1112bf0a6b() { }

public JSONRC_1a23e477b6ae940b541edd1112bf0a6b (RC_1a23e477b6ae940b541edd1112bf0a6b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLINES = ConvertToRestWithoutDefaults(s.ssSTLINES, new ST_1ebe89bcb89e874288df8fa96ba9996fStructure(), ssConectaProveedores.RestRecords.JSONST_1ebe89bcb89e874288df8fa96ba9996fStructure.FromStructure, config);
  } else {
AttrLINES = ssConectaProveedores.RestRecords.JSONST_1ebe89bcb89e874288df8fa96ba9996fStructure.FromStructure(s.ssSTLINES, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1a23e477b6ae940b541edd1112bf0a6b, RC_1a23e477b6ae940b541edd1112bf0a6b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1a23e477b6ae940b541edd1112bf0a6b s) => ToStructure(s, config);
}
public static RC_1a23e477b6ae940b541edd1112bf0a6b ToStructure(ssConectaProveedores.RestRecords.JSONRC_1a23e477b6ae940b541edd1112bf0a6b obj, IBehaviorsConfiguration config) { 
  RC_1a23e477b6ae940b541edd1112bf0a6b s = new RC_1a23e477b6ae940b541edd1112bf0a6b();
  if(obj != null) {
  s.ssSTLINES = ssConectaProveedores.RestRecords.JSONST_1ebe89bcb89e874288df8fa96ba9996fStructure.ToStructure(obj.AttrLINES, config);
  }
  return s;
}

public static Func<RC_1a23e477b6ae940b541edd1112bf0a6b, ssConectaProveedores.RestRecords.JSONRC_1a23e477b6ae940b541edd1112bf0a6b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1a23e477b6ae940b541edd1112bf0a6b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1a23e477b6ae940b541edd1112bf0a6b FromStructure(RC_1a23e477b6ae940b541edd1112bf0a6b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1a23e477b6ae940b541edd1112bf0a6b(s, config);
}

}


