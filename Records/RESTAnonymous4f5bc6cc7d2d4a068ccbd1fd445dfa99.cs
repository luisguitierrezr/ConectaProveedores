using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PostCarganovimRequestWrapperRecord
public class RESTRC_0578b8d4fa0f1d821c9958cb37db5e7d : AbstractRESTStructure<RC_0578b8d4fa0f1d821c9958cb37db5e7d> {
[JsonProperty("PostCarganovimRequestWrapper")]
public ssConectaProveedores.RestRecords.RESTST_9b7f85dc32c7c81ceef0a0963388237dStructure AttrPostCarganovimRequestWrapper;

public RESTRC_0578b8d4fa0f1d821c9958cb37db5e7d() { }

public RESTRC_0578b8d4fa0f1d821c9958cb37db5e7d (RC_0578b8d4fa0f1d821c9958cb37db5e7d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPostCarganovimRequestWrapper = ConvertToRestWithoutDefaults(s.ssSTPostCarganovimRequestWrapper, new ST_9b7f85dc32c7c81ceef0a0963388237dStructure(), ssConectaProveedores.RestRecords.RESTST_9b7f85dc32c7c81ceef0a0963388237dStructure.FromStructure, config);
  } else {
AttrPostCarganovimRequestWrapper = ssConectaProveedores.RestRecords.RESTST_9b7f85dc32c7c81ceef0a0963388237dStructure.FromStructure(s.ssSTPostCarganovimRequestWrapper, config);
  }
}

public static RC_0578b8d4fa0f1d821c9958cb37db5e7d ToStructure(ssConectaProveedores.RestRecords.RESTRC_0578b8d4fa0f1d821c9958cb37db5e7d obj) { 
  RC_0578b8d4fa0f1d821c9958cb37db5e7d s = new RC_0578b8d4fa0f1d821c9958cb37db5e7d();
  if(obj != null) {
  s.ssSTPostCarganovimRequestWrapper = ssConectaProveedores.RestRecords.RESTST_9b7f85dc32c7c81ceef0a0963388237dStructure.ToStructure(obj.AttrPostCarganovimRequestWrapper);
  }
  return s;
}

public static Func<RC_0578b8d4fa0f1d821c9958cb37db5e7d, ssConectaProveedores.RestRecords.RESTRC_0578b8d4fa0f1d821c9958cb37db5e7d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0578b8d4fa0f1d821c9958cb37db5e7d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_0578b8d4fa0f1d821c9958cb37db5e7d FromStructure(RC_0578b8d4fa0f1d821c9958cb37db5e7d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_0578b8d4fa0f1d821c9958cb37db5e7d(s, config);
}

}


