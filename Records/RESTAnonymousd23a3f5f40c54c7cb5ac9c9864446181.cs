using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AIContentTypeRecord
public class RESTRC_331ddee75740189a809db62f762472bd : AbstractRESTStructure<RC_331ddee75740189a809db62f762472bd> {
[JsonProperty("AIContentType")]
public ssConectaProveedores.RestRecords.RESTENAIContentTypeEntityRecord AttrAIContentType;

public RESTRC_331ddee75740189a809db62f762472bd() { }

public RESTRC_331ddee75740189a809db62f762472bd (RC_331ddee75740189a809db62f762472bd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIContentType = ConvertToRestWithoutDefaults(s.ssENAIContentType, new ENAIContentTypeEntityRecord(), ssConectaProveedores.RestRecords.RESTENAIContentTypeEntityRecord.FromStructure, config);
  } else {
AttrAIContentType = ssConectaProveedores.RestRecords.RESTENAIContentTypeEntityRecord.FromStructure(s.ssENAIContentType, config);
  }
}

public static RC_331ddee75740189a809db62f762472bd ToStructure(ssConectaProveedores.RestRecords.RESTRC_331ddee75740189a809db62f762472bd obj) { 
  RC_331ddee75740189a809db62f762472bd s = new RC_331ddee75740189a809db62f762472bd();
  if(obj != null) {
  s.ssENAIContentType = ssConectaProveedores.RestRecords.RESTENAIContentTypeEntityRecord.ToStructure(obj.AttrAIContentType);
  }
  return s;
}

public static Func<RC_331ddee75740189a809db62f762472bd, ssConectaProveedores.RestRecords.RESTRC_331ddee75740189a809db62f762472bd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_331ddee75740189a809db62f762472bd s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_331ddee75740189a809db62f762472bd FromStructure(RC_331ddee75740189a809db62f762472bd s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_331ddee75740189a809db62f762472bd(s, config);
}

}


