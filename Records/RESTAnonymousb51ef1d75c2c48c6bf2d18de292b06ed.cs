using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZTC_GENERA_POLIZA_GRALReqRecord
public class RESTRC_4559aa81984c9ba312e6505b4626e6df : AbstractRESTStructure<RC_4559aa81984c9ba312e6505b4626e6df> {
[JsonProperty("ZTC_GENERA_POLIZA_GRALReq")]
public ssConectaProveedores.RestRecords.RESTST_7d9ca3de97b3b074755ccb195cd9efb0Structure AttrZTC_GENERA_POLIZA_GRALReq;

public RESTRC_4559aa81984c9ba312e6505b4626e6df() { }

public RESTRC_4559aa81984c9ba312e6505b4626e6df (RC_4559aa81984c9ba312e6505b4626e6df s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZTC_GENERA_POLIZA_GRALReq = ConvertToRestWithoutDefaults(s.ssSTZTC_GENERA_POLIZA_GRALReq, new ST_7d9ca3de97b3b074755ccb195cd9efb0Structure(), ssConectaProveedores.RestRecords.RESTST_7d9ca3de97b3b074755ccb195cd9efb0Structure.FromStructure, config);
  } else {
AttrZTC_GENERA_POLIZA_GRALReq = ssConectaProveedores.RestRecords.RESTST_7d9ca3de97b3b074755ccb195cd9efb0Structure.FromStructure(s.ssSTZTC_GENERA_POLIZA_GRALReq, config);
  }
}

public static RC_4559aa81984c9ba312e6505b4626e6df ToStructure(ssConectaProveedores.RestRecords.RESTRC_4559aa81984c9ba312e6505b4626e6df obj) { 
  RC_4559aa81984c9ba312e6505b4626e6df s = new RC_4559aa81984c9ba312e6505b4626e6df();
  if(obj != null) {
  s.ssSTZTC_GENERA_POLIZA_GRALReq = ssConectaProveedores.RestRecords.RESTST_7d9ca3de97b3b074755ccb195cd9efb0Structure.ToStructure(obj.AttrZTC_GENERA_POLIZA_GRALReq);
  }
  return s;
}

public static Func<RC_4559aa81984c9ba312e6505b4626e6df, ssConectaProveedores.RestRecords.RESTRC_4559aa81984c9ba312e6505b4626e6df> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4559aa81984c9ba312e6505b4626e6df s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_4559aa81984c9ba312e6505b4626e6df FromStructure(RC_4559aa81984c9ba312e6505b4626e6df s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_4559aa81984c9ba312e6505b4626e6df(s, config);
}

}


