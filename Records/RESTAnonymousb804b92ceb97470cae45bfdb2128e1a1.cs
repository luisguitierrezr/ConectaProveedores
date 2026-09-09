using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SupplierUserSupplierRegionRecord
public class RESTRC_3f6ba4c81bcd03d8108335ecd7631ff4 : AbstractRESTStructure<RC_3f6ba4c81bcd03d8108335ecd7631ff4> {
[JsonProperty("SupplierUser")]
public ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord AttrSupplierUser;

[JsonProperty("Supplier")]
public ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_3f6ba4c81bcd03d8108335ecd7631ff4() { }

public RESTRC_3f6ba4c81bcd03d8108335ecd7631ff4 (RC_3f6ba4c81bcd03d8108335ecd7631ff4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSupplierUser = ConvertToRestWithoutDefaults(s.ssENSupplierUser, new EN_360367a38fba8439556dd1e5826e0428EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrSupplierUser = ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord.FromStructure(s.ssENSupplierUser, config);
AttrSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_3f6ba4c81bcd03d8108335ecd7631ff4 ToStructure(ssConectaProveedores.RestRecords.RESTRC_3f6ba4c81bcd03d8108335ecd7631ff4 obj) { 
  RC_3f6ba4c81bcd03d8108335ecd7631ff4 s = new RC_3f6ba4c81bcd03d8108335ecd7631ff4();
  if(obj != null) {
  s.ssENSupplierUser = ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord.ToStructure(obj.AttrSupplierUser);
  s.ssENSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier);
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_3f6ba4c81bcd03d8108335ecd7631ff4, ssConectaProveedores.RestRecords.RESTRC_3f6ba4c81bcd03d8108335ecd7631ff4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3f6ba4c81bcd03d8108335ecd7631ff4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_3f6ba4c81bcd03d8108335ecd7631ff4 FromStructure(RC_3f6ba4c81bcd03d8108335ecd7631ff4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_3f6ba4c81bcd03d8108335ecd7631ff4(s, config);
}

}


