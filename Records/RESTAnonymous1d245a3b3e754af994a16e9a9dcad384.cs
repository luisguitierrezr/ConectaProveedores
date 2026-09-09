using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioExtendedRecord
public class RESTRC_ad92b2c217228db10c71baf90a615ea5 : AbstractRESTStructure<RC_ad92b2c217228db10c71baf90a615ea5> {
[JsonProperty("FolioExtended")]
public ssConectaProveedores.RestRecords.RESTEN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord AttrFolioExtended;

public RESTRC_ad92b2c217228db10c71baf90a615ea5() { }

public RESTRC_ad92b2c217228db10c71baf90a615ea5 (RC_ad92b2c217228db10c71baf90a615ea5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioExtended = ConvertToRestWithoutDefaults(s.ssENFolioExtended, new EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord.FromStructure, config);
  } else {
AttrFolioExtended = ssConectaProveedores.RestRecords.RESTEN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord.FromStructure(s.ssENFolioExtended, config);
  }
}

public static RC_ad92b2c217228db10c71baf90a615ea5 ToStructure(ssConectaProveedores.RestRecords.RESTRC_ad92b2c217228db10c71baf90a615ea5 obj) { 
  RC_ad92b2c217228db10c71baf90a615ea5 s = new RC_ad92b2c217228db10c71baf90a615ea5();
  if(obj != null) {
  s.ssENFolioExtended = ssConectaProveedores.RestRecords.RESTEN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord.ToStructure(obj.AttrFolioExtended);
  }
  return s;
}

public static Func<RC_ad92b2c217228db10c71baf90a615ea5, ssConectaProveedores.RestRecords.RESTRC_ad92b2c217228db10c71baf90a615ea5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ad92b2c217228db10c71baf90a615ea5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_ad92b2c217228db10c71baf90a615ea5 FromStructure(RC_ad92b2c217228db10c71baf90a615ea5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_ad92b2c217228db10c71baf90a615ea5(s, config);
}

}


