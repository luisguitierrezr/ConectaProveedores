using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserOrderMainUserExtensionSupplierUserSupplierRecord
public class JSONRC_ba5d2807543ac9c0e233d12b8827d820 : AbstractRESTStructure<RC_ba5d2807543ac9c0e233d12b8827d820> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("UserExtension")]
[JsonPropertyName("UserExtension")]
public ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord AttrUserExtension;

[JsonProperty("SupplierUser")]
[JsonPropertyName("SupplierUser")]
public ssConectaProveedores.RestRecords.JSONEN_360367a38fba8439556dd1e5826e0428EntityRecord AttrSupplierUser;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

public JSONRC_ba5d2807543ac9c0e233d12b8827d820() { }

public JSONRC_ba5d2807543ac9c0e233d12b8827d820 (RC_ba5d2807543ac9c0e233d12b8827d820 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrUserExtension = ConvertToRestWithoutDefaults(s.ssENUserExtension, new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure, config);
AttrSupplierUser = ConvertToRestWithoutDefaults(s.ssENSupplierUser, new EN_360367a38fba8439556dd1e5826e0428EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_360367a38fba8439556dd1e5826e0428EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrUserExtension = ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure(s.ssENUserExtension, config);
AttrSupplierUser = ssConectaProveedores.RestRecords.JSONEN_360367a38fba8439556dd1e5826e0428EntityRecord.FromStructure(s.ssENSupplierUser, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_ba5d2807543ac9c0e233d12b8827d820, RC_ba5d2807543ac9c0e233d12b8827d820> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_ba5d2807543ac9c0e233d12b8827d820 s) => ToStructure(s, config);
}
public static RC_ba5d2807543ac9c0e233d12b8827d820 ToStructure(ssConectaProveedores.RestRecords.JSONRC_ba5d2807543ac9c0e233d12b8827d820 obj, IBehaviorsConfiguration config) { 
  RC_ba5d2807543ac9c0e233d12b8827d820 s = new RC_ba5d2807543ac9c0e233d12b8827d820();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENUserExtension = ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.ToStructure(obj.AttrUserExtension, config);
  s.ssENSupplierUser = ssConectaProveedores.RestRecords.JSONEN_360367a38fba8439556dd1e5826e0428EntityRecord.ToStructure(obj.AttrSupplierUser, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  }
  return s;
}

public static Func<RC_ba5d2807543ac9c0e233d12b8827d820, ssConectaProveedores.RestRecords.JSONRC_ba5d2807543ac9c0e233d12b8827d820> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ba5d2807543ac9c0e233d12b8827d820 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_ba5d2807543ac9c0e233d12b8827d820 FromStructure(RC_ba5d2807543ac9c0e233d12b8827d820 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_ba5d2807543ac9c0e233d12b8827d820(s, config);
}

}


