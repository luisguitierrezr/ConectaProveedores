using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AccountingTableRecord
public class JSONRC_d5cf1eb3da0d77e41669d2183b5af20e : AbstractRESTStructure<RC_d5cf1eb3da0d77e41669d2183b5af20e> {
[JsonProperty("AccountingTable")]
[JsonPropertyName("AccountingTable")]
public ssConectaProveedores.RestRecords.JSONST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure AttrAccountingTable;

public JSONRC_d5cf1eb3da0d77e41669d2183b5af20e() { }

public JSONRC_d5cf1eb3da0d77e41669d2183b5af20e (RC_d5cf1eb3da0d77e41669d2183b5af20e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAccountingTable = ConvertToRestWithoutDefaults(s.ssSTAccountingTable, new ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure(), ssConectaProveedores.RestRecords.JSONST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure.FromStructure, config);
  } else {
AttrAccountingTable = ssConectaProveedores.RestRecords.JSONST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure.FromStructure(s.ssSTAccountingTable, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_d5cf1eb3da0d77e41669d2183b5af20e, RC_d5cf1eb3da0d77e41669d2183b5af20e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_d5cf1eb3da0d77e41669d2183b5af20e s) => ToStructure(s, config);
}
public static RC_d5cf1eb3da0d77e41669d2183b5af20e ToStructure(ssConectaProveedores.RestRecords.JSONRC_d5cf1eb3da0d77e41669d2183b5af20e obj, IBehaviorsConfiguration config) { 
  RC_d5cf1eb3da0d77e41669d2183b5af20e s = new RC_d5cf1eb3da0d77e41669d2183b5af20e();
  if(obj != null) {
  s.ssSTAccountingTable = ssConectaProveedores.RestRecords.JSONST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure.ToStructure(obj.AttrAccountingTable, config);
  }
  return s;
}

public static Func<RC_d5cf1eb3da0d77e41669d2183b5af20e, ssConectaProveedores.RestRecords.JSONRC_d5cf1eb3da0d77e41669d2183b5af20e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d5cf1eb3da0d77e41669d2183b5af20e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_d5cf1eb3da0d77e41669d2183b5af20e FromStructure(RC_d5cf1eb3da0d77e41669d2183b5af20e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_d5cf1eb3da0d77e41669d2183b5af20e(s, config);
}

}


