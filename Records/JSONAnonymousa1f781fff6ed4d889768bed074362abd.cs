using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderContractFileOrderMainOrderFileStorageSupplierRecord
public class JSONRC_2cd5474bded5833e5b006a17fe1ba636 : AbstractRESTStructure<RC_2cd5474bded5833e5b006a17fe1ba636> {
[JsonProperty("OrderContractFile")]
[JsonPropertyName("OrderContractFile")]
public ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord AttrOrderContractFile;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderFile")]
[JsonPropertyName("OrderFile")]
public ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord AttrOrderFile;

[JsonProperty("Storage")]
[JsonPropertyName("Storage")]
public ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord AttrStorage;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

public JSONRC_2cd5474bded5833e5b006a17fe1ba636() { }

public JSONRC_2cd5474bded5833e5b006a17fe1ba636 (RC_2cd5474bded5833e5b006a17fe1ba636 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderContractFile = ConvertToRestWithoutDefaults(s.ssENOrderContractFile, new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderFile = ConvertToRestWithoutDefaults(s.ssENOrderFile, new EN_096339be3ef098b3762e8897e3a1c095EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure, config);
AttrStorage = ConvertToRestWithoutDefaults(s.ssENStorage, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
  } else {
AttrOrderContractFile = ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure(s.ssENOrderContractFile, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderFile = ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure(s.ssENOrderFile, config);
AttrStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(s.ssENStorage, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_2cd5474bded5833e5b006a17fe1ba636, RC_2cd5474bded5833e5b006a17fe1ba636> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_2cd5474bded5833e5b006a17fe1ba636 s) => ToStructure(s, config);
}
public static RC_2cd5474bded5833e5b006a17fe1ba636 ToStructure(ssConectaProveedores.RestRecords.JSONRC_2cd5474bded5833e5b006a17fe1ba636 obj, IBehaviorsConfiguration config) { 
  RC_2cd5474bded5833e5b006a17fe1ba636 s = new RC_2cd5474bded5833e5b006a17fe1ba636();
  if(obj != null) {
  s.ssENOrderContractFile = ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.ToStructure(obj.AttrOrderContractFile, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENOrderFile = ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord.ToStructure(obj.AttrOrderFile, config);
  s.ssENStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.ToStructure(obj.AttrStorage, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  }
  return s;
}

public static Func<RC_2cd5474bded5833e5b006a17fe1ba636, ssConectaProveedores.RestRecords.JSONRC_2cd5474bded5833e5b006a17fe1ba636> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2cd5474bded5833e5b006a17fe1ba636 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_2cd5474bded5833e5b006a17fe1ba636 FromStructure(RC_2cd5474bded5833e5b006a17fe1ba636 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_2cd5474bded5833e5b006a17fe1ba636(s, config);
}

}


