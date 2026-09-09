using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderContractFileRecord
public class RESTRC_bdb8cd2e0da3eae2f170942895f2a3ac : AbstractRESTStructure<RC_bdb8cd2e0da3eae2f170942895f2a3ac> {
[JsonProperty("OrderContractFile")]
public ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord AttrOrderContractFile;

public RESTRC_bdb8cd2e0da3eae2f170942895f2a3ac() { }

public RESTRC_bdb8cd2e0da3eae2f170942895f2a3ac (RC_bdb8cd2e0da3eae2f170942895f2a3ac s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderContractFile = ConvertToRestWithoutDefaults(s.ssENOrderContractFile, new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure, config);
  } else {
AttrOrderContractFile = ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure(s.ssENOrderContractFile, config);
  }
}

public static RC_bdb8cd2e0da3eae2f170942895f2a3ac ToStructure(ssConectaProveedores.RestRecords.RESTRC_bdb8cd2e0da3eae2f170942895f2a3ac obj) { 
  RC_bdb8cd2e0da3eae2f170942895f2a3ac s = new RC_bdb8cd2e0da3eae2f170942895f2a3ac();
  if(obj != null) {
  s.ssENOrderContractFile = ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.ToStructure(obj.AttrOrderContractFile);
  }
  return s;
}

public static Func<RC_bdb8cd2e0da3eae2f170942895f2a3ac, ssConectaProveedores.RestRecords.RESTRC_bdb8cd2e0da3eae2f170942895f2a3ac> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bdb8cd2e0da3eae2f170942895f2a3ac s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_bdb8cd2e0da3eae2f170942895f2a3ac FromStructure(RC_bdb8cd2e0da3eae2f170942895f2a3ac s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_bdb8cd2e0da3eae2f170942895f2a3ac(s, config);
}

}


