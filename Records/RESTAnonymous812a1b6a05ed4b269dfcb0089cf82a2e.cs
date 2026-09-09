using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PostCarganovimResponseWrapperRecord
public class RESTRC_2f11367ef093a7d6654be614b79c6c4b : AbstractRESTStructure<RC_2f11367ef093a7d6654be614b79c6c4b> {
[JsonProperty("PostCarganovimResponseWrapper")]
public ssConectaProveedores.RestRecords.RESTST_6636acdf9f49922edfd43b4865475460Structure AttrPostCarganovimResponseWrapper;

public RESTRC_2f11367ef093a7d6654be614b79c6c4b() { }

public RESTRC_2f11367ef093a7d6654be614b79c6c4b (RC_2f11367ef093a7d6654be614b79c6c4b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPostCarganovimResponseWrapper = ConvertToRestWithoutDefaults(s.ssSTPostCarganovimResponseWrapper, new ST_6636acdf9f49922edfd43b4865475460Structure(), ssConectaProveedores.RestRecords.RESTST_6636acdf9f49922edfd43b4865475460Structure.FromStructure, config);
  } else {
AttrPostCarganovimResponseWrapper = ssConectaProveedores.RestRecords.RESTST_6636acdf9f49922edfd43b4865475460Structure.FromStructure(s.ssSTPostCarganovimResponseWrapper, config);
  }
}

public static RC_2f11367ef093a7d6654be614b79c6c4b ToStructure(ssConectaProveedores.RestRecords.RESTRC_2f11367ef093a7d6654be614b79c6c4b obj) { 
  RC_2f11367ef093a7d6654be614b79c6c4b s = new RC_2f11367ef093a7d6654be614b79c6c4b();
  if(obj != null) {
  s.ssSTPostCarganovimResponseWrapper = ssConectaProveedores.RestRecords.RESTST_6636acdf9f49922edfd43b4865475460Structure.ToStructure(obj.AttrPostCarganovimResponseWrapper);
  }
  return s;
}

public static Func<RC_2f11367ef093a7d6654be614b79c6c4b, ssConectaProveedores.RestRecords.RESTRC_2f11367ef093a7d6654be614b79c6c4b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2f11367ef093a7d6654be614b79c6c4b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_2f11367ef093a7d6654be614b79c6c4b FromStructure(RC_2f11367ef093a7d6654be614b79c6c4b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_2f11367ef093a7d6654be614b79c6c4b(s, config);
}

}


