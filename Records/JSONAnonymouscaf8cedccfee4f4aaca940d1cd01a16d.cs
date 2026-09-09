using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OptionRecord
public class JSONRC_df27c8a3fd58b3a0547b138755710019 : AbstractRESTStructure<RC_df27c8a3fd58b3a0547b138755710019> {
[JsonProperty("Option")]
[JsonPropertyName("Option")]
public string AttrOption;

public JSONRC_df27c8a3fd58b3a0547b138755710019() { }

public JSONRC_df27c8a3fd58b3a0547b138755710019 (RC_df27c8a3fd58b3a0547b138755710019 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOption = ConvertToRestWithoutDefaults(s.ssOption, "");
  } else {
AttrOption = s.ssOption;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_df27c8a3fd58b3a0547b138755710019, RC_df27c8a3fd58b3a0547b138755710019> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_df27c8a3fd58b3a0547b138755710019 s) => ToStructure(s, config);
}
public static RC_df27c8a3fd58b3a0547b138755710019 ToStructure(ssConectaProveedores.RestRecords.JSONRC_df27c8a3fd58b3a0547b138755710019 obj, IBehaviorsConfiguration config) { 
  RC_df27c8a3fd58b3a0547b138755710019 s = new RC_df27c8a3fd58b3a0547b138755710019();
  if(obj != null) {
  s.ssOption = obj.AttrOption == null ? "" : obj.AttrOption;
  }
  return s;
}

public static Func<RC_df27c8a3fd58b3a0547b138755710019, ssConectaProveedores.RestRecords.JSONRC_df27c8a3fd58b3a0547b138755710019> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_df27c8a3fd58b3a0547b138755710019 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_df27c8a3fd58b3a0547b138755710019 FromStructure(RC_df27c8a3fd58b3a0547b138755710019 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_df27c8a3fd58b3a0547b138755710019(s, config);
}

}


