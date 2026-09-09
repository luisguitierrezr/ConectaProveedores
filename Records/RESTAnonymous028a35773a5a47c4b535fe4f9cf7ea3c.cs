using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OriginRecord
public class RESTRC_36c38bc61b6c1577adb85f09b017c138 : AbstractRESTStructure<RC_36c38bc61b6c1577adb85f09b017c138> {
[JsonProperty("Origin")]
public ssConectaProveedores.RestRecords.RESTEN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord AttrOrigin;

public RESTRC_36c38bc61b6c1577adb85f09b017c138() { }

public RESTRC_36c38bc61b6c1577adb85f09b017c138 (RC_36c38bc61b6c1577adb85f09b017c138 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrigin = ConvertToRestWithoutDefaults(s.ssENOrigin, new EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord.FromStructure, config);
  } else {
AttrOrigin = ssConectaProveedores.RestRecords.RESTEN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord.FromStructure(s.ssENOrigin, config);
  }
}

public static RC_36c38bc61b6c1577adb85f09b017c138 ToStructure(ssConectaProveedores.RestRecords.RESTRC_36c38bc61b6c1577adb85f09b017c138 obj) { 
  RC_36c38bc61b6c1577adb85f09b017c138 s = new RC_36c38bc61b6c1577adb85f09b017c138();
  if(obj != null) {
  s.ssENOrigin = ssConectaProveedores.RestRecords.RESTEN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord.ToStructure(obj.AttrOrigin);
  }
  return s;
}

public static Func<RC_36c38bc61b6c1577adb85f09b017c138, ssConectaProveedores.RestRecords.RESTRC_36c38bc61b6c1577adb85f09b017c138> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_36c38bc61b6c1577adb85f09b017c138 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_36c38bc61b6c1577adb85f09b017c138 FromStructure(RC_36c38bc61b6c1577adb85f09b017c138 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_36c38bc61b6c1577adb85f09b017c138(s, config);
}

}


