using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrientationRecord
public class JSONRC_3ba1d238c8e0f0c3e875fb37f0381cc6 : AbstractRESTStructure<RC_3ba1d238c8e0f0c3e875fb37f0381cc6> {
[JsonProperty("Orientation")]
[JsonPropertyName("Orientation")]
public ssConectaProveedores.RestRecords.JSONEN_8d4f783227026ce93d50126c7f028443EntityRecord AttrOrientation;

public JSONRC_3ba1d238c8e0f0c3e875fb37f0381cc6() { }

public JSONRC_3ba1d238c8e0f0c3e875fb37f0381cc6 (RC_3ba1d238c8e0f0c3e875fb37f0381cc6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrientation = ConvertToRestWithoutDefaults(s.ssENOrientation, new EN_8d4f783227026ce93d50126c7f028443EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_8d4f783227026ce93d50126c7f028443EntityRecord.FromStructure, config);
  } else {
AttrOrientation = ssConectaProveedores.RestRecords.JSONEN_8d4f783227026ce93d50126c7f028443EntityRecord.FromStructure(s.ssENOrientation, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_3ba1d238c8e0f0c3e875fb37f0381cc6, RC_3ba1d238c8e0f0c3e875fb37f0381cc6> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_3ba1d238c8e0f0c3e875fb37f0381cc6 s) => ToStructure(s, config);
}
public static RC_3ba1d238c8e0f0c3e875fb37f0381cc6 ToStructure(ssConectaProveedores.RestRecords.JSONRC_3ba1d238c8e0f0c3e875fb37f0381cc6 obj, IBehaviorsConfiguration config) { 
  RC_3ba1d238c8e0f0c3e875fb37f0381cc6 s = new RC_3ba1d238c8e0f0c3e875fb37f0381cc6();
  if(obj != null) {
  s.ssENOrientation = ssConectaProveedores.RestRecords.JSONEN_8d4f783227026ce93d50126c7f028443EntityRecord.ToStructure(obj.AttrOrientation, config);
  }
  return s;
}

public static Func<RC_3ba1d238c8e0f0c3e875fb37f0381cc6, ssConectaProveedores.RestRecords.JSONRC_3ba1d238c8e0f0c3e875fb37f0381cc6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3ba1d238c8e0f0c3e875fb37f0381cc6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_3ba1d238c8e0f0c3e875fb37f0381cc6 FromStructure(RC_3ba1d238c8e0f0c3e875fb37f0381cc6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_3ba1d238c8e0f0c3e875fb37f0381cc6(s, config);
}

}


