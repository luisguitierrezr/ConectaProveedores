using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderContractFinanceFileOrderFinanceFileRecord
public class RESTRC_041cacb77c43fb5e1fc788222594e8fd : AbstractRESTStructure<RC_041cacb77c43fb5e1fc788222594e8fd> {
[JsonProperty("OrderContractFinanceFile")]
public ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord AttrOrderContractFinanceFile;

[JsonProperty("OrderFinanceFile")]
public ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord AttrOrderFinanceFile;

public RESTRC_041cacb77c43fb5e1fc788222594e8fd() { }

public RESTRC_041cacb77c43fb5e1fc788222594e8fd (RC_041cacb77c43fb5e1fc788222594e8fd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderContractFinanceFile = ConvertToRestWithoutDefaults(s.ssENOrderContractFinanceFile, new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure, config);
AttrOrderFinanceFile = ConvertToRestWithoutDefaults(s.ssENOrderFinanceFile, new EN_096339be3ef098b3762e8897e3a1c095EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure, config);
  } else {
AttrOrderContractFinanceFile = ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure(s.ssENOrderContractFinanceFile, config);
AttrOrderFinanceFile = ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure(s.ssENOrderFinanceFile, config);
  }
}

public static RC_041cacb77c43fb5e1fc788222594e8fd ToStructure(ssConectaProveedores.RestRecords.RESTRC_041cacb77c43fb5e1fc788222594e8fd obj) { 
  RC_041cacb77c43fb5e1fc788222594e8fd s = new RC_041cacb77c43fb5e1fc788222594e8fd();
  if(obj != null) {
  s.ssENOrderContractFinanceFile = ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.ToStructure(obj.AttrOrderContractFinanceFile);
  s.ssENOrderFinanceFile = ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord.ToStructure(obj.AttrOrderFinanceFile);
  }
  return s;
}

public static Func<RC_041cacb77c43fb5e1fc788222594e8fd, ssConectaProveedores.RestRecords.RESTRC_041cacb77c43fb5e1fc788222594e8fd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_041cacb77c43fb5e1fc788222594e8fd s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_041cacb77c43fb5e1fc788222594e8fd FromStructure(RC_041cacb77c43fb5e1fc788222594e8fd s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_041cacb77c43fb5e1fc788222594e8fd(s, config);
}

}


