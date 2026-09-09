using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CustomSettingsRecord
public class RESTRC_4cea68d4a46fbd7372d4f181e98bfcdb : AbstractRESTStructure<RC_4cea68d4a46fbd7372d4f181e98bfcdb> {
[JsonProperty("CustomSettings")]
public ssConectaProveedores.RestRecords.RESTEN_2598b425876f6271c300c0879185e230EntityRecord AttrCustomSettings;

public RESTRC_4cea68d4a46fbd7372d4f181e98bfcdb() { }

public RESTRC_4cea68d4a46fbd7372d4f181e98bfcdb (RC_4cea68d4a46fbd7372d4f181e98bfcdb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCustomSettings = ConvertToRestWithoutDefaults(s.ssENCustomSettings, new EN_2598b425876f6271c300c0879185e230EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_2598b425876f6271c300c0879185e230EntityRecord.FromStructure, config);
  } else {
AttrCustomSettings = ssConectaProveedores.RestRecords.RESTEN_2598b425876f6271c300c0879185e230EntityRecord.FromStructure(s.ssENCustomSettings, config);
  }
}

public static RC_4cea68d4a46fbd7372d4f181e98bfcdb ToStructure(ssConectaProveedores.RestRecords.RESTRC_4cea68d4a46fbd7372d4f181e98bfcdb obj) { 
  RC_4cea68d4a46fbd7372d4f181e98bfcdb s = new RC_4cea68d4a46fbd7372d4f181e98bfcdb();
  if(obj != null) {
  s.ssENCustomSettings = ssConectaProveedores.RestRecords.RESTEN_2598b425876f6271c300c0879185e230EntityRecord.ToStructure(obj.AttrCustomSettings);
  }
  return s;
}

public static Func<RC_4cea68d4a46fbd7372d4f181e98bfcdb, ssConectaProveedores.RestRecords.RESTRC_4cea68d4a46fbd7372d4f181e98bfcdb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4cea68d4a46fbd7372d4f181e98bfcdb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_4cea68d4a46fbd7372d4f181e98bfcdb FromStructure(RC_4cea68d4a46fbd7372d4f181e98bfcdb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_4cea68d4a46fbd7372d4f181e98bfcdb(s, config);
}

}


