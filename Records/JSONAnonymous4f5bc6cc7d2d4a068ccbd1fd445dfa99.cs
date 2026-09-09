using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PostCarganovimRequestWrapperRecord
public class JSONRC_0578b8d4fa0f1d821c9958cb37db5e7d : AbstractRESTStructure<RC_0578b8d4fa0f1d821c9958cb37db5e7d> {
[JsonProperty("PostCarganovimRequestWrapper")]
[JsonPropertyName("PostCarganovimRequestWrapper")]
public ssConectaProveedores.RestRecords.JSONST_9b7f85dc32c7c81ceef0a0963388237dStructure AttrPostCarganovimRequestWrapper;

public JSONRC_0578b8d4fa0f1d821c9958cb37db5e7d() { }

public JSONRC_0578b8d4fa0f1d821c9958cb37db5e7d (RC_0578b8d4fa0f1d821c9958cb37db5e7d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPostCarganovimRequestWrapper = ConvertToRestWithoutDefaults(s.ssSTPostCarganovimRequestWrapper, new ST_9b7f85dc32c7c81ceef0a0963388237dStructure(), ssConectaProveedores.RestRecords.JSONST_9b7f85dc32c7c81ceef0a0963388237dStructure.FromStructure, config);
  } else {
AttrPostCarganovimRequestWrapper = ssConectaProveedores.RestRecords.JSONST_9b7f85dc32c7c81ceef0a0963388237dStructure.FromStructure(s.ssSTPostCarganovimRequestWrapper, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_0578b8d4fa0f1d821c9958cb37db5e7d, RC_0578b8d4fa0f1d821c9958cb37db5e7d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_0578b8d4fa0f1d821c9958cb37db5e7d s) => ToStructure(s, config);
}
public static RC_0578b8d4fa0f1d821c9958cb37db5e7d ToStructure(ssConectaProveedores.RestRecords.JSONRC_0578b8d4fa0f1d821c9958cb37db5e7d obj, IBehaviorsConfiguration config) { 
  RC_0578b8d4fa0f1d821c9958cb37db5e7d s = new RC_0578b8d4fa0f1d821c9958cb37db5e7d();
  if(obj != null) {
  s.ssSTPostCarganovimRequestWrapper = ssConectaProveedores.RestRecords.JSONST_9b7f85dc32c7c81ceef0a0963388237dStructure.ToStructure(obj.AttrPostCarganovimRequestWrapper, config);
  }
  return s;
}

public static Func<RC_0578b8d4fa0f1d821c9958cb37db5e7d, ssConectaProveedores.RestRecords.JSONRC_0578b8d4fa0f1d821c9958cb37db5e7d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0578b8d4fa0f1d821c9958cb37db5e7d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_0578b8d4fa0f1d821c9958cb37db5e7d FromStructure(RC_0578b8d4fa0f1d821c9958cb37db5e7d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_0578b8d4fa0f1d821c9958cb37db5e7d(s, config);
}

}


