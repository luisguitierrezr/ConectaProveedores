using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrientationRecord
public class RESTRC_3ba1d238c8e0f0c3e875fb37f0381cc6 : AbstractRESTStructure<RC_3ba1d238c8e0f0c3e875fb37f0381cc6> {
[JsonProperty("Orientation")]
public ssConectaProveedores.RestRecords.RESTEN_8d4f783227026ce93d50126c7f028443EntityRecord AttrOrientation;

public RESTRC_3ba1d238c8e0f0c3e875fb37f0381cc6() { }

public RESTRC_3ba1d238c8e0f0c3e875fb37f0381cc6 (RC_3ba1d238c8e0f0c3e875fb37f0381cc6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrientation = ConvertToRestWithoutDefaults(s.ssENOrientation, new EN_8d4f783227026ce93d50126c7f028443EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_8d4f783227026ce93d50126c7f028443EntityRecord.FromStructure, config);
  } else {
AttrOrientation = ssConectaProveedores.RestRecords.RESTEN_8d4f783227026ce93d50126c7f028443EntityRecord.FromStructure(s.ssENOrientation, config);
  }
}

public static RC_3ba1d238c8e0f0c3e875fb37f0381cc6 ToStructure(ssConectaProveedores.RestRecords.RESTRC_3ba1d238c8e0f0c3e875fb37f0381cc6 obj) { 
  RC_3ba1d238c8e0f0c3e875fb37f0381cc6 s = new RC_3ba1d238c8e0f0c3e875fb37f0381cc6();
  if(obj != null) {
  s.ssENOrientation = ssConectaProveedores.RestRecords.RESTEN_8d4f783227026ce93d50126c7f028443EntityRecord.ToStructure(obj.AttrOrientation);
  }
  return s;
}

public static Func<RC_3ba1d238c8e0f0c3e875fb37f0381cc6, ssConectaProveedores.RestRecords.RESTRC_3ba1d238c8e0f0c3e875fb37f0381cc6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3ba1d238c8e0f0c3e875fb37f0381cc6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_3ba1d238c8e0f0c3e875fb37f0381cc6 FromStructure(RC_3ba1d238c8e0f0c3e875fb37f0381cc6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_3ba1d238c8e0f0c3e875fb37f0381cc6(s, config);
}

}


