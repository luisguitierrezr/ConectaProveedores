using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AIContentTypeRecord
public class JSONRC_331ddee75740189a809db62f762472bd : AbstractRESTStructure<RC_331ddee75740189a809db62f762472bd> {
[JsonProperty("AIContentType")]
[JsonPropertyName("AIContentType")]
public ssConectaProveedores.RestRecords.JSONENAIContentTypeEntityRecord AttrAIContentType;

public JSONRC_331ddee75740189a809db62f762472bd() { }

public JSONRC_331ddee75740189a809db62f762472bd (RC_331ddee75740189a809db62f762472bd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIContentType = ConvertToRestWithoutDefaults(s.ssENAIContentType, new ENAIContentTypeEntityRecord(), ssConectaProveedores.RestRecords.JSONENAIContentTypeEntityRecord.FromStructure, config);
  } else {
AttrAIContentType = ssConectaProveedores.RestRecords.JSONENAIContentTypeEntityRecord.FromStructure(s.ssENAIContentType, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_331ddee75740189a809db62f762472bd, RC_331ddee75740189a809db62f762472bd> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_331ddee75740189a809db62f762472bd s) => ToStructure(s, config);
}
public static RC_331ddee75740189a809db62f762472bd ToStructure(ssConectaProveedores.RestRecords.JSONRC_331ddee75740189a809db62f762472bd obj, IBehaviorsConfiguration config) { 
  RC_331ddee75740189a809db62f762472bd s = new RC_331ddee75740189a809db62f762472bd();
  if(obj != null) {
  s.ssENAIContentType = ssConectaProveedores.RestRecords.JSONENAIContentTypeEntityRecord.ToStructure(obj.AttrAIContentType, config);
  }
  return s;
}

public static Func<RC_331ddee75740189a809db62f762472bd, ssConectaProveedores.RestRecords.JSONRC_331ddee75740189a809db62f762472bd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_331ddee75740189a809db62f762472bd s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_331ddee75740189a809db62f762472bd FromStructure(RC_331ddee75740189a809db62f762472bd s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_331ddee75740189a809db62f762472bd(s, config);
}

}


