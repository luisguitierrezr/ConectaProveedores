using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEM_EM_MORecord
public class RESTRC_473d44d37727fbe7aa021ec19b49122c : AbstractRESTStructure<RC_473d44d37727fbe7aa021ec19b49122c> {
[JsonProperty("PI_ITEM_EM_MO")]
public ssConectaProveedores.RestRecords.RESTST_b66fb52d7e61909cfa3b37d2fa32ed69Structure AttrPI_ITEM_EM_MO;

public RESTRC_473d44d37727fbe7aa021ec19b49122c() { }

public RESTRC_473d44d37727fbe7aa021ec19b49122c (RC_473d44d37727fbe7aa021ec19b49122c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_ITEM_EM_MO = ConvertToRestWithoutDefaults(s.ssSTPI_ITEM_EM_MO, new ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure(), ssConectaProveedores.RestRecords.RESTST_b66fb52d7e61909cfa3b37d2fa32ed69Structure.FromStructure, config);
  } else {
AttrPI_ITEM_EM_MO = ssConectaProveedores.RestRecords.RESTST_b66fb52d7e61909cfa3b37d2fa32ed69Structure.FromStructure(s.ssSTPI_ITEM_EM_MO, config);
  }
}

public static RC_473d44d37727fbe7aa021ec19b49122c ToStructure(ssConectaProveedores.RestRecords.RESTRC_473d44d37727fbe7aa021ec19b49122c obj) { 
  RC_473d44d37727fbe7aa021ec19b49122c s = new RC_473d44d37727fbe7aa021ec19b49122c();
  if(obj != null) {
  s.ssSTPI_ITEM_EM_MO = ssConectaProveedores.RestRecords.RESTST_b66fb52d7e61909cfa3b37d2fa32ed69Structure.ToStructure(obj.AttrPI_ITEM_EM_MO);
  }
  return s;
}

public static Func<RC_473d44d37727fbe7aa021ec19b49122c, ssConectaProveedores.RestRecords.RESTRC_473d44d37727fbe7aa021ec19b49122c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_473d44d37727fbe7aa021ec19b49122c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_473d44d37727fbe7aa021ec19b49122c FromStructure(RC_473d44d37727fbe7aa021ec19b49122c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_473d44d37727fbe7aa021ec19b49122c(s, config);
}

}


