using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CustomSettingsRecord
public class JSONRC_4cea68d4a46fbd7372d4f181e98bfcdb : AbstractRESTStructure<RC_4cea68d4a46fbd7372d4f181e98bfcdb> {
[JsonProperty("CustomSettings")]
[JsonPropertyName("CustomSettings")]
public ssConectaProveedores.RestRecords.JSONEN_2598b425876f6271c300c0879185e230EntityRecord AttrCustomSettings;

public JSONRC_4cea68d4a46fbd7372d4f181e98bfcdb() { }

public JSONRC_4cea68d4a46fbd7372d4f181e98bfcdb (RC_4cea68d4a46fbd7372d4f181e98bfcdb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCustomSettings = ConvertToRestWithoutDefaults(s.ssENCustomSettings, new EN_2598b425876f6271c300c0879185e230EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_2598b425876f6271c300c0879185e230EntityRecord.FromStructure, config);
  } else {
AttrCustomSettings = ssConectaProveedores.RestRecords.JSONEN_2598b425876f6271c300c0879185e230EntityRecord.FromStructure(s.ssENCustomSettings, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_4cea68d4a46fbd7372d4f181e98bfcdb, RC_4cea68d4a46fbd7372d4f181e98bfcdb> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_4cea68d4a46fbd7372d4f181e98bfcdb s) => ToStructure(s, config);
}
public static RC_4cea68d4a46fbd7372d4f181e98bfcdb ToStructure(ssConectaProveedores.RestRecords.JSONRC_4cea68d4a46fbd7372d4f181e98bfcdb obj, IBehaviorsConfiguration config) { 
  RC_4cea68d4a46fbd7372d4f181e98bfcdb s = new RC_4cea68d4a46fbd7372d4f181e98bfcdb();
  if(obj != null) {
  s.ssENCustomSettings = ssConectaProveedores.RestRecords.JSONEN_2598b425876f6271c300c0879185e230EntityRecord.ToStructure(obj.AttrCustomSettings, config);
  }
  return s;
}

public static Func<RC_4cea68d4a46fbd7372d4f181e98bfcdb, ssConectaProveedores.RestRecords.JSONRC_4cea68d4a46fbd7372d4f181e98bfcdb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4cea68d4a46fbd7372d4f181e98bfcdb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_4cea68d4a46fbd7372d4f181e98bfcdb FromStructure(RC_4cea68d4a46fbd7372d4f181e98bfcdb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_4cea68d4a46fbd7372d4f181e98bfcdb(s, config);
}

}


