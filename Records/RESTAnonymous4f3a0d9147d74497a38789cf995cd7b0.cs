using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEM_SMRecord
public class RESTRC_d2ad758a70b2b40a58bde012aa28cd97 : AbstractRESTStructure<RC_d2ad758a70b2b40a58bde012aa28cd97> {
[JsonProperty("PI_ITEM_SM")]
public ssConectaProveedores.RestRecords.RESTST_e676179583470b305e615630acee7039Structure AttrPI_ITEM_SM;

public RESTRC_d2ad758a70b2b40a58bde012aa28cd97() { }

public RESTRC_d2ad758a70b2b40a58bde012aa28cd97 (RC_d2ad758a70b2b40a58bde012aa28cd97 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_ITEM_SM = ConvertToRestWithoutDefaults(s.ssSTPI_ITEM_SM, new ST_e676179583470b305e615630acee7039Structure(), ssConectaProveedores.RestRecords.RESTST_e676179583470b305e615630acee7039Structure.FromStructure, config);
  } else {
AttrPI_ITEM_SM = ssConectaProveedores.RestRecords.RESTST_e676179583470b305e615630acee7039Structure.FromStructure(s.ssSTPI_ITEM_SM, config);
  }
}

public static RC_d2ad758a70b2b40a58bde012aa28cd97 ToStructure(ssConectaProveedores.RestRecords.RESTRC_d2ad758a70b2b40a58bde012aa28cd97 obj) { 
  RC_d2ad758a70b2b40a58bde012aa28cd97 s = new RC_d2ad758a70b2b40a58bde012aa28cd97();
  if(obj != null) {
  s.ssSTPI_ITEM_SM = ssConectaProveedores.RestRecords.RESTST_e676179583470b305e615630acee7039Structure.ToStructure(obj.AttrPI_ITEM_SM);
  }
  return s;
}

public static Func<RC_d2ad758a70b2b40a58bde012aa28cd97, ssConectaProveedores.RestRecords.RESTRC_d2ad758a70b2b40a58bde012aa28cd97> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d2ad758a70b2b40a58bde012aa28cd97 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d2ad758a70b2b40a58bde012aa28cd97 FromStructure(RC_d2ad758a70b2b40a58bde012aa28cd97 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d2ad758a70b2b40a58bde012aa28cd97(s, config);
}

}


