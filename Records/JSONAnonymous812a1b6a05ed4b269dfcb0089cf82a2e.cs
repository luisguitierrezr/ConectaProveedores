using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PostCarganovimResponseWrapperRecord
public class JSONRC_2f11367ef093a7d6654be614b79c6c4b : AbstractRESTStructure<RC_2f11367ef093a7d6654be614b79c6c4b> {
[JsonProperty("PostCarganovimResponseWrapper")]
[JsonPropertyName("PostCarganovimResponseWrapper")]
public ssConectaProveedores.RestRecords.JSONST_6636acdf9f49922edfd43b4865475460Structure AttrPostCarganovimResponseWrapper;

public JSONRC_2f11367ef093a7d6654be614b79c6c4b() { }

public JSONRC_2f11367ef093a7d6654be614b79c6c4b (RC_2f11367ef093a7d6654be614b79c6c4b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPostCarganovimResponseWrapper = ConvertToRestWithoutDefaults(s.ssSTPostCarganovimResponseWrapper, new ST_6636acdf9f49922edfd43b4865475460Structure(), ssConectaProveedores.RestRecords.JSONST_6636acdf9f49922edfd43b4865475460Structure.FromStructure, config);
  } else {
AttrPostCarganovimResponseWrapper = ssConectaProveedores.RestRecords.JSONST_6636acdf9f49922edfd43b4865475460Structure.FromStructure(s.ssSTPostCarganovimResponseWrapper, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_2f11367ef093a7d6654be614b79c6c4b, RC_2f11367ef093a7d6654be614b79c6c4b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_2f11367ef093a7d6654be614b79c6c4b s) => ToStructure(s, config);
}
public static RC_2f11367ef093a7d6654be614b79c6c4b ToStructure(ssConectaProveedores.RestRecords.JSONRC_2f11367ef093a7d6654be614b79c6c4b obj, IBehaviorsConfiguration config) { 
  RC_2f11367ef093a7d6654be614b79c6c4b s = new RC_2f11367ef093a7d6654be614b79c6c4b();
  if(obj != null) {
  s.ssSTPostCarganovimResponseWrapper = ssConectaProveedores.RestRecords.JSONST_6636acdf9f49922edfd43b4865475460Structure.ToStructure(obj.AttrPostCarganovimResponseWrapper, config);
  }
  return s;
}

public static Func<RC_2f11367ef093a7d6654be614b79c6c4b, ssConectaProveedores.RestRecords.JSONRC_2f11367ef093a7d6654be614b79c6c4b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2f11367ef093a7d6654be614b79c6c4b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_2f11367ef093a7d6654be614b79c6c4b FromStructure(RC_2f11367ef093a7d6654be614b79c6c4b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_2f11367ef093a7d6654be614b79c6c4b(s, config);
}

}


