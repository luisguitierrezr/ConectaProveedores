using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainSupplierUserSupplierRecord
public class JSONRC_7ff0d2d2388d9acf793b4f023e6f8f0f : AbstractRESTStructure<RC_7ff0d2d2388d9acf793b4f023e6f8f0f> {
[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("SupplierUser")]
[JsonPropertyName("SupplierUser")]
public ssConectaProveedores.RestRecords.JSONEN_360367a38fba8439556dd1e5826e0428EntityRecord AttrSupplierUser;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

public JSONRC_7ff0d2d2388d9acf793b4f023e6f8f0f() { }

public JSONRC_7ff0d2d2388d9acf793b4f023e6f8f0f (RC_7ff0d2d2388d9acf793b4f023e6f8f0f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrSupplierUser = ConvertToRestWithoutDefaults(s.ssENSupplierUser, new EN_360367a38fba8439556dd1e5826e0428EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_360367a38fba8439556dd1e5826e0428EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
  } else {
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrSupplierUser = ssConectaProveedores.RestRecords.JSONEN_360367a38fba8439556dd1e5826e0428EntityRecord.FromStructure(s.ssENSupplierUser, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_7ff0d2d2388d9acf793b4f023e6f8f0f, RC_7ff0d2d2388d9acf793b4f023e6f8f0f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_7ff0d2d2388d9acf793b4f023e6f8f0f s) => ToStructure(s, config);
}
public static RC_7ff0d2d2388d9acf793b4f023e6f8f0f ToStructure(ssConectaProveedores.RestRecords.JSONRC_7ff0d2d2388d9acf793b4f023e6f8f0f obj, IBehaviorsConfiguration config) { 
  RC_7ff0d2d2388d9acf793b4f023e6f8f0f s = new RC_7ff0d2d2388d9acf793b4f023e6f8f0f();
  if(obj != null) {
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENSupplierUser = ssConectaProveedores.RestRecords.JSONEN_360367a38fba8439556dd1e5826e0428EntityRecord.ToStructure(obj.AttrSupplierUser, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  }
  return s;
}

public static Func<RC_7ff0d2d2388d9acf793b4f023e6f8f0f, ssConectaProveedores.RestRecords.JSONRC_7ff0d2d2388d9acf793b4f023e6f8f0f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7ff0d2d2388d9acf793b4f023e6f8f0f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_7ff0d2d2388d9acf793b4f023e6f8f0f FromStructure(RC_7ff0d2d2388d9acf793b4f023e6f8f0f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_7ff0d2d2388d9acf793b4f023e6f8f0f(s, config);
}

}


