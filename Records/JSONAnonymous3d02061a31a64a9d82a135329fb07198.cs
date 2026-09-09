using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderListTableStructureRecord
public class JSONRC_9f2ace8f61f1c245fb0b20b98c1f76f7 : AbstractRESTStructure<RC_9f2ace8f61f1c245fb0b20b98c1f76f7> {
[JsonProperty("OrderListTableStructure")]
[JsonPropertyName("OrderListTableStructure")]
public ssConectaProveedores.RestRecords.JSONST_00c299856fb2c1322ea33527b24c9dd0Structure AttrOrderListTableStructure;

public JSONRC_9f2ace8f61f1c245fb0b20b98c1f76f7() { }

public JSONRC_9f2ace8f61f1c245fb0b20b98c1f76f7 (RC_9f2ace8f61f1c245fb0b20b98c1f76f7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderListTableStructure = ConvertToRestWithoutDefaults(s.ssSTOrderListTableStructure, new ST_00c299856fb2c1322ea33527b24c9dd0Structure(), ssConectaProveedores.RestRecords.JSONST_00c299856fb2c1322ea33527b24c9dd0Structure.FromStructure, config);
  } else {
AttrOrderListTableStructure = ssConectaProveedores.RestRecords.JSONST_00c299856fb2c1322ea33527b24c9dd0Structure.FromStructure(s.ssSTOrderListTableStructure, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_9f2ace8f61f1c245fb0b20b98c1f76f7, RC_9f2ace8f61f1c245fb0b20b98c1f76f7> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_9f2ace8f61f1c245fb0b20b98c1f76f7 s) => ToStructure(s, config);
}
public static RC_9f2ace8f61f1c245fb0b20b98c1f76f7 ToStructure(ssConectaProveedores.RestRecords.JSONRC_9f2ace8f61f1c245fb0b20b98c1f76f7 obj, IBehaviorsConfiguration config) { 
  RC_9f2ace8f61f1c245fb0b20b98c1f76f7 s = new RC_9f2ace8f61f1c245fb0b20b98c1f76f7();
  if(obj != null) {
  s.ssSTOrderListTableStructure = ssConectaProveedores.RestRecords.JSONST_00c299856fb2c1322ea33527b24c9dd0Structure.ToStructure(obj.AttrOrderListTableStructure, config);
  }
  return s;
}

public static Func<RC_9f2ace8f61f1c245fb0b20b98c1f76f7, ssConectaProveedores.RestRecords.JSONRC_9f2ace8f61f1c245fb0b20b98c1f76f7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9f2ace8f61f1c245fb0b20b98c1f76f7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_9f2ace8f61f1c245fb0b20b98c1f76f7 FromStructure(RC_9f2ace8f61f1c245fb0b20b98c1f76f7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_9f2ace8f61f1c245fb0b20b98c1f76f7(s, config);
}

}


