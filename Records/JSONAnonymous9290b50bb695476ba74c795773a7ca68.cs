using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderContractFinanceFileOrderFinanceFileRecord
public class JSONRC_041cacb77c43fb5e1fc788222594e8fd : AbstractRESTStructure<RC_041cacb77c43fb5e1fc788222594e8fd> {
[JsonProperty("OrderContractFinanceFile")]
[JsonPropertyName("OrderContractFinanceFile")]
public ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord AttrOrderContractFinanceFile;

[JsonProperty("OrderFinanceFile")]
[JsonPropertyName("OrderFinanceFile")]
public ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord AttrOrderFinanceFile;

public JSONRC_041cacb77c43fb5e1fc788222594e8fd() { }

public JSONRC_041cacb77c43fb5e1fc788222594e8fd (RC_041cacb77c43fb5e1fc788222594e8fd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderContractFinanceFile = ConvertToRestWithoutDefaults(s.ssENOrderContractFinanceFile, new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure, config);
AttrOrderFinanceFile = ConvertToRestWithoutDefaults(s.ssENOrderFinanceFile, new EN_096339be3ef098b3762e8897e3a1c095EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure, config);
  } else {
AttrOrderContractFinanceFile = ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure(s.ssENOrderContractFinanceFile, config);
AttrOrderFinanceFile = ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure(s.ssENOrderFinanceFile, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_041cacb77c43fb5e1fc788222594e8fd, RC_041cacb77c43fb5e1fc788222594e8fd> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_041cacb77c43fb5e1fc788222594e8fd s) => ToStructure(s, config);
}
public static RC_041cacb77c43fb5e1fc788222594e8fd ToStructure(ssConectaProveedores.RestRecords.JSONRC_041cacb77c43fb5e1fc788222594e8fd obj, IBehaviorsConfiguration config) { 
  RC_041cacb77c43fb5e1fc788222594e8fd s = new RC_041cacb77c43fb5e1fc788222594e8fd();
  if(obj != null) {
  s.ssENOrderContractFinanceFile = ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.ToStructure(obj.AttrOrderContractFinanceFile, config);
  s.ssENOrderFinanceFile = ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord.ToStructure(obj.AttrOrderFinanceFile, config);
  }
  return s;
}

public static Func<RC_041cacb77c43fb5e1fc788222594e8fd, ssConectaProveedores.RestRecords.JSONRC_041cacb77c43fb5e1fc788222594e8fd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_041cacb77c43fb5e1fc788222594e8fd s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_041cacb77c43fb5e1fc788222594e8fd FromStructure(RC_041cacb77c43fb5e1fc788222594e8fd s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_041cacb77c43fb5e1fc788222594e8fd(s, config);
}

}


