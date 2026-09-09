using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OptionRecord
public class RESTRC_df27c8a3fd58b3a0547b138755710019 : AbstractRESTStructure<RC_df27c8a3fd58b3a0547b138755710019> {
[JsonProperty("Option")]
public string AttrOption;

public RESTRC_df27c8a3fd58b3a0547b138755710019() { }

public RESTRC_df27c8a3fd58b3a0547b138755710019 (RC_df27c8a3fd58b3a0547b138755710019 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOption = ConvertToRestWithoutDefaults(s.ssOption, "");
  } else {
AttrOption = s.ssOption;
  }
}

public static RC_df27c8a3fd58b3a0547b138755710019 ToStructure(ssConectaProveedores.RestRecords.RESTRC_df27c8a3fd58b3a0547b138755710019 obj) { 
  RC_df27c8a3fd58b3a0547b138755710019 s = new RC_df27c8a3fd58b3a0547b138755710019();
  if(obj != null) {
  s.ssOption = obj.AttrOption == null ? "" : obj.AttrOption;
  }
  return s;
}

public static Func<RC_df27c8a3fd58b3a0547b138755710019, ssConectaProveedores.RestRecords.RESTRC_df27c8a3fd58b3a0547b138755710019> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_df27c8a3fd58b3a0547b138755710019 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_df27c8a3fd58b3a0547b138755710019 FromStructure(RC_df27c8a3fd58b3a0547b138755710019 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_df27c8a3fd58b3a0547b138755710019(s, config);
}

}


