using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TextRecord
public class JSONRC_4025a6e81cda8c0b3682c310ca5a8765 : AbstractRESTStructure<RC_4025a6e81cda8c0b3682c310ca5a8765> {
[JsonProperty("Text")]
[JsonPropertyName("Text")]
public ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure AttrText;

public JSONRC_4025a6e81cda8c0b3682c310ca5a8765() { }

public JSONRC_4025a6e81cda8c0b3682c310ca5a8765 (RC_4025a6e81cda8c0b3682c310ca5a8765 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrText = ConvertToRestWithoutDefaults(s.ssSTText, new ST_1f76dfa138680efe9e5e11deb3c828b8Structure(), ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure.FromStructure, config);
  } else {
AttrText = ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure.FromStructure(s.ssSTText, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_4025a6e81cda8c0b3682c310ca5a8765, RC_4025a6e81cda8c0b3682c310ca5a8765> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_4025a6e81cda8c0b3682c310ca5a8765 s) => ToStructure(s, config);
}
public static RC_4025a6e81cda8c0b3682c310ca5a8765 ToStructure(ssConectaProveedores.RestRecords.JSONRC_4025a6e81cda8c0b3682c310ca5a8765 obj, IBehaviorsConfiguration config) { 
  RC_4025a6e81cda8c0b3682c310ca5a8765 s = new RC_4025a6e81cda8c0b3682c310ca5a8765();
  if(obj != null) {
  s.ssSTText = ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure.ToStructure(obj.AttrText, config);
  }
  return s;
}

public static Func<RC_4025a6e81cda8c0b3682c310ca5a8765, ssConectaProveedores.RestRecords.JSONRC_4025a6e81cda8c0b3682c310ca5a8765> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4025a6e81cda8c0b3682c310ca5a8765 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_4025a6e81cda8c0b3682c310ca5a8765 FromStructure(RC_4025a6e81cda8c0b3682c310ca5a8765 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_4025a6e81cda8c0b3682c310ca5a8765(s, config);
}

}


