using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AccountingTableRecord
public class RESTRC_d5cf1eb3da0d77e41669d2183b5af20e : AbstractRESTStructure<RC_d5cf1eb3da0d77e41669d2183b5af20e> {
[JsonProperty("AccountingTable")]
public ssConectaProveedores.RestRecords.RESTST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure AttrAccountingTable;

public RESTRC_d5cf1eb3da0d77e41669d2183b5af20e() { }

public RESTRC_d5cf1eb3da0d77e41669d2183b5af20e (RC_d5cf1eb3da0d77e41669d2183b5af20e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAccountingTable = ConvertToRestWithoutDefaults(s.ssSTAccountingTable, new ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure(), ssConectaProveedores.RestRecords.RESTST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure.FromStructure, config);
  } else {
AttrAccountingTable = ssConectaProveedores.RestRecords.RESTST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure.FromStructure(s.ssSTAccountingTable, config);
  }
}

public static RC_d5cf1eb3da0d77e41669d2183b5af20e ToStructure(ssConectaProveedores.RestRecords.RESTRC_d5cf1eb3da0d77e41669d2183b5af20e obj) { 
  RC_d5cf1eb3da0d77e41669d2183b5af20e s = new RC_d5cf1eb3da0d77e41669d2183b5af20e();
  if(obj != null) {
  s.ssSTAccountingTable = ssConectaProveedores.RestRecords.RESTST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure.ToStructure(obj.AttrAccountingTable);
  }
  return s;
}

public static Func<RC_d5cf1eb3da0d77e41669d2183b5af20e, ssConectaProveedores.RestRecords.RESTRC_d5cf1eb3da0d77e41669d2183b5af20e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d5cf1eb3da0d77e41669d2183b5af20e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d5cf1eb3da0d77e41669d2183b5af20e FromStructure(RC_d5cf1eb3da0d77e41669d2183b5af20e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d5cf1eb3da0d77e41669d2183b5af20e(s, config);
}

}


