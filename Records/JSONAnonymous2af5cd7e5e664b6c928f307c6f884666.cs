using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// User_PreferencesRecord
public class JSONRC_8a18f13d5e920f1ccdf5a8a3416c783c : AbstractRESTStructure<RC_8a18f13d5e920f1ccdf5a8a3416c783c> {
[JsonProperty("User_Preferences")]
[JsonPropertyName("User_Preferences")]
public ssConectaProveedores.RestRecords.JSONEN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord AttrUser_Preferences;

public JSONRC_8a18f13d5e920f1ccdf5a8a3416c783c() { }

public JSONRC_8a18f13d5e920f1ccdf5a8a3416c783c (RC_8a18f13d5e920f1ccdf5a8a3416c783c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser_Preferences = ConvertToRestWithoutDefaults(s.ssENUser_Preferences, new EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord.FromStructure, config);
  } else {
AttrUser_Preferences = ssConectaProveedores.RestRecords.JSONEN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord.FromStructure(s.ssENUser_Preferences, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8a18f13d5e920f1ccdf5a8a3416c783c, RC_8a18f13d5e920f1ccdf5a8a3416c783c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8a18f13d5e920f1ccdf5a8a3416c783c s) => ToStructure(s, config);
}
public static RC_8a18f13d5e920f1ccdf5a8a3416c783c ToStructure(ssConectaProveedores.RestRecords.JSONRC_8a18f13d5e920f1ccdf5a8a3416c783c obj, IBehaviorsConfiguration config) { 
  RC_8a18f13d5e920f1ccdf5a8a3416c783c s = new RC_8a18f13d5e920f1ccdf5a8a3416c783c();
  if(obj != null) {
  s.ssENUser_Preferences = ssConectaProveedores.RestRecords.JSONEN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord.ToStructure(obj.AttrUser_Preferences, config);
  }
  return s;
}

public static Func<RC_8a18f13d5e920f1ccdf5a8a3416c783c, ssConectaProveedores.RestRecords.JSONRC_8a18f13d5e920f1ccdf5a8a3416c783c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8a18f13d5e920f1ccdf5a8a3416c783c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8a18f13d5e920f1ccdf5a8a3416c783c FromStructure(RC_8a18f13d5e920f1ccdf5a8a3416c783c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8a18f13d5e920f1ccdf5a8a3416c783c(s, config);
}

}


