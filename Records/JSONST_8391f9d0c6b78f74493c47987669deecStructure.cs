using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProgressBarOptionalConfigs
public class JSONST_8391f9d0c6b78f74493c47987669deecStructure : AbstractRESTStructure<ST_8391f9d0c6b78f74493c47987669deecStructure> {
[JsonProperty("Shape")]
[JsonPropertyName("Shape")]
public string AttrShape;

[JsonProperty("AnimateInitialProgress")]
[JsonPropertyName("AnimateInitialProgress")]
public bool? AttrAnimateInitialProgress;

public JSONST_8391f9d0c6b78f74493c47987669deecStructure() { }

public JSONST_8391f9d0c6b78f74493c47987669deecStructure (ST_8391f9d0c6b78f74493c47987669deecStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrShape = ConvertToRestWithoutDefaults(s.ssShape, RsseSpaceOutSystemsUI.DefaultValues.ReferenceStructure_ProgressBarOptionalConfigs_ReferenceStructureAttribute_Shape);
AttrAnimateInitialProgress = ConvertToRestWithoutDefaults(s.ssAnimateInitialProgress, true);
  } else {
AttrShape = s.ssShape;
AttrAnimateInitialProgress = (bool?) s.ssAnimateInitialProgress;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_8391f9d0c6b78f74493c47987669deecStructure, ST_8391f9d0c6b78f74493c47987669deecStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_8391f9d0c6b78f74493c47987669deecStructure s) => ToStructure(s, config);
}
public static ST_8391f9d0c6b78f74493c47987669deecStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_8391f9d0c6b78f74493c47987669deecStructure obj, IBehaviorsConfiguration config) { 
  ST_8391f9d0c6b78f74493c47987669deecStructure s = new ST_8391f9d0c6b78f74493c47987669deecStructure();
  if(obj != null) {
  s.ssShape = obj.AttrShape == null ? RsseSpaceOutSystemsUI.DefaultValues.ReferenceStructure_ProgressBarOptionalConfigs_ReferenceStructureAttribute_Shape : obj.AttrShape;
  s.ssAnimateInitialProgress = obj.AttrAnimateInitialProgress == null ? true : obj.AttrAnimateInitialProgress.Value;
  }
  return s;
}

public static Func<ST_8391f9d0c6b78f74493c47987669deecStructure, ssConectaProveedores.RestRecords.JSONST_8391f9d0c6b78f74493c47987669deecStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_8391f9d0c6b78f74493c47987669deecStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_8391f9d0c6b78f74493c47987669deecStructure FromStructure(ST_8391f9d0c6b78f74493c47987669deecStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_8391f9d0c6b78f74493c47987669deecStructure(s, config);
}

}


