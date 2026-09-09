using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SupplierRegionRecord
public class RESTRC_c81aee5ce0504fe68694be6deb703b5e : AbstractRESTStructure<RC_c81aee5ce0504fe68694be6deb703b5e> {
[JsonProperty("Supplier")]
public ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_c81aee5ce0504fe68694be6deb703b5e() { }

public RESTRC_c81aee5ce0504fe68694be6deb703b5e (RC_c81aee5ce0504fe68694be6deb703b5e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_c81aee5ce0504fe68694be6deb703b5e ToStructure(ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e obj) { 
  RC_c81aee5ce0504fe68694be6deb703b5e s = new RC_c81aee5ce0504fe68694be6deb703b5e();
  if(obj != null) {
  s.ssENSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier);
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_c81aee5ce0504fe68694be6deb703b5e, ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c81aee5ce0504fe68694be6deb703b5e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e FromStructure(RC_c81aee5ce0504fe68694be6deb703b5e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e(s, config);
}

}


