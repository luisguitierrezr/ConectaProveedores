using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderListTableStructureRecord
public class RESTRC_9f2ace8f61f1c245fb0b20b98c1f76f7 : AbstractRESTStructure<RC_9f2ace8f61f1c245fb0b20b98c1f76f7> {
[JsonProperty("OrderListTableStructure")]
public ssConectaProveedores.RestRecords.RESTST_00c299856fb2c1322ea33527b24c9dd0Structure AttrOrderListTableStructure;

public RESTRC_9f2ace8f61f1c245fb0b20b98c1f76f7() { }

public RESTRC_9f2ace8f61f1c245fb0b20b98c1f76f7 (RC_9f2ace8f61f1c245fb0b20b98c1f76f7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderListTableStructure = ConvertToRestWithoutDefaults(s.ssSTOrderListTableStructure, new ST_00c299856fb2c1322ea33527b24c9dd0Structure(), ssConectaProveedores.RestRecords.RESTST_00c299856fb2c1322ea33527b24c9dd0Structure.FromStructure, config);
  } else {
AttrOrderListTableStructure = ssConectaProveedores.RestRecords.RESTST_00c299856fb2c1322ea33527b24c9dd0Structure.FromStructure(s.ssSTOrderListTableStructure, config);
  }
}

public static RC_9f2ace8f61f1c245fb0b20b98c1f76f7 ToStructure(ssConectaProveedores.RestRecords.RESTRC_9f2ace8f61f1c245fb0b20b98c1f76f7 obj) { 
  RC_9f2ace8f61f1c245fb0b20b98c1f76f7 s = new RC_9f2ace8f61f1c245fb0b20b98c1f76f7();
  if(obj != null) {
  s.ssSTOrderListTableStructure = ssConectaProveedores.RestRecords.RESTST_00c299856fb2c1322ea33527b24c9dd0Structure.ToStructure(obj.AttrOrderListTableStructure);
  }
  return s;
}

public static Func<RC_9f2ace8f61f1c245fb0b20b98c1f76f7, ssConectaProveedores.RestRecords.RESTRC_9f2ace8f61f1c245fb0b20b98c1f76f7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9f2ace8f61f1c245fb0b20b98c1f76f7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_9f2ace8f61f1c245fb0b20b98c1f76f7 FromStructure(RC_9f2ace8f61f1c245fb0b20b98c1f76f7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_9f2ace8f61f1c245fb0b20b98c1f76f7(s, config);
}

}


