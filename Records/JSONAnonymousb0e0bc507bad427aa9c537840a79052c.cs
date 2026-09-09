using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainSupplierRecord
public class JSONRC_1f350886772613b21997a3d775fb549d : AbstractRESTStructure<RC_1f350886772613b21997a3d775fb549d> {
[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

public JSONRC_1f350886772613b21997a3d775fb549d() { }

public JSONRC_1f350886772613b21997a3d775fb549d (RC_1f350886772613b21997a3d775fb549d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
  } else {
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1f350886772613b21997a3d775fb549d, RC_1f350886772613b21997a3d775fb549d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1f350886772613b21997a3d775fb549d s) => ToStructure(s, config);
}
public static RC_1f350886772613b21997a3d775fb549d ToStructure(ssConectaProveedores.RestRecords.JSONRC_1f350886772613b21997a3d775fb549d obj, IBehaviorsConfiguration config) { 
  RC_1f350886772613b21997a3d775fb549d s = new RC_1f350886772613b21997a3d775fb549d();
  if(obj != null) {
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  }
  return s;
}

public static Func<RC_1f350886772613b21997a3d775fb549d, ssConectaProveedores.RestRecords.JSONRC_1f350886772613b21997a3d775fb549d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1f350886772613b21997a3d775fb549d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1f350886772613b21997a3d775fb549d FromStructure(RC_1f350886772613b21997a3d775fb549d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1f350886772613b21997a3d775fb549d(s, config);
}

}


