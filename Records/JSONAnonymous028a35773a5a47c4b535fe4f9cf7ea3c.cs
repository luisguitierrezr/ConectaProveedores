using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OriginRecord
public class JSONRC_36c38bc61b6c1577adb85f09b017c138 : AbstractRESTStructure<RC_36c38bc61b6c1577adb85f09b017c138> {
[JsonProperty("Origin")]
[JsonPropertyName("Origin")]
public ssConectaProveedores.RestRecords.JSONEN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord AttrOrigin;

public JSONRC_36c38bc61b6c1577adb85f09b017c138() { }

public JSONRC_36c38bc61b6c1577adb85f09b017c138 (RC_36c38bc61b6c1577adb85f09b017c138 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrigin = ConvertToRestWithoutDefaults(s.ssENOrigin, new EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord.FromStructure, config);
  } else {
AttrOrigin = ssConectaProveedores.RestRecords.JSONEN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord.FromStructure(s.ssENOrigin, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_36c38bc61b6c1577adb85f09b017c138, RC_36c38bc61b6c1577adb85f09b017c138> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_36c38bc61b6c1577adb85f09b017c138 s) => ToStructure(s, config);
}
public static RC_36c38bc61b6c1577adb85f09b017c138 ToStructure(ssConectaProveedores.RestRecords.JSONRC_36c38bc61b6c1577adb85f09b017c138 obj, IBehaviorsConfiguration config) { 
  RC_36c38bc61b6c1577adb85f09b017c138 s = new RC_36c38bc61b6c1577adb85f09b017c138();
  if(obj != null) {
  s.ssENOrigin = ssConectaProveedores.RestRecords.JSONEN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord.ToStructure(obj.AttrOrigin, config);
  }
  return s;
}

public static Func<RC_36c38bc61b6c1577adb85f09b017c138, ssConectaProveedores.RestRecords.JSONRC_36c38bc61b6c1577adb85f09b017c138> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_36c38bc61b6c1577adb85f09b017c138 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_36c38bc61b6c1577adb85f09b017c138 FromStructure(RC_36c38bc61b6c1577adb85f09b017c138 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_36c38bc61b6c1577adb85f09b017c138(s, config);
}

}


