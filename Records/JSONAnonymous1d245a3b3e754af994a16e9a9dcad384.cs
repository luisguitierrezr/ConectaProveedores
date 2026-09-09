using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioExtendedRecord
public class JSONRC_ad92b2c217228db10c71baf90a615ea5 : AbstractRESTStructure<RC_ad92b2c217228db10c71baf90a615ea5> {
[JsonProperty("FolioExtended")]
[JsonPropertyName("FolioExtended")]
public ssConectaProveedores.RestRecords.JSONEN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord AttrFolioExtended;

public JSONRC_ad92b2c217228db10c71baf90a615ea5() { }

public JSONRC_ad92b2c217228db10c71baf90a615ea5 (RC_ad92b2c217228db10c71baf90a615ea5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioExtended = ConvertToRestWithoutDefaults(s.ssENFolioExtended, new EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord.FromStructure, config);
  } else {
AttrFolioExtended = ssConectaProveedores.RestRecords.JSONEN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord.FromStructure(s.ssENFolioExtended, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_ad92b2c217228db10c71baf90a615ea5, RC_ad92b2c217228db10c71baf90a615ea5> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_ad92b2c217228db10c71baf90a615ea5 s) => ToStructure(s, config);
}
public static RC_ad92b2c217228db10c71baf90a615ea5 ToStructure(ssConectaProveedores.RestRecords.JSONRC_ad92b2c217228db10c71baf90a615ea5 obj, IBehaviorsConfiguration config) { 
  RC_ad92b2c217228db10c71baf90a615ea5 s = new RC_ad92b2c217228db10c71baf90a615ea5();
  if(obj != null) {
  s.ssENFolioExtended = ssConectaProveedores.RestRecords.JSONEN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord.ToStructure(obj.AttrFolioExtended, config);
  }
  return s;
}

public static Func<RC_ad92b2c217228db10c71baf90a615ea5, ssConectaProveedores.RestRecords.JSONRC_ad92b2c217228db10c71baf90a615ea5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ad92b2c217228db10c71baf90a615ea5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_ad92b2c217228db10c71baf90a615ea5 FromStructure(RC_ad92b2c217228db10c71baf90a615ea5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_ad92b2c217228db10c71baf90a615ea5(s, config);
}

}


